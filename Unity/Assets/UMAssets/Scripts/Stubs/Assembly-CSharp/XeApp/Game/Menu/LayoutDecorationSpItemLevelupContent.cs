using XeSys.Gfx;
using UnityEngine.UI;
using UnityEngine;

namespace XeApp.Game.Menu
{
	public class LayoutDecorationSpItemLevelupContent : LayoutUGUIScriptBase
	{
    public void Awake() { UnityEngine.Debug.LogError("Immplement LayoutUGUIScriptBase"); }
		[SerializeField]
		private Text m_message;
		[SerializeField]
		private Text m_currentLevel;
		[SerializeField]
		private Text m_nextLevel;
	}
}
