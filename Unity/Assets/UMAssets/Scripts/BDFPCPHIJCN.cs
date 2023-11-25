using UnityEngine;
using XeSys;
using System.Collections.Generic;
using CriWare;
using XeApp.Game.Common;

public class BDFPCPHIJCN : LBHFILLFAGA
{
	private WWW IEJJKNOEKLM; // 0x4C
	private int LGADCGFMLLD; // 0x50
	private AssetBundleCreateRequest NMNCMNNPNCI; // 0x54

#if UNITY_EDITOR || UNITY_STANDALONE
	bool m_DownloadingFile = false;
#endif
	// RVA: 0xC70568 Offset: 0xC70568 VA: 0xC70568
	public BDFPCPHIJCN(string CJEKGLGBIHF_path, string BOPDLODALFD_withoutPlarformPath, FileLoadedPostProcess OGLMMENAJFL_onSuccess, FileLoadedPostProcess GOIHDOPGPCE_onFail, Dictionary<string, string> JBKMAPLCBMO_arg, int HNKPENAFDKA_argValue, FileLoadInfo LAMFBMFNOFP_fi, bool ALJGNAPELAH)
        : base(CJEKGLGBIHF_path,BOPDLODALFD_withoutPlarformPath,OGLMMENAJFL_onSuccess,GOIHDOPGPCE_onFail,JBKMAPLCBMO_arg,HNKPENAFDKA_argValue,LAMFBMFNOFP_fi)
    {
		return;
    }

	// RVA: 0xC70630 Offset: 0xC70630 VA: 0xC70630 Slot: 4
	public override void BDALHEMDIDC_DoStart()
	{
		if(Common.IsStreamingAssetsPath(HHHEFALNMJO_mPath))
		{
			IEJJKNOEKLM = new WWW(Application.streamingAssetsPath + HHHEFALNMJO_mPath);
		}
		else
		{
#if UNITY_EDITOR || UNITY_STANDALONE
			m_DownloadingFile = true;
			FileSystemProxy.TryInstallFile(HHHEFALNMJO_mPath, (string newPath) =>
			{
				IEJJKNOEKLM = new WWW("file://" + newPath);
				m_DownloadingFile = false;
			});
#else
			IEJJKNOEKLM = new WWW("file://"+HHHEFALNMJO_mPath);
#endif
		}
		LGADCGFMLLD = 0;
	}

	// // RVA: 0xC70770 Offset: 0xC70770 VA: 0xC70770 Slot: 5
	public override bool GDEMPLAOGKK_IsDone()
	{
#if UNITY_EDITOR || UNITY_STANDALONE
		if (m_DownloadingFile)
			return false;
#endif
		if(FHHAFJMELMD_alreadyLoading)
		{
			return true;
		}
		return IEJJKNOEKLM.isDone;
	}

	// // RVA: 0xC707B4 Offset: 0xC707B4 VA: 0xC707B4 Slot: 6
	public override string LKPOPGJLPAJ_GetErrorStr()
	{
		if(IEJJKNOEKLM != null)
			return IEJJKNOEKLM.error;
		return null;
	}

