
using System.Collections.Generic;
using UnityEngine;
using XeApp.Game.Common;

public class ILLPDLODANB
{
	public enum LOEGALDKHPL
	{
		HJNNKCMLGFL = 0,
		APCJDBPNMLN = 1,
		JDBOFJKBJNK = 2,
		OCGOGBEIHPD = 3,
		HCKOEGLNAJH = 4,
		FCNKHKLIIGH = 5,
		DCFBLGLFJDO = 6,
		NOMJEIEDKML = 7,
		GIEOJGGBODI = 8,
		ABDCDIGADHD = 9,
		LOGACAKHGBL = 10,
		HPNKPGICCMK = 11,
		OMEOCCEFCOB = 12,
		JHEMKMOJBDO = 13,
		GCMANDIOBFN = 14,
		MMOGNIPPMDO = 15,
		CHPEIDMDNFP = 16,
		ECOEJFBAABC = 17,
		DGILGEFLNCF = 18,
		ODDEKPGKLJA = 19,
		GKHJKFJFAHO = 20,
		FJPCGKGPKPE = 21,
		NKKFJIPJKAO = 22,
		OGCMIONDMHB = 23,
		OLPLKIAHMOG = 24,
		LAFFLNEDNDO = 25,
		HDJGNKOIMOH = 26,
		OKEIMJEMKKJ = 27,
		NDHANBGPBBP = 28,
		BHINHMNCMKC = 29,
		IDLHNACLCLG = 30,
		DBAKKHLLCNC = 31,
		BFIIIGLDKNN = 33,
		CJKGEAFKKFL = 34,
		BDJBKMFEHHC = 40,
		LBKOGDGCFCM = 41,
		MCBICLJIJMK = 42,
		FMOCAEEMHFJ = 43,
		GNLPMEDLIJJ = 44,
		PEPILDAEIEL = 45,
		PBKOKCHKGGL = 46,
		IDAIIJEMNMP_47 = 47,
		AFLMHBMBNBO = 48,
		DDGKOJFPGFF = 49,
		NEIJFCOANMA_50 = 50,
		NEMNEDBLJEM = 51,
		OECOMFPCPAI = 52,
		LOKMFLKHIPG = 53,
		NMBILGNHKFC = 54,
		KKIEICKBEEF = 55,
		FMGMIOKOPKP = 56,
		JCHPMNHJPKG = 57,
		AJLNMHBKMLE = 58,
		BBOGLGJCAGE = 59,
		OECPMGEPMHC = 60,
		CKENLOAPCEC = 61,
		BHJDMGFAPLG = 62,
		JHMKDDGIGAA = 63,
		MEMMJNAKOHB = 64,
		HIFAMABBNIE = 65,
		CKOOMMACNKA = 66,
		DOIFAGIGLEE = 67,
		MLMDDOJOPFC = 68,
		ADDCIMFHNAE = 69,
		HDHEKLONOGD = 70,
		LEFBLIEIELJ = 71,
		MOKJAMEPIMK = 72,
		CHANJDIDJOH = 73,
		CFDPIBHFFPD = 74,
		LANICCFBKAI = 75,
		BJHMIGMHOCE = 76,
		NCOHGNCGFJC = 77,
		MENBLIKPJMC = 78,
		JAMJLBCKHHB = 79,
		BFHKNEJHFLH = 80,
		HOHJCNDMDCD = 81,
		ANALBHDNGKP = 82,
		AIKOJFKHPMO = 83,
		FJCFIBPGLDG = 84,
		DNLGEBHGKGL = 85,
		EMKEFFFNBGG = 86,
		LHBGGMLDOHH = 87,
		LMFBIGPJMFM = 88,
		PAGIHFIMLCK = 89,
	}

	private static LOEGALDKHPL NNLCKKMJPLJ; // 0x0

	//// RVA: 0x9F1AF4 Offset: 0x9F1AF4 VA: 0x9F1AF4
	public static bool HHMKDAIGMKC_IsDebutMission(LOEGALDKHPL INDDJNMPONH)
	{
		return INDDJNMPONH >= LOEGALDKHPL.BDJBKMFEHHC/*40*/ && INDDJNMPONH < LOEGALDKHPL.LOKMFLKHIPG/*53*/;
	}

	//// RVA: 0x9F1B08 Offset: 0x9F1B08 VA: 0x9F1B08
	//public static void IHKAKFFAGPC(ILLPDLODANB.LOEGALDKHPL INDDJNMPONH) { }

	//// RVA: 0x9F1B98 Offset: 0x9F1B98 VA: 0x9F1B98
	public static bool DDJGDCHMCBN(LOEGALDKHPL INDDJNMPONH)
	{
		if(NNLCKKMJPLJ != LOEGALDKHPL.HJNNKCMLGFL/*0*/)
		{
			return INDDJNMPONH == NNLCKKMJPLJ;
		}
		return false;
	}

	//// RVA: 0x9F1C78 Offset: 0x9F1C78 VA: 0x9F1C78
	//public static void ILOGJDALEOO() { }

