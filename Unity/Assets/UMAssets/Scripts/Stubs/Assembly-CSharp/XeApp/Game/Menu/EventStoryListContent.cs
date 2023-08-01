using XeApp.Game.Common;
using XeSys.Gfx;
using UnityEngine;
using UnityEngine.UI;

namespace XeApp.Game.Menu
{
	public class EventStoryListContent : SwapScrollListContent
	{
		private void Awake()
		{
			TodoLogger.LogError(0, "Implement monobehaviour");
		}
		[SerializeField]
		private RawImageEx m_thumbnail;
		[SerializeField]
		private Text m_titleText;
		[SerializeField]
		private Text m_unlockText;
		[SerializeField]
		private ActionButton[] m_buttons;
		[SerializeField]
		private int m_capture;
	}
}
