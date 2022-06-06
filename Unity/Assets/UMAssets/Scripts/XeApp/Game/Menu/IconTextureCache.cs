
namespace XeApp.Game.Menu
{
	public abstract class IconTextureCache
	{
		// Fields
		//private IndexableDictionary<string, IiconTexture> m_iconTextureCache; // 0x8
		//private IndexableDictionary<string, IconTextureLodingInfo> m_loadingAssetBundle; // 0xC
		private int m_capacity; // 0x10
		private ulong m_createCount; // 0x18

		// RVA: 0x13DBD3C Offset: 0x13DBD3C VA: 0x13DBD3C
		public IconTextureCache(int capacity = 0)
		{
			//m_loadingAssetBundle = new IndexableDictionary<string, IconTextureLodingInfo>();
			//m_iconTextureCache = new IndexableDictionary<string, IiconTexture>(capacity);
			m_capacity = capacity;
			m_createCount = 0;
		}

		// // RVA: 0x13DBE18 Offset: 0x13DBE18 VA: 0x13DBE18 Slot: 4
		// public virtual void Clear() { }

		// // RVA: -1 Offset: -1 Slot: 5
		// public abstract void Terminated();

		// // RVA: 0x13DBFC0 Offset: 0x13DBFC0 VA: 0x13DBFC0 Slot: 6
		// public virtual void Load(string path, Action<IiconTexture> callBack) { }

		// // RVA: 0x13DBFE0 Offset: 0x13DBFE0 VA: 0x13DBFE0
		// protected void Load(string path, IconTextureType iconTextureType, Action<IiconTexture> callBack) { }

		// // RVA: 0x13DC6D0 Offset: 0x13DC6D0 VA: 0x13DC6D0
		public void Update()
		{
			UnityEngine.Debug.LogError("TODO");
		}

		// // RVA: 0x13DC9B4 Offset: 0x13DC9B4 VA: 0x13DC9B4
		// public bool IsLoading() { }

		// // RVA: -1 Offset: -1 Slot: 7
		// protected abstract IiconTexture CreateIconTexture(IconTextureLodingInfo info);

		// // RVA: 0x13DCA3C Offset: 0x13DCA3C VA: 0x13DCA3C
		// protected void SetupForSplitTexture(IconTextureLodingInfo info, IiconTexture icon) { }

		// // RVA: 0x13DCE74 Offset: 0x13DCE74 VA: 0x13DCE74
		// protected void SetupForSplitTexture(IconTextureLodingInfo info, IiconTexture icon, Texture2D maskTexture) { }

		// // RVA: 0x13DD214 Offset: 0x13DD214 VA: 0x13DD214
		// protected void SetupForSplitTextureBias(IconTextureLodingInfo info, IiconTexture icon, float mipmapBias) { }

		// // RVA: 0x13DD70C Offset: 0x13DD70C VA: 0x13DD70C
		// protected void SetupForSplitTextureBias(IconTextureLodingInfo info, IiconTexture icon, Texture2D maskTexture, float mipmapBias) { }

		// // RVA: 0x13DDB7C Offset: 0x13DDB7C VA: 0x13DDB7C
		// protected void SetupForSingleTexture(IconTextureLodingInfo info, IiconTexture icon) { }

		// // RVA: 0x13DC66C Offset: 0x13DC66C VA: 0x13DC66C
		// public ulong GetCreateCountAndIncrement() { }
	}
}