	//// RVA: 0x9F1CF4 Offset: 0x9F1CF4 VA: 0x9F1CF4
	public static long DCLKMNGMIKC_GetQuestCurrentValue(CNLPPCFJEID_QuestInfo KOGBMDOONFA, OKGLGHCBCJP_Database LKMHPJKIFDN, BBHNACPENDM_ServerSaveData LDEGEHAEALK)
	{
		int questValue = KOGBMDOONFA.CHOFDPDFPDC_ConfigValue;
		int questType = KOGBMDOONFA.INDDJNMPONH_Type;
		switch(questType)
		{
			case 1:
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.EJFAEKPGKNJ_Day.MILCBLJDADN_MClr;
			case 2:
				{
					long res = 0;
					for (int i = 0; i < 5; i++)
					{
						if (questValue <= i)
						{
							res += LDEGEHAEALK.OEKEIGFAIGN_Counter.EJFAEKPGKNJ_Day.GEIONHDKGEB_SRnk[i];
						}
					}
					return res;
				}
			case 3:
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.EJFAEKPGKNJ_Day.MPHFGEPJOGL_AS;
			case 4:
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.EJFAEKPGKNJ_Day.NDNHHGJKJGM_Gach;
			case 5:
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.EJFAEKPGKNJ_Day.GACBDCLPOCD_Sdv;
			case 6:
				{
					long res = 0;
					for (int i = 0; i < LDEGEHAEALK.GOACJBOCLHH_Quest.BEGCHDHHEKC_DailyQuests.Count; i++)
					{
						NFPHOINMHKN_QuestInfo saveQuest = LDEGEHAEALK.GOACJBOCLHH_Quest.BEGCHDHHEKC_DailyQuests[i];
						if (saveQuest.EALOBDHOCHP_Stat != 0)
						{
							CNLPPCFJEID_QuestInfo dbQuest = LKMHPJKIFDN.MHGPMMIDKMM_Quest.BEGCHDHHEKC_DailyQuests[i];
							if(dbQuest.INDDJNMPONH_Type != 0)
							{
								if(dbQuest.INDDJNMPONH_Type != 6)
								{
									if (saveQuest.EALOBDHOCHP_Stat < 2)
									{
										if (KPEDEPGGMEC_GetDailyQuestStatus(dbQuest.PPFNGGCBJKC, LKMHPJKIFDN, LDEGEHAEALK) == 2)
											res++;
									}
									else
										res++;
								}
							}
						}
					}
					return res;
				}
			case 7:
				for(int i = 0; i < LKMHPJKIFDN.OHCIFMDPAPD_Story.CDENCMNHNGA.Count; i++)
				{
					LAEGMENIEDB_Story.ALGOILKGAAH dbStory = LKMHPJKIFDN.OHCIFMDPAPD_Story.CDENCMNHNGA[i];
					if (dbStory.KLCIIHKFPPO == questValue)
					{
						NEKDCJKANAH_StoryRecord.HKDNILFKCFC saveStory = LDEGEHAEALK.LNOOKHJBENO_StoryRecord.MMKAJBFBKNH[dbStory.LFLLLOPAKCO - 1];
						return saveStory.HALOKFOJMLA ? 1 : 0;
					}
				}
				return 0;
			case 8:
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.MILCBLJDADN_MusicClear;
			case 9:
				if(questValue > 0)
				{
					if (LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.LHOCOEOKFNO_SerieClear.Length < questValue)
						return 0;
					return LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.LHOCOEOKFNO_SerieClear[questValue - 1];
				}
				return 0;
			case 10:
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.PHPPOGOEOAF_DiffClear[questValue - 1];
			case 11: // 0xb
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.HLNOELCIBPH_Perf;
			case 12: // 0xc
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.FILFPNDEINH_Fcb;
			case 13: // 0xd
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.KOONLNKCIJC_SS;
			case 14: // 0xe
				return LDEGEHAEALK.KCCLEHLLOFG_Common.KIECDDFNCAN_Level;
			case 15: // 0xf
				if (questValue < 1)
					return 0;
				if (questValue > LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList.Count)
					return 0;
				return LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[questValue - 1].HEBKEJBDCBH_DivaLevel;
			case 16: // 0x10
				return LDEGEHAEALK.PNLOINMCCKH_Scene.IGJAAIEAJPB_GetNumUnlockedScene();
			case 17: // 0x11
				return LDEGEHAEALK.PNLOINMCCKH_Scene.MPFLFKBNFEI_GetNumSceneAtLevelOrMore(LKMHPJKIFDN.HNMMJINNHII_Game, LKMHPJKIFDN.ECNHDEHADGL_Scene, questValue);
			case 18: // 0x12
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.HOHBKPPOLLA_Uc;
			case 19: // 0x13
				return NFPHOINMHKN_QuestInfo.JGJAEKFMEPM(LDEGEHAEALK.GOACJBOCLHH_Quest.GPMKFMFEKLN_NormalQuests, LKMHPJKIFDN.MHGPMMIDKMM_Quest);
			case 20: // 0x14
				return LDEGEHAEALK.NGHJPEIKLJL_Episode.GGKOLJCPNKO(LKMHPJKIFDN.MOLEPBNJAGE_Episode);
			case 21: // 0x15
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.IMIEPNOECFD_Vk;
			case 22: // 0x16
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.GACBDCLPOCD_Sdv;
			case 23: // 0x17
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.EDLBLCGHECJ_MaxScore;
			case 24: // 0x18
				int v = LDEGEHAEALK.GOACJBOCLHH_Quest.GPMKFMFEKLN_NormalQuests[KOGBMDOONFA.PPFNGGCBJKC - 1].EALOBDHOCHP_Stat;
				if (v > 1)
					return 1;
				if (questValue == 0)
				{
					if (HDEEBKIFLNI.HHCJCDFCLOB.FAEJJLGPAJP_HasALinkPlatform())
						return 1;
				}
				else
				{
					if (questValue - 1 > 2)
						return 0;
					if (HDEEBKIFLNI.HHCJCDFCLOB.EPAKLDBFECD_IsLinked((HDEEBKIFLNI.DGNPPLKNCGH_PlatformLink)questValue - 1))
						return 1;
				}
				return 0;
			case 25: // 0x19
			case 26: // 0x1a
			case 27: // 0x1b
				return LDEGEHAEALK.GOACJBOCLHH_Quest.GPMKFMFEKLN_NormalQuests[KOGBMDOONFA.PPFNGGCBJKC - 1].EALOBDHOCHP_Stat > 1 ? 1 : 0;
			case 28: // 0x1c
				return BIFNGFAIEIL.HHCJCDFCLOB.CEDPKMOHANM(questValue);
			case 29: // 0x1d
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.BENEAPDMALA_Mk;
			case 30: // 0x1e
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.PDGJIJOMAKO_Medl;
			case 31: // 0x1f
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.PFOMECFACLL_Shp;
			default:
				return 0;
			case 33: // 0x21
				{
					int res = 0;
					for (int i = 0; i < LKMHPJKIFDN.ECNHDEHADGL_Scene.CDENCMNHNGA_SceneList.Count; i++)
					{
						MLIBEPGADJH_Scene.KKLDOOJBJMN dbScene = LKMHPJKIFDN.ECNHDEHADGL_Scene.CDENCMNHNGA_SceneList[i];
						if (dbScene.PPEGAKEIEGM_En == 2)
						{
							MMPBPOIFDAF_Scene.PMKOFEIONEG saveScene = LDEGEHAEALK.PNLOINMCCKH_Scene.OPIBAPEGCLA[i];
							res += saveScene.DMNIMMGGJJJ_Leaf;
						}
					}
					return res;
				}
			case 34: // 0x22
				{
					HighScoreRating hs = new HighScoreRating();
					hs.CalcUtaRate(null, false);
					return hs.GetUtaRateTotal();
				}
			case 40: // 0x28
			case 41: // 0x29
			case 42: // 0x2a
			case 43: // 0x2b
			case 44: // 0x2c
			case 45: // 0x2d
			case 46: // 0x2e
			case 47: // 0x2f
			case 48: // 0x30
			case 49: // 0x31
			case 50: // 0x32
			case 51: // 0x33
				return LDEGEHAEALK.GOACJBOCLHH_Quest.GPMKFMFEKLN_NormalQuests[KOGBMDOONFA.PPFNGGCBJKC - 1].EALOBDHOCHP_Stat > 1 ? 1 : 0;
			case 52: // 0x34
				{
					int res = 0;
					for (int i = 0; i < LDEGEHAEALK.GOACJBOCLHH_Quest.GPMKFMFEKLN_NormalQuests.Count; i++)
					{
						NFPHOINMHKN_QuestInfo dbQuest = LDEGEHAEALK.GOACJBOCLHH_Quest.GPMKFMFEKLN_NormalQuests[i];
						if (dbQuest.EALOBDHOCHP_Stat != 0)
						{
							CNLPPCFJEID_QuestInfo saveQuest = LKMHPJKIFDN.MHGPMMIDKMM_Quest.GPMKFMFEKLN_NormalQuests[i];
							if (saveQuest.INDDJNMPONH_Type != 0)
							{
								if (saveQuest.INDDJNMPONH_Type != 52)
								{
									res += (dbQuest.EALOBDHOCHP_Stat > 2 && HHMKDAIGMKC_IsDebutMission((LOEGALDKHPL)saveQuest.INDDJNMPONH_Type)) ? 1 : 0;
								}
							}
						}
					}
					return res;
				}
			case 53: // 0x35
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.KNCLIEBAPJD_Cosu;
			case 54: // 0x36
				if (questValue > 4)
					return 0;
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.GKOAPFJFKEJ_VOpC[questValue];
			case 55: // 0x37
				if (questValue > 10)
					return 0;
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.LOOAKNLDONN_DOpC[questValue - 1];
			case 56: // 0x38
				if(KDHGBOOECKC.HHCJCDFCLOB != null)
				{
					return BIFNGFAIEIL.HHCJCDFCLOB.EEGOJOFABAF(KDHGBOOECKC.HHCJCDFCLOB.EKODBMNLMKA(), questValue) ? 1 : 0;
				}
				return 0;
			case 57: //0x39
				return LDEGEHAEALK.DAEJHMCMFJD_Offer.MLBBKNLPBBD_HasShowTuto((BOPFPIHGJMD.PDLKAKEABDP)questValue) ? 1 : 0;
			case 58: //0x3a
				return LDEGEHAEALK.BEKHNNCGIEL_Costume.MLBBKNLPBBD_IsTutoDone(questValue) ? 1 : 0;
			case 59: //0x3b
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.BJDKMJFCOOM_LCnt;
			case 74: //0x4a
				return LDEGEHAEALK.KCCLEHLLOFG_Common.ADKJDHPEAJH(GPFlagConstant.ID.IsDecolture) ? 1 : 0;
			case 75: //0x4b
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.DHNOLFBEHKN_Dcshp;
			case 76: //0x4c
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.NALPJPKDNGH_Dp;
			case 77: //0x4d
				return LDEGEHAEALK.KCCLEHLLOFG_Common.ADKJDHPEAJH(GPFlagConstant.ID.IsValkyrieUpgrade) ? 1 : 0;
			case 78: //0x4e
				return LDEGEHAEALK.OEKEIGFAIGN_Counter.BDLNMOIOMHK_Total.MJBCBJDMODC_Valu;
			case 79: //0x4f
				{
					if (questValue > 0)
					{
						if (questValue <= LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList.Count)
						{
							return LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[questValue - 1].MMCEMJILMJI_EvSoLevel;
						}
					}
					int res = 0;
					for (int i = 0; i < LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList.Count; i++)
					{
						res = Mathf.Max(res, LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[i].MMCEMJILMJI_EvSoLevel);
					}
					return res;
				}
			case 80: //0x50
				{
					if (questValue > 0)
					{
						if (questValue <= LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList.Count)
						{
							return LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[questValue - 1].HDPANGMKKCP_EvVoLevel;
						}
					}
					int res = 0;
					for (int i = 0; i < LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList.Count; i++)
					{
						res = Mathf.Max(res, LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[i].HDPANGMKKCP_EvVoLevel);
					}
					return res;
				}
			case 81: //0x51
				{
					if (questValue > 0)
					{
						if (questValue <= LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList.Count)
						{
							return LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[questValue - 1].FFMLBEEBHDD_EvChLevel;
						}
					}
					int res = 0;
					for (int i = 0; i < LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList.Count; i++)
					{
						res = Mathf.Max(res, LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[i].FFMLBEEBHDD_EvChLevel);
					}
					return res;
				}
		}
	}

