using UnityEngine;
using XeApp.Game.Common;

namespace XeApp.Game.Menu
{
	public class GakuyaViewReturnButton : MonoBehaviour
	{
		[SerializeField]
		private UGUIEnterLeave m_enterLeaveControl;
		[SerializeField]
		private UGUIButton m_buttonReturn;
		private void Awake()
		{
			TodoLogger.LogError(0, "Implement Monobehaviour");
		}
	}
}
