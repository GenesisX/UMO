using UnityEngine;
using XeApp.Game.Common;

namespace XeApp.Game.Menu
{
	public class GakuyaViewModeButton : MonoBehaviour
	{
		[SerializeField]
		private UGUIEnterLeave m_enterLeaveControl;
		[SerializeField]
		private UGUIButton m_buttonView;
		private void Awake()
		{
			TodoLogger.Log(0, "Implement Monobehaviour");
		}
	}
}
