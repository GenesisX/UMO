using XeSys.Gfx;
using UnityEngine.UI;
using UnityEngine;

namespace XeApp.Game.Menu
{
	public class LayoutPopupPresentGet : LayoutUGUIScriptBase
	{
    public void Awake() { UnityEngine.Debug.LogError("Immplement LayoutUGUIScriptBase"); }
		[SerializeField]
		private Text m_ItemName;
		[SerializeField]
		private Text m_ItemDetail;
		[SerializeField]
		private RawImageEx m_imageItem;
	}
}
