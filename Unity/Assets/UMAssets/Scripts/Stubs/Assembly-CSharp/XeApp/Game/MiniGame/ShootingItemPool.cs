using UnityEngine;

namespace XeApp.Game.MiniGame
{
	public class ShootingItemPool : ShootingTask
	{
		private void Awake()
		{
			TodoLogger.Log(0, "Implement monobehaviour");
		}
		[SerializeField]
		private int m_createNum;
		public ShootingItem m_taskObject;
	}
}
