using UnityEngine.EventSystems;
using UnityEngine;

namespace XeApp.Game.Common
{
	public class WebContent : UIBehaviour
	{
		private void Awake()
		{
			TodoLogger.Log(0, "Implement monobehaviour");
		}
		[SerializeField]
		private RectTransform m_webArea;
	}
}
