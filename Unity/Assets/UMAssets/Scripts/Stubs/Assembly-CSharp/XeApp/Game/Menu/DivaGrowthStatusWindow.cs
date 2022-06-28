using XeSys.Gfx;
using UnityEngine.UI;
using UnityEngine;
using XeApp.Game.Common;

namespace XeApp.Game.Menu
{
	public class DivaGrowthStatusWindow : LayoutUGUIScriptBase
	{
    public void Awake() { UnityEngine.Debug.LogError("Immplement LayoutUGUIScriptBase"); }
		[SerializeField]
		private Text[] m_statusTexts;
		[SerializeField]
		private RawImageEx m_divaImage;
		[SerializeField]
		private ActionButton m_detailButton;
	}
}
