
public class NAKMCMEPAGH
{
	private const int MNHALNODIPI = 99999999;
	private const long AGJGPJKMLPE = 999999999999;
	private const long CKDBIMGJMFC = 999999999999;
	private const long NGMFAGBELEO = 999999999999;
	public int FBGGEFFJJHB; // 0x8
	public int MILCBLJDADN_MusicClear; // 0xC
	public int[] LHOCOEOKFNO_SerieClear = new int[5]; // 0x10
	public int[] PHPPOGOEOAF_DiffClear = new int[5]; // 0x14
	public int[] IAFPEPABGJJ_DiffClear16 = new int[5]; // 0x18
	public int HLNOELCIBPH_Perf; // 0x1C
	public int FILFPNDEINH_Fcb; // 0x20
	public int KOONLNKCIJC_SS; // 0x24
	public int EDLBLCGHECJ_MaxScore; // 0x28
	public long HOHBKPPOLLA_Uc; // 0x30
	public int GACBDCLPOCD_Sdv; // 0x38
	public int IMIEPNOECFD_Vk; // 0x3C
	public int BENEAPDMALA_Mk; // 0x40
	public long PDGJIJOMAKO_Medl; // 0x48
	public int PFOMECFACLL_Shp; // 0x50
	public int DHNOLFBEHKN_Dcshp; // 0x54
	public long NALPJPKDNGH_Dp; // 0x58
	public int KNCLIEBAPJD_Cosu; // 0x60
	public int MJBCBJDMODC_Valu; // 0x64
	public int[] GKOAPFJFKEJ_VOpC = new int[5]; // 0x68
	public int[] LOOAKNLDONN_DOpC = new int[10]; // 0x6C
	public int CCNDOFGDOGF; // 0x70
	public int DAPDDMJNNGG; // 0x74

	public int BJDKMJFCOOM_LCnt { get { return CCNDOFGDOGF ^ FBGGEFFJJHB; } set { CCNDOFGDOGF = value ^ FBGGEFFJJHB; } } //0x17C0578 JKLLJKHDJFM 0x17C0588 OHDMFLKNGDA
	public int BKEKKFPEPBG_LDt { get { return DAPDDMJNNGG ^ FBGGEFFJJHB; } set { DAPDDMJNNGG = value ^ FBGGEFFJJHB; } } //0x17C0598 POIFAKPKGPE 0x17C05A8 KPEDOCAGMJP

	// // RVA: 0x17C05B8 Offset: 0x17C05B8 VA: 0x17C05B8
	public void FBKAPLHEACL_AddMusicClear()
	{
		if (MILCBLJDADN_MusicClear < 99999999)
			MILCBLJDADN_MusicClear++;
	}

	// // RVA: 0x17C05D4 Offset: 0x17C05D4 VA: 0x17C05D4
	public void KGFIAHEEMDN_AddSerieClear(int MGBDCFIKBPM)
	{
		int a = 0;
		if(MGBDCFIKBPM >= 2 && MGBDCFIKBPM < 6)
		{
			a = 1;
			switch(MGBDCFIKBPM)
			{
				case 2:
					break;
				default:
					a = MGBDCFIKBPM - 1;
					break;
			}
		}
		if (LHOCOEOKFNO_SerieClear[a] > 99999998)
			return;
		LHOCOEOKFNO_SerieClear[a]++;
	}

	// // RVA: 0x17C06AC Offset: 0x17C06AC VA: 0x17C06AC
	public void HIEBCILPBGB_AddDiffClear(int AKNELONELJK, bool GIKLNODJKFK = false)
	{
		if(!GIKLNODJKFK)
		{
			if (PHPPOGOEOAF_DiffClear[AKNELONELJK] > 99999998)
				return;
			PHPPOGOEOAF_DiffClear[AKNELONELJK]++;
		}
		else
		{
			if (IAFPEPABGJJ_DiffClear16[AKNELONELJK] > 99999998)
				return;
			IAFPEPABGJJ_DiffClear16[AKNELONELJK]++;
		}
	}

	// // RVA: 0x17C0798 Offset: 0x17C0798 VA: 0x17C0798
	public void PFLCOFBJOED_AddFcb()
	{
		if (FILFPNDEINH_Fcb < 99999999)
			FILFPNDEINH_Fcb++;
	}

	// // RVA: 0x17C07B4 Offset: 0x17C07B4 VA: 0x17C07B4
	public void OLEDHOJJIOH_AddSS()
	{
		if (KOONLNKCIJC_SS < 99999999)
			KOONLNKCIJC_SS++;
	}

