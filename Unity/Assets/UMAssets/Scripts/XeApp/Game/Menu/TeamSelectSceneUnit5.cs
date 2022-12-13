using System.Collections;
using UnityEngine;
using XeApp.Game.Common;
using XeApp.Game.Tutorial;
using XeSys;

namespace XeApp.Game.Menu
{
	public class TeamSelectSceneUnit5 : LiveBeforeSceneBaseUnit5
	{
		
		private enum DispType
		{
			CurrentUnit = 0,
			UnitSet = 1,
			Prism = 2,
		}

		private enum SkipStatusType
		{
			Enable = 0,
			Story = 1,
			Lock = 2,
			Limit = 3,
			LackTicket = 4,
			Boost = 5,
			Rival = 6,
			Support = 7,
		}

		public static int UnitSetSelectIndex_Normal; // 0x0
		public static int UnitSetSelectIndex_GoDiva; // 0x4
		[SerializeField]
		//[TooltipAttribute] // RVA: 0x67EE7C Offset: 0x67EE7C VA: 0x67EE7C
		private int m_switchDispTypeWaitFrame; // 0x64
		private static TeamSelectSceneUnit5.DispType m_dispType; // 0x8
		private UGUIObject m_headButtonsObject; // 0x68
		private UGUIObject m_unitStatusObject; // 0x6C
		private UGUIObject m_valkyrieButtonObject; // 0x70
		private UGUIObject m_unitInfoChangeButtonObject; // 0x74
		private UGUIObject m_unitInfoObject; // 0x78
		private UGUIObject m_musicInfoObject; // 0x7C
		private UGUIObject m_playButtonsObject; // 0x80
		private UGUIObject m_unitSetListButtonsObject; // 0x84
		private UGUIObject m_unitSetCloseButtonObject; // 0x88
		private UGUIObject m_unitSetSelectButtonsObject; // 0x8C
		private UGUIObject m_unitSetInfoObject; // 0x90
		private UGUIObject m_loadSaveButtonsObject; // 0x94
		private UGUIObject m_prismSettingButtonsObject; // 0x98
		private UGUIObject m_prismUnitInfoObject; // 0x9C
		private UGUIObject m_statusWindowObject; // 0xA0
		private SetDeckHeadButtons m_headButtons; // 0xA4
		private SetDeckUnitStatus m_unitStatus; // 0xA8
		private SetDeckValkyrieButton m_valkyrieButton; // 0xAC
		private SetDeckUnitInfoChangeButton m_unitInfoChangeButton; // 0xB0
		private SetDeckUnitInfo m_unitInfo; // 0xB4
		private SetDeckMusicInfo m_musicInfo; // 0xB8
		private SetDeckPlayButtons m_playButtons; // 0xBC
		private SetDeckUnitSetListButtons m_unitSetListButtons; // 0xC0
		private SetDeckUnitSetCloseButton m_unitSetCloseButton; // 0xC4
		private SetDeckUnitSetSelectButtons m_unitSetSelectButtons; // 0xC8
		private SetDeckUnitInfo m_unitSetInfo; // 0xCC
		private SetDeckLoadSaveButtons m_loadSaveButtons; // 0xD0
		private SetDeckPrismSettingButtons m_prismSettingButtons; // 0xD4
		private SetDeckUnitInfoSLive m_prismUnitInfo; // 0xD8
		private SetDeckStatusWindow m_statusWindow; // 0xDC
		private SetDeckParamCalculator m_paramCalculator = new SetDeckParamCalculator(); // 0xE0
		private SetDeckParamCalculator m_unitSetParamCalculator = new SetDeckParamCalculator(); // 0xE4
		private JLKEOGLJNOD m_viewUnitData; // 0xE8
		private EEDKAACNBBG m_viewMusicData; // 0xEC
		private EJKBKMBJMGL_EnemyData m_viewEnemyData; // 0xF0
		private int m_divaDispTypeIndex; // 0xF4
		private int m_sceneDispTypeIndex; // 0xF8
		private int m_useLiveSkipTicketCount; // 0xFC
		private bool m_isWaitOpenScene; // 0x100
		private bool m_isOpenEndAutoSetting; // 0x101
		private bool m_isDoSkip; // 0x102
		private ConfigMenu m_gameSettingMenu; // 0x104
		private bool m_isShowSubPlate; // 0x108
		private bool m_isWaitOnPostSetCanvas; // 0x109
		private bool m_isWaitActivateScene; // 0x10A
		private bool m_updateBaseScoreRatio; // 0x10B
		private SkipStatusType m_skipStatus; // 0x10C
		private bool m_isWaitEnterAnimation; // 0x110
		private bool m_isWaitExitAnimation; // 0x111
		private TeamSelectDivaListArgs m_selectDivaListArgs = new TeamSelectDivaListArgs(); // 0x114
		private CostumeChangeDivaArgs m_costumeChangeDivaArgs = new CostumeChangeDivaArgs(); // 0x118
		//private TeamSelectSceneListArgs m_selectSceneListArgs = new TeamSelectSceneListArgs(); // 0x11C
		//private CIKHPBBNEIM m_viewEpisodeBonus = new CIKHPBBNEIM(); // 0x120
		private PopupFilterSortUGUIInitParam m_dispTypePopupParam = new PopupFilterSortUGUIInitParam(); // 0x124
		private PopupEpisodeBonusListSetting m_episodeBonusPopupSetting = new PopupEpisodeBonusListSetting(); // 0x128
		private PopupUnitBonusContentSetting m_unitBonusPopupSetting = new PopupUnitBonusContentSetting(); // 0x12C
		private PopupValkyrieStatusSetting m_valkyriePopupSetting = new PopupValkyrieStatusSetting(); // 0x130
		private TextPopupSetting m_textPopupSetting = new TextPopupSetting(); // 0x134
		private ButtonInfo[] m_textPopupOkButtons = new ButtonInfo[1] { new ButtonInfo() { Label = PopupButton.ButtonLabel.Ok, Type = PopupButton.ButtonType.Positive } }; // 0x138
		private ButtonInfo[] m_textPopupButtons = new ButtonInfo[1] { new ButtonInfo() { Label = PopupButton.ButtonLabel.Close, Type = PopupButton.ButtonType.Negative } }; // 0x13C
		private PopupSkipTicketUseConfirmSetting m_skipTicketPopupSetting = new PopupSkipTicketUseConfirmSetting(); // 0x140
		private ButtonInfo[] m_skipTicketPopupButtons = new ButtonInfo[2] { new ButtonInfo() { Label = PopupButton.ButtonLabel.Cancel, Type = PopupButton.ButtonType.Negative },
																			new ButtonInfo() { Label = PopupButton.ButtonLabel.Ok, Type = PopupButton.ButtonType.Positive } }; // 0x144
		private IKDICBBFBMI m_eventCtrl; // 0x148
		private bool m_isRaidEvent; // 0x14C
		private bool m_isGoDivaEvent; // 0x14D
		private bool m_isGoDivaBonus; // 0x14E

		//private int UseLiveSkipTicketCount { get; set; } 0xA80220 0xA80234
		private int UnitSetIndex { get { return m_isGoDivaEvent ? UnitSetSelectIndex_GoDiva : UnitSetSelectIndex_Normal; } set { if (m_isGoDivaEvent) UnitSetSelectIndex_GoDiva = value; UnitSetSelectIndex_Normal = value; } } //0xA80248 0xA8031C
		private EAJCBFGKKFA m_viewFriendPlayerData { get { return GameManager.Instance.SelectedGuestData; } } //0xA803F4
		//private bool IsEnableUnitInfoChange { get; } 0xA80490

		// RVA: 0xA804A4 Offset: 0xA804A4 VA: 0xA804A4 Slot: 4
		protected override void Awake()
		{
			m_useLiveSkipTicketCount = 3257895;
			IsReady = false;
			m_dispTypePopupParam.Scene = PopupFilterSortUGUI.Scene.UnitDispType;
			m_dispTypePopupParam.EnableSave = true;
			m_episodeBonusPopupSetting.WindowSize = SizeType.Large;
			m_episodeBonusPopupSetting.IsCaption = false;
			m_episodeBonusPopupSetting.SetParent(transform);
			m_episodeBonusPopupSetting.Buttons = new ButtonInfo[1] { new ButtonInfo() { Label = PopupButton.ButtonLabel.Close, Type = PopupButton.ButtonType.Negative } };
			m_unitBonusPopupSetting.WindowSize = SizeType.Large;
			m_unitBonusPopupSetting.IsCaption = false;
			m_unitBonusPopupSetting.SetParent(transform);
			m_unitBonusPopupSetting.Buttons = new ButtonInfo[1] { new ButtonInfo() { Label = PopupButton.ButtonLabel.Close, Type = PopupButton.ButtonType.Negative } };
			m_skipTicketPopupSetting.WindowSize = SizeType.Large;
			m_skipTicketPopupSetting.IsCaption = true;
			m_skipTicketPopupSetting.TitleText = MessageManager.Instance.GetMessage("menu", "use_ticket_popup_title");
			m_skipTicketPopupSetting.SetParent(transform);
			m_skipTicketPopupSetting.Buttons = m_skipTicketPopupButtons;
			m_valkyriePopupSetting.TitleText = MessageManager.Instance.GetBank("menu").GetMessageByLabel("popup_title_04");
			m_valkyriePopupSetting.SetParent(transform);
			m_valkyriePopupSetting.Buttons = new ButtonInfo[1] { new ButtonInfo() { Label = PopupButton.ButtonLabel.Close, Type = PopupButton.ButtonType.Negative } };
			SetupPrismPopupSetting();
			StartCoroutine(Co_LoadResource());
		}

		//[IteratorStateMachineAttribute] // RVA: 0x72F154 Offset: 0x72F154 VA: 0x72F154
		//// RVA: 0xA80A90 Offset: 0xA80A90 VA: 0xA80A90
		private IEnumerator Co_LoadResource()
		{
			//0xA94FF8
			yield return CreateUGUIObjectCache();
			IsReady = true;
		}

		// RVA: 0xA80B3C Offset: 0xA80B3C VA: 0xA80B3C Slot: 5
		protected override void Start()
		{
			return;
		}

