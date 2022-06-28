using XeSys.Gfx;
using UnityEngine;
using UnityEngine.UI;

namespace XeApp.Game.Menu
{
	public class LayoutGachaTitle : LayoutUGUIScriptBase
	{
    public void Awake() { UnityEngine.Debug.LogError("Immplement LayoutUGUIScriptBase"); }
		[SerializeField]
		private RawImageEx m_imageTitle;
		[SerializeField]
		private Text m_textPeriod;
		[SerializeField]
		private Text m_textDesc;
		[SerializeField]
		private Text m_textEvTicket;
	}
}
