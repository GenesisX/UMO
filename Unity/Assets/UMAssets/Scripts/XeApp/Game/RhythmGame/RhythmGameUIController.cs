using UnityEngine;
using System;
using UnityEngine.Events;
using System.Collections.Generic;

namespace XeApp.Game.RhythmGame
{
	public class RhythmGameUIController : MonoBehaviour
	{
		private List<Animator> m_list_anim = new List<Animator>(); // 0x1C
		private List<ParticleSystem> m_list_particle = new List<ParticleSystem>(); // 0x20
		private List<EffectBundleControllerSimple> m_list_effect = new List<EffectBundleControllerSimple>(); // 0x24

		public GameUIIntro intro { get; private set; } // 0xC
		public GameUIComplete complete { get; private set; } // 0x10
		public GameUIFailed failed { get; private set; } // 0x14
		public IRhythmGameHUD Hud { get; private set; } // 0x18

		// // RVA: 0xC0C4F0 Offset: 0xC0C4F0 VA: 0xC0C4F0
		// public void Pause() { }

		// // RVA: 0xC0C8C0 Offset: 0xC0C8C0 VA: 0xC0C8C0
		// public void Resume() { }

		// // RVA: 0xC0CC90 Offset: 0xC0CC90 VA: 0xC0CC90
		public void OnAwake()
		{
			return;
		}

		// // RVA: 0xC0CC94 Offset: 0xC0CC94 VA: 0xC0CC94
		public void OnStart()
		{
			return;
		}

		// // RVA: 0xC0CC98 Offset: 0xC0CC98 VA: 0xC0CC98
		public void OnUpdate()
		{
			TodoLogger.Log(0, "uicontroller OnUpdate");
		}

		// // RVA: 0xC0CC9C Offset: 0xC0CC9C VA: 0xC0CC9C
		public void Initialize(RhythmGameResource resource, RhythmGamePlayer.Setting setting, RhythmGamePlayer.SettingMV mvSetting)
		{
			Canvas[] cs = transform.root.Find("Layer-Overlay").GetComponentsInChildren<Canvas>(true);
			Transform c = null;
			for(int i = 0; i < cs.Length; i++)
			{
				if (cs[i].name == "TopLayoutCanvas")
				{
					c = cs[i].transform.GetChild(0);
					break;
				}
			}
			GameObject ui = Instantiate(resource.uiPrefab);
			ui.transform.SetParent(transform.root.Find("Layer-UI").GetComponentInChildren<Canvas>(true).transform.GetChild(0).transform, false);
			Hud =  ui.GetComponent<IRhythmGameHUD>();
			Hud.isEnableCutin = setting.m_enable_cutin;
			Hud.isShowNotes = mvSetting.m_show_notes;
			Hud.Initialize();
			Hud.SetPlayerSideTexture(resource.m_pilotTexture, resource.m_divaTexture);
			Hud.SetEnemySideTexture(resource.m_enemyPilotTexture, resource.m_enemyRobotTexture);
			if(resource.enemySkillPrefab != null)
			{
				Hud.SetEnemyLiveSkillEffect(resource.enemySkillPrefab);
			}
			intro = GameManager.Instance.GameUIIntro;
			failed = resource.faildUiPrefab.GetComponent<GameUIFailed>();
			failed.transform.SetParent(c, false);
			failed.gameObject.SetActive(false);
			complete = resource.completeUiPrefab.GetComponent<GameUIComplete>();
			complete.transform.SetParent(c, false);
			complete.gameObject.SetActive(false);
			m_list_anim.Clear();
			m_list_anim.AddRange(ui.GetComponentsInChildren<Animator>(true));
			m_list_particle.Clear();
			m_list_particle.AddRange(ui.GetComponentsInChildren<ParticleSystem>(true));
			m_list_effect.Clear();
			m_list_effect.AddRange(ui.GetComponentsInChildren<EffectBundleControllerSimple>(true));
		}

		// // RVA: 0xC0D81C Offset: 0xC0D81C VA: 0xC0D81C
		public void BeginIntroAnim(Action callback)
		{
			TodoLogger.Log(0, "BeginIntroAnim");
			callback();
		}

		// // RVA: 0xBF2A8C Offset: 0xBF2A8C VA: 0xBF2A8C
		public void DeleteIntro()
		{
			TodoLogger.Log(0, "DeleteIntro");
		}

