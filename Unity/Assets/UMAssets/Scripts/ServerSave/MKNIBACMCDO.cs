
[System.Obsolete("Use MKNIBACMCDO_AssistPlate", true)]
public class MKNIBACMCDO { }
public class MKNIBACMCDO_AssistPlate : KLFDBFMNLBL_ServerSaveBlock
{
	private const int ECFEMKGFDCE = 2;
	public const int FBBENLHJFKO = 5;
	private int FBGGEFFJJHB; // 0x24
	public JNMFKOHFAFB_PublicStatus.ONCMONJIPCD[] LDIINNKMLLO = new JNMFKOHFAFB_PublicStatus.ONCMONJIPCD[5]; // 0x28
	public int NBIIKNFOLLK; // 0x2C

	public int HODDNKENKHD_Page { get { return NBIIKNFOLLK ^ FBGGEFFJJHB; } set { NBIIKNFOLLK = value ^ FBGGEFFJJHB; } } //EMLKHGADCIE 0x195AB08 LAGDPCMEBOD 0x195AB18

	// // RVA: 0x195AA5C Offset: 0x195AA5C VA: 0x195AA5C
	public MKNIBACMCDO_AssistPlate()
	{
		FBGGEFFJJHB = LPDNKHAIOLH.CEIBAFOCNCA();
	}

	// // RVA: 0x195AB28 Offset: 0x195AB28 VA: 0x195AB28 Slot: 4
	public override void KMBPACJNEOF()
	{
		for(int i = 0; i < 5; i++)
		{
			LDIINNKMLLO[i] = new JNMFKOHFAFB_PublicStatus.ONCMONJIPCD();
			LDIINNKMLLO[i].KMBPACJNEOF(i);
		}
		HODDNKENKHD_Page = 0;
	}

	// // RVA: 0x195AC68 Offset: 0x195AC68 VA: 0x195AC68 Slot: 7
	public override void BMGGKONLFIC(KLFDBFMNLBL_ServerSaveBlock GPBJHKLFCEP)
	{
		MKNIBACMCDO_AssistPlate a = GPBJHKLFCEP as MKNIBACMCDO_AssistPlate;
		for(int i = 0; i < 5; i++)
		{
			LDIINNKMLLO[i].ODDIHGPONFL(a.LDIINNKMLLO[i]);
		}
		HODDNKENKHD_Page = a.HODDNKENKHD_Page;
	}

	// // RVA: 0x195AE1C Offset: 0x195AE1C VA: 0x195AE1C Slot: 10
	public override void AGHKODFKOJI(BHBONAHFKHD JBBHNIACMFJ, KLFDBFMNLBL_ServerSaveBlock GJLFANGDGCL, long MCKEOKFMLAH)
	{
		TodoLogger.LogError(0, "AGHKODFKOJI");
	}

	// // RVA: 0x195B1D0 Offset: 0x195B1D0 VA: 0x195B1D0 Slot: 8
	public override bool AGBOGBEOFME(KLFDBFMNLBL_ServerSaveBlock GPBJHKLFCEP)
	{
		MKNIBACMCDO_AssistPlate other = GPBJHKLFCEP as MKNIBACMCDO_AssistPlate;
		for(int i = 0; i < LDIINNKMLLO.Length; i++)
		{
			if (!LDIINNKMLLO[i].AGBOGBEOFME(other.LDIINNKMLLO[i]))
				return false;
		}
		return HODDNKENKHD_Page == other.HODDNKENKHD_Page;
	}

	// // RVA: 0x195B3C8 Offset: 0x195B3C8 VA: 0x195B3C8 Slot: 11
	public override FENCAJJBLBH PFAKPFKJJKA()
	{
		TodoLogger.LogError(TodoLogger.DbIntegrityCheck, "TODO");
		return null;
	}

	// // RVA: 0x195B3D0 Offset: 0x195B3D0 VA: 0x195B3D0 Slot: 5
	public override void OKJPIBHMKMJ(EDOHBJAPLPF_JsonData OILEIIEIBHP, long MCKEOKFMLAH)
	{
		EDOHBJAPLPF_JsonData data = new EDOHBJAPLPF_JsonData();
		data[AFEHLCGHAEE_Strings.EOKMNCPJMCO_assist_list] = EOLCFDGNIJI();
		data["page"] = HODDNKENKHD_Page;
		OILEIIEIBHP[JIKKNHIAEKG_BlockName] = data;
	}

	// // RVA: 0x195B098 Offset: 0x195B098 VA: 0x195B098
	private EDOHBJAPLPF_JsonData EOLCFDGNIJI()
	{
		EDOHBJAPLPF_JsonData data = new EDOHBJAPLPF_JsonData();
		OAILDDLJFEE o = new OAILDDLJFEE();
		for(int i = 0; i < LDIINNKMLLO.Length; i++)
		{
			data.Add(o.LPGBJBHFINB(LDIINNKMLLO[i]));
		}
		return data;
	}

	// // RVA: 0x195B560 Offset: 0x195B560 VA: 0x195B560 Slot: 6
	public override bool IIEMACPEEBJ_Deserialize(EDOHBJAPLPF_JsonData OILEIIEIBHP)
	{
		bool isInvalid = false;
		if(OILEIIEIBHP.BBAJPINMOEP_Contains(JIKKNHIAEKG_BlockName))
		{
			HODDNKENKHD_Page = CJAENOMGPDA_ReadInt(OILEIIEIBHP[JIKKNHIAEKG_BlockName], "page", 0, ref isInvalid);
			FIFBCMMEPOE(OILEIIEIBHP[JIKKNHIAEKG_BlockName], ref isInvalid);
			KFKDMBPNLJK_BlockInvalid = isInvalid;
			return true;
		}
		KFKDMBPNLJK_BlockInvalid = true;
		return false;
	}

