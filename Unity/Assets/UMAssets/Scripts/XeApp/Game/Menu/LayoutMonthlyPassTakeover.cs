using XeSys.Gfx;
using XeApp.Game.Common;
using UnityEngine;
using UnityEngine.UI;
using System;
using XeSys;
using mcrs;

namespace XeApp.Game.Menu
{
	public class LayoutMonthlyPassTakeover : LayoutUGUIScriptBase
	{
		[SerializeField]
		private ActionButton ContractedButton; // 0x14
		[SerializeField]
		private ActionButton NotContractButton; // 0x18
		[SerializeField]
		private Text ConfirmationText; // 0x1C
		private AbsoluteLayout m_layoutRoot; // 0x20
		private AbsoluteLayout LayoutContracted; // 0x24
		private AbsoluteLayout LayoutNotContract; // 0x28

		// RVA: 0x1D6A32C Offset: 0x1D6A32C VA: 0x1D6A32C
		private void Start()
		{
			return;
		}

		// RVA: 0x1D6A330 Offset: 0x1D6A330 VA: 0x1D6A330
		private void Update()
		{
			return;
		}

		//// RVA: 0x1D6A334 Offset: 0x1D6A334 VA: 0x1D6A334
		public void SettingLayout(Action _contracted, Action _notContract)
		{
			SetOnClickButton(_contracted, _notContract);
			MessageBank bk = MessageManager.Instance.GetBank("common");
			ConfirmationText.text = bk.GetMessageByLabel("pop_subscription_confirmation_text");
			ConfirmationText.horizontalOverflow = HorizontalWrapMode.Overflow;
			ConfirmationText.verticalOverflow = VerticalWrapMode.Overflow;
		}

		//// RVA: 0x1D6A484 Offset: 0x1D6A484 VA: 0x1D6A484
		private void SetOnClickButton(Action _contracted, Action _notContract)
		{
			ContractedButton.AddOnClickCallback(() =>
			{
				//0x15C9A10
				SoundManager.Instance.sePlayerBoot.Play((int)cs_se_boot.SE_BTN_001);
				_contracted();
			});
			NotContractButton.AddOnClickCallback(() =>
			{
				//0x15C9A8C
				SoundManager.Instance.sePlayerBoot.Play((int)cs_se_boot.SE_BTN_001);
				_notContract();
			});
		}

		//// RVA: 0x1D6A5DC Offset: 0x1D6A5DC VA: 0x1D6A5DC
		public void Enter()
		{
			SoundManager.Instance.sePlayerBoot.Play((int)cs_se_boot.SE_WND_000);
			m_layoutRoot.StartChildrenAnimGoStop("go_in", "st_in");
		}

		//// RVA: 0x1D6A6B4 Offset: 0x1D6A6B4 VA: 0x1D6A6B4
		public void Leave()
		{
			SoundManager.Instance.sePlayerBoot.Play((int)cs_se_boot.SE_WND_001);
			m_layoutRoot.StartChildrenAnimGoStop("go_out", "st_out");
		}

		//// RVA: 0x1D6A78C Offset: 0x1D6A78C VA: 0x1D6A78C
		//public void Hide() { }

		//// RVA: 0x1D6A854 Offset: 0x1D6A854 VA: 0x1D6A854
		//public void Show() { }

		//// RVA: 0x1D6A91C Offset: 0x1D6A91C VA: 0x1D6A91C
		public bool IsPlaying()
		{
			return m_layoutRoot.IsPlaying();
		}

		// RVA: 0x1D6A948 Offset: 0x1D6A948 VA: 0x1D6A948 Slot: 5
		public override bool InitializeFromLayout(Layout layout, TexUVListManager uvMan)
		{
			m_layoutRoot = layout.FindViewByExId("root_inh_pop_04_sw_inh_pop_04_inout_anim") as AbsoluteLayout;
			AbsoluteLayout l1 = layout.FindViewByExId("inh_pop_04_sw_pass_btn_01_anim") as AbsoluteLayout;
			AbsoluteLayout l2 = layout.FindViewByExId("inh_pop_04_sw_pass_btn_01_anim_2") as AbsoluteLayout;
			LayoutContracted = l1.FindViewByExId("sw_pass_btn_01_anim_swtbl_pass_btn_fnt") as AbsoluteLayout;
			LayoutNotContract = l2.FindViewByExId("sw_pass_btn_01_anim_swtbl_pass_btn_fnt") as AbsoluteLayout;
			LayoutContracted.StartChildrenAnimGoStop("02");
			LayoutNotContract.StartChildrenAnimGoStop("01");
			Loaded();
			return base.InitializeFromLayout(layout, uvMan);
		}
	}
}