		// RVA: 0xA80B44 Offset: 0xA80B44 VA: 0xA80B44 Slot: 16
		protected override void OnPreSetCanvas()
		{
			InitializeUGUIObject();
			m_headButtons.OnClickAutoSettingButton = OnClickAutoSettingButton;
			m_headButtons.OnClickUnitSetButton = OnClickUnitSetButton;
			m_headButtons.OnClickPrismButton = OnClickPrismSettingButton;
			m_headButtons.OnClickUnitButton = OnClickUnitSettingButton;
			m_headButtons.OnClickSettingButton = OnClickGameSettingButton;
			m_unitStatus.OnClickNameEditButton = OnChangeUnitName;
			m_unitStatus.OnClickEpisodeBonusButton = OnShowEpisodeBonusScenePopup;
			m_unitStatus.OnClickCheckStatusButton = OnShowStatusWindow;
			m_unitStatus.OnClickDispTypeButton = OnShowChangeStatusButton;
			m_valkyrieButton.OnClickValkyrieButton = OnClickValkyrieButton;
			m_valkyrieButton.OnStayValkyrieButton = OnStayValkyrieButton;
			m_unitInfoChangeButton.OnClickChangeButton = OnClickUnitInfoChangeButton;
			m_unitInfo.OnClickDiva = OnSelectDiva;
			m_unitInfo.OnStayDiva = OnShowDivaStatus;
			m_unitInfo.OnClickCostume = OnSelectCostume;
			m_unitInfo.OnClickScene = OnSelectScene;
			m_unitInfo.OnStayScene = OnShowSceneStatus;
			if(m_unitInfo.ExistAssistControl)
			{
				m_unitInfo.AssistControl.OnClickFriend = OnShowFriendDivaStatus;
			}
			m_unitInfo.SetTapGuard(false);
			m_musicInfo.OnClickExpectedScoreDescButton = OnShowScoreInfoPopup;
			m_musicInfo.ExpectedScoreGauge.OnClickMinusButton = () =>
			{
				//0xA936A4
				OnClickAnyButtons();
			};
			m_musicInfo.ExpectedScoreGauge.OnClickPlusButton = () =>
			{
				//0xA936CC
				OnClickAnyButtons();
			};
			m_playButtons.OnClickPlayButton = OnPlayButton;
			m_playButtons.OnClickSkipButton = OnSkipButton;
			m_unitSetListButtons.OnClickUnitButton = (int no, JLKEOGLJNOD data) =>
			{
				//0xA936F4
				OnClickAnyButtons();
			};
			m_unitSetListButtons.OnChangeUnit = OnChangeUnitSetSelect;
			m_unitSetListButtons.OnStartChangePage = OnStartChangeUnitSetPage;
			m_unitSetListButtons.OnEndChangePage = OnEndChangeUnitSetPage;
			m_unitSetCloseButton.OnClickCloseButton = OnClickUnitSetCloseButton;
			m_unitSetSelectButtons.OnClickSelectButtonLeft = () =>
			{
				//0xA9371C
				OnClickUnitSetSelectButton(-1);
			};
			m_unitSetSelectButtons.OnClickSelectButtonRight = () =>
			{
				//0xA93748
				OnClickUnitSetSelectButton(1);
			};
			m_unitSetInfo.OnClickDiva = null;
			m_unitSetInfo.OnStayDiva = null;
			m_unitSetInfo.OnClickCostume = null;
			m_unitSetInfo.OnClickScene = null;
			m_unitSetInfo.OnStayScene = null;
			m_unitSetInfo.SetTapGuard(true);
			m_loadSaveButtons.OnClickLoadButton = OnUnitSetLoad;
			m_loadSaveButtons.OnClickSaveButton = OnUnitSetSave;
			m_prismSettingButtons.OnClickOriginalSettingButton = OnClickOriginalSetting;
			m_prismUnitInfo.OnClickItem = OnClickPrismItems;
			if(Args != null)
			{
				m_dispType = DispType.CurrentUnit;
			}
			m_isGoDivaEvent = m_transitionName == TransitionList.Type.GODIVA_TEAM_SELECT;
			if(m_isGoDivaEvent)
			{
				TodoLogger.Log(0, "TODO Event");
			}
			m_viewMusicData = Database.Instance.selectedMusic.GetSelectedMusicData();
			m_viewEnemyData = Database.Instance.selectedMusic.GetEnemyData(Database.Instance.gameSetup.musicInfo.difficultyType);
			m_viewEnemyData.NPEKPHAFMGE(Database.Instance.gameSetup.musicInfo.enemyInfo.NJOPIPNGANO_CS, Database.Instance.gameSetup.musicInfo.enemyInfo.EDLACELKJIK_LS);
			UpdatePrismData(m_viewMusicData.DLAEJOBELBH_MusicId, Database.Instance.gameSetup.musicInfo);
			m_isRaidEvent = Database.Instance.gameSetup.musicInfo.gameEventType == OHCAABOMEOF.KGOGMKMBCPP_EventType.CADKONMJEDA_EventRaid;
			if(TutorialProc.CanUnit5Help(Database.Instance.gameSetup.musicInfo))
			{
				TodoLogger.Log(0, "Tuto");
			}
			int energy = Database.Instance.selectedMusic.GetNeedEnergy(Database.Instance.gameSetup.musicInfo.difficultyType, Database.Instance.gameSetup.musicInfo.IsLine6Mode);
			m_updateBaseScoreRatio = true;
			if (PrevTransition != TransitionList.Type.STORY_SELECT && PrevTransition != TransitionList.Type.FRIEND_SELECT && PrevTransition != TransitionList.Type.EVENT_BATTLE && PrevTransition != TransitionList.Type.EVENT_GODIVA)
				m_updateBaseScoreRatio = false;
			m_eventCtrl = null;
			if (Database.Instance.gameSetup.musicInfo.gameEventType != OHCAABOMEOF.KGOGMKMBCPP_EventType.HJNNKCMLGFL)
			{
				TodoLogger.Log(0, "Todo Event");
			}
			UpdateEpisodeBonusList();
			m_viewUnitData = m_playerData.DPLBHAIKPGL(m_isGoDivaEvent);
			int divaSortItem = GameManager.Instance.localSave.EPJOACOONAC_GetSave().PPCGEFGJJIC_SortProprty.BICLOMKLAOF_unitWindowDivaDispItem;
			int sceneSortItem = GameManager.Instance.localSave.EPJOACOONAC_GetSave().PPCGEFGJJIC_SortProprty.LEAPMNHODPJ_unitWindowDispItem;
			m_divaDispTypeIndex = PopupSortMenu.UnitDivaSortItem.FindIndex((SortItem x) =>
			{
				//0xA93774
				return divaSortItem == (int)x;
			});
			m_sceneDispTypeIndex = PopupSortMenu.UnitSortItem.FindIndex((SortItem x) =>
			{
				//0xA93788
				return sceneSortItem == (int)x;
			});
			UpdateParamCalculator();
			if(m_updateBaseScoreRatio)
			{
				m_musicInfo.ExpectedScoreGauge.UpdateBaseGaugeRatio();
			}
			if(m_unitInfo.ExistAssistControl)
			{
				if(Database.Instance.gameSetup.musicInfo.gameEventType == OHCAABOMEOF.KGOGMKMBCPP_EventType.PFKOKHODEGL_EventBattle)
				{
					TodoLogger.Log(0, "Event");
				}
				else
				{
					m_unitInfo.AssistControl.UpdateContent(m_viewFriendPlayerData, m_viewMusicData);
				}
			}
			m_musicInfo.Set(m_viewMusicData, Database.Instance.gameSetup.musicInfo, false, SetDeckMusicInfo.BottomType.ExpectedScoreGauge);
			m_musicInfo.SetPosType(SetDeckMusicInfo.PosType.Normal);
			m_skipStatus = CehckSkipStatus(NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF.FJDBNGEPKHL.KMEFBNBFJHI_GetServerTime());
			CheckExistOriginalSetting(m_prismData);
			SetDeckPlayButtons.SkipButtoType skipButton = SetDeckPlayButtons.SkipButtoType.Enable;
			TodoLogger.Log(0, "Fix skipButton");
			// L 909
			m_playButtons.Set(skipButton, GetSkipRestCount(), CheckPlayButtonType(Database.Instance.gameSetup.musicInfo), energy);
			m_playButtons.SetPosType(SetDeckPlayButtons.PosType.Normal);
			m_unitSetListButtons.UpdateContent(m_playerData, m_isGoDivaEvent, UnitSetIndex);
			m_prismSettingButtons.UpdateContent(m_prismData, SetDeckPrismSettingButtons.ModeType.Prism, CheckExistOriginalSetting(m_prismData));
			m_prismUnitInfo.UpdateContent(m_prismData, Database.Instance.gameSetup.musicInfo);
			m_unitStatus.SetCheckStatusButtonState(0);
			if(m_dispType == DispType.UnitSet)
			{
				ApplyUnitSetContent(UnitSetIndex);
			}
			else if (m_dispType == DispType.Prism)
			{
				ApplyCurrentUnitContent(true);
				ApplyPrismUnitContent();
			}
			else
			{
				ApplyCurrentUnitContent(false);
			}
			ApplyDispType(m_dispType);
			ApplyPrismSettingButton(m_prismData);
			m_statusWindow.gameObject.SetActive(false);
			MenuScene.Instance.BgControl.StorytBgReturn();
		}

		// RVA: 0xA853A8 Offset: 0xA853A8 VA: 0xA853A8 Slot: 17
		protected override bool IsEndPreSetCanvas()
		{
			return !IsApplyWait() && !MenuScene.Instance.BgControl.IsLoadingStoryBg() && base.IsEndPreSetCanvas();
		}

		// RVA: 0xA8569C Offset: 0xA8569C VA: 0xA8569C Slot: 18
		protected override void OnPostSetCanvas()
		{
			StartCoroutine(Co_OnPostSetCanvas());
		}

		//[IteratorStateMachineAttribute] // RVA: 0x72F1CC Offset: 0x72F1CC VA: 0x72F1CC
		//// RVA: 0xA856C0 Offset: 0xA856C0 VA: 0xA856C0
		private IEnumerator Co_OnPostSetCanvas()
		{
			//0xA954EC
			m_isWaitOnPostSetCanvas = true;
			yield return null;
			m_isWaitOnPostSetCanvas = false;
		}

		// RVA: 0xA8576C Offset: 0xA8576C VA: 0xA8576C Slot: 19
		protected override bool IsEndPostSetCanvas()
		{
			return m_isWaitOnPostSetCanvas == false;
		}

