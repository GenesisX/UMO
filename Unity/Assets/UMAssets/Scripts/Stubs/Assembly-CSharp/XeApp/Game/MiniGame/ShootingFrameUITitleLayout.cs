using UnityEngine;

namespace XeApp.Game.MiniGame
{
	public class ShootingFrameUITitleLayout : MonoBehaviour
	{
		[SerializeField]
		private ShootingBackBotton m_backButton;
		[SerializeField]
		private ShootingHelpBotton m_helpButton;
		private void Awake()
		{
			TodoLogger.LogError(0, "Implement Monobehaviour");
		}
	}
}
