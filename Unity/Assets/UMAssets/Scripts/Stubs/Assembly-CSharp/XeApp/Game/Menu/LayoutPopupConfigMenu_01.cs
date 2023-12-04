using UnityEngine.UI;
using UnityEngine;

namespace XeApp.Game.Menu
{
	public class LayoutPopupConfigMenu_01 : LayoutPopupConfigBase
	{
		private void Awake()
		{
			TodoLogger.LogError(1, "Implement monobehaviour");
		}

		public override int GetContentsHeight()
		{
			TodoLogger.LogError(0, "Implement monobehaviour");
			return 0;
		}

		public override bool IsShow()
		{
			TodoLogger.LogError(0, "Implement monobehaviour");
			return false;
		}
		[SerializeField]
		private Text m_titleVolume;
		[SerializeField]
		private Text m_titleDiva;
		[SerializeField]
		private Text m_descDiva;
		[SerializeField]
		private Text m_descCenterDiva;
		[SerializeField]
		private Text m_descSelectDiva;
		[SerializeField]
		private Text m_titleKira;
		[SerializeField]
		private Text m_descKira;
		[SerializeField]
		private Text m_descOnKira;
		[SerializeField]
		private Text m_descOffKira;
		[SerializeField]
		private Text m_costumeEffectTitle;
		[SerializeField]
		private Text m_costumeEffectCaution01;
		[SerializeField]
		private Text m_costumeEffectCaution02;
		[SerializeField]
		private Text m_plateAnimeTitle;
		[SerializeField]
		private Text m_plateAnimeCaution01;
		[SerializeField]
		private GameObject m_voicePos;
		[SerializeField]
		private GameObject m_sePos;
		[SerializeField]
		private GameObject m_bgmPos;
	}
}