		// RVA: 0xA85788 Offset: 0xA85788 VA: 0xA85788 Slot: 9
		protected override void OnStartEnterAnimation()
		{
			StartCoroutine(Co_EnterAnimation());
		}

		//[IteratorStateMachineAttribute] // RVA: 0x72F244 Offset: 0x72F244 VA: 0x72F244
		//// RVA: 0xA857AC Offset: 0xA857AC VA: 0xA857AC
		private IEnumerator Co_EnterAnimation()
		{
			//0xA9479C
			m_isWaitEnterAnimation = true;
			SetTitleInOut(DispType.CurrentUnit, m_dispType);
			SetInactiveUnnecessaryContent(m_dispType);
			yield return Co_EnterContents(m_dispType);
			m_isWaitEnterAnimation = false;
		}

		// RVA: 0xA85858 Offset: 0xA85858 VA: 0xA85858 Slot: 10
		protected override bool IsEndEnterAnimation()
		{
			return !m_isWaitEnterAnimation;
		}

		// RVA: 0xA8586C Offset: 0xA8586C VA: 0xA8586C Slot: 12
		protected override void OnStartExitAnimation()
		{
			StartCoroutine(Co_ExitAnimation());
		}

		//[IteratorStateMachineAttribute] // RVA: 0x72F2BC Offset: 0x72F2BC VA: 0x72F2BC
		//// RVA: 0xA85890 Offset: 0xA85890 VA: 0xA85890
		private IEnumerator Co_ExitAnimation()
		{
			//0xA94E40
			m_isWaitExitAnimation = true;
			while (IsPlayingContents())
				yield return null;
			LeaveContents();
			while (IsPlayingContents())
				yield return null;
			m_isWaitExitAnimation = false;
		}

		// RVA: 0xA8593C Offset: 0xA8593C VA: 0xA8593C Slot: 13
		protected override bool IsEndExitAnimation()
		{
			return !m_isWaitExitAnimation;
		}

		// RVA: 0xA85950 Offset: 0xA85950 VA: 0xA85950 Slot: 21
		protected override void OnOpenScene()
		{
			m_isWaitOpenScene = true;
			StartCoroutine(OpenSceneCoroutine());
		}

		// RVA: 0xA85A0C Offset: 0xA85A0C VA: 0xA85A0C Slot: 22
		protected override bool IsEndOpenScene()
		{
			return !m_isWaitOpenScene;
		}

		//[IteratorStateMachineAttribute] // RVA: 0x72F334 Offset: 0x72F334 VA: 0x72F334
		//// RVA: 0xA85980 Offset: 0xA85980 VA: 0xA85980
		protected IEnumerator OpenSceneCoroutine()
		{
			int i;

			//0xA967A0
			if (IsPlayingContents())
				yield return null;
			i = 0;
			yield return null;
			i++;
			while (i <= 4)
			{
				i++;
				yield return null;
			}
			bool isWait = false;
			m_gameSettingMenu = ConfigMenu.Create(null);
			if(ConfigManager.gotoTimingScene)
			{
				if(!GameManager.Instance.IsTutorial)
				{
					isWait = true;
					m_gameSettingMenu.ShowPopupRhythm(null, (PopupButton.ButtonLabel label) =>
					{
						//0xA937A4
						isWait = false;
					});
					while (isWait)
						yield return null;
				}
			}
			MenuScene.Instance.TryShowPopupWindow(this, GameManager.Instance.ViewPlayerData, m_viewMusicData, false, m_transitionName, UpdateContent);
			if(m_isShowSubPlate)
			{
				m_isShowSubPlate = false;
				if(PrevTransition == TransitionList.Type.SCENE_GROWTH)
				{
					ShowSubPlateWindow(true);
				}
			}
			m_isWaitOpenScene = false;
		}

		// RVA: 0xA85A40 Offset: 0xA85A40 VA: 0xA85A40 Slot: 23
		protected override void OnActivateScene()
		{
			StartCoroutine(Co_ShowHelp());
		}

		// RVA: 0xA85AF0 Offset: 0xA85AF0 VA: 0xA85AF0 Slot: 24
		protected override bool IsEndActivateScene()
		{
			return !m_isWaitActivateScene;
		}

		//[IteratorStateMachineAttribute] // RVA: 0x72F3AC Offset: 0x72F3AC VA: 0x72F3AC
		//// RVA: 0xA85A64 Offset: 0xA85A64 VA: 0xA85A64
		private IEnumerator Co_ShowHelp()
		{
			//0xA95604
			m_isWaitActivateScene = true;
			if(TutorialProc.CanAutoSettingHelp())
			{
				TodoLogger.Log(0, "Co_ShowHelp");
			}
			if(TutorialProc.CanUnit5Help(Database.Instance.gameSetup.musicInfo))
			{
				TodoLogger.Log(0, "Co_ShowHelp");
			}
			MenuScene.Instance.InputDisable();
			yield return TutorialManager.TryShowTutorialCoroutine(CheckTutorialCondition);
			MenuScene.Instance.InputEnable();
			GameManager.Instance.AddPushBackButtonHandler(OnBackButton);
			m_isWaitActivateScene = false;
		}

		// RVA: 0xA85B24 Offset: 0xA85B24 VA: 0xA85B24 Slot: 14
		protected override void OnDestoryScene()
		{
			GameManager.Instance.RemovePushBackButtonHandler(OnBackButton);
			m_gameSettingMenu.Dispose();
			FinalizeUGUIObject();
			if (Database.Instance.gameSetup.musicInfo.gameEventType == OHCAABOMEOF.KGOGMKMBCPP_EventType.CADKONMJEDA_EventRaid)
			{
				TodoLogger.Log(0, "Event");
			}
		}

		//// RVA: 0xA827E4 Offset: 0xA827E4 VA: 0xA827E4
		private void InitializeUGUIObject()
		{
			m_headButtonsObject = GameManager.Instance.LayoutObjectCache.GetUGUIInstance("SetDeckHeadButtons");
			m_unitStatusObject = GameManager.Instance.LayoutObjectCache.GetUGUIInstance("SetDeckUnitStatus");
			m_valkyrieButtonObject = GameManager.Instance.LayoutObjectCache.GetUGUIInstance("SetDeckValkyrieButton");
			m_unitInfoChangeButtonObject = GameManager.Instance.LayoutObjectCache.GetUGUIInstance("SetDeckUnitInfoChangeButton");
			if(!IsStoryMode() && m_transitionName != TransitionList.Type.GODIVA_TEAM_SELECT)
			{
				m_unitInfoObject = GameManager.Instance.LayoutObjectCache.GetUGUIInstance("SetDeckUnitInfo_Select");
			}
			else
			{
				m_unitInfoObject = GameManager.Instance.LayoutObjectCache.GetUGUIInstance("SetDeckUnitInfo_Edit");
			}
			m_musicInfoObject = GameManager.Instance.LayoutObjectCache.GetUGUIInstance("SetDeckMusicInfo");
			m_playButtonsObject = GameManager.Instance.LayoutObjectCache.GetUGUIInstance("SetDeckPlayButtons");
			m_unitSetListButtonsObject = GameManager.Instance.LayoutObjectCache.GetUGUIInstance("SetDeckUnitSetListButtons");
			m_unitSetCloseButtonObject = GameManager.Instance.LayoutObjectCache.GetUGUIInstance("SetDeckUnitSetCloseButton");
			m_unitSetSelectButtonsObject = GameManager.Instance.LayoutObjectCache.GetUGUIInstance("SetDeckUnitSetSelectButtons");
			m_unitSetInfoObject = GameManager.Instance.LayoutObjectCache.GetUGUIInstance("SetDeckUnitInfo_Edit");
			m_loadSaveButtonsObject = GameManager.Instance.LayoutObjectCache.GetUGUIInstance("SetDeckLoadSaveButtons");
			m_prismSettingButtonsObject = GameManager.Instance.LayoutObjectCache.GetUGUIInstance("SetDeckPrismSettingButtons");
			m_prismUnitInfoObject = GameManager.Instance.LayoutObjectCache.GetUGUIInstance("SetDeckUnitInfo_SLive");
			m_statusWindowObject = GameManager.Instance.LayoutObjectCache.GetUGUIInstance("SetDeckStatusWindow");

			m_headButtonsObject.instanceObject.SetActive(true);
			m_unitStatusObject.instanceObject.SetActive(true);
			m_valkyrieButtonObject.instanceObject.SetActive(true);
			m_unitInfoChangeButtonObject.instanceObject.SetActive(true);
			m_unitInfoObject.instanceObject.SetActive(true);
			m_musicInfoObject.instanceObject.SetActive(true);
			m_playButtonsObject.instanceObject.SetActive(true);
			m_unitSetListButtonsObject.instanceObject.SetActive(true);
			m_unitSetCloseButtonObject.instanceObject.SetActive(true);
			m_unitSetSelectButtonsObject.instanceObject.SetActive(true);
			m_unitSetInfoObject.instanceObject.SetActive(true);
			m_loadSaveButtonsObject.instanceObject.SetActive(true);
			m_prismSettingButtonsObject.instanceObject.SetActive(true);
			m_prismUnitInfoObject.instanceObject.SetActive(true);
			m_statusWindowObject.instanceObject.SetActive(true);

			m_headButtons = m_headButtonsObject.instanceObject.GetComponentInChildren<SetDeckHeadButtons>();
			m_unitStatus = m_unitStatusObject.instanceObject.GetComponentInChildren<SetDeckUnitStatus>();
			m_valkyrieButton = m_valkyrieButtonObject.instanceObject.GetComponentInChildren<SetDeckValkyrieButton>();
			m_unitInfoChangeButton = m_unitInfoChangeButtonObject.instanceObject.GetComponentInChildren<SetDeckUnitInfoChangeButton>();
			m_unitInfo = m_unitInfoObject.instanceObject.GetComponentInChildren<SetDeckUnitInfo>();
			m_musicInfo = m_musicInfoObject.instanceObject.GetComponentInChildren<SetDeckMusicInfo>();
			m_playButtons = m_playButtonsObject.instanceObject.GetComponentInChildren<SetDeckPlayButtons>();
			m_unitSetListButtons = m_unitSetListButtonsObject.instanceObject.GetComponentInChildren<SetDeckUnitSetListButtons>();
			m_unitSetCloseButton = m_unitSetCloseButtonObject.instanceObject.GetComponentInChildren<SetDeckUnitSetCloseButton>();
			m_unitSetSelectButtons = m_unitSetSelectButtonsObject.instanceObject.GetComponentInChildren<SetDeckUnitSetSelectButtons>();
			m_unitSetInfo = m_unitSetInfoObject.instanceObject.GetComponentInChildren<SetDeckUnitInfo>();
			m_loadSaveButtons = m_loadSaveButtonsObject.instanceObject.GetComponentInChildren<SetDeckLoadSaveButtons>();
			m_prismSettingButtons = m_prismSettingButtonsObject.instanceObject.GetComponentInChildren<SetDeckPrismSettingButtons>();
			m_prismUnitInfo = m_prismUnitInfoObject.instanceObject.GetComponentInChildren<SetDeckUnitInfoSLive>();
			m_statusWindow = m_statusWindowObject.instanceObject.GetComponentInChildren<SetDeckStatusWindow>();

			m_headButtonsObject.SetParent(transform, null);
			m_unitStatusObject.SetParent(transform, null);
			m_valkyrieButtonObject.SetParent(transform, null);
			m_unitInfoChangeButtonObject.SetParent(transform, null);
			m_unitInfoObject.SetParent(transform, null);
			m_musicInfoObject.SetParent(transform, null);
			m_playButtonsObject.SetParent(transform, null);
			m_unitSetListButtonsObject.SetParent(transform, null);
			m_unitSetCloseButtonObject.SetParent(transform, null);
			m_unitSetSelectButtonsObject.SetParent(transform, null);
			m_unitSetInfoObject.SetParent(transform, null);
			m_loadSaveButtonsObject.SetParent(transform, null);
			m_prismSettingButtonsObject.SetParent(transform, null);
			m_prismUnitInfoObject.SetParent(transform, null);
			m_statusWindowObject.SetParent(transform, null);

			m_unitSetInfo.transform.SetAsLastSibling();
			m_prismUnitInfo.transform.SetAsLastSibling();
			m_unitInfo.transform.SetAsLastSibling();
			m_unitInfoChangeButton.transform.SetAsLastSibling();
			m_unitSetSelectButtons.transform.SetAsLastSibling();
			m_unitStatus.transform.SetAsLastSibling();
			m_prismSettingButtons.transform.SetAsLastSibling();
			m_valkyrieButton.transform.SetAsLastSibling();
			m_headButtons.transform.SetAsLastSibling();
			m_unitSetListButtons.transform.SetAsLastSibling();
			m_unitSetCloseButton.transform.SetAsLastSibling();
			m_musicInfo.transform.SetAsLastSibling();
			m_playButtons.transform.SetAsLastSibling();
			m_loadSaveButtons.transform.SetAsLastSibling();
			m_statusWindow.transform.SetAsLastSibling();

			ClearUGUIObjectListener();
			HideUGUIObject();
		}

