using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace XeSys.uGUI
{
	public class uGUIClickSwapImage : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		public UnityEvent onClick;
		public Sprite sprite1;
		public Sprite sprite2;
		public Image swapImage;

		public void OnPointerClick(PointerEventData eventData)
		{
			//throw new System.NotImplementedException();
		}

		private void Awake()
		{
			TodoLogger.LogError(0, "Implement Monobehaviour");
		}
	}
}
