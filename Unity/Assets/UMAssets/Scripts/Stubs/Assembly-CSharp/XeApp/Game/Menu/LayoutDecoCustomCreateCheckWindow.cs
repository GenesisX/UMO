using XeSys.Gfx;
using UnityEngine;
using UnityEngine.UI;

namespace XeApp.Game.Menu
{
	public class LayoutDecoCustomCreateCheckWindow : LayoutUGUIScriptBase
	{
    public void Awake() { UnityEngine.Debug.LogError("Immplement LayoutUGUIScriptBase"); }
		[SerializeField]
		private RawImageEx m_charactorImage;
		[SerializeField]
		private RawImageEx m_serifImage;
		[SerializeField]
		private Text[] m_serifText;
	}
}