		//// RVA: 0xA85D5C Offset: 0xA85D5C VA: 0xA85D5C
		private void FinalizeUGUIObject()
		{
			ClearUGUIObjectListener();
			HideUGUIObject();
			GameManager.Instance.LayoutObjectCache.ReturnUGUIInstance("SetDeckHeadButtons", m_headButtonsObject);
			GameManager.Instance.LayoutObjectCache.ReturnUGUIInstance("SetDeckUnitStatus", m_unitStatusObject);
			GameManager.Instance.LayoutObjectCache.ReturnUGUIInstance("SetDeckValkyrieButton", m_valkyrieButtonObject);
			GameManager.Instance.LayoutObjectCache.ReturnUGUIInstance("SetDeckUnitInfoChangeButton", m_unitInfoChangeButtonObject);
			if(!IsStoryMode() && m_transitionName != TransitionList.Type.GODIVA_TEAM_SELECT)
			{
				GameManager.Instance.LayoutObjectCache.ReturnUGUIInstance("SetDeckUnitInfo_Select", m_unitInfoObject);
			}
			else
			{
				GameManager.Instance.LayoutObjectCache.ReturnUGUIInstance("SetDeckUnitInfo_Edit", m_unitInfoObject);
			}
			GameManager.Instance.LayoutObjectCache.ReturnUGUIInstance("SetDeckMusicInfo", m_musicInfoObject);
			GameManager.Instance.LayoutObjectCache.ReturnUGUIInstance("SetDeckPlayButtons", m_playButtonsObject);
			GameManager.Instance.LayoutObjectCache.ReturnUGUIInstance("SetDeckUnitSetListButtons", m_unitSetListButtonsObject);
			GameManager.Instance.LayoutObjectCache.ReturnUGUIInstance("SetDeckUnitSetCloseButton", m_unitSetCloseButtonObject);
			GameManager.Instance.LayoutObjectCache.ReturnUGUIInstance("SetDeckUnitSetSelectButtons", m_unitSetSelectButtonsObject);
			GameManager.Instance.LayoutObjectCache.ReturnUGUIInstance("SetDeckUnitInfo_Edit", m_unitSetInfoObject);
			GameManager.Instance.LayoutObjectCache.ReturnUGUIInstance("SetDeckLoadSaveButtons", m_loadSaveButtonsObject);
			GameManager.Instance.LayoutObjectCache.ReturnUGUIInstance("SetDeckPrismSettingButtons", m_prismSettingButtonsObject);
			GameManager.Instance.LayoutObjectCache.ReturnUGUIInstance("SetDeckUnitInfo_SLive", m_prismUnitInfoObject);
			GameManager.Instance.LayoutObjectCache.ReturnUGUIInstance("SetDeckStatusWindow", m_statusWindowObject);
			m_loadSaveButtonsObject = null;
			m_prismSettingButtonsObject = null;
			m_prismUnitInfoObject = null;
			m_statusWindowObject = null;
			m_unitSetCloseButtonObject = null;
			m_unitSetSelectButtonsObject = null;
			m_unitSetInfoObject = null;
			m_loadSaveButtonsObject = null;
			m_headButtonsObject = null;
			m_unitStatusObject = null;
			m_valkyrieButtonObject = null;
			m_unitInfoChangeButtonObject = null;
			m_unitInfoObject = null;
			m_musicInfoObject = null;
			m_playButtonsObject = null;
			m_unitSetListButtonsObject = null;
		}

		//// RVA: 0xA864C0 Offset: 0xA864C0 VA: 0xA864C0
		private void ClearUGUIObjectListener()
		{
			m_headButtons.OnClickAutoSettingButton = null;
			m_headButtons.OnClickUnitSetButton = null;
			m_headButtons.OnClickPrismButton = null;
			m_headButtons.OnClickUnitButton = null;
			m_headButtons.OnClickSettingButton = null;
			m_unitStatus.OnClickNameEditButton = null;
			m_unitStatus.OnClickCheckStatusButton = null;
			m_unitStatus.OnClickDispTypeButton = null;
			m_unitStatus.OnClickEpisodeBonusButton = null;
			m_valkyrieButton.OnClickValkyrieButton = null;
			m_valkyrieButton.OnStayValkyrieButton = null;
			m_unitInfoChangeButton.OnClickChangeButton = null;
			m_unitInfo.OnClickDiva = null;
			m_unitInfo.OnStayDiva = null;
			m_unitInfo.OnClickCostume = null;
			m_unitInfo.OnClickScene = null;
			m_unitInfo.OnStayScene = null;
			m_musicInfo.OnClickExpectedScoreDescButton = null;
			m_playButtons.OnClickPlayButton = null;
			m_playButtons.OnClickSkipButton = null;
			m_unitSetListButtons.OnChangeUnit = null;
			m_unitSetListButtons.OnStartChangePage = null;
			m_unitSetListButtons.OnEndChangePage = null;
			m_unitSetCloseButton.OnClickCloseButton = null;
			m_unitSetSelectButtons.OnClickSelectButtonLeft = null;
			m_unitSetSelectButtons.OnClickSelectButtonRight = null;
			m_unitSetInfo.OnClickDiva = null;
			m_unitSetInfo.OnStayDiva = null;
			m_unitSetInfo.OnClickCostume = null;
			m_unitSetInfo.OnClickScene = null;
			m_unitSetInfo.OnStayScene = null;
			m_loadSaveButtons.OnClickLoadButton = null;
			m_loadSaveButtons.OnClickSaveButton = null;
			m_prismSettingButtons.OnClickOriginalSettingButton = null;
			m_prismUnitInfo.OnClickItem = null;
		}

		//// RVA: 0xA86860 Offset: 0xA86860 VA: 0xA86860
		private void HideUGUIObject()
		{
			m_headButtons.InOut.Leave(0, false, null);
			m_unitStatus.InOut.Leave(0, false, null);
			m_valkyrieButton.InOut.Leave(0, false, null);
			m_unitInfoChangeButton.InOut.Leave(0, false, null);
			m_unitInfo.AnimeControl.Hide();
			m_musicInfo.InOut.Leave(0, false, null);
			m_playButtons.InOut.Leave(0, false, null);
			m_unitSetListButtons.InOut.Leave(0, false, null);
			m_unitSetCloseButton.InOut.Leave(0, false, null);
			m_unitSetSelectButtons.InOutLeft.Leave(0, false, null);
			m_unitSetSelectButtons.InOutRight.Leave(0, false, null);
			m_unitSetInfo.AnimeControl.Hide();
			m_loadSaveButtons.InOut.Leave(0, false, null);
			m_prismSettingButtons.InOut.Leave(0, false, null);
			m_prismUnitInfo.AnimeControl.Hide();
			m_statusWindow.InOut.Leave(0, false, null);
			m_unitStatus.SetCheckStatusButtonState(SetDeckUnitStatus.CheckStatusButtonState.Normal);
		}

		//// RVA: 0xA86D6C Offset: 0xA86D6C VA: 0xA86D6C
		private bool IsStoryMode()
		{
			return Database.Instance.selectedMusic.GetSelectedMusicData() is LIEJFHMGNIA;
		}

		//// RVA: 0xA86490 Offset: 0xA86490 VA: 0xA86490
		//private bool CheckUseAssist() { }

