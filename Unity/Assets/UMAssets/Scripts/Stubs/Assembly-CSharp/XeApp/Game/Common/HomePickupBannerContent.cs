using XeSys.Gfx;
using UnityEngine;
using UnityEngine.UI;

namespace XeApp.Game.Common
{
	public class HomePickupBannerContent : UGUILoopScrollContent
	{
		private void Awake()
		{
			TodoLogger.Log(0, "Implement monobehaviour");
		}
		[SerializeField]
		private RawImageEx m_imageBanner;
		[SerializeField]
		private ButtonBase m_buttonBanner;
		[SerializeField]
		private GameObject m_textPeriodSwitch;
		[SerializeField]
		private Text m_textPeriod;
	}
}
