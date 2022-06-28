using XeSys.Gfx;
using UnityEngine.UI;
using UnityEngine;
using XeApp.Game.Common;

namespace XeApp.Game.Menu
{
	public class LayoutMissionCardButton : LayoutUGUIScriptBase
	{
    public void Awake() { UnityEngine.Debug.LogError("Immplement LayoutUGUIScriptBase"); }
		[SerializeField]
		private Text m_desc;
		[SerializeField]
		private Text m_pointText;
		[SerializeField]
		private RawImageEx m_levelImage;
		[SerializeField]
		private ActionButton m_button;
	}
}
