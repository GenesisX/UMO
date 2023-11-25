using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XeApp.Core;
using XeApp.Game;
using System.Net.Sockets;
using System.Net;
using System.Text;
using XeApp.Game.Common;
#if UNITY_EDITOR
using System.Reflection;
using System.Linq;
#endif

static class FileSystemProxy
{
	private static Dictionary<string, string> serverFileList;

	private static bool isInitialized = false;

	static public bool IsInitialized { get { return isInitialized; } }

	static public string ConvertURL(string url)
	{
		string urlExt = "";
		if (url.Contains("?"))
		{
			urlExt = url.Substring(url.IndexOf("?"));
			url = url.Substring(0, url.IndexOf("?"));
		}
		if (url.Contains("!s00000000z!"))
		{
			int idx = url.IndexOf("/android/");
			string fileName = url.Substring(idx);
			fileName = fileName.Replace("!s00000000z!", "");
			if(serverFileList.ContainsKey(fileName))
			{
				url = url.Substring(0, idx) + serverFileList[fileName];
			}
			else
			{
				TodoLogger.LogError(TodoLogger.Filesystem, "Error finding file source name " + url);
				return "";
			}
		}

#if !UNITY_ANDROID && !DEBUG_ANDROID_FILESYSTEM
		if (RuntimeSettings.CurrentSettings == null || string.IsNullOrEmpty(RuntimeSettings.CurrentSettings.DataWebServerURL))
		{
			if (!string.IsNullOrEmpty(RuntimeSettings.CurrentSettings.DataDirectory))
			{
				url = url.Replace("[SERVER_DATA_PATH]", "file://" + Path.GetFullPath(RuntimeSettings.CurrentSettings.DataDirectory));
			}
			return url + urlExt;
		}
		string serverPath = RuntimeSettings.CurrentSettings.DataWebServerURL;
#else
		if(foundServer == "")
			UnityEngine.Debug.LogError("Missing URL");
		string serverPath = "http://"+foundServer+":8000";
#endif
		if (serverPath.EndsWith("/"))
			serverPath = serverPath.Substring(0, serverPath.Length - 1);
		return url.Replace("[SERVER_DATA_PATH]", serverPath) + urlExt;
	}

	static public string ConvertPath(string path)
	{
		path = path.Replace("\\", "/");
		path = path.Replace("!s00000000z!", "");
		path = path.Replace("[SERVER_DATA_PATH]", Application.persistentDataPath + "/data");
		if (File.Exists(path))
			return path;
		if (RuntimeSettings.CurrentSettings == null)
			return path;
		if (path.Contains(UnityEngine.Application.persistentDataPath + "/data") && !string.IsNullOrEmpty(RuntimeSettings.CurrentSettings.DataDirectory))
		{
			string dataDir = RuntimeSettings.CurrentSettings.DataDirectory;
			if (!Path.IsPathRooted(dataDir))
				dataDir = Path.GetFullPath(dataDir);
			if (Directory.Exists(dataDir))
			{
				string new_path = path.Replace(UnityEngine.Application.persistentDataPath + "/data", dataDir);
				if (File.Exists(new_path)) // Search normal name
					return new_path;
				if (File.Exists(new_path + ".decrypted")) // Search normal name + ".decrypted"
					return new_path + ".decrypted";
				string baseName = new_path.Replace(dataDir, "");
				if (serverFileList.ContainsKey(baseName))
				{
					new_path = dataDir + serverFileList[baseName];
					if (File.Exists(new_path)) // Search server format name (with hash)
						return new_path;
					if (File.Exists(new_path + ".decrypted")) // Search server format name (with hash) decrypted
						return new_path + ".decrypted";
				}
			}
		}
		return path;
	}

	public static bool FileExists(string path)
	{
		return File.Exists(ConvertPath(path));
	}

