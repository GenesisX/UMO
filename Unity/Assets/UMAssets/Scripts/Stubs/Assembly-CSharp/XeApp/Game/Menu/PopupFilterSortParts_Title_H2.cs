using UnityEngine.UI;
using UnityEngine;

namespace XeApp.Game.Menu
{
	public class PopupFilterSortParts_Title_H2 : PopupFilterSortPartsBase
	{
		private void Awake()
		{
			TodoLogger.Log(0, "Implement monobehaviour");
		}
		[SerializeField]
		private Text m_title_text;
	}
}