	//// RVA: 0x9F4088 Offset: 0x9F4088 VA: 0x9F4088
	public static BKANGIKIEML.NODKLJHEAJB HNHNHHCBLDE(LOEGALDKHPL INDDJNMPONH, int CHOFDPDFPDC)
	{
		switch(INDDJNMPONH)
		{
			case LOEGALDKHPL.APCJDBPNMLN/*1*/:
			case LOEGALDKHPL.JDBOFJKBJNK/*2*/:
			case LOEGALDKHPL.OCGOGBEIHPD/*3*/:
			case LOEGALDKHPL.FCNKHKLIIGH/*5*/:
			case LOEGALDKHPL.GIEOJGGBODI/*8*/:
			case LOEGALDKHPL.LOGACAKHGBL/*10*/:
			case LOEGALDKHPL.HPNKPGICCMK/*0xb*/:
			case LOEGALDKHPL.OMEOCCEFCOB/*0xc*/:
			case LOEGALDKHPL.JHEMKMOJBDO/*0xd*/:
			case LOEGALDKHPL.GCMANDIOBFN/*0xe*/:
			case LOEGALDKHPL.MMOGNIPPMDO/*0xf*/:
			case LOEGALDKHPL.DGILGEFLNCF/*0x12*/:
			case LOEGALDKHPL.FJPCGKGPKPE/*0x15*/:
			case LOEGALDKHPL.NKKFJIPJKAO/*0x16*/:
			case LOEGALDKHPL.OGCMIONDMHB/*0x17*/:
			case LOEGALDKHPL.OKEIMJEMKKJ/*0x1b*/:
			case LOEGALDKHPL.BHINHMNCMKC/*0x1d*/:
			case LOEGALDKHPL.IDLHNACLCLG/*0x1e*/:
			case LOEGALDKHPL.CJKGEAFKKFL/*0x22*/:
			case LOEGALDKHPL.BDJBKMFEHHC/*0x28*/:
			case LOEGALDKHPL.DDGKOJFPGFF/*0x31*/:
			case LOEGALDKHPL.JCHPMNHJPKG/*0x39*/:
			case LOEGALDKHPL.JHMKDDGIGAA/*0x3f*/:
			case LOEGALDKHPL.MEMMJNAKOHB/*0x40*/:
			case LOEGALDKHPL.MLMDDOJOPFC/*0x44*/:
			case LOEGALDKHPL.ADDCIMFHNAE/*0x45*/:
			case LOEGALDKHPL.CFDPIBHFFPD/*0x4a*/:
			case LOEGALDKHPL.NCOHGNCGFJC/*0x4d*/:
				return BKANGIKIEML.NODKLJHEAJB.MGJDKBFHDML_5/*5*/;
			case LOEGALDKHPL.HCKOEGLNAJH/*4*/:
			case LOEGALDKHPL.IDAIIJEMNMP_47/*0x2f*/:
				return BKANGIKIEML.NODKLJHEAJB.DOEHLCLBCNN_1/*1*/;
			default:
				return BKANGIKIEML.NODKLJHEAJB.HJNNKCMLGFL/*0*/;
			case LOEGALDKHPL.NOMJEIEDKML/*7*/:
			case LOEGALDKHPL.LBKOGDGCFCM/*0x29*/:
				return BKANGIKIEML.NODKLJHEAJB.PAAIHBHJJMM_3/*3*/;
			case LOEGALDKHPL.ABDCDIGADHD/*9*/:
				if (CHOFDPDFPDC == 0 || CHOFDPDFPDC - 1 > 4)
					return BKANGIKIEML.NODKLJHEAJB.HJNNKCMLGFL/*0*/;
				return new BKANGIKIEML.NODKLJHEAJB[5] { BKANGIKIEML.NODKLJHEAJB.GONENLHJLCJ_9/*9*/
					, BKANGIKIEML.NODKLJHEAJB.MLINGAKKDEP_8/*8*/
					, BKANGIKIEML.NODKLJHEAJB.OEFNIAKHGKD_7/*7*/
					, BKANGIKIEML.NODKLJHEAJB.HBIPNFMLLBF_6/*6*/
					, BKANGIKIEML.NODKLJHEAJB.BBAEIHMIFFI_11/*0xb*/ }[CHOFDPDFPDC - 1];
			case LOEGALDKHPL.CHPEIDMDNFP/*0x10*/:
			case LOEGALDKHPL.ANALBHDNGKP/*0x52*/:
			case LOEGALDKHPL.LMFBIGPJMFM/*0x58*/:
				return BKANGIKIEML.NODKLJHEAJB.DFEBFNNJMBM_32/*0x20*/;
			case LOEGALDKHPL.ECOEJFBAABC/*0x11*/:
			case LOEGALDKHPL.BFIIIGLDKNN/*0x21*/:
			case LOEGALDKHPL.MCBICLJIJMK/*0x2a*/:
			case LOEGALDKHPL.BHJDMGFAPLG/*0x3e*/:
			case LOEGALDKHPL.PAGIHFIMLCK/*0x59*/:
				return BKANGIKIEML.NODKLJHEAJB.ADNIADMMBPM_21/*0x15*/;
			case LOEGALDKHPL.GKHJKFJFAHO/*0x14*/:
			case LOEGALDKHPL.NEIJFCOANMA_50/*0x32*/:
			case LOEGALDKHPL.HIFAMABBNIE/*0x41*/:
				return BKANGIKIEML.NODKLJHEAJB.EKHDECEEFFJ_4/*4*/;
			case LOEGALDKHPL.OLPLKIAHMOG/*0x18*/:
				return BKANGIKIEML.NODKLJHEAJB.IJMFEGLNDFI_30/*0x1e*/;
			case LOEGALDKHPL.LAFFLNEDNDO/*0x19*/:
				return BKANGIKIEML.NODKLJHEAJB.KKFFEJEKFEG/*0x1d*/;
			case LOEGALDKHPL.HDJGNKOIMOH/*0x1a*/:
				return BKANGIKIEML.NODKLJHEAJB.GFCAMHABJIC_22/*0x16*/;
			case LOEGALDKHPL.NDHANBGPBBP/*0x1c*/:
			case LOEGALDKHPL.PEPILDAEIEL/*0x2d*/:
			case LOEGALDKHPL.FMGMIOKOPKP/*0x38*/:
				return BKANGIKIEML.NODKLJHEAJB.HGOGFPOCKFA_31/*0x1f*/;
			case LOEGALDKHPL.DBAKKHLLCNC/*0x1f*/:
			case LOEGALDKHPL.LANICCFBKAI/*0x4b*/:
			case LOEGALDKHPL.LHBGGMLDOHH/*0x57*/:
				return BKANGIKIEML.NODKLJHEAJB.LJILBHPMPOG_34/*0x22*/;
			case LOEGALDKHPL.FMOCAEEMHFJ/*0x2b*/:
				if (CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.KCCLEHLLOFG_Common.KIECDDFNCAN_Level > 2)
					return BKANGIKIEML.NODKLJHEAJB.PAAIHBHJJMM_3/*3*/;
				return BKANGIKIEML.NODKLJHEAJB.MGJDKBFHDML_5/*5*/;
			case LOEGALDKHPL.GNLPMEDLIJJ/*0x2c*/:
			case LOEGALDKHPL.AFLMHBMBNBO/*0x30*/:
				return BKANGIKIEML.NODKLJHEAJB.OBBOJKJAHIE_20/*20*/;
			case LOEGALDKHPL.PBKOKCHKGGL/*0x2e*/:
				return BKANGIKIEML.NODKLJHEAJB.ICAPJDDJIEA_23/*0x17*/;
			case LOEGALDKHPL.NEMNEDBLJEM/*0x33*/:
				DEKKMGAFJCG_Diva.MNNLOBDPCCH_DivaInfo diva = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[0];
				if (diva.CPGFPEDMDEH_Have != 0)
				{
					if(diva.BEEAIAAJOHD_CostumeId != 2)
					{
						return BKANGIKIEML.NODKLJHEAJB.KBHGPMNGALJ_33/*33*/;
					}
					AMCGONHBGGF unit = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.MLAFAACKKBG_Unit.FJDDNKGHPHN_GetDefault().FDBOPFEOENF_MainDivas[0];
					if (unit.DIPKCALNIII_Id == 1)
						return BKANGIKIEML.NODKLJHEAJB.MGJDKBFHDML_5/*5*/;
				}
				return BKANGIKIEML.NODKLJHEAJB.OBBOJKJAHIE_20/*20*/;
			case LOEGALDKHPL.LOKMFLKHIPG/*0x35*/:
			case LOEGALDKHPL.HDHEKLONOGD/*0x46*/:
				return BKANGIKIEML.NODKLJHEAJB.LEHHJINPFHA_37/*0x25*/;
			case LOEGALDKHPL.NMBILGNHKFC/*0x36*/:
			case LOEGALDKHPL.KKIEICKBEEF/*0x37*/:
			case LOEGALDKHPL.AJLNMHBKMLE/*0x3a*/:
				return BKANGIKIEML.NODKLJHEAJB.OCNIBCBBLAA_36/*0x24*/;
			case LOEGALDKHPL.OECPMGEPMHC/*0x3c*/:
				return BKANGIKIEML.NODKLJHEAJB.FNILHIFGOCE_15/*0xf*/;
			case LOEGALDKHPL.CKENLOAPCEC/*0x3d*/:
				return BKANGIKIEML.NODKLJHEAJB.NHIOLMNADIO_35/*0x23*/;
			case LOEGALDKHPL.CKOOMMACNKA/*0x42*/:
			case LOEGALDKHPL.DOIFAGIGLEE/*0x43*/:
				return BKANGIKIEML.NODKLJHEAJB.HHFLHPFJMPN_39/*0x27*/;
			case LOEGALDKHPL.MOKJAMEPIMK/*0x48*/:
				return BKANGIKIEML.NODKLJHEAJB.OBDLOMGHHED_12/*0xc*/;
			case LOEGALDKHPL.CHANJDIDJOH/*0x49*/:
				return BKANGIKIEML.NODKLJHEAJB.LINKBPIPHAK_17/*0x11*/;
			case LOEGALDKHPL.MENBLIKPJMC/*0x4e*/:
				return BKANGIKIEML.NODKLJHEAJB.JDCENDOKKIE_41/*0x29*/;
			case LOEGALDKHPL.JAMJLBCKHHB/*0x4f*/:
			case LOEGALDKHPL.BFHKNEJHFLH/*0x50*/:
			case LOEGALDKHPL.HOHJCNDMDCD/*0x51*/:
			case LOEGALDKHPL.AIKOJFKHPMO/*0x53*/:
			case LOEGALDKHPL.EMKEFFFNBGG/*0x56*/:
				return BKANGIKIEML.NODKLJHEAJB.AGCMIOFBFMG_10/*10*/;
			case LOEGALDKHPL.FJCFIBPGLDG/*0x54*/:
				return BKANGIKIEML.NODKLJHEAJB.KJAFDMGNBPO_43/*0x2b*/;
			case LOEGALDKHPL.DNLGEBHGKGL/*0x55*/:
				return BKANGIKIEML.NODKLJHEAJB.CLJHDIKFECG_42/*0x2a*/;
		}
	}