	public static void TryInstallFile(string path, Action<string> onDone)
	{
		string existingPath = ConvertPath(path);
		if (File.Exists(existingPath))
		{
			if (onDone != null)
				onDone(existingPath);
			return;
		}
		if (RuntimeSettings.CurrentSettings != null)
		{
			if(!string.IsNullOrEmpty(RuntimeSettings.CurrentSettings.DataWebServerURL))
			{
				GameManager.Instance.StartCoroutineWatched(TryInstallFileCoroutine(path, onDone));
				return;
			}
		}
		if (onDone != null)
			onDone(path);
	}

	public static IEnumerator ReloadFileList()
	{
		serverFileList = null;
		yield return Co.R(InitServerFileList());
	}

	public static IEnumerator InitServerFileList()
	{
		if (serverFileList == null)
		{
			serverFileList = new Dictionary<string, string>();
			string filePath = UnityEngine.Application.dataPath + "/../../Data/RequestGetFiles.json";
#if (UNITY_ANDROID && !UNITY_EDITOR) || DEBUG_ANDROID_FILESYSTEM
			filePath = Application.persistentDataPath+"/data/RequestGetFiles.json";
#endif
			if(File.Exists(filePath))
			{
				string fileList = System.Text.Encoding.UTF8.GetString(System.IO.File.ReadAllBytes(filePath));
				fileList = fileList.Replace("[[DATE]]", "0");
				EDOHBJAPLPF_JsonData jsonData = IKPIMINCOPI_JsonMapper.PFAMKCGJKKL_ToObject(fileList);
				EDOHBJAPLPF_JsonData fileL = jsonData["files"];
				for (int i = 0; i < fileL.HNBFOAJIIAL_Count; i++)
				{
					if((i % 1000) == 0)
					{
						TodoLogger.Log(TodoLogger.Filesystem, "Done file list " + i+"/"+fileL.HNBFOAJIIAL_Count);
						yield return null;
					}
					string fileName = (string)fileL[i]["file"];
					string localName = GCGNICILKLD_AssetFileInfo.NOCCMAKNLLD.Replace(fileName, "");
					//UnityEngine.Debug.Log("Added file " + localName + " to remote name " + fileName);
					serverFileList.Add(localName, fileName);
				}
			}
			isInitialized = true;
		}
	}

	static IEnumerator TryInstallFileCoroutine(string path, Action<string> onDone)
	{
		yield return Co.R(InitServerFileList());
		path = path.Replace("\\", "/");
		string relativePath = path;
		int pos = path.IndexOf("/android/");
		if (pos >= 0)
			relativePath = path.Substring(pos);
		TodoLogger.Log(TodoLogger.Filesystem, "Try install relative path : " + relativePath);
		if (serverFileList.ContainsKey(relativePath))
		{
			string startPath = RuntimeSettings.CurrentSettings.DataWebServerURL;
			if(serverFileList[relativePath].StartsWith("/") && startPath.EndsWith("/"))
				startPath = startPath.Substring(0, startPath.Length - 1);
			string url = startPath + serverFileList[relativePath];
			TodoLogger.Log(TodoLogger.Filesystem, "Try dld from server at " + url);
			WWW dldData = new WWW(url);
			while (!dldData.isDone)
				yield return null;
			if (string.IsNullOrEmpty(dldData.error))
			{
				Directory.CreateDirectory(Path.GetDirectoryName(path));
				File.WriteAllBytes(path, dldData.bytes);
			}
			else
			{
				TodoLogger.LogError(TodoLogger.Filesystem, "Dld Error : " + dldData.error);
			}
		}
		if (onDone != null)
			onDone(path);
	}

#if UNITY_ANDROID || DEBUG_ANDROID_FILESYSTEM
	public static string foundServer = "";

