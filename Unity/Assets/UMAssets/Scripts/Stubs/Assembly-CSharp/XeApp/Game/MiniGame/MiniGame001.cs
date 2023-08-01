using UnityEngine;
using XeSys.uGUI;

namespace XeApp.Game.MiniGame
{
	public class MiniGame001 : MonoBehaviour
	{
		[SerializeField]
		private VirtualPad virtualPad;
		[SerializeField]
		private UGUIFader fadePlane;
		[SerializeField]
		private RectTransform m_mainSceenSize;
		private void Awake()
		{
			TodoLogger.LogError(0, "Implement Monobehaviour");
		}
	}
}
