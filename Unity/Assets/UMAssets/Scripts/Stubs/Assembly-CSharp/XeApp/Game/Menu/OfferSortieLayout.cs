using XeSys.Gfx;
using UnityEngine;

namespace XeApp.Game.Menu
{
	public class OfferSortieLayout : LayoutUGUIScriptBase
	{
    public void Awake() { TodoLogger.LogError(0, "Implement LayoutUGUIScriptBase"); }
		[SerializeField]
		private RectTransform m_ValAnimRect;
		public bool IsSortieEnd;
	}
}
