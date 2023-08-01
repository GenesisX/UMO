using XeSys.Gfx;
using XeApp.Game.Common;
using UnityEngine;
using UnityEngine.UI;

namespace XeApp.Game.Menu
{
	public class HomeComebackPopup : LayoutUGUIScriptBase
	{
    public void Awake() { TodoLogger.LogError(0, "Implement LayoutUGUIScriptBase"); }
		[SerializeField]
		private ActionButton m_buttonClose;
		[SerializeField]
		private Text m_textMissionCount;
		[SerializeField]
		private RawImageEx m_image;
		[SerializeField]
		private LayoutUGUIHitOnly m_touchBlocker;
	}
}