	// // RVA: 0x17C07D0 Offset: 0x17C07D0 VA: 0x17C07D0
	public void DHECAFOELPF_SetHighScore(int KNIFCANOHOC)
	{
		if (EDLBLCGHECJ_MaxScore < KNIFCANOHOC)
			EDLBLCGHECJ_MaxScore = KNIFCANOHOC;
	}

	// // RVA: 0x17C07E0 Offset: 0x17C07E0 VA: 0x17C07E0
	public void EJJAPFPJLHP_AddUc(int ACGLMKEBMDL)
	{
		TodoLogger.LogError(TodoLogger.ToCheck, "Find the max value (99999999?)");
		HOHBKPPOLLA_Uc += ACGLMKEBMDL;
	}

	// // RVA: 0x17C0824 Offset: 0x17C0824 VA: 0x17C0824
	public void FNLAFLEEAHC(int IDAEEHPLIIO)
	{
		TodoLogger.LogError(TodoLogger.ToCheck, "Find the max value (99999999?)");
		NALPJPKDNGH_Dp += IDAEEHPLIIO;
	}

	// // RVA: 0x17C0868 Offset: 0x17C0868 VA: 0x17C0868
	// public void MAFAKCMFHEE() { }

	// // RVA: 0x17C0884 Offset: 0x17C0884 VA: 0x17C0884
	public void MOOJGMJFOKK_AddVk()
	{
		if (IMIEPNOECFD_Vk < 99999999)
			IMIEPNOECFD_Vk++;
	}

	// // RVA: 0x17C08A0 Offset: 0x17C08A0 VA: 0x17C08A0
	public void LLKJHBIPCOP_AddMk()
	{
		if (BENEAPDMALA_Mk < 99999999)
			BENEAPDMALA_Mk++;
	}

	// // RVA: 0x17C08BC Offset: 0x17C08BC VA: 0x17C08BC
	public void KPNLMLPFKMJ_AddMedal(int MHKJEBNOPIM)
	{
		if(PDGJIJOMAKO_Medl + MHKJEBNOPIM < 999999999999)
			PDGJIJOMAKO_Medl += MHKJEBNOPIM;
		else
			PDGJIJOMAKO_Medl = 999999999999;
	}

	// // RVA: 0x17C0900 Offset: 0x17C0900 VA: 0x17C0900
	public void AGNDGJOPIDL_AddShop(int HMFFHLPNMPH)
	{
		PFOMECFACLL_Shp += HMFFHLPNMPH;
		if(PFOMECFACLL_Shp > 99999999)
			PFOMECFACLL_Shp = 99999999;
	}

	// // RVA: 0x17C0920 Offset: 0x17C0920 VA: 0x17C0920
	public void MFCKAGIINJL_AddDecoShop(int HMFFHLPNMPH)
	{
		DHNOLFBEHKN_Dcshp += HMFFHLPNMPH;
		if(DHNOLFBEHKN_Dcshp > 99999999)
			DHNOLFBEHKN_Dcshp = 99999999;
	}

	// // RVA: 0x17B5CFC Offset: 0x17B5CFC VA: 0x17B5CFC
	// public void CIKKGHDIDPJ(int HMFFHLPNMPH) { }

	// // RVA: 0x17C0940 Offset: 0x17C0940 VA: 0x17C0940
	public void FFMDFKBLECC(int HMFFHLPNMPH)
	{
		MJBCBJDMODC_Valu += HMFFHLPNMPH;
		if(MJBCBJDMODC_Valu > 99999999)
			MJBCBJDMODC_Valu = 99999999;
	}

	// // RVA: 0x17C0960 Offset: 0x17C0960 VA: 0x17C0960
	public void KNGCKBNFEGM_AddVOp(int FGHGMHPNEMG, int HMFFHLPNMPH)
	{
		if(FGHGMHPNEMG < GKOAPFJFKEJ_VOpC.Length)
		{
			GKOAPFJFKEJ_VOpC[FGHGMHPNEMG] += HMFFHLPNMPH;
			if (GKOAPFJFKEJ_VOpC[FGHGMHPNEMG] < 100000000)
				return;
			GKOAPFJFKEJ_VOpC[FGHGMHPNEMG] = 99999999;
		}
	}

	// // RVA: 0x17C0A58 Offset: 0x17C0A58 VA: 0x17C0A58
	public void PMDMJKCANFF_AddDOp(int AHHJLDLAPAN, int HMFFHLPNMPH)
	{
		if(AHHJLDLAPAN > 0)
		{
			if(AHHJLDLAPAN - 1 < LOOAKNLDONN_DOpC.Length)
			{
				LOOAKNLDONN_DOpC[AHHJLDLAPAN - 1] += HMFFHLPNMPH;
				if (LOOAKNLDONN_DOpC[AHHJLDLAPAN - 1] < 100000000)
					return;
				LOOAKNLDONN_DOpC[AHHJLDLAPAN - 1] = 99999999;
			}
		}
	}

