
using System;
using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using XeApp.Game;
using XeSys;
using XeSys.Gfx;

namespace XeApp.Core
{
    public class AssetBundleLoadLayoutOperation : AssetBundleLoadLayoutOperationBase
    {
        protected LoadedAssetBundle m_loadedAssetBundle; // 0x1C

        // RVA: 0xE0FD2C Offset: 0xE0FD2C VA: 0xE0FD2C
        public AssetBundleLoadLayoutOperation(string bundleName, string assetName) : base(bundleName, assetName)
        {

        }

        // RVA: 0xE0FD30 Offset: 0xE0FD30 VA: 0xE0FD30 Slot: 7
        public override bool Update()
        { 
            //UnityEngine.Debug.Log("Update Load "+m_AssetName+" - req: "+m_request+" - loadedbundle: "+m_loadedAssetBundle+" - error : "+m_loadingError+" - isdone: "+IsDone()+" - iserror : "+IsError());
            if(m_request != null)
                return !IsDone();
            m_loadedAssetBundle = AssetBundleManager.GetLoadedAssetBundle(m_AssetBundleName, out m_loadingError);
            if(m_loadedAssetBundle != null)
            {
                UnityEngine.Debug.Log("Request load layout in bundle : "+m_AssetName);
                m_request = m_loadedAssetBundle.m_AssetBundle.LoadAssetAsync(m_AssetName, m_Type);
                //UnityEngine.Debug.Log("Request load layout in bundle : "+m_AssetName+" "+m_request);
            }
            return !IsError();
        }

        // [IteratorStateMachineAttribute] // RVA: 0x747EE0 Offset: 0x747EE0 VA: 0x747EE0
        // RVA: 0xE0FE3C Offset: 0xE0FE3C VA: 0xE0FE3C Slot: 11
        public override IEnumerator InitializeLayoutCoroutine(Font font, Action<GameObject> finish)
        {
            //UnityEngine.Debug.Log("Enter InitializeLayoutCoroutine "+m_AssetName);
			//UnityEngine.Debug.Log("Enter InitializeLayoutCoroutine request : "+m_request);
			//0xE110FC
#if UNITY_EDITOR || UNITY_STANDALONE
			BundleShaderInfo.Instance.FixMaterialShader(m_request.asset);
#endif
            GameObject instance = UnityEngine.Object.Instantiate<GameObject>(m_request.asset as GameObject);
            LayoutUGUIRuntime[] runtimes = instance.GetComponentsInChildren<LayoutUGUIRuntime>(true);
            for(int i = 0; i < runtimes.Length; i++)
            {
                runtimes[i].gameObject.SetActive(true);
                runtimes[i].IsLayoutAutoLoad = false;
            }
            Canvas[] canvas = instance.GetComponentsInChildren<Canvas>(true);
            for(int i = 0; i < canvas.Length; i++)
            {
                canvas[i].enabled = false;
            }
            for(int i = 0; i < runtimes.Length; i++)
            {
                yield return Co.R(CreateLayoutCoroutine(runtimes[i], font, (Layout layout, TexUVListManager uvMan) => {
                    //0xE10128
                    runtimes[i].UvMan = uvMan;
                    runtimes[i].Layout = layout;
                }));
                runtimes[i].LoadLayout();
            }
            yield return null;
            Array.ForEach(instance.GetComponentsInChildren<Text>(true), (Text text) => {
                //0xE1001C
                if(text.font == null)
                {
                    text.font = font;
                    text.horizontalOverflow = HorizontalWrapMode.Overflow;
                }
            });
            if(finish != null)
            {
                finish(instance);
            }
            //UnityEngine.Debug.Log("Exit InitializeLayoutCoroutine "+m_AssetName);
        }

        // [IteratorStateMachineAttribute] // RVA: 0x747F58 Offset: 0x747F58 VA: 0x747F58
        // // RVA: 0xE0FF1C Offset: 0xE0FF1C VA: 0xE0FF1C Slot: 12
        public override IEnumerator CreateLayoutCoroutine(LayoutUGUIRuntime runtime, Font font, Action<Layout, TexUVListManager> finish)
        {
            // private Layout <layout>5__2; // 0x20
            // private TexUVListManager <uvMan>5__3; // 0x24
            // private LayoutAnimation <layoutAnime>5__4; // 0x28
            // private int <j>5__5; // 0x2C
            // private StringReader <sr>5__6; // 0x30
            // 0xE1018C
            Layout layout = new Layout();
            layout.fontInfo = new FontInfo();
            layout.fontInfo.font = font;
            TexUVListManager uvMan = new TexUVListManager();
            LayoutAnimation layoutAnime = new LayoutAnimation();
            m_request = m_loadedAssetBundle.m_AssetBundle.LoadAssetAsync<ScriptableLayout>(Path.GetFileName(runtime.LayoutPath));
            while(!m_request.isDone)
                yield return null;
            ScriptableLayout scriptable = m_request.asset as ScriptableLayout;
            if(scriptable != null)
            {
                layout.Import(scriptable);
                for(int j = 0; j < runtime.TexturePathList.Length; j++)
                {
                    TexUVList uvList = GameManager.Instance.UnionTextureManager.GetTexUvList(runtime.UvListPathList[j]);
                    if(uvList == null)
                    {
                        m_request = m_loadedAssetBundle.m_AssetBundle.LoadAssetAsync<TexUVList>(Path.GetFileName(runtime.UvListPathList[j]));
                        while(!m_request.isDone)
                            yield return null;
                        uvList = m_request.asset as TexUVList;
                    }
                    if(uvList == null)
                        UnityEngine.Debug.LogError("Failed to load "+Path.GetFileName(runtime.UvListPathList[j]));
                    uvMan.Register(j, uvList);
                }
                layout.SettingTexture(uvMan);
                if(finish != null)
                {
                    finish(layout, uvMan);
                }
                yield break;
            }
            m_request = m_loadedAssetBundle.m_AssetBundle.LoadAssetAsync<TextAsset>(Path.GetFileName(runtime.LayoutPath));
            while(!m_request.isDone)
                yield return null;
            if(m_request.asset != null)
            {
                layout.LoadFromString((m_request.asset as TextAsset).text);
                if(!string.IsNullOrEmpty(runtime.AnimListPath))
                {
                    m_request = m_loadedAssetBundle.m_AssetBundle.LoadAssetAsync<TextAsset>(Path.GetFileName(runtime.AnimListPath));
                    while(!m_request.isDone)
                        yield return null;
                    TextAsset animText = m_request.asset as TextAsset;
                    StringReader sr = new StringReader(animText.text);
                    while(true)
                    {
                        string animName = sr.ReadLine();
                        if(animName == null)
                            break;
                        m_request = m_loadedAssetBundle.m_AssetBundle.LoadAssetAsync<TextAsset>(Path.GetFileName(animName));
                        while(!m_request.isDone)
                            yield return null;
                        layoutAnime.LoadFromBytes((m_request.asset as TextAsset).bytes);
                    }
                    layout.SettingAnimation(layoutAnime);
                    sr = null;
                }
                for(int j = 0; j < runtime.TexturePathList.Length; j++)
                {
                    m_request = m_loadedAssetBundle.m_AssetBundle.LoadAssetAsync<TextAsset>(runtime.UvListPathList[j]);
                    while(!m_request.isDone)
                        yield return null;
                    uvMan.Add((m_request.asset as TextAsset).bytes, null);
                }
                layout.SettingTexture(uvMan);
                if(finish != null)
                {
                    finish(layout, uvMan);
                }
            }
        }
    }
}