		//// RVA: 0xA8406C Offset: 0xA8406C VA: 0xA8406C
		private void UpdateEpisodeBonusList()
		{
			if (((int)Database.Instance.gameSetup.musicInfo.gameEventType | 4) == 4)
				return;
			if (m_eventCtrl == null)
				return;
			TodoLogger.Log(0, "Event");
		}

		//// RVA: 0xA86E48 Offset: 0xA86E48 VA: 0xA86E48
		private void UpdateEpisodeBonusList(int unitSetIndex)
		{
			if ((int)Database.Instance.gameSetup.musicInfo.gameEventType == 0)
				return;
			if (m_eventCtrl == null)
				return;
			TodoLogger.Log(0, "Event");
		}

		//// RVA: 0xA86FA0 Offset: 0xA86FA0 VA: 0xA86FA0
		private void UpdateUnitBonus()
		{
			if(Database.Instance.gameSetup.musicInfo.gameEventType == OHCAABOMEOF.KGOGMKMBCPP_EventType.CADKONMJEDA_EventRaid)
			{
				TodoLogger.Log(0, "Event");
			}
		}

		//// RVA: 0xA8711C Offset: 0xA8711C VA: 0xA8711C
		private void UpdateUnitBonus(int unitSetIndex)
		{
			if (Database.Instance.gameSetup.musicInfo.gameEventType == OHCAABOMEOF.KGOGMKMBCPP_EventType.CADKONMJEDA_EventRaid)
			{
				TodoLogger.Log(0, "Event");
			}
		}

		//// RVA: 0xA847FC Offset: 0xA847FC VA: 0xA847FC
		private SetDeckPlayButtons.PlayButtonType CheckPlayButtonType(GameSetupData.MusicInfo musicInfo)
		{
			if(musicInfo.gameEventType == OHCAABOMEOF.KGOGMKMBCPP_EventType.CADKONMJEDA_EventRaid && m_eventCtrl != null)
			{
				TodoLogger.Log(0, "Event");
			}
			if (!musicInfo.isEnergyRequired)
				return SetDeckPlayButtons.PlayButtonType.Play;
			if (m_isRaidEvent)
				return SetDeckPlayButtons.PlayButtonType.Play_EN;
			return SetDeckPlayButtons.PlayButtonType.Play_AP;
		}

		//// RVA: 0xA84314 Offset: 0xA84314 VA: 0xA84314
		private SkipStatusType CehckSkipStatus(long consumeTime)
		{
			SkipStatusType res = SkipStatusType.Story;
			if (!IsStoryMode())
			{
				if(Database.Instance.gameSetup.musicInfo.gameEventType == OHCAABOMEOF.KGOGMKMBCPP_EventType.PFKOKHODEGL_EventBattle)
				{
					TodoLogger.Log(0, "Event");
				}
				TodoLogger.Log(0, "Event");
				res = SkipStatusType.Boost;
				if(Database.Instance.gameSetup.SelectedDashIndex < 1)
				{
					res = SkipStatusType.Lock;
					if((Database.Instance.selectedMusic.GetSelectedMusicData() as IBJAKJJICBC).JHLDFOLFNGB(Database.Instance.gameSetup.musicInfo.difficultyType, Database.Instance.gameSetup.musicInfo.IsLine6Mode))
					{
						res = SkipStatusType.Limit;
						if(!CIOECGOMILE.HHCJCDFCLOB.PPDOILECBAD())
						{
							res = SkipStatusType.LackTicket;
							if(CIOECGOMILE.HHCJCDFCLOB.HDKICOHCCJB(consumeTime))
							{
								res = SkipStatusType.Enable;
							}
						}
					}
				}
			}
			return res;
		}

		//// RVA: 0xA84714 Offset: 0xA84714 VA: 0xA84714
		//private SetDeckPlayButtons.SkipButtoType ConvertSkipButtonType(TeamSelectSceneUnit5.SkipStatusType skipStatus) { }

		//// RVA: 0xA84730 Offset: 0xA84730 VA: 0xA84730
		private int GetSkipRestCount()
		{
			return CIOECGOMILE.HHCJCDFCLOB.PPADGJPHDAD() - CIOECGOMILE.HHCJCDFCLOB.PIEPAMPMODI();
		}

		//// RVA: 0xA841B4 Offset: 0xA841B4 VA: 0xA841B4
		private void UpdateParamCalculator()
		{
			m_paramCalculator.Calc(Database.Instance.gameSetup.musicInfo, m_playerData, m_viewUnitData,
				m_viewMusicData, m_viewFriendPlayerData, m_viewEnemyData, Database.Instance.bonusData.EffectiveEpisodeBonus, 
				m_isRaidEvent);
		}

		//// RVA: 0xA8520C Offset: 0xA8520C VA: 0xA8520C
		private void ApplyDispType(DispType dispType)
		{
			if(dispType == DispType.Prism)
			{
				m_headButtons.SetType(SetDeckHeadButtons.Type.Prism);
				m_unitStatus.SetUnitNameEditButtonEnable(true);
				m_unitStatus.SetCheckStatusButtonEnable(false);
			}
			else if(dispType == DispType.UnitSet)
			{
				m_unitStatus.SetUnitNameEditButtonEnable(false);
				m_unitStatus.SetCheckStatusButtonEnable(true);
			}
			else if(dispType == DispType.CurrentUnit)
			{
				m_headButtons.SetType(SetDeckHeadButtons.Type.TeamSelect);
				m_unitStatus.SetUnitNameEditButtonEnable(true);
				m_unitStatus.SetCheckStatusButtonEnable(true);
			}
		}

		//// RVA: 0xA84DA4 Offset: 0xA84DA4 VA: 0xA84DA4
		private void ApplyCurrentUnitContent(bool forPrism = false)
		{
			UpdateEpisodeBonusList();
			UpdateUnitBonus();
			UpdateParamCalculator();
			m_unitStatus.UpdateContent(m_paramCalculator);
			m_unitStatus.SetUnitName(m_viewUnitData.BHKALCOAHHO_Name);
			if(!forPrism)
			{
				m_valkyrieButton.UpdateContent(m_viewUnitData, m_viewMusicData);
			}
			m_valkyrieButton.SetTapGuard(false);
			m_unitInfo.UpdateContent(m_playerData, m_viewUnitData, m_paramCalculator, m_viewMusicData, Database.Instance.gameSetup.musicInfo, m_isGoDivaEvent);
			m_unitInfo.SetStatusDisplayType(PopupSortMenu.UnitDivaSortItem[m_divaDispTypeIndex], PopupSortMenu.UnitSortItem[m_sceneDispTypeIndex]);
			SetExpectedScoreGauge();
			m_statusWindow.UpdateContent(m_playerData, m_viewUnitData, m_viewMusicData, m_viewEnemyData, m_viewFriendPlayerData, 0, m_isGoDivaEvent);
			m_musicInfo.ReStartMusicAttrAnime();
		}

		//// RVA: 0xA84920 Offset: 0xA84920 VA: 0xA84920
		private void ApplyUnitSetContent(int unitSetIndex)
		{
			UpdateEpisodeBonusList(unitSetIndex);
			UpdateUnitBonus(unitSetIndex);
			m_unitSetParamCalculator.Calc(Database.Instance.gameSetup.musicInfo, m_playerData, m_playerData.JKIJFGGMNAN_GetUnit(unitSetIndex, m_isGoDivaEvent), m_viewMusicData, m_viewFriendPlayerData, m_viewEnemyData, Database.Instance.bonusData.EffectiveEpisodeBonus, m_isRaidEvent);
			m_unitStatus.UpdateContent(m_unitSetParamCalculator);
			JLKEOGLJNOD viewUnitData = m_playerData.JKIJFGGMNAN_GetUnit(unitSetIndex);
			m_unitStatus.SetUnitName(viewUnitData.BHKALCOAHHO_Name);
			m_valkyrieButton.UpdateContent(viewUnitData, m_viewMusicData);
			m_valkyrieButton.SetTapGuard(true);
			m_unitSetInfo.UpdateContent(m_playerData, viewUnitData, m_unitSetParamCalculator, m_viewMusicData, Database.Instance.gameSetup.musicInfo, m_isGoDivaEvent);
			m_unitSetInfo.SetStatusDisplayType(PopupSortMenu.UnitDivaSortItem[m_divaDispTypeIndex], PopupSortMenu.UnitSortItem[m_sceneDispTypeIndex]);
			SetExpectedScoreGauge();
			m_statusWindow.UpdateContent(m_playerData, viewUnitData, m_viewMusicData, m_viewEnemyData, m_viewFriendPlayerData, 0, m_isGoDivaEvent);
			m_loadSaveButtons.SetType(viewUnitData.EIGKIHENKNC ? SetDeckLoadSaveButtons.ModeType.Overwrite : SetDeckLoadSaveButtons.ModeType.NewSave);
			m_musicInfo.ReStartMusicAttrAnime();
		}

		//// RVA: 0xA850FC Offset: 0xA850FC VA: 0xA850FC
		private void ApplyPrismUnitContent()
		{
			m_valkyrieButton.UpdateContent(m_prismData);
			m_valkyrieButton.SetTapGuard(false);
			m_prismUnitInfo.UpdateContent(m_prismData, Database.Instance.gameSetup.musicInfo);
		}

		//// RVA: 0xA872A0 Offset: 0xA872A0 VA: 0xA872A0
		private void SetExpectedScoreGauge()
		{
			int[] score = new int[10];
			float[] rank = new float[5];
			for(int i = 0; i < 10; i++)
			{
				score[i] = CMMKCEPBIHI.NDNOLJACLLC((CMMKCEPBIHI.NOJENDEDECD)i);
			}
			for(int i = 0; i < rank.Length; i++)
			{
				rank[i] = CMMKCEPBIHI.GPCKPNJGANO((ResultScoreRank.Type)i);
			}
			m_musicInfo.ExpectedScoreGauge.Set(CMMKCEPBIHI.KHCOOPDAGOE, 0, rank, score);
		}

		//// RVA: 0xA874DC Offset: 0xA874DC VA: 0xA874DC
		private void ApplyUnitContent(DispType dispType)
		{
			if(dispType == DispType.Prism)
			{
				ApplyPrismUnitContent();
			}
			else if(dispType == DispType.CurrentUnit)
			{
				ApplyCurrentUnitContent();
			}
			else if(dispType == DispType.UnitSet)
			{
				ApplyUnitSetContent(UnitSetIndex);
			}
		}

