using XeApp.Game.Common;
using UnityEngine;
using UnityEngine.UI;

namespace XeApp.Game.Menu
{
	public class PopupFilterSortUGUIParts_FilterPlateSkill : PopupFilterSortUGUIPartsBase
	{
		private void Awake()
		{
			TodoLogger.LogError(0, "Implement monobehaviour");
		}
		[SerializeField]
		private InOutAnime m_inOutAnime;
		[SerializeField]
		private UGUIToggleButton[] m_RangeBtn;
		[SerializeField]
		private UGUIToggleButton[] m_RankBtn;
		[SerializeField]
		private UGUIToggleButton[] m_SkillBtn;
		[SerializeField]
		private Text[] m_Text;
		[SerializeField]
		private int skillType;
		[SerializeField]
		public UGUIToggleButton m_showBtn;
		[SerializeField]
		private GameObject m_setupContents;
		[SerializeField]
		private UGUIToggleButton m_allBtn;
		[SerializeField]
		private UGUIButton m_releaseBtn;
		[SerializeField]
		private RectTransform[] m_longshortArea;
		
		public override Type MyType { get { TodoLogger.LogError(0, "Type"); return 0; } }
		protected override System.Collections.IEnumerator OnInitialize() { TodoLogger.LogError(0, "OnInitialize"); yield return null; }
	}
}
