using UnityEngine;
using UnityEngine.UI;

namespace XeApp.Game.MiniGame
{
	public class ShootingScore : MonoBehaviour
	{
		[SerializeField]
		private Text m_scoreText;
		private void Awake()
		{
			TodoLogger.LogError(0, "Implement Monobehaviour");
		}
	}
}
