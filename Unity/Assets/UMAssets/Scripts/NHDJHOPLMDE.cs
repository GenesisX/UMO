
using System.Collections.Generic;
using XeApp.Game.Common;
using XeSys;

public class NHDJHOPLMDE
{
	private int FBGGEFFJJHB; // 0x8
	private long BBEGLBMOBOF; // 0x10
	private int IFGMKBKBFJI; // 0x18
	private int HCFNIMFOOPF; // 0x1C
	private int FMFMCBKHIMK; // 0x20
	private int NFCALENBIBL; // 0x24
	private int ILHCNHLCELO_SkillLevelCrypted; // 0x28
	private int LIELJCECBNF; // 0x2C
	private int ICLBAMBDKNI; // 0x30
	private int AMFILEGKAML; // 0x34
	private int KIDNEIEHOMN; // 0x38
	private int CDDLNKAPCFB; // 0x3C
	private int EOBFILHOOOD; // 0x40
	private NNJFKLBPBNK_SecureString FINCFIGKHPA = new NNJFKLBPBNK_SecureString(); // 0x44
	private NNJFKLBPBNK_SecureString PMKLGDOEFNM = new NNJFKLBPBNK_SecureString(); // 0x48

	public int GPPEFLKGGGJ { get { return IFGMKBKBFJI ^ FBGGEFFJJHB; } set { IFGMKBKBFJI = value ^ FBGGEFFJJHB; } } //0x18903D0 PCDKIHHDCHI 0x18903E0 LANEIFNCIAA
	public int ENMAEBJGEKL { get { return HCFNIMFOOPF ^ FBGGEFFJJHB; } set { HCFNIMFOOPF = value ^ FBGGEFFJJHB; } } //0x18903F0 FHIMMFAEDIP 0x1890400 CPEAMPGOMCB
	public int BHGDALFOHBL { get { return FMFMCBKHIMK ^ FBGGEFFJJHB; } set { FMFMCBKHIMK = value ^ FBGGEFFJJHB; } } //0x1890410 BBKOELBDLNH 0x1890420 FHKMBENCBKA
	public int CIEOBFIIPLD { get { return NFCALENBIBL ^ FBGGEFFJJHB; } set { NFCALENBIBL = value ^ FBGGEFFJJHB; } } //0x1890430 OGKGFGMKPKB 0x1890440 JOOMBHHPHBD
	public int NBLBJCLIDNN_SkillLevel { get { return ILHCNHLCELO_SkillLevelCrypted ^ FBGGEFFJJHB; } set { ILHCNHLCELO_SkillLevelCrypted = value ^ FBGGEFFJJHB; } } //0x1890450 EKBBCGCNPMH 0x1890460 OJCHLBPANDN
	public int MMODCBJCDMA { get { return LIELJCECBNF ^ FBGGEFFJJHB; } set { LIELJCECBNF = value ^ FBGGEFFJJHB; } } //0x1890470 IGCKEGMPEHD 0x1890480 MNGLKCNIHNO
	public int KINFGHHNFCF_Atk { get { return KIDNEIEHOMN ^ FBGGEFFJJHB; } set { KIDNEIEHOMN = value ^ FBGGEFFJJHB; } } //0x1890490 BNLKPIIJCDF 0x18904A0 PKEDNGJNJNC
	public int NONBCCLGBAO_Hit { get { return CDDLNKAPCFB ^ FBGGEFFJJHB; } set { CDDLNKAPCFB = value ^ FBGGEFFJJHB; } } //0x18904B0 AEJBEGKBPCO 0x18904C0 JPIBPFANBNG
	public int EHMLAAHLNMN { get { return EOBFILHOOOD ^ FBGGEFFJJHB; } set { EOBFILHOOOD = value ^ FBGGEFFJJHB; } } //0x18904D0 MGFAGEDCCHM 0x18904E0 HBNAGHBGHMH
	public string OPFGFINHFCE_SkillName { get { return FINCFIGKHPA.DNJEJEANJGL_Value; } set { FINCFIGKHPA.DNJEJEANJGL_Value = value; } } //0x18904F0 DKJOHDGOIJE 0x189051C MJAMIGECMMF
	public string KLMPFGOCBHC_SkillDesc { get { return PMKLGDOEFNM.DNJEJEANJGL_Value; } set { PMKLGDOEFNM.DNJEJEANJGL_Value = value; } } //0x1890550 BGJNIABLBDB 0x189057C HFBJLALGKOM
	public EPIFHEDDJAE.JFEIHHBGFPF_AbilityCondition CHOFDPDFPDC { get { return (EPIFHEDDJAE.JFEIHHBGFPF_AbilityCondition)(ICLBAMBDKNI ^ FBGGEFFJJHB); } set { ICLBAMBDKNI = (int)value ^ FBGGEFFJJHB; } } //0x18905B0 IBCDKHDLOKG 0x18905C0 ICHJGBKDCGM
	public EPIFHEDDJAE.NGEDJNHECKN EICJJFIBCEF { get { return (EPIFHEDDJAE.NGEDJNHECKN)(AMFILEGKAML ^ FBGGEFFJJHB); } set { AMFILEGKAML = (int)value ^ FBGGEFFJJHB; } } //0x18905D0 LLBFBCBNLLA 0x18905E0 AGEJCMNBHJJ

