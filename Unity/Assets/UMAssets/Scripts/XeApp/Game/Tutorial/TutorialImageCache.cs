using XeApp.Game.Menu;

namespace XeApp.Game.Tutorial
{
	public class TutorialImageCache : IconTextureCache
	{

		// RVA: 0xE45F08 Offset: 0xE45F08 VA: 0xE45F08
		public TutorialImageCache() : base(6)
		{
			return;
		}

		// // RVA: 0xE45F14 Offset: 0xE45F14 VA: 0xE45F14 Slot: 5
		// public override void Terminated() { }

		// // RVA: 0xE45F1C Offset: 0xE45F1C VA: 0xE45F1C
		// public void Load(int imageId, Action<IiconTexture> cb) { }

		// // RVA: 0xE45FC4 Offset: 0xE45FC4 VA: 0xE45FC4 Slot: 7
		protected override IiconTexture CreateIconTexture(IconTextureLodingInfo info)
		{
			UnityEngine.Debug.LogError("TODO CreateIconTexture");
			return null;
		}
	}
}