	//// RVA: 0x9F4608 Offset: 0x9F4608 VA: 0x9F4608
	public static BKANGIKIEML.NODKLJHEAJB ODEHLBNBPPE(IKDICBBFBMI_EventBase FBFNJMKPBBA)
	{
		if(FBFNJMKPBBA.HIDHLFCBIDE_EventType >= OHCAABOMEOF.KGOGMKMBCPP_EventType.ENPJADLIFAB_EventSp && FBFNJMKPBBA.HIDHLFCBIDE_EventType < OHCAABOMEOF.KGOGMKMBCPP_EventType.DMPMKBCPHMA_9/*9*/)
		{
			TodoLogger.LogError(0, "Event");
		}
		if ((int)FBFNJMKPBBA.HIDHLFCBIDE_EventType - 1 > 13)
			return 0;
		return new BKANGIKIEML.NODKLJHEAJB[14]
		{
			BKANGIKIEML.NODKLJHEAJB.KIBGKANOLLP_25/*25*/,
			BKANGIKIEML.NODKLJHEAJB.DFDKJPOHGAD_26/*26*/,
			BKANGIKIEML.NODKLJHEAJB.PHKLLDPCDBO_24/*24*/,
			BKANGIKIEML.NODKLJHEAJB.HJNNKCMLGFL/*0*/,
			BKANGIKIEML.NODKLJHEAJB.HJNNKCMLGFL/*0*/,
			BKANGIKIEML.NODKLJHEAJB.PHKLLDPCDBO_24/*24*/,
			BKANGIKIEML.NODKLJHEAJB.HJNNKCMLGFL/*0*/,
			BKANGIKIEML.NODKLJHEAJB.HJNNKCMLGFL/*0*/,
			BKANGIKIEML.NODKLJHEAJB.HJNNKCMLGFL/*0*/,
			BKANGIKIEML.NODKLJHEAJB.FNILHIFGOCE_15/*15*/,
			BKANGIKIEML.NODKLJHEAJB.JBMMAOHHEJH_27/*27*/,
			BKANGIKIEML.NODKLJHEAJB.BPNDHDHHKGE_38/*38*/,
			BKANGIKIEML.NODKLJHEAJB.HJNNKCMLGFL/*0*/,
			BKANGIKIEML.NODKLJHEAJB.CJCABIKGFGG_28/*28*/
		}[(int)FBFNJMKPBBA.HIDHLFCBIDE_EventType - 1];
	}