	//// RVA: 0x18905F0 Offset: 0x18905F0 VA: 0x18905F0
	public NHDJHOPLMDE(int LLOBHDMHJIG, int ANAJIAENLNB = 0)
	{
		if(LLOBHDMHJIG > 0)
		{
			if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database != null)
			{
				if(CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave != null)
				{
					JPIANKEOOMB_Valkyrie.KJPIDJOMODA_ValkyrieInfo dbInfo = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.PEOALFEGNDH_Valkyrie.GCINIJEMHFK(LLOBHDMHJIG);
					if (dbInfo != null && dbInfo.PPEGAKEIEGM_Enabled == 2)
					{
						GKFMJAHKEMA_ValSkill.CCPFGNNIBDD info1 = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.DIAEPFPGPEP_ValSkill.MNHBHNIHJJH(dbInfo.BMIJDLBGFNP_SkillId);
						if (info1 != null)
						{
							GKFMJAHKEMA_ValSkill.GBDONNIHJHG info2 = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.DIAEPFPGPEP_ValSkill.OOEFAGKHOCE(info1.KFLIHDFDBOA);
							if(info2 != null)
							{
								GPPEFLKGGGJ = LLOBHDMHJIG;
								ENMAEBJGEKL = dbInfo.BMIJDLBGFNP_SkillId;
								BHGDALFOHBL = info1.KFLIHDFDBOA;
								EICJJFIBCEF = (EPIFHEDDJAE.NGEDJNHECKN)info2.CBDFEJIBAMO;
								CHOFDPDFPDC = (EPIFHEDDJAE.JFEIHHBGFPF_AbilityCondition)info2.ODMJFHDIGLP;
								OPFGFINHFCE_SkillName = MessageManager.Instance.GetBank("master").GetMessageByLabel("val_skill_nm_"+ info2.CBDFEJIBAMO.ToString("D4"));
								KLMPFGOCBHC_SkillDesc = MessageManager.Instance.GetBank("master").GetMessageByLabel("val_skill_dsc_" + info1.KFLIHDFDBOA.ToString("D4"));
								NBLBJCLIDNN_SkillLevel = info1.DOOGFEGEKLG;
								int skill_level_max = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.DIAEPFPGPEP_ValSkill.LPJLEHAJADA("skill_level_max", 4);
								if (skill_level_max < NBLBJCLIDNN_SkillLevel)
									NBLBJCLIDNN_SkillLevel = skill_level_max;
								if(ANAJIAENLNB < 1)
								{
									ANAJIAENLNB = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.JJFFBDLIOCF_Valkyrie.OEMMJCLJMGB_GetLevel(GPPEFLKGGGJ);
								}
								CIEOBFIIPLD = NBLBJCLIDNN_SkillLevel;
								if (ANAJIAENLNB <= NBLBJCLIDNN_SkillLevel)
								{
									CIEOBFIIPLD = ANAJIAENLNB;
								}
								int val = MMODCBJCDMA;
								if (CIEOBFIIPLD >= 1)
								{
									MMODCBJCDMA = info2.NBMPBLECFJD(CIEOBFIIPLD - 1);
								}
								if(MMODCBJCDMA > 0)
								{
									List<EPIFHEDDJAE.JAOBCBKBKJJ> l = new List<EPIFHEDDJAE.JAOBCBKBKJJ>();
									l.Add((EPIFHEDDJAE.JAOBCBKBKJJ)info2.PFBDNFPPNEJ);
									l.Add((EPIFHEDDJAE.JAOBCBKBKJJ)info2.GAMEFFJONIJ);
									for(int i = 0; i < l.Count; i++)
									{
										if(l[i] == EPIFHEDDJAE.JAOBCBKBKJJ.FIFJJFPHOEM)
										{
											EHMLAAHLNMN = MMODCBJCDMA;
										}
										else if(l[i] == EPIFHEDDJAE.JAOBCBKBKJJ.JIOPJDJBLFK)
										{
											NONBCCLGBAO_Hit = MMODCBJCDMA;
										}
										else if(l[i] == EPIFHEDDJAE.JAOBCBKBKJJ.FMHLGHDKJBC)
										{
											KINFGHHNFCF_Atk = MMODCBJCDMA;
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	//// RVA: 0x1890C5C Offset: 0x1890C5C VA: 0x1890C5C
	//public void LHPDDGIJKNB() { }

	//// RVA: 0x1890D3C Offset: 0x1890D3C VA: 0x1890D3C
	//public string DMBDNIEEMCB() { }

	//// RVA: 0x1890D88 Offset: 0x1890D88 VA: 0x1890D88
	public bool LAKLFHGMCLI(EPIFHEDDJAE.NGEDJNHECKN CNLDPKNLBND, EPIFHEDDJAE.JFEIHHBGFPF_AbilityCondition OAFPGJLCNFM)
	{
		if (EICJJFIBCEF != CNLDPKNLBND)
			return false;
		if(CNLDPKNLBND == EPIFHEDDJAE.NGEDJNHECKN.FJFMLFPJKNB_2)
		{
			if(CHOFDPDFPDC == EPIFHEDDJAE.JFEIHHBGFPF_AbilityCondition.PPNNBADDNKB_11)
			{
				if(OAFPGJLCNFM > EPIFHEDDJAE.JFEIHHBGFPF_AbilityCondition.FHBJEIEPABF_12)
				{
					return false;
				}
			}
			else if(CHOFDPDFPDC == EPIFHEDDJAE.JFEIHHBGFPF_AbilityCondition.FHBJEIEPABF_12 && OAFPGJLCNFM != EPIFHEDDJAE.JFEIHHBGFPF_AbilityCondition.FHBJEIEPABF_12)
			{
				return false;
			}
		}
		else if(CNLDPKNLBND == EPIFHEDDJAE.NGEDJNHECKN.MGJDKBFHDML && CHOFDPDFPDC != OAFPGJLCNFM)
		{
			return false;
		}
		return CIEOBFIIPLD > 0;
	}

	//// RVA: 0x1890E18 Offset: 0x1890E18 VA: 0x1890E18
	public bool LAKLFHGMCLI(SeriesAttr.Type AIHCEGFANAM)
	{
		bool res = false;
		if(EICJJFIBCEF == EPIFHEDDJAE.NGEDJNHECKN.MGJDKBFHDML/*1*/)
		{
			res = false;
			int v = (int)CHOFDPDFPDC;
			if ((v - 1) > 4)
				v = 0;
			if (v == (int)AIHCEGFANAM && CIEOBFIIPLD > 0)
				res = true;
		}
		return res;
	}
}