	public static IEnumerator WaitServerInfo(string message_, bool allowRetry, bool allowServer, Action<PopupButton.ButtonLabel> cb = null)
	{
		string prevServer = foundServer;
		foundServer = "";
		//if(foundServer != "")
		//	yield break;

		bool retry = false;
		bool next = false;
		string choice = "";
		if(allowRetry)
		{
			choice += "\n- Copy missing file and select Retry button to recheck";
		}
		if(allowServer)
		{
			choice += "\n- Select Next button to download from UMO server";
		}
		ButtonInfo[] buttons = null;
		if(allowRetry && allowServer)
		{
			buttons = new ButtonInfo[2]
			{
				new ButtonInfo() { Label = PopupButton.ButtonLabel.Retry, Type = PopupButton.ButtonType.Positive },
				new ButtonInfo() { Label = PopupButton.ButtonLabel.Next, Type = PopupButton.ButtonType.Positive }
			};
		}
		else if(allowServer)
		{
			buttons = new ButtonInfo[1]
			{
				new ButtonInfo() { Label = PopupButton.ButtonLabel.Next, Type = PopupButton.ButtonType.Positive }
			};
		}
		else if(allowRetry)
		{
			buttons = new ButtonInfo[1]
			{
				new ButtonInfo() { Label = PopupButton.ButtonLabel.Retry, Type = PopupButton.ButtonType.Positive }
			};
		}
        PopupWindowManager.Show(PopupWindowManager.CrateTextContent("UMO", SizeType.Large, message_ + "\nCheck install process on project wiki\n"+choice, buttons, false, true), (PopupWindowControl control_, PopupButton.ButtonType t, PopupButton.ButtonLabel label) =>
		{
			if(label == PopupButton.ButtonLabel.Retry)
				retry = true;
			else
				next = true;
		}, null, null, null);
		while(!next && !retry)
			yield return null;
		if(retry)
		{
			if(cb != null)
				cb(PopupButton.ButtonLabel.Retry);
			yield break;
		}

		UdpClient udp = new UdpClient(8001);
		bool cancel = false;
        PopupWindowControl control = PopupWindowManager.Show(PopupWindowManager.CrateTextContent("UMO", SizeType.Middle, "Searching for server, please start webserver and connect the phone on the same local network...", 
		new ButtonInfo[1]
        {
            new ButtonInfo() { Label = PopupButton.ButtonLabel.Cancel, Type = PopupButton.ButtonType.Negative }
		}
		//new ButtonInfo[0] {}
		, false, true), (PopupWindowControl control_, PopupButton.ButtonType t, PopupButton.ButtonLabel label) =>
		{
			cancel = true;
		}, null, null, null);
		yield return null;
        while (foundServer == "" && !cancel)
		{
			bool waiting = true;
			udp.BeginReceive((IAsyncResult ar) =>
			{
				IPEndPoint ip = new IPEndPoint(IPAddress.Any, 8001);
				byte[] bytes = udp.EndReceive(ar, ref ip);
				string message = Encoding.ASCII.GetString(bytes);
				if(message == "UMO")
				{
					foundServer = ip.Address.ToString();
				}
				waiting = false;
			}, new object());
			while(waiting && !cancel)
				yield return null;
		}
		if(control.IsActive)
		{
			control.Close(null, null);
		}
		if(cancel)
		{
			InputPopupSetting s = new InputPopupSetting();
			s.TitleText = "UMO";
			s.WindowSize = SizeType.Small;
			s.Description = "Enter IP of the server";
			s.Notes = "";
			s.InputText = prevServer == "" ? "0.0.0.0" : prevServer;
			s.DisableRegex = true;
			s.CharacterLimit = 50;
			s.Buttons = new ButtonInfo[1]
			{
				new ButtonInfo() { Label = PopupButton.ButtonLabel.Ok, Type = PopupButton.ButtonType.Positive }
			};
			bool done = false;
			PopupWindowManager.Show(s, (PopupWindowControl control_, PopupButton.ButtonType t, PopupButton.ButtonLabel label) =>
			{
				foundServer = (control_.Content as InputContent).Text;
				done = true;
			}, null, null, null);
			while(!done)
				yield return null;
		}
		if(cb != null)
			cb(PopupButton.ButtonLabel.Next);
	}
#endif

#if UNITY_EDITOR
	//[UnityEditor.MenuItem("UMO/TestLoadBundle")]
	static void TestLoadBundle()
	{
		if (GameManager.Instance)
		{
			GameManager.Instance.StartCoroutineWatched(TestBundleAsync());
		}
	}