		// // RVA: 0xC0D874 Offset: 0xC0D874 VA: 0xC0D874
		public void BeginFailedAnim(Action callback)
		{
			TodoLogger.Log(0, "BeginFailedAnim");
		}

		// // RVA: 0xC0D8EC Offset: 0xC0D8EC VA: 0xC0D8EC
		// public void BeginRetryAnim(Action callback) { }

		// // RVA: 0xC0D964 Offset: 0xC0D964 VA: 0xC0D964
		// public void BeginCompleteAnim(Action callback, RhythmGameConsts.ResultComboType comboRank, bool isMvMode = False) { }

		// // RVA: 0xC0DBE4 Offset: 0xC0DBE4 VA: 0xC0DBE4
		// public void EndCompleteAnim() { }

		// // RVA: 0xC0DC10 Offset: 0xC0DC10 VA: 0xC0DC10
		public void UpdateEnergy(int energy)
		{
			TodoLogger.Log(0, "UpdateEnergy");
		}

		// // RVA: 0xC0DCF0 Offset: 0xC0DCF0 VA: 0xC0DCF0
		public void UpdateEnemyLife(int damage, int threshold1, int threshold2, UnityAction onChaseModeCallback)
		{
			TodoLogger.Log(0, "UpdateEnemyLife");
		}

		// // RVA: 0xC0DDFC Offset: 0xC0DDFC VA: 0xC0DDFC
		public void UpdateEnemyDamageResult(int result, Vector3 position)
		{
			TodoLogger.Log(0, "UpdateEnemyDamageResult");
		}

		// // RVA: 0xC0DF08 Offset: 0xC0DF08 VA: 0xC0DF08
		public void UpdateCombo(int newCombo)
		{
			TodoLogger.Log(0, "UpdateCombo");
		}

		// // RVA: 0xC0DFE8 Offset: 0xC0DFE8 VA: 0xC0DFE8
		public void UpdateBattleCombo(int battleCombo)
		{
			TodoLogger.Log(0, "UpdateBattleCombo");
		}

		// // RVA: 0xC0E0C8 Offset: 0xC0E0C8 VA: 0xC0E0C8
		// public void EnterLIVESkill(LiveSkill skill, Material skillDesc, Material material) { }

		// // RVA: 0xC0E1C4 Offset: 0xC0E1C4 VA: 0xC0E1C4
		// public void ShowLIVESkill() { }

		// // RVA: 0xC0E29C Offset: 0xC0E29C VA: 0xC0E29C
		// public void AddBuffEffect(BuffEffect buff, int line) { }

		// // RVA: 0xC0E3E0 Offset: 0xC0E3E0 VA: 0xC0E3E0
		// public void DeleteBuffEffect(BuffEffect buff, int line) { }

		// // RVA: 0xC0E4E8 Offset: 0xC0E4E8 VA: 0xC0E4E8
		// public void DeleteBuffEffectTopPriorityFlagOnly(BuffEffect buff, int line) { }

		// // RVA: 0xC0E5F0 Offset: 0xC0E5F0 VA: 0xC0E5F0
		// public void DrawBuffEffectEnable(int line, bool flag) { }

		// // RVA: 0xC0E6D8 Offset: 0xC0E6D8 VA: 0xC0E6D8
		// public void EndActiveSkill() { }

		// // RVA: 0xBF2FC4 Offset: 0xBF2FC4 VA: 0xBF2FC4
		// public void ShowConfirmationWindow(Action<PopupWindowControl, PopupButton.ButtonType, PopupButton.ButtonLabel> callback, DJBHIFLHJLK errorGotoTitle) { }

		// // RVA: 0xBF2E70 Offset: 0xBF2E70 VA: 0xBF2E70
		// public void ShowContinueWindow(Action<PopupWindowControl, PopupButton.ButtonType, PopupButton.ButtonLabel> callback) { }

		// // RVA: 0xC0F378 Offset: 0xC0F378 VA: 0xC0F378
		// public void ShowReconfirmationWindow(Action<PopupWindowControl, PopupButton.ButtonType, PopupButton.ButtonLabel> callback) { }

		// // RVA: 0xC0FBD8 Offset: 0xC0FBD8 VA: 0xC0FBD8
		// public void ShowPauseWindow(Action<PopupWindowControl, PopupButton.ButtonType, PopupButton.ButtonLabel> callback) { }

