using XeSys.Gfx;
using UnityEngine.UI;
using UnityEngine;

namespace XeApp.Game.Menu
{
	public class LayoutDecorationSpItemLevelupContent : LayoutUGUIScriptBase
	{
    public void Awake() { TodoLogger.LogError(0, "Implement LayoutUGUIScriptBase"); }
		[SerializeField]
		private Text m_message;
		[SerializeField]
		private Text m_currentLevel;
		[SerializeField]
		private Text m_nextLevel;
	}
}
