using UnityEngine;

namespace XeApp.Game.Common
{
	public class HomeGakuyaButton : MonoBehaviour
	{
		[SerializeField]
		private ButtonBase m_button;
		[SerializeField]
		private InOutAnime m_inOutAnime;
		private void Awake()
		{
			TodoLogger.Log(0, "Implement Monobehaviour");
		}
	}
}
