
public class BAJFMCIDGOK
{
	public int ENOBDCFHELD; // 0x8
	public int CJAOMKLHFJL_Crypted; // 0xC
	public int NBOLDNMPJFG_Crypted; // 0x10
	public int JBFANBKCHMG_Crypted; // 0x14
	public int FAJBIAPFFLP_Crypted; // 0x18
	public int HLOEAMGPJKO_Crypted; // 0x1C
	public int JCNBDMGNIGP_Crypted; // 0x20
	public int BFHMIJBAAMC_Crypted; // 0x24
	public int LJPHHIIINNP_Crypted; // 0x28

	public int GOIKCKHMBDL_F { get { return CJAOMKLHFJL_Crypted ^ ENOBDCFHELD; } set { CJAOMKLHFJL_Crypted = value ^ ENOBDCFHELD; } } //0xF15FE8 BPGCGEDHBEH 0xF15FF8 ICPMFBIDFFO
	public int KNIFCANOHOC_Sc { get { return NBOLDNMPJFG_Crypted ^ ENOBDCFHELD; } set { NBOLDNMPJFG_Crypted = value ^ ENOBDCFHELD; } } //0xF16008 EOJEPLIPOMJ 0xF16018 AEEMBPAEAAI
	public int JKAMFMNGEBB_Hs { get { return JBFANBKCHMG_Crypted ^ ENOBDCFHELD; } set { JBFANBKCHMG_Crypted = value ^ ENOBDCFHELD; } } //0xF16028 EAOCMNMBDEG 0xF16038 ILFAFLEFJCF
	public int EPKDHJLMKLF_C { get { return FAJBIAPFFLP_Crypted ^ ENOBDCFHELD; } set { FAJBIAPFFLP_Crypted = value ^ ENOBDCFHELD; } } //0xF16048 DOIBLOOMBGL 0xF16058 HKNODKKBNEO
	public int LJLCKFLJNPC_Bn { get { return HLOEAMGPJKO_Crypted ^ ENOBDCFHELD; } set { HLOEAMGPJKO_Crypted = value ^ ENOBDCFHELD; } } //0xF16068 GHLAFGAKDEM 0xF16078 AJEHAIDOPNN
	public int CEAEKLNDENC_Ec { get { return JCNBDMGNIGP_Crypted ^ ENOBDCFHELD; } set { JCNBDMGNIGP_Crypted = value ^ ENOBDCFHELD; } } //0xF16088 FAIFLKACINH 0xF16098 BPIDBJJHNOI
	public int FAKIHAPMADE_Ep { get { return BFHMIJBAAMC_Crypted ^ ENOBDCFHELD; } set { BFHMIJBAAMC_Crypted = value ^ ENOBDCFHELD; } } //0xF160A8 NNJAAGOONFB 0xF160B8 BGGHKMCGLKC
	public bool PFGLKPNGKLN_Wl { get { return LJPHHIIINNP_Crypted == ENOBDCFHELD; } set { LJPHHIIINNP_Crypted = value ? ENOBDCFHELD : ~ENOBDCFHELD; } } //0xF160C8 DHHPKBDGDAJ 0xF160E0 CKLHNEHHELA

	// RVA: 0xF16114 Offset: 0xF16114 VA: 0xF16114
	public void LHPDDGIJKNB(int KNEFBLHBDBG)
    {
        ENOBDCFHELD = KNEFBLHBDBG;
        EPKDHJLMKLF_C = 0;
        LJLCKFLJNPC_Bn = 0;
        CEAEKLNDENC_Ec = 0;
        FAKIHAPMADE_Ep = 0;
        GOIKCKHMBDL_F = 0;
        KNIFCANOHOC_Sc = 0;
        JKAMFMNGEBB_Hs = 0;
        PFGLKPNGKLN_Wl = false;
    }

	// // RVA: 0xF16150 Offset: 0xF16150 VA: 0xF16150
	public bool AGBOGBEOFME(BAJFMCIDGOK OIKJFMGEICL)
	{
		if(GOIKCKHMBDL_F != OIKJFMGEICL.GOIKCKHMBDL_F)
			return false;
		if(KNIFCANOHOC_Sc != OIKJFMGEICL.KNIFCANOHOC_Sc)
			return false;
		if(JKAMFMNGEBB_Hs != OIKJFMGEICL.JKAMFMNGEBB_Hs)
			return false;
		if(EPKDHJLMKLF_C != OIKJFMGEICL.EPKDHJLMKLF_C)
			return false;
		if(LJLCKFLJNPC_Bn != OIKJFMGEICL.LJLCKFLJNPC_Bn)
			return false;
		if(CEAEKLNDENC_Ec != OIKJFMGEICL.CEAEKLNDENC_Ec)
			return false;
		if(FAKIHAPMADE_Ep != OIKJFMGEICL.FAKIHAPMADE_Ep)
			return false;
		if(PFGLKPNGKLN_Wl != OIKJFMGEICL.PFGLKPNGKLN_Wl)
			return false;
		return true;
	}

	// // RVA: 0xF16258 Offset: 0xF16258 VA: 0xF16258
	public void ODDIHGPONFL(BAJFMCIDGOK OIKJFMGEICL)
	{
		GOIKCKHMBDL_F = OIKJFMGEICL.GOIKCKHMBDL_F;
		KNIFCANOHOC_Sc = OIKJFMGEICL.KNIFCANOHOC_Sc;
		JKAMFMNGEBB_Hs = OIKJFMGEICL.JKAMFMNGEBB_Hs;
		EPKDHJLMKLF_C = OIKJFMGEICL.EPKDHJLMKLF_C;
		LJLCKFLJNPC_Bn = OIKJFMGEICL.LJLCKFLJNPC_Bn;
		CEAEKLNDENC_Ec = OIKJFMGEICL.CEAEKLNDENC_Ec;
		FAKIHAPMADE_Ep = OIKJFMGEICL.FAKIHAPMADE_Ep;
		PFGLKPNGKLN_Wl = OIKJFMGEICL.PFGLKPNGKLN_Wl;
	}

	// // RVA: 0xF163E8 Offset: 0xF163E8 VA: 0xF163E8
	public EDOHBJAPLPF_JsonData OKJPIBHMKMJ()
	{
		EDOHBJAPLPF_JsonData res = new EDOHBJAPLPF_JsonData();
		res["f"] = GOIKCKHMBDL_F;
		res["sc"] = KNIFCANOHOC_Sc;
		res["hs"] = JKAMFMNGEBB_Hs;
		res["c"] = EPKDHJLMKLF_C;
		res["bn"] = LJLCKFLJNPC_Bn;
		res["ec"] = CEAEKLNDENC_Ec;
		res["ep"] = FAKIHAPMADE_Ep;
		res["wl"] = PFGLKPNGKLN_Wl ? 1 : 0;
		return res;
	}
}
