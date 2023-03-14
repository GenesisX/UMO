using XeApp.Game.Common;
using XeSys.Gfx;
using UnityEngine;
using UnityEngine.UI;

namespace XeApp.Game.Menu
{
	public class BgSelectIconScrollContent : SwapScrollListContent
	{
		private void Awake()
		{
			TodoLogger.Log(0, "Implement monobehaviour");
		}
		[SerializeField]
		private RawImageEx m_sceneIconImage;
		[SerializeField]
		private ActionButton m_sceneIconButton;
		[SerializeField]
		private Text m_limitText;
		[SerializeField]
		private RawImageEx[] m_selectFrameIcon;
		[SerializeField]
		private RawImageEx[] m_setFrameIcon;
	}
}