	// // RVA: 0x195B680 Offset: 0x195B680 VA: 0x195B680
	private void FIFBCMMEPOE(EDOHBJAPLPF_JsonData OBHAFLMHAKG, ref bool NGJDHLGMHMH)
	{
		if(OBHAFLMHAKG.BBAJPINMOEP_Contains(AFEHLCGHAEE_Strings.EOKMNCPJMCO_assist_list))
		{
			for(int i = 0; i < 5; i++)
			{
				LFNFJHGDKAA(LDIINNKMLLO[i], OBHAFLMHAKG[AFEHLCGHAEE_Strings.EOKMNCPJMCO_assist_list][i], ref NGJDHLGMHMH);
			}
		}
	}

	// // RVA: 0x195B834 Offset: 0x195B834 VA: 0x195B834
	private void LFNFJHGDKAA(JNMFKOHFAFB_PublicStatus.ONCMONJIPCD IDLHJIOMJBK, EDOHBJAPLPF_JsonData OBHAFLMHAKG, ref bool NGJDHLGMHMH)
	{
		for(int i = 0; i < 4; i++)
		{
			EHEMJOHCJOG(IDLHJIOMJBK.JOHLGBDOLNO_DataList[i], OBHAFLMHAKG[AFEHLCGHAEE_Strings.GGLICPAANFE_assist_data_list][i], ref NGJDHLGMHMH);
		}
		IDLHJIOMJBK.JCJNKBKMJFK_Name = FGCNMLBACGO_ReadString(OBHAFLMHAKG, AFEHLCGHAEE_Strings.COEBIDJMMCH_assist_name, "", ref NGJDHLGMHMH);
	}

	// // RVA: 0x195BA04 Offset: 0x195BA04 VA: 0x195BA04
	private void EHEMJOHCJOG(JNMFKOHFAFB_PublicStatus.KNHIPBADANI KDIFMECGNIC, EDOHBJAPLPF_JsonData OBHAFLMHAKG, ref bool NGJDHLGMHMH)
	{
		KDIFMECGNIC.KMBPACJNEOF_Reset();
		KDIFMECGNIC.PPFNGGCBJKC_Id = CJAENOMGPDA_ReadInt(OBHAFLMHAKG, AFEHLCGHAEE_Strings.PPFNGGCBJKC_Id, 0, ref NGJDHLGMHMH);
		bool isReset = false;
		if(IMMAOANGPNK.HHCJCDFCLOB.LNAHEIEIBOI_Initialized)
		{
			if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database != null)
			{
				if(!IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.ECNHDEHADGL_Scene.FGNJBMPDBLO_IsSceneValid(KDIFMECGNIC.PPFNGGCBJKC_Id))
				{
					isReset = true;
					KDIFMECGNIC.PPFNGGCBJKC_Id = 0;
				}
			}
		}
		KDIFMECGNIC.ANAJIAENLNB_Level = CJAENOMGPDA_ReadInt(OBHAFLMHAKG, AFEHLCGHAEE_Strings.GKOAEJDMLED_reward_opened_at, 0, ref NGJDHLGMHMH);
		KDIFMECGNIC.MJBODMOLOBC_Luck = CJAENOMGPDA_ReadInt(OBHAFLMHAKG, AFEHLCGHAEE_Strings.MJBODMOLOBC_luck, 0, ref NGJDHLGMHMH);
		KDIFMECGNIC.JPIPENJGGDD_Mlt = CJAENOMGPDA_ReadInt(OBHAFLMHAKG, AFEHLCGHAEE_Strings.ALMNMBDELDB_mlt, 0, ref NGJDHLGMHMH);
		KDIFMECGNIC.DMNIMMGGJJJ_Leaf = CJAENOMGPDA_ReadInt(OBHAFLMHAKG, "leaf", 0, ref NGJDHLGMHMH);
		if(isReset)
		{
			if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.HDGOHBFKKDM_LimitOver.AJHBAOCLNDF_Enabled != 2)
			{
				KDIFMECGNIC.DMNIMMGGJJJ_Leaf = 0;
			}
		}
		CEDHHAGBIBA.IFOLECIIDPO_StringToByteArray(KDIFMECGNIC.PDNIFBEGMHC_Mb, FGCNMLBACGO_ReadString(OBHAFLMHAKG, AFEHLCGHAEE_Strings.DANMJLOBLIE_mb, "", ref NGJDHLGMHMH));
		CEDHHAGBIBA.IFOLECIIDPO_StringToByteArray(KDIFMECGNIC.EMOJHJGHJLN_Sb, FGCNMLBACGO_ReadString(OBHAFLMHAKG, AFEHLCGHAEE_Strings.KOHNLDKIKPC_sb, "", ref NGJDHLGMHMH));
		KDIFMECGNIC.ANAJIAENLNB_Level = CEDHHAGBIBA.OGPFNHOKONH_GetNumBitActive(KDIFMECGNIC.PDNIFBEGMHC_Mb) + 1;
		if (KDIFMECGNIC.MJBODMOLOBC_Luck < 0)
			KDIFMECGNIC.MJBODMOLOBC_Luck = 0;
		if(KDIFMECGNIC.MJBODMOLOBC_Luck > 25)
			KDIFMECGNIC.MJBODMOLOBC_Luck = 25;
	}
}