	// // RVA: 0x17C0B5C Offset: 0x17C0B5C VA: 0x17C0B5C
	public void LHPDDGIJKNB()
	{
		FBGGEFFJJHB = LPDNKHAIOLH.CEIBAFOCNCA();
		MILCBLJDADN_MusicClear = 0;
		BENEAPDMALA_Mk = 0;
		HLNOELCIBPH_Perf = 0;
		FILFPNDEINH_Fcb = 0;
		KOONLNKCIJC_SS = 0;
		EDLBLCGHECJ_MaxScore = 0;
		NALPJPKDNGH_Dp = 0;
		MJBCBJDMODC_Valu = 0;
		PDGJIJOMAKO_Medl = 0;
		PFOMECFACLL_Shp = 0;
		DHNOLFBEHKN_Dcshp = 0;
		HOHBKPPOLLA_Uc = 0;
		GACBDCLPOCD_Sdv = 0;
		IMIEPNOECFD_Vk = 0;
		for(int i = 0; i < GKOAPFJFKEJ_VOpC.Length; i++)
		{
			GKOAPFJFKEJ_VOpC[i] = 0;
		}
		for(int i = 0; i < LOOAKNLDONN_DOpC.Length; i++)
		{
			LOOAKNLDONN_DOpC[i] = 0;
		}
		for(int i = 0; i < LHOCOEOKFNO_SerieClear.Length; i++)
		{
			LHOCOEOKFNO_SerieClear[i] = 0;
		}
		for(int i = 0; i < PHPPOGOEOAF_DiffClear.Length; i++)
		{
			PHPPOGOEOAF_DiffClear[i] = 0;
			IAFPEPABGJJ_DiffClear16[i] = 0;
		}
		BJDKMJFCOOM_LCnt = 0;
		BKEKKFPEPBG_LDt = 0;
	}

	// // RVA: 0x17C0DEC Offset: 0x17C0DEC VA: 0x17C0DEC
	public bool AGBOGBEOFME(NAKMCMEPAGH OIKJFMGEICL)
	{
		if(MILCBLJDADN_MusicClear != OIKJFMGEICL.MILCBLJDADN_MusicClear ||
			HLNOELCIBPH_Perf != OIKJFMGEICL.HLNOELCIBPH_Perf ||
			FILFPNDEINH_Fcb != OIKJFMGEICL.FILFPNDEINH_Fcb ||
			KOONLNKCIJC_SS != OIKJFMGEICL.KOONLNKCIJC_SS ||
			EDLBLCGHECJ_MaxScore != OIKJFMGEICL.EDLBLCGHECJ_MaxScore ||
			HOHBKPPOLLA_Uc != OIKJFMGEICL.HOHBKPPOLLA_Uc ||
			GACBDCLPOCD_Sdv != OIKJFMGEICL.GACBDCLPOCD_Sdv ||
			IMIEPNOECFD_Vk != OIKJFMGEICL.IMIEPNOECFD_Vk ||
			BENEAPDMALA_Mk != OIKJFMGEICL.BENEAPDMALA_Mk ||
			PDGJIJOMAKO_Medl != OIKJFMGEICL.PDGJIJOMAKO_Medl ||
			PFOMECFACLL_Shp != OIKJFMGEICL.PFOMECFACLL_Shp ||
			DHNOLFBEHKN_Dcshp != OIKJFMGEICL.DHNOLFBEHKN_Dcshp ||
			NALPJPKDNGH_Dp != OIKJFMGEICL.NALPJPKDNGH_Dp ||
			KNCLIEBAPJD_Cosu != OIKJFMGEICL.KNCLIEBAPJD_Cosu ||
			MJBCBJDMODC_Valu != OIKJFMGEICL.MJBCBJDMODC_Valu ||
			BJDKMJFCOOM_LCnt != OIKJFMGEICL.BJDKMJFCOOM_LCnt ||
			BKEKKFPEPBG_LDt != OIKJFMGEICL.BKEKKFPEPBG_LDt)
			return false;
		for(int i = 0; i < GKOAPFJFKEJ_VOpC.Length; i++)
		{
			if(GKOAPFJFKEJ_VOpC[i] != OIKJFMGEICL.GKOAPFJFKEJ_VOpC[i])
				return false;
		}
		for(int i = 0; i < LOOAKNLDONN_DOpC.Length; i++)
		{
			if(LOOAKNLDONN_DOpC[i] != OIKJFMGEICL.LOOAKNLDONN_DOpC[i])
				return false;
		}
		for(int i = 0; i < LHOCOEOKFNO_SerieClear.Length; i++)
		{
			if(LHOCOEOKFNO_SerieClear[i] != OIKJFMGEICL.LHOCOEOKFNO_SerieClear[i])
				return false;
		}
		for(int i = 0; i < PHPPOGOEOAF_DiffClear.Length; i++)
		{
			if(PHPPOGOEOAF_DiffClear[i] != OIKJFMGEICL.PHPPOGOEOAF_DiffClear[i] ||
				IAFPEPABGJJ_DiffClear16[i] != OIKJFMGEICL.IAFPEPABGJJ_DiffClear16[i])
				return false;
		}
		return true;
	}

