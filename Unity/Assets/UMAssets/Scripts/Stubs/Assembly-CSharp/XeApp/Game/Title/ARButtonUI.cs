using UnityEngine;
using UnityEngine.UI;

namespace XeApp.Game.Title
{
	public class ARButtonUI : MonoBehaviour
	{
		[SerializeField]
		private Button m_gotoARButton;
		private void Awake()
		{
			TodoLogger.Log(0, "Implement Monobehaviour");
		}
	}
}