	//// RVA: 0x9F474C Offset: 0x9F474C VA: 0x9F474C
	public static BKANGIKIEML.NODKLJHEAJB HNHNHHCBLDE(AKIIJBEJOEP NDFIEMPPMLF, IKDICBBFBMI_EventBase FBFNJMKPBBA)
	{
		if (NDFIEMPPMLF == null || FBFNJMKPBBA == null)
			return 0;
		BKANGIKIEML.NODKLJHEAJB res = BKANGIKIEML.NODKLJHEAJB.PAAIHBHJJMM_3/*3*/;
		switch (NDFIEMPPMLF.HDAMBOOCIAA_ClearType)
		{
			case 6:
			case 14:
			case 15:
			case 16:
			case 17:
			case 23:
			case 27:
			case 28:
			case 29:
			case 30:
			case 34:
			case 35:
			case 36:
			case 37:
			case 41:
			case 42:
			case 43:
			case 44:
			case 45:
				return ODEHLBNBPPE(FBFNJMKPBBA);
			default:
				if (NDFIEMPPMLF.HMOJCCPIPBP_TargetMusicType < 1 || NDFIEMPPMLF.HMOJCCPIPBP_TargetMusicType > 6)
					return BKANGIKIEML.NODKLJHEAJB.MGJDKBFHDML_5/*5*/;
				res = BKANGIKIEML.NODKLJHEAJB.GAPJLFLINME_16/*16*/;
				switch(NDFIEMPPMLF.HMOJCCPIPBP_TargetMusicType)
				{
					case 1:
						if (FBFNJMKPBBA.HIDHLFCBIDE_EventType == OHCAABOMEOF.KGOGMKMBCPP_EventType.DAMDPLEBNCB_AprilFool)
							return BKANGIKIEML.NODKLJHEAJB.FNILHIFGOCE_15/*15*/;
						int EHDDADDKMFI = NDFIEMPPMLF.HBJJCDIMOPO_TargetMusicConditionId;
						int idx = JEPBIIJDGEF_EventInfo.HHCJCDFCLOB.HEACCHAKMFG(FBFNJMKPBBA).FindIndex((int GHPLINIACBB) =>
						{
							//0x9F61A4
							return EHDDADDKMFI == GHPLINIACBB;
						});
						if(idx < 0)
							return BKANGIKIEML.NODKLJHEAJB.FNILHIFGOCE_15/*15*/;
						break;
					case 2:
						return BKANGIKIEML.NODKLJHEAJB.ANBJBLLMHMB_18/*18*/;
					case 3:
						if (NDFIEMPPMLF.HBJJCDIMOPO_TargetMusicConditionId > 0 && NDFIEMPPMLF.HBJJCDIMOPO_TargetMusicConditionId < 6)
							return new BKANGIKIEML.NODKLJHEAJB[5] {
								BKANGIKIEML.NODKLJHEAJB.GONENLHJLCJ_9/*9*/,
								BKANGIKIEML.NODKLJHEAJB.MLINGAKKDEP_8/*8*/, 
								BKANGIKIEML.NODKLJHEAJB.OEFNIAKHGKD_7/*7*/,
								BKANGIKIEML.NODKLJHEAJB.HBIPNFMLLBF_6/*6*/,
								BKANGIKIEML.NODKLJHEAJB.BBAEIHMIFFI_11/*11*/
							}[NDFIEMPPMLF.HBJJCDIMOPO_TargetMusicConditionId - 1];
						break;
					case 4:
						break;
					case 5:
						List<int> l = JEPBIIJDGEF_EventInfo.HHCJCDFCLOB.HEACCHAKMFG(FBFNJMKPBBA);
						for(int i = 0; i < l.Count; i++)
						{
							if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.IBPAFKKEKNK_Music.NOBCLJIAMLC_GetFreeMusicData(l[i]).DLAEJOBELBH_MusicId == NDFIEMPPMLF.HBJJCDIMOPO_TargetMusicConditionId)
							{
								return ODEHLBNBPPE(FBFNJMKPBBA);
							}
						}
						return BKANGIKIEML.NODKLJHEAJB.MGJDKBFHDML_5/*5*/;
					case 6:
						return res;
				}
				return ODEHLBNBPPE(FBFNJMKPBBA);
			case 18:
				break;
			case 19:
			case 20:
				res = BKANGIKIEML.NODKLJHEAJB.HJNNKCMLGFL/*0*/;
				break;
			case 21:
			case 26:
				res = BKANGIKIEML.NODKLJHEAJB.NHIOLMNADIO_35/*35*/;
				break;
			case 31:
				res = BKANGIKIEML.NODKLJHEAJB.DFEBFNNJMBM_32/*32*/;
				break;
			case 32:
				res = BKANGIKIEML.NODKLJHEAJB.PKHEABDDHKB_40/*40*/;
				break;
			case 49:
				res = BKANGIKIEML.NODKLJHEAJB.GFLALMCKGAH_19/*19*/;
				break;
		}
		return res;
	}

	//// RVA: 0x9F3E6C Offset: 0x9F3E6C VA: 0x9F3E6C
	public static int KPEDEPGGMEC_GetDailyQuestStatus(int CMEJFJFOIIJ, OKGLGHCBCJP_Database LKMHPJKIFDN, BBHNACPENDM_ServerSaveData LDEGEHAEALK)
	{
		CNLPPCFJEID_QuestInfo dbQuest = LKMHPJKIFDN.MHGPMMIDKMM_Quest.BEGCHDHHEKC_DailyQuests[CMEJFJFOIIJ - 1];
		NFPHOINMHKN_QuestInfo saveQuest = LDEGEHAEALK.GOACJBOCLHH_Quest.BEGCHDHHEKC_DailyQuests[CMEJFJFOIIJ - 1];
		if (dbQuest.INDDJNMPONH_Type == 0)
			return 0;
		if(saveQuest.EALOBDHOCHP_Stat != 1)
		{
			return saveQuest.EALOBDHOCHP_Stat;
		}
		long v = DCLKMNGMIKC_GetQuestCurrentValue(dbQuest, LKMHPJKIFDN, LDEGEHAEALK);
		return v < dbQuest.FCDKJAKLGMB ? 1 : 2;
	}

	//// RVA: 0x9F4D28 Offset: 0x9F4D28 VA: 0x9F4D28
	public static int OBOJKHIJBGL_GetNormalQuestStatus(int CMEJFJFOIIJ, OKGLGHCBCJP_Database LKMHPJKIFDN, BBHNACPENDM_ServerSaveData LDEGEHAEALK, bool KDEBJBCDFOL = false)
	{
		CNLPPCFJEID_QuestInfo dbQuest = LKMHPJKIFDN.MHGPMMIDKMM_Quest.GPMKFMFEKLN_NormalQuests[CMEJFJFOIIJ - 1];
		NFPHOINMHKN_QuestInfo saveQuest = LDEGEHAEALK.GOACJBOCLHH_Quest.GPMKFMFEKLN_NormalQuests[CMEJFJFOIIJ - 1];
		int c = 0;
		if(dbQuest.INDDJNMPONH_Type != 0)
		{
			int a = 0;
			if (saveQuest.EALOBDHOCHP_Stat > 1)
				return saveQuest.EALOBDHOCHP_Stat;
			if(!KDEBJBCDFOL)
			{
				if(dbQuest.HHIBBHFHENH_LinkQuestId != 0)
				{
					CNLPPCFJEID_QuestInfo q2 = LKMHPJKIFDN.MHGPMMIDKMM_Quest.GPMKFMFEKLN_NormalQuests[dbQuest.HHIBBHFHENH_LinkQuestId - 1];
					long t = DCLKMNGMIKC_GetQuestCurrentValue(q2, LKMHPJKIFDN, LDEGEHAEALK);
					a = 2;
					if(t < q2.FCDKJAKLGMB)
					{
						NFPHOINMHKN_QuestInfo s2 = LDEGEHAEALK.GOACJBOCLHH_Quest.GPMKFMFEKLN_NormalQuests[dbQuest.HHIBBHFHENH_LinkQuestId - 1];
						a = s2.EALOBDHOCHP_Stat;
					}
				}
			}
			c = 2;
			long t2 = DCLKMNGMIKC_GetQuestCurrentValue(dbQuest, LKMHPJKIFDN, LDEGEHAEALK);
			if(t2 < dbQuest.FCDKJAKLGMB)
			{
				if(dbQuest.EKANGPODCEP != 0)
				{
					IKDICBBFBMI_EventBase ev = JEPBIIJDGEF_EventInfo.HHCJCDFCLOB.OIKOHACJPCB(dbQuest.EKANGPODCEP);
					if (ev == null)
						return 0;
					if (ev.NGOFCFJHOMI_Status > KGCNCBOKCBA.GNENJEHKMHD.MEAJLPAHINL/*5*/)
						return 0;
				}
				return (dbQuest.HHIBBHFHENH_LinkQuestId == 0 || a > 1) ? 1 : 0;
			}
		}
		return c;
	}

	// RVA: 0x9F5228 Offset: 0x9F5228 VA: 0x9F5228
	public static void MOFIPNGNNPA(LOEGALDKHPL INDDJNMPONH, OKGLGHCBCJP_Database LKMHPJKIFDN, BBHNACPENDM_ServerSaveData LDEGEHAEALK, int EALOBDHOCHP, bool FBBNPFFEJBN = false)
	{
		if((int)INDDJNMPONH > 39)
		{
			if((int)INDDJNMPONH < 53)
			{
				if(!DDJGDCHMCBN(INDDJNMPONH))
				{
					CNLPPCFJEID_QuestInfo c = LKMHPJKIFDN.MHGPMMIDKMM_Quest.GPMKFMFEKLN_NormalQuests.Find((CNLPPCFJEID_QuestInfo GHPLINIACBB) =>
					{
						//0x9F60D8
						return (int)INDDJNMPONH == GHPLINIACBB.INDDJNMPONH_Type;
					});
					if(c != null)
					{
						NFPHOINMHKN_QuestInfo n = LDEGEHAEALK.GOACJBOCLHH_Quest.GPMKFMFEKLN_NormalQuests[c.PPFNGGCBJKC - 1];
						if(!FBBNPFFEJBN)
						{
							if (EALOBDHOCHP <= n.EALOBDHOCHP_Stat)
								return;
						}
						n.EALOBDHOCHP_Stat = EALOBDHOCHP;
					}
				}
			}
		}
	}

	//// RVA: 0x9F54E8 Offset: 0x9F54E8 VA: 0x9F54E8
	public static void MOFIPNGNNPA(LOEGALDKHPL INDDJNMPONH, int EALOBDHOCHP = 2, bool FBBNPFFEJBN = false)
	{
		if(CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave != null && IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database != null)
		{
			MOFIPNGNNPA(INDDJNMPONH, IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database, CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave, EALOBDHOCHP, FBBNPFFEJBN);
		}
	}

	//// RVA: 0x9F5634 Offset: 0x9F5634 VA: 0x9F5634
	public static int BFLCENAJOEN(LOEGALDKHPL INDDJNMPONH)
	{
		CNLPPCFJEID_QuestInfo c = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.MHGPMMIDKMM_Quest.GPMKFMFEKLN_NormalQuests.Find((CNLPPCFJEID_QuestInfo GHPLINIACBB) =>
		{
			//0x9F611C
			return GHPLINIACBB.INDDJNMPONH_Type == (int)INDDJNMPONH;
		});
		if(c != null)
		{
			return CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.GOACJBOCLHH_Quest.GPMKFMFEKLN_NormalQuests[c.PPFNGGCBJKC - 1].EALOBDHOCHP_Stat;
		}
		return 0;
	}

	//// RVA: 0x9F58BC Offset: 0x9F58BC VA: 0x9F58BC
	public static void HECOAKHIAKP(LOEGALDKHPL INDDJNMPONH, int EALOBDHOCHP = 2, bool FBBNPFFEJBN = false)
	{
		CNLPPCFJEID_QuestInfo quest = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.MHGPMMIDKMM_Quest.GPMKFMFEKLN_NormalQuests.Find((CNLPPCFJEID_QuestInfo GHPLINIACBB) =>
		{
			//0x9F6160
			return GHPLINIACBB.INDDJNMPONH_Type == (int)INDDJNMPONH;
		});
		if(quest != null)
		{
			NFPHOINMHKN_QuestInfo q = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.GOACJBOCLHH_Quest.GPMKFMFEKLN_NormalQuests[quest.PPFNGGCBJKC - 1];
			if(!FBBNPFFEJBN)
			{
				if (EALOBDHOCHP <= q.EALOBDHOCHP_Stat)
					return;
			}
			q.EALOBDHOCHP_Stat = EALOBDHOCHP;
		}
	}

	//// RVA: 0x9F5B78 Offset: 0x9F5B78 VA: 0x9F5B78
	public static bool FJFPHHEFMIB_IsSnsMission(CNLPPCFJEID_QuestInfo MABBBOEAPAA)
	{
		if (MABBBOEAPAA.INDDJNMPONH_Type != 28)
			return MABBBOEAPAA.INDDJNMPONH_Type == 56;
		return true;
	}

	//// RVA: 0x9F5BC0 Offset: 0x9F5BC0 VA: 0x9F5BC0
	public static bool OHFOAIDPDEM(int MALFHCHNEFN, out int CMEJFJFOIIJ)
	{
		int a = BIFNGFAIEIL.HHCJCDFCLOB.CEDPKMOHANM(MALFHCHNEFN);
		List<CNLPPCFJEID_QuestInfo> dbQuests = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.MHGPMMIDKMM_Quest.GPMKFMFEKLN_NormalQuests;
		List<NFPHOINMHKN_QuestInfo> saveQuests = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.GOACJBOCLHH_Quest.GPMKFMFEKLN_NormalQuests;
		for(int i = 0; i < dbQuests.Count; i++)
		{
			if(FJFPHHEFMIB_IsSnsMission(dbQuests[i]))
			{
				if(dbQuests[i].CHOFDPDFPDC_ConfigValue == MALFHCHNEFN)
				{
					if(saveQuests[i].EALOBDHOCHP_Stat < 2)
					{
						if (dbQuests[i].FCDKJAKLGMB <= a)
						{
							CMEJFJFOIIJ = i;
							return true;
						}
						CMEJFJFOIIJ = 0;
						return false;
					}
				}
			}
		}
		CMEJFJFOIIJ = 0;
		return false;
	}

	//// RVA: 0x9F5F10 Offset: 0x9F5F10 VA: 0x9F5F10
	public static void CIEDCPPINCB(int CMEJFJFOIIJ, int EALOBDHOCHP = 2)
	{
		CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.GOACJBOCLHH_Quest.GPMKFMFEKLN_NormalQuests[CMEJFJFOIIJ - 1].EALOBDHOCHP_Stat = EALOBDHOCHP;
	}
}