	// // RVA: 0x17C155C Offset: 0x17C155C VA: 0x17C155C
	public void ODDIHGPONFL(NAKMCMEPAGH GPBJHKLFCEP)
	{
		MILCBLJDADN_MusicClear = GPBJHKLFCEP.MILCBLJDADN_MusicClear;
		HLNOELCIBPH_Perf = GPBJHKLFCEP.HLNOELCIBPH_Perf;
		FILFPNDEINH_Fcb = GPBJHKLFCEP.FILFPNDEINH_Fcb;
		KOONLNKCIJC_SS = GPBJHKLFCEP.KOONLNKCIJC_SS;
		HOHBKPPOLLA_Uc = GPBJHKLFCEP.HOHBKPPOLLA_Uc;
		EDLBLCGHECJ_MaxScore = GPBJHKLFCEP.EDLBLCGHECJ_MaxScore;
		GACBDCLPOCD_Sdv = GPBJHKLFCEP.GACBDCLPOCD_Sdv;
		IMIEPNOECFD_Vk = GPBJHKLFCEP.IMIEPNOECFD_Vk;
		BENEAPDMALA_Mk = GPBJHKLFCEP.BENEAPDMALA_Mk;
		PDGJIJOMAKO_Medl = GPBJHKLFCEP.PDGJIJOMAKO_Medl;
		PFOMECFACLL_Shp = GPBJHKLFCEP.PFOMECFACLL_Shp;
		DHNOLFBEHKN_Dcshp = GPBJHKLFCEP.DHNOLFBEHKN_Dcshp;
		NALPJPKDNGH_Dp = GPBJHKLFCEP.NALPJPKDNGH_Dp;
		KNCLIEBAPJD_Cosu = GPBJHKLFCEP.KNCLIEBAPJD_Cosu;
		MJBCBJDMODC_Valu = GPBJHKLFCEP.MJBCBJDMODC_Valu;
		BJDKMJFCOOM_LCnt = GPBJHKLFCEP.BJDKMJFCOOM_LCnt;
		BKEKKFPEPBG_LDt = GPBJHKLFCEP.BKEKKFPEPBG_LDt;
		MILCBLJDADN_MusicClear = GPBJHKLFCEP.MILCBLJDADN_MusicClear;
		MILCBLJDADN_MusicClear = GPBJHKLFCEP.MILCBLJDADN_MusicClear;
		MILCBLJDADN_MusicClear = GPBJHKLFCEP.MILCBLJDADN_MusicClear;
		for(int i = 0; i < GKOAPFJFKEJ_VOpC.Length; i++)
		{
			GKOAPFJFKEJ_VOpC[i] = GPBJHKLFCEP.GKOAPFJFKEJ_VOpC[i];
		}
		for(int i = 0; i < LOOAKNLDONN_DOpC.Length; i++)
		{
			LOOAKNLDONN_DOpC[i] = GPBJHKLFCEP.LOOAKNLDONN_DOpC[i];
		}
		for(int i = 0; i < LHOCOEOKFNO_SerieClear.Length; i++)
		{
			LHOCOEOKFNO_SerieClear[i] = GPBJHKLFCEP.LHOCOEOKFNO_SerieClear[i];
		}
		for(int i = 0; i < PHPPOGOEOAF_DiffClear.Length; i++)
		{
			PHPPOGOEOAF_DiffClear[i] = GPBJHKLFCEP.PHPPOGOEOAF_DiffClear[i];
			IAFPEPABGJJ_DiffClear16[i] = GPBJHKLFCEP.IAFPEPABGJJ_DiffClear16[i];
		}
	}

	// // RVA: 0x17C1A60 Offset: 0x17C1A60 VA: 0x17C1A60
	// public void AGHKODFKOJI(BHBONAHFKHD JBBHNIACMFJ, string JIKKNHIAEKG, string MJBACHKCIHA, int OIPCCBHIKIA, NAKMCMEPAGH OHMCIEMIKCE, bool EFOEPDLNLJG) { }
}
