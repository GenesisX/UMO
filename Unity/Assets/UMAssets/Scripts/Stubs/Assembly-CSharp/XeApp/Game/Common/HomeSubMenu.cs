using UnityEngine;
using System.Collections.Generic;

namespace XeApp.Game.Common
{
	public class HomeSubMenu : MonoBehaviour
	{
		[SerializeField]
		private List<HomeSubMenuButton> m_buttons;
		[SerializeField]
		private InOutAnime m_inOutAnime;
		[SerializeField]
		private CanvasGroup m_canvasGroup;
		private void Awake()
		{
			TodoLogger.Log(0, "Implement Monobehaviour");
		}
	}
}