		//// RVA: 0xA87534 Offset: 0xA87534 VA: 0xA87534
		private void UpdateContent()
		{
			ApplyUnitContent(m_dispType);
		}

		//// RVA: 0xA8548C Offset: 0xA8548C VA: 0xA8548C
		private bool IsApplyWait()
		{
			return m_valkyrieButton.IsUpdatingContent || m_unitInfo.IsUpdatingContent() || m_unitSetInfo.IsUpdatingContent() || m_prismUnitInfo.IsUpdatingContent();
		}

		//[IteratorStateMachineAttribute] // RVA: 0x72F424 Offset: 0x72F424 VA: 0x72F424
		//// RVA: 0xA875CC Offset: 0xA875CC VA: 0xA875CC
		private IEnumerator Co_EnterContents(DispType dispType)
		{
			//0xA94974
			SetActiveNecessaryContent(dispType);
			LeaveUnnecessaryContent(dispType);
			EnterNecessaryContent(dispType);
			while (IsPlayingContents())
				yield return null;
			SetInactiveUnnecessaryContent(dispType);
		}

		//// RVA: 0xA87694 Offset: 0xA87694 VA: 0xA87694
		private void EnterNecessaryContent(DispType dispType)
		{
			SetDeckUnitInfoAnimeControl.DispType deckDisp = (SetDeckUnitInfoAnimeControl.DispType)GameManager.Instance.localSave.EPJOACOONAC_GetSave().MCNEIJAOLNO_Select.ECNAIALHHBO_UnitMenu.BLABFAMKLIN_UnitInfoDispType;
			if (m_isGoDivaEvent)
				deckDisp = SetDeckUnitInfoAnimeControl.DispType.Skill;
			if(dispType == DispType.Prism)
			{
				m_headButtons.InOut.Enter();
				m_valkyrieButton.InOut.Enter();
				m_musicInfo.InOut.Enter();
				m_playButtons.InOut.Enter();
				m_prismSettingButtons.InOut.Enter();
				m_prismUnitInfo.AnimeControl.TryEnter();
			}
			else if(dispType == DispType.UnitSet)
			{
				m_unitStatus.InOut.Enter();
				m_valkyrieButton.InOut.Enter();
				if(!m_isGoDivaEvent)
				{
					m_unitInfoChangeButton.InOut.Enter();
				}
				m_musicInfo.InOut.Enter();
				m_unitSetListButtons.InOut.Enter();
				m_unitSetListButtons.ResetUnitNameScroll();
				m_unitSetCloseButton.InOut.Enter();
				m_unitSetSelectButtons.InOutLeft.Enter();
				m_unitSetSelectButtons.InOutRight.Enter();
				m_unitSetInfo.AnimeControl.TryEnter(deckDisp);
				m_loadSaveButtons.InOut.Enter();
			}
			else if(dispType == DispType.CurrentUnit)
			{
				m_headButtons.InOut.Enter();
				m_unitStatus.InOut.Enter();
				m_valkyrieButton.InOut.Enter();
				if(!m_isGoDivaEvent)
				{
					m_unitInfoChangeButton.InOut.Enter();
				}
				m_unitInfo.AnimeControl.TryEnter();
				m_musicInfo.InOut.Enter();
				m_playButtons.InOut.Enter();
			}
		}

		//// RVA: 0xA87E3C Offset: 0xA87E3C VA: 0xA87E3C
		private void LeaveUnnecessaryContent(DispType dispType)
		{
			if(dispType != DispType.Prism)
			{
				if(dispType == DispType.UnitSet)
				{
					m_headButtons.InOut.Leave(false);
					m_unitInfo.AnimeControl.TryLeave();
					m_playButtons.InOut.Leave(false);
				}
				else if(dispType == DispType.CurrentUnit)
				{
					m_unitSetListButtons.InOut.Leave(false);
					m_unitSetCloseButton.InOut.Leave(false);
					m_unitSetSelectButtons.InOutLeft.Leave(false);
					m_unitSetSelectButtons.InOutRight.Leave(false);
					m_unitSetInfo.AnimeControl.TryLeave();
					m_loadSaveButtons.InOut.Leave(false);
					m_prismSettingButtons.InOut.Leave(false);
					m_prismUnitInfo.AnimeControl.TryLeave();
				}
			}
			else
			{
				m_unitStatus.InOut.Leave(false);
				m_unitInfoChangeButton.InOut.Leave(false);
				m_unitInfo.AnimeControl.TryLeave();
				m_unitSetListButtons.InOut.Leave(false);
				m_unitSetCloseButton.InOut.Leave(false);
				m_unitSetSelectButtons.InOutLeft.Leave(false);
				m_unitSetSelectButtons.InOutRight.Leave(false);
				m_unitSetInfo.AnimeControl.TryLeave();
				m_loadSaveButtons.InOut.Leave(false);
			}
		}

		//// RVA: 0xA883BC Offset: 0xA883BC VA: 0xA883BC
		private void SetActiveNecessaryContent(DispType dispType)
		{
			if(dispType == DispType.Prism)
			{
				m_headButtons.gameObject.SetActive(true);
				m_valkyrieButton.gameObject.SetActive(true);
				m_musicInfo.gameObject.SetActive(true);
				m_playButtons.gameObject.SetActive(true);
				m_prismSettingButtons.gameObject.SetActive(true);
				m_prismUnitInfo.gameObject.SetActive(true);
			}
			else if(dispType == DispType.UnitSet)
			{
				m_unitStatus.gameObject.SetActive(true);
				m_valkyrieButton.gameObject.SetActive(true);
				if(!m_isGoDivaEvent)
				{
					m_unitInfoChangeButton.gameObject.SetActive(true);
				}
				m_musicInfo.gameObject.SetActive(true);
				m_unitSetListButtons.gameObject.SetActive(true);
				m_unitSetCloseButton.gameObject.SetActive(true);
				m_unitSetSelectButtons.gameObject.SetActive(true);
				m_unitSetInfo.gameObject.SetActive(true);
				m_loadSaveButtons.gameObject.SetActive(true);
			}
			else if(dispType == DispType.CurrentUnit)
			{
				m_headButtons.gameObject.SetActive(true);
				m_unitStatus.gameObject.SetActive(true);
				m_valkyrieButton.gameObject.SetActive(true);
				if(!m_isGoDivaEvent)
				{
					m_unitInfoChangeButton.gameObject.SetActive(true);
				}
				m_unitInfo.gameObject.SetActive(true);
				m_musicInfo.gameObject.SetActive(true);
				m_playButtons.gameObject.SetActive(true);
			}
		}

		//// RVA: 0xA8895C Offset: 0xA8895C VA: 0xA8895C
		private void SetInactiveUnnecessaryContent(TeamSelectSceneUnit5.DispType dispType)
		{
			if (dispType == DispType.Prism)
			{
				m_unitStatus.gameObject.SetActive(false);
				m_unitInfoChangeButton.gameObject.SetActive(false);
				m_unitInfo.gameObject.SetActive(false);
				m_unitSetListButtons.gameObject.SetActive(false);
				m_unitSetCloseButton.gameObject.SetActive(false);
				m_unitSetSelectButtons.gameObject.SetActive(false);
				m_unitSetInfo.gameObject.SetActive(false);
				m_loadSaveButtons.gameObject.SetActive(false);
			}
			else
			{
				if (dispType == DispType.UnitSet)
				{
					m_headButtons.gameObject.SetActive(false);
					m_unitInfo.gameObject.SetActive(false);
					m_playButtons.gameObject.SetActive(false);
				}
				else
				{
					m_unitSetListButtons.gameObject.SetActive(false);
					m_unitSetCloseButton.gameObject.SetActive(false);
					m_unitSetSelectButtons.gameObject.SetActive(false);
					m_unitSetInfo.gameObject.SetActive(false);
					m_loadSaveButtons.gameObject.SetActive(false);
				}
				m_prismSettingButtons.gameObject.SetActive(false);
				m_prismUnitInfo.gameObject.SetActive(false);
			}
			if (!m_isGoDivaEvent)
				return;
			m_unitInfoChangeButton.gameObject.SetActive(false);
		}

		//// RVA: 0xA88E24 Offset: 0xA88E24 VA: 0xA88E24
		private void LeaveContents()
		{
			m_headButtons.InOut.Leave(false);
			m_unitStatus.InOut.Leave(false);
			m_valkyrieButton.InOut.Leave(false);
			m_unitInfoChangeButton.InOut.Leave(false);
			m_unitInfo.AnimeControl.TryLeave();
			m_musicInfo.InOut.Leave(false);
			m_playButtons.InOut.Leave(false);
			m_unitSetListButtons.InOut.Leave(false);
			m_unitSetCloseButton.InOut.Leave(false);
			m_unitSetSelectButtons.InOutLeft.Leave(false);
			m_unitSetSelectButtons.InOutRight.Leave(false);
			m_unitSetInfo.AnimeControl.TryLeave();
			m_unitSetInfo.MessageControl.Leave();
			m_loadSaveButtons.InOut.Leave(false);
			m_prismSettingButtons.InOut.Leave(false);
			m_prismUnitInfo.AnimeControl.TryLeave();
			m_statusWindow.InOut.Leave(false);
			m_unitStatus.SetCheckStatusButtonState(SetDeckUnitStatus.CheckStatusButtonState.Normal);
		}

		//// RVA: 0xA89300 Offset: 0xA89300 VA: 0xA89300
		private bool IsPlayingContents()
		{
			return m_headButtons.InOut.IsPlaying() || m_unitStatus.InOut.IsPlaying() || m_valkyrieButton.InOut.IsPlaying() ||
				m_unitInfoChangeButton.InOut.IsPlaying() || m_unitInfo.AnimeControl.IsPlaying() || m_musicInfo.InOut.IsPlaying() ||
				m_playButtons.InOut.IsPlaying() || m_unitSetListButtons.InOut.IsPlaying() || m_unitSetCloseButton.InOut.IsPlaying() ||
				m_unitSetSelectButtons.InOutLeft.IsPlaying() || m_unitSetSelectButtons.InOutRight.IsPlaying() || m_unitSetInfo.AnimeControl.IsPlaying() ||
				m_loadSaveButtons.InOut.IsPlaying() || m_prismSettingButtons.InOut.IsPlaying() || m_prismUnitInfo.AnimeControl.IsPlaying() ||
				m_statusWindow.InOut.IsPlaying();
		}

