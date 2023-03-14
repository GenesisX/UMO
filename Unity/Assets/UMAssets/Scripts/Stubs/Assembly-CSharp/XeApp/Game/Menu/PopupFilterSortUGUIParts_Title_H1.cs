using UnityEngine.UI;
using UnityEngine;
using XeApp.Game.Common;

namespace XeApp.Game.Menu
{
	public class PopupFilterSortUGUIParts_Title_H1 : PopupFilterSortUGUIPartsBase
	{
		private void Awake()
		{
			TodoLogger.Log(0, "Implement monobehaviour");
		}
		[SerializeField]
		private Text m_title_text;
		[SerializeField]
		private UGUIButton[] m_btn;
		[SerializeField]
		private Text[] m_btn_text;
	}
}