		// // RVA: 0xC104CC Offset: 0xC104CC VA: 0xC104CC
		// public void ShowRetireConfirmationWindow(Action<PopupWindowControl, PopupButton.ButtonType, PopupButton.ButtonLabel> callback) { }

		// // RVA: 0xC10730 Offset: 0xC10730 VA: 0xC10730
		// public void ShowSkipConfirmationWindow(Action<PopupWindowControl, PopupButton.ButtonType, PopupButton.ButtonLabel> callback) { }

		// // RVA: 0xC10E9C Offset: 0xC10E9C VA: 0xC10E9C
		// public void ShowMvModePauseWindow(Action<PopupWindowControl, PopupButton.ButtonType, PopupButton.ButtonLabel> callback) { }

		// // RVA: 0xC11608 Offset: 0xC11608 VA: 0xC11608
		// public void ShowMvModeEndConfirmWindow(Action<PopupWindowControl, PopupButton.ButtonType, PopupButton.ButtonLabel> callback) { }

		// // RVA: 0xC119E0 Offset: 0xC119E0 VA: 0xC119E0
		// public void ShowEndTutorialWindow(Action callback, bool isRetry) { }

		// // RVA: 0xC11A78 Offset: 0xC11A78 VA: 0xC11A78
		// private bool PlayPopupOpenSe(PopupWindowControl.SeType type) { }

		// // RVA: 0xC11B30 Offset: 0xC11B30 VA: 0xC11B30
		// private bool PlayPopupButtonSe(PopupButton.ButtonLabel label, PopupButton.ButtonType type) { }

		// // RVA: 0xBF1884 Offset: 0xBF1884 VA: 0xBF1884
		// public void ShowNotesDescriptionTutorialWindow(Action callback) { }

		// // RVA: 0xBF391C Offset: 0xBF391C VA: 0xBF391C
		// public void ShowFWaveDescriptionTutorialWindow(Action callback) { }

		// // RVA: 0xC11BF0 Offset: 0xC11BF0 VA: 0xC11BF0
		// public void ShowModeDescriptionTutorialWindow(Action callback) { }

		// // RVA: 0xBF3A24 Offset: 0xBF3A24 VA: 0xBF3A24
		// public void Show6LineDescriptionTutorialWindow(Action callback) { }

		// [IteratorStateMachineAttribute] // RVA: 0x746044 Offset: 0x746044 VA: 0x746044
		// // RVA: 0xC11CF8 Offset: 0xC11CF8 VA: 0xC11CF8
		// private IEnumerator Co_Show6LineDescriptionTutorialWindow(Action callback) { }

		// // RVA: 0xC0FD2C Offset: 0xC0FD2C VA: 0xC0FD2C
		// private PopupSetting CreatePausePopupsetting() { }

		// // RVA: 0xC0E7B0 Offset: 0xC0E7B0 VA: 0xC0E7B0
		// private PopupSetting CreateConfirmationSetting(DJBHIFLHJLK errorGotoTitle) { }

		// // RVA: 0xC0F0F4 Offset: 0xC0F0F4 VA: 0xC0F0F4
		// private PopupSetting CreateContinueSetting() { }

		// // RVA: 0xC0EE70 Offset: 0xC0EE70 VA: 0xC0EE70
		// private PopupSetting CreateConfirmationSettingForStory() { }

		// // RVA: 0xC0F5DC Offset: 0xC0F5DC VA: 0xC0F5DC
		// private PopupSetting CreateRetirePopupsetting() { }

		// // RVA: 0xC0F954 Offset: 0xC0F954 VA: 0xC0F954
		// private PopupSetting CreateRetirePopupsettingForStory() { }

		// // RVA: 0xC10994 Offset: 0xC10994 VA: 0xC10994
		// private PopupSetting CreateSkipPopupsettingForStory() { }

		// // RVA: 0xC10C18 Offset: 0xC10C18 VA: 0xC10C18
		// private PopupSetting CreateSkipPopupsettingForTutorial() { }

		// // RVA: 0xC10FF0 Offset: 0xC10FF0 VA: 0xC10FF0
		// private PopupSetting CreateMvModePausePopupSetting() { }

		// // RVA: 0xC1175C Offset: 0xC1175C VA: 0xC1175C
		// private PopupSetting CreateMvModeEndConfirmPopupSetting() { }

		// // RVA: 0xC11D80 Offset: 0xC11D80 VA: 0xC11D80
	}
}