		//[IteratorStateMachineAttribute] // RVA: 0x72F49C Offset: 0x72F49C VA: 0x72F49C
		//// RVA: 0xA89790 Offset: 0xA89790 VA: 0xA89790
		//private IEnumerator Co_SwitchContents(TeamSelectSceneUnit5.DispType dispType) { }

		//// RVA: 0xA89858 Offset: 0xA89858 VA: 0xA89858
		private void SetTitleInOut(DispType prevType, DispType nextType)
		{
			if ((prevType != DispType.UnitSet) == (nextType != DispType.UnitSet))
				return;
			if(nextType == DispType.UnitSet)
			{
				MenuScene.Instance.HelpButton.TryLeave();
				MenuScene.Instance.HeaderMenu.MenuStack.LeaveBackButton(false);
				MenuScene.Instance.HeaderMenu.MenuStack.LeaveLabel(false);
				return;
			}
			MenuScene.Instance.HelpButton.TryEnter();
			MenuScene.Instance.HeaderMenu.MenuStack.EnterBackButton(false);
			MenuScene.Instance.HeaderMenu.MenuStack.EnterLabel();
		}

		//// RVA: 0xA89B58 Offset: 0xA89B58 VA: 0xA89B58
		//private bool IsUseTitle(TeamSelectSceneUnit5.DispType dispType) { }

		//// RVA: 0xA85328 Offset: 0xA85328 VA: 0xA85328
		private void ApplyPrismSettingButton(AOJGDNFAIJL_PrismData.AMIECPBIALP prismData)
		{
			if(prismData.OFHMEAJBIEL_IsPrismUnlocked())
			{
				m_headButtons.SetPrismType(prismData.FBGAKINEIPG ? SetDeckHeadButtons.PrismType.ON : SetDeckHeadButtons.PrismType.OFF);
			}
			else
			{
				m_headButtons.SetPrismType(SetDeckHeadButtons.PrismType.Lock);
			}
		}

		//// RVA: 0xA89B68 Offset: 0xA89B68 VA: 0xA89B68
		private void OnPlayButton()
		{
			TodoLogger.Log(0, "OnPlayButton");
		}

		//// RVA: 0xA8C708 Offset: 0xA8C708 VA: 0xA8C708
		private void OnSkipButton()
		{
			TodoLogger.Log(0, "OnSkipButton");
		}

		//// RVA: 0xA8A680 Offset: 0xA8A680 VA: 0xA8A680
		//private void PreGameSkipShow(Action onContinue) { }

		//// RVA: 0xA8C374 Offset: 0xA8C374 VA: 0xA8C374
		//private void PreGameSettingShow(Action onContinue) { }

		//// RVA: 0xA8B940 Offset: 0xA8B940 VA: 0xA8B940
		//private void AdvanceGame() { }

		//// RVA: 0xA8D2EC Offset: 0xA8D2EC VA: 0xA8D2EC
		//private void SettingCompleteShow(Action onClose) { }

		//// RVA: 0xA89EF8 Offset: 0xA89EF8 VA: 0xA89EF8
		//private bool CheckSetAllDiva() { }

		//// RVA: 0xA8A228 Offset: 0xA8A228 VA: 0xA8A228
		//private void NotSetAllDivaShow() { }

		//[IteratorStateMachineAttribute] // RVA: 0x72F514 Offset: 0x72F514 VA: 0x72F514
		//// RVA: 0xA8D5D0 Offset: 0xA8D5D0 VA: 0xA8D5D0
		//private IEnumerator Co_SwitchDivaSelectDisplay() { }

		//// RVA: 0xA8A504 Offset: 0xA8A504 VA: 0xA8A504
		//private bool IsForceSkip() { }

		//// RVA: 0xA8D67C Offset: 0xA8D67C VA: 0xA8D67C
		private void OnChangeUnitName()
		{
			TodoLogger.Log(0, "OnChangeUnitName");
		}

		//// RVA: 0xA8DCDC Offset: 0xA8DCDC VA: 0xA8DCDC
		private void OnShowEpisodeBonusScenePopup()
		{
			TodoLogger.Log(0, "OnShowEpisodeBonusScenePopup");
		}

		//// RVA: 0xA8E110 Offset: 0xA8E110 VA: 0xA8E110
		private void OnShowStatusWindow()
		{
			TodoLogger.Log(0, "OnShowStatusWindow");
		}

		//[IteratorStateMachineAttribute] // RVA: 0x72F58C Offset: 0x72F58C VA: 0x72F58C
		//// RVA: 0xA8E1CC Offset: 0xA8E1CC VA: 0xA8E1CC
		//private IEnumerator Co_ShowStatusWindow(bool isShow) { }

		//// RVA: 0xA8E294 Offset: 0xA8E294 VA: 0xA8E294
		private void OnShowChangeStatusButton()
		{
			TodoLogger.Log(0, "OnShowChangeStatusButton");
		}

		//// RVA: 0xA8E3E8 Offset: 0xA8E3E8 VA: 0xA8E3E8
		//private void ApplyStatusDisplayType() { }

		//// RVA: 0xA8E530 Offset: 0xA8E530 VA: 0xA8E530
		private void OnClickValkyrieButton()
		{
			TodoLogger.Log(0, "OnClickValkyrieButton");
		}

		//// RVA: 0xA8E814 Offset: 0xA8E814 VA: 0xA8E814
		private void OnStayValkyrieButton()
		{
			TodoLogger.Log(0, "OnStayValkyrieButton");
		}

		//// RVA: 0xA8EA34 Offset: 0xA8EA34 VA: 0xA8EA34
		private void OnClickUnitInfoChangeButton()
		{
			TodoLogger.Log(0, "OnClickUnitInfoChangeButton");
		}

		//// RVA: 0xA83E8C Offset: 0xA83E8C VA: 0xA83E8C
		//private SetDeckUnitInfoAnimeControl.DispType ChangeUnitInfoDispType() { }

		//// RVA: 0xA8EC04 Offset: 0xA8EC04 VA: 0xA8EC04
		//private void OnClickSubPlateButton() { }

		//// RVA: 0xA8EC70 Offset: 0xA8EC70 VA: 0xA8EC70
		private void ShowSubPlateWindow(bool isReShow = false)
		{
			TodoLogger.Log(0, "ShowSubPlateWindow");
		}

		//// RVA: 0xA8EEE0 Offset: 0xA8EEE0 VA: 0xA8EEE0
		private void OnSelectDiva(int slotNumber, FFHPBEPOMAK divaData)
		{
			OnClickAnyButtons();
			SoundManager.Instance.sePlayerBoot.Play(1);
			m_selectDivaListArgs.slot = slotNumber;
			m_selectDivaListArgs.viewPlayerData = m_playerData;
			m_selectDivaListArgs.viewMusicBaseData = m_viewMusicData;
			MenuScene.Instance.Call(TransitionList.Type.DIVA_SELECT_LIST, m_selectDivaListArgs, true);
		}

		//// RVA: 0xA8F050 Offset: 0xA8F050 VA: 0xA8F050
		private void OnShowDivaStatus(int slotNumber, FFHPBEPOMAK divaData)
		{
			TodoLogger.Log(0, "OnShowDivaStatus");
		}

		//// RVA: 0xA8F1CC Offset: 0xA8F1CC VA: 0xA8F1CC
		private void OnSelectCostume(int slotNumber, FFHPBEPOMAK divaData)
		{
			OnClickAnyButtons();
			if(slotNumber > -1)
			{
				SoundManager.Instance.sePlayerBoot.Play(1);
				m_costumeChangeDivaArgs.DivaId = divaData.AHHJLDLAPAN_DivaId;
				m_costumeChangeDivaArgs.is_godiva = m_isGoDivaEvent;
				MenuScene.Instance.Call(TransitionList.Type.COSTUME_SELECT, m_costumeChangeDivaArgs, true);
			}
		}

		//// RVA: 0xA8F334 Offset: 0xA8F334 VA: 0xA8F334
		private void OnSelectScene(int divaSlotNumber, int sceneSlotNumber, FFHPBEPOMAK divaData, GCIJNCFDNON sceneData)
		{
			TodoLogger.Log(0, "OnSelectScene");
		}

		//// RVA: 0xA8F5B4 Offset: 0xA8F5B4 VA: 0xA8F5B4
		private void OnShowSceneStatus(int divaSlotNumber, int sceneSlotNumber, FFHPBEPOMAK divaData, GCIJNCFDNON sceneData)
		{
			TodoLogger.Log(0, "OnShowSceneStatus");
		}

		//// RVA: 0xA8F73C Offset: 0xA8F73C VA: 0xA8F73C
		private void OnShowFriendDivaStatus(EAJCBFGKKFA friendData)
		{
			TodoLogger.Log(0, "OnShowFriendDivaStatus");
		}

		//// RVA: 0xA8F89C Offset: 0xA8F89C VA: 0xA8F89C
		private void OnShowScoreInfoPopup()
		{
			TodoLogger.Log(0, "OnShowScoreInfoPopup");
		}

		//// RVA: 0xA8FB84 Offset: 0xA8FB84 VA: 0xA8FB84
		private void OnClickAutoSettingButton()
		{
			TodoLogger.Log(0, "OnClickAutoSettingButton");
		}

		//[IteratorStateMachineAttribute] // RVA: 0x72F604 Offset: 0x72F604 VA: 0x72F604
		//// RVA: 0xA8FF98 Offset: 0xA8FF98 VA: 0xA8FF98
		//private IEnumerator Co_ApplyCurrentUnitContentForAutoSetting() { }

		//// RVA: 0xA90044 Offset: 0xA90044 VA: 0xA90044
		private void OnClickUnitSetButton()
		{
			TodoLogger.Log(0, "OnClickUnitSetButton");
		}

		//[IteratorStateMachineAttribute] // RVA: 0x72F67C Offset: 0x72F67C VA: 0x72F67C
		//// RVA: 0xA900BC Offset: 0xA900BC VA: 0xA900BC
		//private IEnumerator Co_EnterUnitSet() { }

		//[IteratorStateMachineAttribute] // RVA: 0x72F6F4 Offset: 0x72F6F4 VA: 0x72F6F4
		//// RVA: 0xA90168 Offset: 0xA90168 VA: 0xA90168
		//private IEnumerator Co_DownloadUnitSetResources() { }

