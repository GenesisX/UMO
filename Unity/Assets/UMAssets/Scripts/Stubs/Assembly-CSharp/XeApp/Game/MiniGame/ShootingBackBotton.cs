using UnityEngine;
using XeApp.Game.Common;

namespace XeApp.Game.MiniGame
{
	public class ShootingBackBotton : MonoBehaviour
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
