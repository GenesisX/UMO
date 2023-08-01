using XeSys.Gfx;
using UnityEngine;
using XeApp.Game.Common;

namespace XeApp.Game.Menu
{
	public class LobbyGroupSelectWindow : LayoutUGUIScriptBase
	{
    public void Awake() { TodoLogger.LogError(0, "Implement LayoutUGUIScriptBase"); }
		[SerializeField]
		private RawImageEx[] m_bannerImage;
		[SerializeField]
		private ActionButton m_groupSearchButton;
		[SerializeField]
		private ActionButton[] m_Button;
		public bool IsShow;
	}
}