		//// RVA: 0xA90214 Offset: 0xA90214 VA: 0xA90214
		private void OnClickPrismSettingButton()
		{
			TodoLogger.Log(0, "OnClickPrismSettingButton");
		}

		//// RVA: 0xA90564 Offset: 0xA90564 VA: 0xA90564
		private void OnClickUnitSettingButton()
		{
			TodoLogger.Log(0, "OnClickUnitSettingButton");
		}

		//// RVA: 0xA905E0 Offset: 0xA905E0 VA: 0xA905E0
		private void OnClickGameSettingButton()
		{
			TodoLogger.Log(0, "OnClickGameSettingButton");
		}

		//// RVA: 0xA90668 Offset: 0xA90668 VA: 0xA90668
		private void OnChangeUnitSetSelect(int unitSetIndex, JLKEOGLJNOD unitData)
		{
			TodoLogger.Log(0, "OnChangeUnitSetSelect");
		}

		//// RVA: 0xA9079C Offset: 0xA9079C VA: 0xA9079C
		private void OnStartChangeUnitSetPage()
		{
			TodoLogger.Log(0, "OnStartChangeUnitSetPage");
		}

		//// RVA: 0xA90890 Offset: 0xA90890 VA: 0xA90890
		private void OnEndChangeUnitSetPage()
		{
			TodoLogger.Log(0, "OnEndChangeUnitSetPage");
		}

		//// RVA: 0xA9092C Offset: 0xA9092C VA: 0xA9092C
		private void OnClickUnitSetCloseButton()
		{
			TodoLogger.Log(0, "OnClickUnitSetCloseButton");
		}

		//// RVA: 0xA909A8 Offset: 0xA909A8 VA: 0xA909A8
		private void OnClickUnitSetSelectButton(int tick)
		{
			TodoLogger.Log(0, "OnClickUnitSetSelectButton");
		}

		//[IteratorStateMachineAttribute] // RVA: 0x72F76C Offset: 0x72F76C VA: 0x72F76C
		//// RVA: 0xA90A28 Offset: 0xA90A28 VA: 0xA90A28
		//private IEnumerator Co_OnClickUnitSetSelect(int tick) { }

		//// RVA: 0xA90AF0 Offset: 0xA90AF0 VA: 0xA90AF0
		private void OnUnitSetLoad()
		{
			TodoLogger.Log(0, "OnUnitSetLoad");
		}

		//// RVA: 0xA90D30 Offset: 0xA90D30 VA: 0xA90D30
		private void OnUnitSetSave()
		{
			TodoLogger.Log(0, "OnUnitSetSave");
		}

		//[IteratorStateMachineAttribute] // RVA: 0x72F7E4 Offset: 0x72F7E4 VA: 0x72F7E4
		//// RVA: 0xA906F4 Offset: 0xA906F4 VA: 0xA906F4
		//private IEnumerator Co_ApplyUnitSetContent(bool isApplyUnitSetList = True) { }

		//// RVA: 0xA91058 Offset: 0xA91058 VA: 0xA91058
		//private void SaveUnitSetByCurrentUnit(int unitSetIndex) { }

		//// RVA: 0xA9117C Offset: 0xA9117C VA: 0xA9117C
		//private void LoadUnitSetForCurrentUnit(int unitSetIndex) { }

		//// RVA: 0xA912FC Offset: 0xA912FC VA: 0xA912FC
		private void OnClickOriginalSetting()
		{
			TodoLogger.Log(0, "OnClickOriginalSetting");
		}

		//// RVA: 0xA914E0 Offset: 0xA914E0 VA: 0xA914E0
		private void OnClickPrismItems(PopupMvModeSelectListContent.SelectTarget target, int divaSlotNumber)
		{
			TodoLogger.Log(0, "OnClickPrismItems");
		}

		//// RVA: 0xA89EAC Offset: 0xA89EAC VA: 0xA89EAC
		private void OnClickAnyButtons()
		{
			TodoLogger.Log(0, "OnClickAnyButtons");
		}

		// RVA: 0xA91658 Offset: 0xA91658 VA: 0xA91658 Slot: 28
		protected override TransitionArgs GetCallArgsReturn()
		{
			if(Database.Instance.gameSetup.musicInfo.gameEventType == OHCAABOMEOF.KGOGMKMBCPP_EventType.BNECMLPHAGJ_EventGoDiva ||
				Database.Instance.gameSetup.musicInfo.gameEventType == OHCAABOMEOF.KGOGMKMBCPP_EventType.PFKOKHODEGL_EventBattle)
			{
				TodoLogger.Log(0, "Event");
			}
			return null;
		}

		//// RVA: 0xA917F4 Offset: 0xA917F4 VA: 0xA917F4
		private bool CheckTutorialCondition(TutorialConditionId conditionId)
		{
			return conditionId == TutorialConditionId.Condition73;
		}

		//// RVA: 0xA91804 Offset: 0xA91804 VA: 0xA91804
		//private bool CheckTutorialCondition_forSwitchDispType(TutorialConditionId conditionId) { }

		//// RVA: 0xA918F8 Offset: 0xA918F8 VA: 0xA918F8
		private void OnBackButton()
		{
			if(MenuScene.Instance.GetInputDisableCount() < 1)
			{
				if(MenuScene.Instance.GetRaycastDisableCount() < 1)
				{
					if(!GameManager.Instance.IsTutorial)
					{
						if(!MenuScene.Instance.IsRequestChangeScene)
						{
							if (MenuScene.Instance.DirtyChangeScene)
								return;
							if(m_dispType == DispType.UnitSet)
							{
								OnClickUnitSetCloseButton();
								return;
							}
							SoundManager.Instance.sePlayerBoot.Play(0);
							MenuScene.SaveRequest();
							MenuScene.Instance.Return(true);
						}
					}
				}
			}
		}

		//[CompilerGeneratedAttribute] // RVA: 0x72F85C Offset: 0x72F85C VA: 0x72F85C
		//// RVA: 0xA9203C Offset: 0xA9203C VA: 0xA9203C
		//private bool <Co_ShowHelp>b__101_0() { }

		//[CompilerGeneratedAttribute] // RVA: 0x72F86C Offset: 0x72F86C VA: 0x72F86C
		//// RVA: 0xA92044 Offset: 0xA92044 VA: 0xA92044
		//private void <NotSetAllDivaShow>b__144_0(PopupWindowControl ctrl, PopupButton.ButtonType type, PopupButton.ButtonLabel label) { }

		//[CompilerGeneratedAttribute] // RVA: 0x72F87C Offset: 0x72F87C VA: 0x72F87C
		//// RVA: 0xA920FC Offset: 0xA920FC VA: 0xA920FC
		//private void <OnChangeUnitName>b__147_0(PopupWindowControl control, PopupButton.ButtonType type, PopupButton.ButtonLabel label) { }

		//[CompilerGeneratedAttribute] // RVA: 0x72F88C Offset: 0x72F88C VA: 0x72F88C
		//// RVA: 0xA922A0 Offset: 0xA922A0 VA: 0xA922A0
		//private void <OnShowChangeStatusButton>b__151_0(PopupFilterSortUGUI content) { }

		//[CompilerGeneratedAttribute] // RVA: 0x72F89C Offset: 0x72F89C VA: 0x72F89C
		//// RVA: 0xA92574 Offset: 0xA92574 VA: 0xA92574
		//private void <OnClickValkyrieButton>b__153_0() { }

		//[CompilerGeneratedAttribute] // RVA: 0x72F8AC Offset: 0x72F8AC VA: 0x72F8AC
		//// RVA: 0xA92578 Offset: 0xA92578 VA: 0xA92578
		//private void <ShowSubPlateWindow>b__158_0() { }

		//[CompilerGeneratedAttribute] // RVA: 0x72F8BC Offset: 0x72F8BC VA: 0x72F8BC
		//// RVA: 0xA92584 Offset: 0xA92584 VA: 0xA92584
		//private void <OnShowScoreInfoPopup>b__165_0(PopupWindowControl ctrl, PopupButton.ButtonType type, PopupButton.ButtonLabel label) { }

		//[CompilerGeneratedAttribute] // RVA: 0x72F8CC Offset: 0x72F8CC VA: 0x72F8CC
		//// RVA: 0xA925D0 Offset: 0xA925D0 VA: 0xA925D0
		//private void <OnClickAutoSettingButton>b__166_0(PopupAutoSettingContent content) { }

		//[CompilerGeneratedAttribute] // RVA: 0x72F8DC Offset: 0x72F8DC VA: 0x72F8DC
		//// RVA: 0xA92688 Offset: 0xA92688 VA: 0xA92688
		//private void <OnClickAutoSettingButton>b__166_1() { }

		//[CompilerGeneratedAttribute] // RVA: 0x72F8EC Offset: 0x72F8EC VA: 0x72F8EC
		//// RVA: 0xA926AC Offset: 0xA926AC VA: 0xA926AC
		//private void <OnClickAutoSettingButton>b__166_2() { }

		//[CompilerGeneratedAttribute] // RVA: 0x72F8FC Offset: 0x72F8FC VA: 0x72F8FC
		//// RVA: 0xA926B8 Offset: 0xA926B8 VA: 0xA926B8
		//private void <OnUnitSetLoad>b__180_0() { }

		//[CompilerGeneratedAttribute] // RVA: 0x72F90C Offset: 0x72F90C VA: 0x72F90C
		//// RVA: 0xA9276C Offset: 0xA9276C VA: 0xA9276C
		//private void <OnUnitSetLoad>b__180_1() { }

		//[CompilerGeneratedAttribute] // RVA: 0x72F91C Offset: 0x72F91C VA: 0x72F91C
		//// RVA: 0xA92828 Offset: 0xA92828 VA: 0xA92828
		//private void <OnUnitSetSave>b__181_0() { }

		//[CompilerGeneratedAttribute] // RVA: 0x72F92C Offset: 0x72F92C VA: 0x72F92C
		//// RVA: 0xA92974 Offset: 0xA92974 VA: 0xA92974
		//private void <OnClickOriginalSetting>b__185_0() { }

		//[CompilerGeneratedAttribute] // RVA: 0x72F93C Offset: 0x72F93C VA: 0x72F93C
		//// RVA: 0xA92978 Offset: 0xA92978 VA: 0xA92978
		//private void <OnClickPrismItems>b__186_0() { }
	}
}
