using XeSys.Gfx;
using XeApp.Game.Common;
using UnityEngine;
using UnityEngine.UI;
using System;
using XeSys;

namespace XeApp.Game.Menu
{
	public class LayoutPopupDash : LayoutUGUIScriptBase
	{
		public enum CostType
		{
			Energy = 0,
			Ticket = 1,
		}

		[SerializeField]
		private ActionButton[] m_buttons = new ActionButton[3]; // 0x14
		[SerializeField]
		private ToggleButtonGroup m_toggleButtonGroup; // 0x18
		[SerializeField]
		private Text[] m_textButton = new Text[3]; // 0x1C
		[SerializeField]
		private Text m_textCost; // 0x20
		[SerializeField]
		private Text m_textOwn; // 0x24
		[SerializeField]
		private Text[] m_textCaution = new Text[2]; // 0x28
		[SerializeField]
		private Text m_textCostOver; // 0x2C
		[SerializeField]
		private RawImageEx m_imageCostOver; // 0x30
		private CostType m_type; // 0x34
		private int m_ownValue; // 0x38
		private PopupDashContentSetting.InitParam[] m_param; // 0x3C

		public Action<int> OnSelectCallback { get; set; } // 0x40

		// // RVA: 0x171B8CC Offset: 0x171B8CC VA: 0x171B8CC
		// public void SetStatus(LayoutPopupDash.CostType type, PopupDashContentSetting.InitParam[] param, int own, int index) { }

		// // RVA: 0x171BFE0 Offset: 0x171BFE0 VA: 0x171BFE0
		// public bool IsLoading() { }

		// // RVA: 0x171C09C Offset: 0x171C09C VA: 0x171C09C
		// public void Show() { }

		// // RVA: 0x171C0A0 Offset: 0x171C0A0 VA: 0x171C0A0
		// public void Hide() { }

		// RVA: 0x171C0A4 Offset: 0x171C0A4 VA: 0x171C0A4 Slot: 5
		public override bool InitializeFromLayout(Layout layout, TexUVListManager uvMan)
		{
			m_textButton[0].text = "";
			m_textButton[1].text = "";
			m_textCost.text = "";
			m_textOwn.text = "";
			m_textCaution[0].text = "";
			m_textCaution[1].text = "";
			m_toggleButtonGroup.OnSelectToggleButtonEvent.RemoveAllListeners();
			m_toggleButtonGroup.OnSelectToggleButtonEvent.AddListener((int index) =>
			{
				//0x171C664
				UpdateCost(index);
				ConfigUtility.PlaySeToggleButton();
				if(OnSelectCallback != null)
					OnSelectCallback(index);
			});
			Loaded();
			return true;
		}

		// // RVA: 0x171BD00 Offset: 0x171BD00 VA: 0x171BD00
		public void UpdateCost(int index)
		{
			MessageBank bk = MessageManager.Instance.GetBank("menu");
			string str1 = "";
			string str2 = "";
			if(m_type == CostType.Ticket)
			{
				str1 = bk.GetMessageByLabel("popup_dash_cost_ticket");
				str2 = bk.GetMessageByLabel("popup_dash_own_ticket");
			}
			else
			{
				str1 = bk.GetMessageByLabel("popup_dash_cost_energy");
				str2 = bk.GetMessageByLabel("popup_dash_own_energy");
			}
			m_textCost.text = string.Format(str1, m_param[index].Cost);
			m_textOwn.text = string.Format(str2, m_ownValue);
		}

		// // RVA: 0x171C3E4 Offset: 0x171C3E4 VA: 0x171C3E4
		// public void SetCostOver(bool isOver) { }
	}
}
