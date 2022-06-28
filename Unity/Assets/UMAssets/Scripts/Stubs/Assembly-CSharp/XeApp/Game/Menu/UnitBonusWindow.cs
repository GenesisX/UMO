using XeSys.Gfx;
using UnityEngine.UI;
using UnityEngine;

namespace XeApp.Game.Menu
{
	internal class UnitBonusWindow : LayoutUGUIScriptBase
	{
    public void Awake() { UnityEngine.Debug.LogError("Immplement LayoutUGUIScriptBase"); }
		[SerializeField]
		private Text m_descText;
		[SerializeField]
		private Text m_bonusPointText;
		[SerializeField]
		private LayoutUGUIScrollSupport m_scrollSupport;
	}
}