	public static bool IsTesting = false;

	static T Copy<T>(T src) where T : UnityEngine.Object
	{
		if (src is Material)
			return new Material(src as Material) as T;
		UnityEngine.Debug.LogError("Can't copy " + src.GetType());
		return null;
	}

	static T GetCopyOf<T>(this UnityEngine.Object comp, T other, ExportInfo info) where T : UnityEngine.Object
	{
		Type type = comp.GetType();
		if (type != other.GetType()) return null; // type mis-match
		BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Default/* | BindingFlags.DeclaredOnly*/;
		//PropertyInfo[] pinfos = type.GetProperties(flags);
		// Replace pinfos with this:
		var pinfos = from property in type.GetProperties(flags)
					 where !property.CustomAttributes.Any(attribute => attribute.AttributeType == typeof(ObsoleteAttribute))
					 select property;
		foreach (var pinfo in pinfos)
		{
			if (pinfo.CanWrite)
			{
				try
				{
					pinfo.SetValue(comp, pinfo.GetValue(other, null), null);
					if(pinfo.GetValue(comp) is UnityEngine.Object)
					{
						string guid;
						long localId;
						UnityEngine.Object obj = pinfo.GetValue(comp) as UnityEngine.Object;
						if (UnityEditor.AssetDatabase.TryGetGUIDAndLocalFileIdentifier(obj, out guid, out localId))
						{
							UnityEngine.Debug.LogError("Ext : "+obj.name+" "+guid+" "+localId);
							if(guid == Guid.Empty.ToString("N"))
							{
								if(!info.externalFiles.ContainsKey(localId))
								{
									info.externalFiles[localId] = ExportFile(obj, info);
								}
								pinfo.SetValue(comp, info.externalFiles[localId]);
							}
						}
					}
				}
				catch { } // In case of NotImplementedException being thrown. For some reason specifying that exception didn't seem to catch it, so I didn't catch anything specific.
			}
		}
		FieldInfo[] finfos = type.GetFields(flags);
		foreach (var finfo in finfos)
		{
			finfo.SetValue(comp, finfo.GetValue(other));
		}
		return comp as T;
	}

	static GameObject DuplicateGO(GameObject src, ExportInfo info)
	{
		GameObject go = new GameObject(src.name);
		Component[] cp = src.GetComponents(typeof(Component));
		for(int i = 0; i < cp.Length; i++)
		{
			Component c = go.AddComponent(cp[i].GetType()).GetCopyOf(cp[i], info);
			if (c is Behaviour && cp[i] is Behaviour)
			{
				(c as Behaviour).enabled = (cp[i] as Behaviour).enabled;
			}
		}
		for(int i = 0; i < src.transform.childCount; i++)
		{
			GameObject n = DuplicateGO(src.transform.GetChild(i).gameObject, info);
			n.transform.SetParent(go.transform, false);
		}
		go.layer = src.layer;
		go.SetActive(src.activeSelf);
		return go;
	}

	static T ExportFile<T>(T data, ExportInfo info) where T : UnityEngine.Object
	{
		if (data is Texture2D)
		{
			Texture2D tex = data as Texture2D;
			Texture2D newTex = TextureHelper.Copy(tex as Texture2D);

			string path = info.Path + tex.name + ".png";
			File.WriteAllBytes(path, newTex.EncodeToPNG());
			UnityEditor.AssetDatabase.ImportAsset(path, UnityEditor.ImportAssetOptions.ForceUpdate);
			var assetImporter = UnityEditor.AssetImporter.GetAtPath(path) as UnityEditor.TextureImporter;
			assetImporter.mipmapEnabled = tex.mipmapCount > 0;
			assetImporter.mipMapBias = tex.mipMapBias;
			assetImporter.sRGBTexture = false;
			assetImporter.anisoLevel = tex.anisoLevel;
			UnityEditor.AssetDatabase.WriteImportSettingsIfDirty(path);
			UnityEditor.AssetDatabase.ImportAsset(path, UnityEditor.ImportAssetOptions.ForceUpdate);
			Texture2D res = UnityEditor.AssetDatabase.LoadAssetAtPath<Texture2D>(path);
			return res as T;
		}
		else if(data is Material)
		{
			Material mat = data as Material;
			string p = info.Path + mat.name + ".mat";
			Material newMat = Copy(mat).GetCopyOf(mat, info);
			UnityEditor.AssetDatabase.CreateAsset(newMat, p);
			UnityEditor.AssetDatabase.ImportAsset(p, UnityEditor.ImportAssetOptions.ForceUpdate);
			Material res = UnityEditor.AssetDatabase.LoadAssetAtPath<Material>(p);
			return res as T;
		}
		else
		{
			UnityEngine.Debug.LogError("Cannon save type " + data.GetType() + " for asset "+data.name);
			return data;
		}
	}

