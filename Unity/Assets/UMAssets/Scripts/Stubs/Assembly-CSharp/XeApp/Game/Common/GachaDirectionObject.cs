using UnityEngine;

namespace XeApp.Game.Common
{
	public class GachaDirectionObject : MonoBehaviour
	{
		[SerializeField]
		private Transform m_elementRoot;
		[SerializeField]
		private Transform m_quartzRoot;
		private void Awake()
		{
			TodoLogger.LogError(0, "Implement Monobehaviour");
		}
	}
}
