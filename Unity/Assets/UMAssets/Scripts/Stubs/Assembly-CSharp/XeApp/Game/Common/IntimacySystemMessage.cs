using UnityEngine;

namespace XeApp.Game.Common
{
	public class IntimacySystemMessage : MonoBehaviour
	{
		[SerializeField]
		private UGUICommonInfoWindow m_systemWindow;
		[SerializeField]
		private Color[] m_colorTable;
		private void Awake()
		{
			TodoLogger.Log(0, "Implement Monobehaviour");
		}
	}
}
