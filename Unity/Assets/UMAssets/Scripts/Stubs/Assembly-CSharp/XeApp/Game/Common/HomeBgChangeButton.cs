using UnityEngine;

namespace XeApp.Game.Common
{
	public class HomeBgChangeButton : MonoBehaviour
	{
		[SerializeField]
		private ButtonBase m_button;
		[SerializeField]
		private GameObject m_iconNew;
		[SerializeField]
		private InOutAnime m_inOutAnime;
		private void Awake()
		{
			TodoLogger.Log(0, "Implement Monobehaviour");
		}
	}
}
