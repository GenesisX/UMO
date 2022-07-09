using System;

namespace XeApp.Game.Menu
{
	public class ItemTextureCache : IconTextureCache
	{
		// RVA: 0x14BD444 Offset: 0x14BD444 VA: 0x14BD444
		public ItemTextureCache() : base(40)
		{
			return;
		}

		// // RVA: 0x14BD450 Offset: 0x14BD450 VA: 0x14BD450 Slot: 5
		// public override void Terminated() { }

		// // RVA: 0x14BD458 Offset: 0x14BD458 VA: 0x14BD458 Slot: 7
		protected override IiconTexture CreateIconTexture(IconTextureLodingInfo info)
		{
			UnityEngine.Debug.LogError("TODO CreateIconTexture");
			return null;
		}

		// // RVA: 0x14BD4E0 Offset: 0x14BD4E0 VA: 0x14BD4E0
		public void Load(int id, Action<IiconTexture> callBack)
		{
			UnityEngine.Debug.LogError("TODO IconTextureCache Load");
		}

		// // RVA: 0x14BD918 Offset: 0x14BD918 VA: 0x14BD918
		// public void Load(int id, int subId, Action<IiconTexture> callBack) { }

		// // RVA: 0x14BD94C Offset: 0x14BD94C VA: 0x14BD94C
		// public void LoadEmblem(int emblemId, Action<IiconTexture> callback) { }

		// // RVA: 0x14BDA14 Offset: 0x14BDA14 VA: 0x14BDA14
		// public void TryInstallEmblem(int emblemId) { }

		// // RVA: 0x14BDAC4 Offset: 0x14BDAC4 VA: 0x14BDAC4
		// public void TryInstall(int id, int subId = 0) { }

		// // RVA: 0x14BDB7C Offset: 0x14BDB7C VA: 0x14BDB7C
		// private static int ConvertDegreeTexId(int itemId) { }

		// // RVA: 0x14BD984 Offset: 0x14BD984 VA: 0x14BD984
		// public static string MakeEmblemIconTexturePath(int emblemId) { }

		// // RVA: 0x14BD514 Offset: 0x14BD514 VA: 0x14BD514
		// public static string MakeItemIconTexturePath(int id, int subId = 0) { }

		// // RVA: 0x14BDCF8 Offset: 0x14BDCF8 VA: 0x14BDCF8
		// public static string MakeDecoItemIconTexturePath(int id, int subId = 0) { }

		// // RVA: 0x14BDFFC Offset: 0x14BDFFC VA: 0x14BDFFC
		// public static string MakeDecoPosterIconTexturePath(int id, int subId = 0) { }

		// // RVA: 0x14BE294 Offset: 0x14BE294 VA: 0x14BE294
		// public static string MakeDecoCostumeTorsoIconTexturePath(int id, int subId = 0) { }

		// // RVA: 0x14BE194 Offset: 0x14BE194 VA: 0x14BE194
		// public static string MakeDecoVFFigureIconTexturePath(int id, int subId = 0) { }

		// // RVA: 0x14BE3FC Offset: 0x14BE3FC VA: 0x14BE3FC
		// private static string MakeDecoItemDirectoryPath(EKLNMHFCAOI.FKGCBLHOOCL type) { }

	}
}