	class ExportInfo
	{
		public string Path;
		public Dictionary<long, UnityEngine.Object> externalFiles = new Dictionary<long, UnityEngine.Object>();
	}

	static void SavePrefab(GameObject bundleSource, ExportInfo info)
	{
		GameObject prefab = DuplicateGO(bundleSource, info);
		UnityEditor.PrefabUtility.SaveAsPrefabAsset(prefab, info.Path + bundleSource.name + ".prefab");
	}

	static void ExtractBundle(AssetBundleLoadAllAssetOperationBase operation, string dirName)
	{
		UnityEditor.AssetDatabase.CreateFolder("Assets/Test/", dirName);
		ExportInfo info = new ExportInfo();
		info.Path = "Assets/Test/" + dirName + "/";

		// save prefabs & associated files
		operation.ForEach((UnityEngine.Object obj) =>
		{
			if(obj is GameObject)
			{
				SavePrefab(obj as GameObject, info);
			}
		});
		// save other data in the bundle not used by prefabs
		operation.ForEach((UnityEngine.Object obj) =>
		{
			if (!(obj is GameObject))
			{
				string guid;
				long localId;
				if (UnityEditor.AssetDatabase.TryGetGUIDAndLocalFileIdentifier(obj, out guid, out localId))
				{
					if (guid == Guid.Empty.ToString("N"))
					{
						if (!info.externalFiles.ContainsKey(localId))
						{
							info.externalFiles[localId] = ExportFile(obj, info);
						}
					}
					else
						UnityEngine.Debug.LogError(""+obj+" GUID is not null : " +guid);
				}
			}
		});
	}

	static IEnumerator TestBundleAsync()
	{
		/*foreach (var k in serverFileList)
		{
			//string path = ConvertPath(UnityEngine.Application.persistentDataPath + "/data" + k.Value);
			string path = k.Key.Replace("/android/", "");
			UnityEngine.Debug.LogError(path);
			yield return AssetBundleManager.LoadAllAssetAsync(path);
			AssetBundleManager.UnloadAssetBundle(path);
		}*/
		IsTesting = true;
		string s = "ad/am/100601.xab";
		UnityEngine.Debug.LogError(s);
		AssetBundleLoadAllAssetOperationBase operation = AssetBundleManager.LoadAllAssetAsync(s);
		yield return Co.R(operation);
		GameObject go = operation.GetAsset<GameObject>("100601");
		go = UnityEngine.Object.Instantiate(go);
		ExtractBundle(operation, "100601");
		yield return null;
		AssetBundleManager.UnloadAssetBundle(s);
		s = "ad/am/100602.xab";
		UnityEngine.Debug.LogError(s);
		operation = AssetBundleManager.LoadAllAssetAsync(s);
		yield return Co.R(operation);
		go = operation.GetAsset<GameObject>("100602");
		go = UnityEngine.Object.Instantiate(go);
		ExtractBundle(operation, "100602");
		yield return null;
		AssetBundleManager.UnloadAssetBundle(s);
		yield return new WaitForSeconds(1);
		IsTesting = false;
		UnityEngine.Debug.LogError("Done");
	}
#endif
}