	// // RVA: 0xC707CC Offset: 0xC707CC VA: 0xC707CC Slot: 9
	public override bool MLMEOLAEJEL_DoLoadData()
	{
#if UNITY_EDITOR || UNITY_STANDALONE
		if (m_DownloadingFile)
			return false;
#endif
		if(!FHHAFJMELMD_alreadyLoading)
		{
			if(LGADCGFMLLD == 2)
			{
				return false;
			}
			else if(LGADCGFMLLD == 1)
			{
				TodoLogger.Log(TodoLogger.Filesystem, "Bundle wait for load in memory");
				if(NMNCMNNPNCI.isDone)
				{
					if(NMNCMNNPNCI.assetBundle == null)
					{
						NMNCMNNPNCI = null;
						TodoLogger.LogError(TodoLogger.Filesystem, "Error loading bundle");
						LGADCGFMLLD = 2;
						PopupWindowControl control = PopupWindowManager.Show(PopupWindowManager.CrateTextContent("UMO", SizeType.Large, "Error loading asset bundle \n"+HHHEFALNMJO_mPath+"\nReplace it and retry or relaunch the game and enable Integrity Check.", 
						new ButtonInfo[1]
						{
							new ButtonInfo() { Label = PopupButton.ButtonLabel.Retry, Type = PopupButton.ButtonType.Positive }
						}
						, false, true), (PopupWindowControl control_, PopupButton.ButtonType t, PopupButton.ButtonLabel label) =>
						{
							BDALHEMDIDC_DoStart();
						}, null, null, null);
						return false;
					}
					else
					{
						TodoLogger.Log(TodoLogger.Filesystem, "Bundle loaded in memory");
						IMGIFJHHEED_fro.assetBundle = NMNCMNNPNCI.assetBundle;
						NMNCMNNPNCI = null;
					}
				}
				else
				{
					return false;
				}
			}
			else if(LGADCGFMLLD == 0)
			{
				byte[] data = IEJJKNOEKLM.bytes;
				if(!BBGDFKAPJHN(data))
				{
					if(DMKAFCEJFDG_decryptor == null)
					{
						Debug.LogError("decryptor is null");
					}
					DMKAFCEJFDG_decryptor.CLNHGLGOKPF_Decrypt(data);
					if(!BBGDFKAPJHN(data))
					{
						Debug.LogError("decrypt failed");
					}
				}
				TodoLogger.Log(TodoLogger.Filesystem, "Bundle decrypted, start load in memory");
				//#region UMO
				// Convert android bundle to Window / Linux bundle
				//#if UNITY_STANDALONE_WIN || UNITY_EDITOR_WIN || UNITY_STANDALONE_LINUX || UNITY_EDITOR_LINUX
#if !UNITY_EDITOR && (UNITY_STANDALONE_WIN || UNITY_STANDALONE_LINUX) // Load Bug with stage bundle
				int pos = -1;
				// search for 2018 engine tag
				int valCnt = 0;
				for(int i = 0; i < data.Length - 5; i++)
				{
					if (data[i] == '2' && data[i + 1] == '0' && data[i + 2] == '1' && data[i + 3] == '8' && data[i + 4] == '.')
					{
						valCnt++;
						if(valCnt == 2)
						{
							pos = i;
							for (; data[pos] != 0; pos++)
								;
							pos++;
							if (data[pos] != 13)
								pos = -1;
							break;
						}
					}
				}

				if (pos == -1)
					UnityEngine.Debug.LogError("Asset bundle " + HHHEFALNMJO_mPath + " is not in android format");
				else
#if UNITY_STANDALONE_WIN || UNITY_EDITOR_WIN
					data[pos] = 19;
#elif UNITY_STANDALONE_LINUX || UNITY_EDITOR_LINUX
					data[pos] = 17;
#endif
#endif
				//#endregion
				NMNCMNNPNCI = AssetBundle.LoadFromMemoryAsync(data);
				LGADCGFMLLD = 1;
				return false;
			}
		}
		return base.MLMEOLAEJEL_DoLoadData();
	}

	// // RVA: 0xC70AB0 Offset: 0xC70AB0 VA: 0xC70AB0 Slot: 11
	public override void PAHHAMPDBFP()
	{
		if(FHHAFJMELMD_alreadyLoading)
			return;
		if(IEJJKNOEKLM != null)
		{
			IEJJKNOEKLM.Dispose();
			IEJJKNOEKLM = null;
		}
		base.PAHHAMPDBFP();
	}

	// // RVA: 0xC70AF8 Offset: 0xC70AF8 VA: 0xC70AF8 Slot: 12
	public override void DKNGPHJKGAP()
	{
		if(FHHAFJMELMD_alreadyLoading)
			return;
		if(IEJJKNOEKLM != null)
		{
			IEJJKNOEKLM.Dispose();
			IEJJKNOEKLM = null;
		}
		base.DKNGPHJKGAP();
	}

	// // RVA: 0xC70B40 Offset: 0xC70B40 VA: 0xC70B40 Slot: 13
	public override void JNDNHPEIMEI()
	{
		if(IMGIFJHHEED_fro.assetBundle == null)
		{
			return;
		}
		IMGIFJHHEED_fro.assetBundle.Unload(false);
		IMGIFJHHEED_fro.assetBundle = null;
	}
}
