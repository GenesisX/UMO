using XeSys.Gfx;
using UnityEngine;

namespace XeApp.Game.UI
{
	public class ModifierRadarChart : LayoutUGUIScriptBase
	{
    public void Awake() { UnityEngine.Debug.LogError("Immplement LayoutUGUIScriptBase"); }
		[SerializeField]
		private int m_DataCount;
		[SerializeField]
		private float m_DrawSize;
		[SerializeField]
		private Vector2[] m_UVList;
		[SerializeField]
		private float m_AnimeTime;
	}
}
