using System.Collections.Generic;

namespace XeApp.Game.MiniGame
{
	public class ShootingItemManager : ShootingTask
	{
		private void Awake()
		{
			TodoLogger.Log(0, "Implement monobehaviour");
		}
		public List<ShootingItemPool> m_itemPoolObj;
	}
}
