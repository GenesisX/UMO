using XeSys.Gfx;
using UnityEngine;
using XeApp.Game.Common;

namespace XeApp.Game.Menu
{
	public class HomeRichBanner : LayoutUGUIScriptBase
	{
    public void Awake() { UnityEngine.Debug.LogError("Immplement LayoutUGUIScriptBase"); }
		[SerializeField]
		private RawImageEx m_image;
		[SerializeField]
		private ActionButton m_okButton;
		[SerializeField]
		private Material m_materialSource;
	}
}
