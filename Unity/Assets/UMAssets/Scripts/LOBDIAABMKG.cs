
using System;
using System.Collections.Generic;
using XeSys;

public enum NPCHMKMAHMA
{
	HJNNKCMLGFL = 0,
	AIMPCCIHKAJ = 1,
	DIHBOGEPHFI = 2,
}

public class LOBDIAABMKG
{
	private const int HMDMNGHDFEC = 3600;
	private const int HNPLKNDMDIL = 10;
	public static int[] BHIHFFLOAGI = new int[20]; // 0x0
	public string OPFGFINHFCE_Name; // 0x8
	public string EFIMCLPAEEN_ImageUrl; // 0xC
	public string KLMPFGOCBHC_Description; // 0x10
	public IKMBBPDBECA KACECFNECON; // 0x14
	public int MJNOAMAFNHA; // 0x18
	public long KJBGCLPMLCG_OpenedAt; // 0x20
	public long GJFPFFBAKGK_CloseAt; // 0x28
	public long EABMLBFHJBH; // 0x30
	public bool KNMLPAAHAOF_IsStartGacha; // 0x38
	public GCAHJLOGMCI.KNMMOMEHDON INDDJNMPONH_Category; // 0x3C
	public int MGBDCFIKBPM; // 0x40
	public int FDEBLMKEMLF_TypeAndSeriesId; // 0x44
	public string IJADMGDHEIE; // 0x48
	public int HNKHCIDOKFF; // 0x4C
	public int MFICPBJPCCJ; // 0x50
	public bool MEBKAHGMING; // 0x54
	public long EEFLOOBOAGF; // 0x58
	public bool FJAOAGNFABN; // 0x60
	public int ABNMIDCBENB; // 0x64
	public bool KNMNJDKJHDM; // 0x68
	private int JFDOLJDCCDJ; // 0x6C
	public string JCIBGEDBOHP = ""; // 0x70
	public int HHIBBHFHENH; // 0x74
	public int GPDIDIJDKAG; // 0x78
	public bool IMCNDJMDNJE; // 0x7C
	public bool CMCNKHLIKPP_HighRarityScene; // 0x7D
	private List<KBPDNHOKEKD_ProductId> MHKCPJDNJKI = new List<KBPDNHOKEKD_ProductId>(11); // 0x80
	private List<IKMBBPDBECA> LNPCOGEJGLL = new List<IKMBBPDBECA>(11); // 0x84
	private List<int> DHIACJMOEBH = new List<int>(11); // 0x88
	//public Dictionary<string, HIMAFGJCECK> PECBGINLOLH = new Dictionary<string, HIMAFGJCECK>(); // 0x8C
	public bool CADENLBDAEB; // 0x90
	public KOPCFBCDBPC NECDFDNBHFK; // 0x94
	//public JBHCLFDBPKP NJLONELPNCD; // 0x98

	// public int OANKCIDLHLJ { get; }

	// // RVA: 0x10C4520 Offset: 0x10C4520 VA: 0x10C4520
	// public bool OHEBECPDIDF() { }

	// // RVA: 0x10C46C4 Offset: 0x10C46C4 VA: 0x10C46C4
	// public bool MEONHEGJNEF() { }

	// // RVA: 0x10C47C4 Offset: 0x10C47C4 VA: 0x10C47C4
	// public int IGFFJIPFENH() { }

	// // RVA: 0x10C47E4 Offset: 0x10C47E4 VA: 0x10C47E4
	// public MMNNAPPLHFM CHNFEEOJJCO(int CPNGJMKFCJI) { }

	// // RVA: 0x10C48FC Offset: 0x10C48FC VA: 0x10C48FC
	// public ABPEPHGCNDA NLGPIELHAKC(int CPNGJMKFCJI, bool LNKELOHFELH) { }

	// // RVA: 0x10C4A28 Offset: 0x10C4A28 VA: 0x10C4A28
	public KBPDNHOKEKD_ProductId DBHIEABGKII(GCAHJLOGMCI.NFCAJPIJFAM BJLONGBNPCI)
	{
		return MHKCPJDNJKI[(int)BJLONGBNPCI];
	}

	// // RVA: 0x10C4AA8 Offset: 0x10C4AA8 VA: 0x10C4AA8
	public IKMBBPDBECA HNDLKGOMMNM(GCAHJLOGMCI.NFCAJPIJFAM BJLONGBNPCI)
	{
		if (LNPCOGEJGLL[(int)BJLONGBNPCI] == null)
			return KACECFNECON;
		return LNPCOGEJGLL[(int)BJLONGBNPCI];
	}

	// // RVA: 0x10C4B30 Offset: 0x10C4B30 VA: 0x10C4B30
	public int OMNAPCHLBHF(GCAHJLOGMCI.NFCAJPIJFAM BJLONGBNPCI)
	{
		if(BJLONGBNPCI != GCAHJLOGMCI.NFCAJPIJFAM.OBLEFFEJGIJ_8/*8*/)
		{
			return DHIACJMOEBH[(int)BJLONGBNPCI];
		}
		if (NECDFDNBHFK == null)
			return 0;
		return NECDFDNBHFK.LKPHIGAFJKD.PPFNGGCBJKC;
	}

	// // RVA: 0x10C4BF0 Offset: 0x10C4BF0 VA: 0x10C4BF0
	// public int FKKCFICCGMM(int APHNELOFGAK) { }

	// // RVA: 0x10C4F48 Offset: 0x10C4F48 VA: 0x10C4F48
	// public bool HFEFJALCHMM() { }

	// // RVA: 0x10C5070 Offset: 0x10C5070 VA: 0x10C5070
	// public int HCMGHDNNJOM() { }

	// // RVA: 0x10C518C Offset: 0x10C518C VA: 0x10C518C
	// public int EDODPNCAGKN() { }

	// // RVA: 0x10C52A8 Offset: 0x10C52A8 VA: 0x10C52A8
	// public bool DIOPMDBJELP() { }

	// // RVA: 0x10C53D0 Offset: 0x10C53D0 VA: 0x10C53D0
	// public bool NIHLEOHPAFC() { }

	// // RVA: 0x10C54F8 Offset: 0x10C54F8 VA: 0x10C54F8
	public KBPDNHOKEKD_ProductId.KNEKLJHNHAK FJICMLBOJCH()
	{
		KBPDNHOKEKD_ProductId.KNEKLJHNHAK res = KBPDNHOKEKD_ProductId.KNEKLJHNHAK.HJNNKCMLGFL;
		for(int i = 0; i < MHKCPJDNJKI.Count; i++)
		{
			if(MHKCPJDNJKI[i] != null)
			{
				KBPDNHOKEKD_ProductId.KNEKLJHNHAK r = MHKCPJDNJKI[i].FJICMLBOJCH();
				if (r != KBPDNHOKEKD_ProductId.KNEKLJHNHAK.HJNNKCMLGFL)
					return r;
			}
		}
		return res;
	}

	// // RVA: 0x10C5618 Offset: 0x10C5618 VA: 0x10C5618
	public bool BANFOFKNKED(int APHNELOFGAK)
	{
		if(APHNELOFGAK == 1001)
		{
			if(MHKCPJDNJKI[2] != null)
			{
				if (MHKCPJDNJKI[4] != null)
					return true;
			}
		}
		return false;
	}

	// // RVA: 0x10C56F0 Offset: 0x10C56F0 VA: 0x10C56F0
	// public int BAGPMBGOCOK(int APHNELOFGAK) { }

	// // RVA: 0x10C57A4 Offset: 0x10C57A4 VA: 0x10C57A4
	// public HIMAFGJCECK OHBCGMINBDP(GCAHJLOGMCI.NFCAJPIJFAM BJLONGBNPCI, bool LNKELOHFELH) { }

	// // RVA: 0x10C5BD0 Offset: 0x10C5BD0 VA: 0x10C5BD0
	// private bool MIJEHENMEOE(GCAHJLOGMCI.NFCAJPIJFAM BJLONGBNPCI) { }

	// // RVA: 0x10C5BF0 Offset: 0x10C5BF0 VA: 0x10C5BF0
	private bool DOMFHDPMCCO(List<KBPDNHOKEKD_ProductId> NNDGIAEFMOG, GCAHJLOGMCI.NFCAJPIJFAM BJLONGBNPCI, bool DDNGPDGGJBN, bool AJOAFPDICDK = false, NPCHMKMAHMA COMIABFPIKA = 0)
	{
		//joined_r0x010c5c94
		for(int i = NNDGIAEFMOG.Count - 1; i >= 0; i--)
		{
			if(NNDGIAEFMOG[i].KAPMOPMDHJE_Label == (int)BJLONGBNPCI || AJOAFPDICDK)
			{
				GCAHJLOGMCI.NFCAJPIJFAM e = GCAHJLOGMCI.HHFLDFFJICJ(NNDGIAEFMOG[i].KAPMOPMDHJE_Label);
				bool b = ((1 << (int)e & 0xff) & 0x2a) == 0;
				if((COMIABFPIKA == NPCHMKMAHMA.DIHBOGEPHFI/*2*/ && ((int)e > 5 || b)) || 
				(COMIABFPIKA != NPCHMKMAHMA.AIMPCCIHKAJ/*1*/) ||
				((int)e <= 5 && b))
				{
					if(MHKCPJDNJKI[(int)BJLONGBNPCI] != null)
					{
						int a = GCAHJLOGMCI.BDJDDKBCHKO(MHKCPJDNJKI[(int)BJLONGBNPCI].KAPMOPMDHJE_Label);
						int c = GCAHJLOGMCI.BDJDDKBCHKO(NNDGIAEFMOG[i].KAPMOPMDHJE_Label);
						if(c <= a)
							return true;
						MHKCPJDNJKI[(int)BJLONGBNPCI] = NNDGIAEFMOG[i];
						LNPCOGEJGLL[(int)BJLONGBNPCI] = IKMBBPDBECA.HEGEKFMJNCC(NNDGIAEFMOG[i].KLMPFGOCBHC_Description);
						if(!DDNGPDGGJBN)
							return true;
						OPFGFINHFCE_Name = NNDGIAEFMOG[i].OPFGFINHFCE_Name;
						EFIMCLPAEEN_ImageUrl = NNDGIAEFMOG[i].EFIMCLPAEEN_ImageUrl;
						KLMPFGOCBHC_Description = NNDGIAEFMOG[i].KLMPFGOCBHC_Description;
						GJFPFFBAKGK_CloseAt = NNDGIAEFMOG[i].EGBOHDFBAPB_ClosedAt;
						KJBGCLPMLCG_OpenedAt = NNDGIAEFMOG[i].KBFOIECIADN_OpenedAt;
						EABMLBFHJBH = NNDGIAEFMOG[i].EGBOHDFBAPB_ClosedAt;
						KNMLPAAHAOF_IsStartGacha = false;
						if(OPFGFINHFCE_Name.Contains(JpStringLiterals.StringLiteral_10431))
						{
							KNMLPAAHAOF_IsStartGacha = true;
						}
						KACECFNECON = LNPCOGEJGLL[(int)BJLONGBNPCI];
						if(KACECFNECON == null)
							return true;
						KLMPFGOCBHC_Description = KACECFNECON.KLMPFGOCBHC_Description;
						if(KACECFNECON.JOFAGCFNKIO != 0)
						{
							KJBGCLPMLCG_OpenedAt = KACECFNECON.JOFAGCFNKIO;
						}
						if(!string.IsNullOrEmpty(KACECFNECON.OPFGFINHFCE_Name))
						{
							OPFGFINHFCE_Name = KACECFNECON.OPFGFINHFCE_Name;
						}
						if(!string.IsNullOrEmpty(KACECFNECON.EABMLBFHJBH))
						{
							DateTime d;
							if(DateTime.TryParse(KACECFNECON.EABMLBFHJBH, out d))
							{
								EABMLBFHJBH = Utility.GetTargetUnixTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, d.Second);
							}
						}
						if(!string.IsNullOrEmpty(KACECFNECON.FHHKLJCJNNC))
						{
							JCIBGEDBOHP = KACECFNECON.FHHKLJCJNNC;
						}
						if(KACECFNECON.HNKHCIDOKFF < 1)
						{
							if(KACECFNECON.FLADABCFDFA.Count < 1)
							{
								if(INDDJNMPONH_Category == GCAHJLOGMCI.KNMMOMEHDON.GENEIBGNMPH_3/*3*/)
								{
									//
								}
								else if(KACECFNECON.PGKIHFOKEHL.Count < 1)
								{
									//
								}
								else
									HNKHCIDOKFF = KACECFNECON.PGKIHFOKEHL[0].DNJEJEANJGL_Value;
							}
							else
							{
								HNKHCIDOKFF = KACECFNECON.FLADABCFDFA[0].DNJEJEANJGL_Value;
							}
						}
						else
						{
							HNKHCIDOKFF = KACECFNECON.HNKHCIDOKFF;
						}
						if(KACECFNECON.MFICPBJPCCJ > 0)
						{
							MFICPBJPCCJ = KACECFNECON.MFICPBJPCCJ;
						}
						CMCNKHLIKPP_HighRarityScene = false;
						MLIBEPGADJH_Scene sceneDb = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.ECNHDEHADGL_Scene;
						foreach(var k in KACECFNECON.NNDMIOEKKMM)
						{
							foreach(var l in k.ADDCEJNOJLG_Scenes)
							{
								if(sceneDb.CDENCMNHNGA_SceneList[l.DNJEJEANJGL_Value - 1].OOOPJNKBDIL_Is6OrMoreRarity())
								{
									CMCNKHLIKPP_HighRarityScene = true;
								}
							}
						}
						KACECFNECON.EDCOECLMPGM(KNMLPAAHAOF_IsStartGacha);
						IMCNDJMDNJE = KACECFNECON.IMCNDJMDNJE;
						MEBKAHGMING = KACECFNECON.NNDMIOEKKMM.Count > 0;
						HHIBBHFHENH = KACECFNECON.FPFECIDDNFA;
						GPDIDIJDKAG = KACECFNECON.MPHNHBBJDGP;
						FJAOAGNFABN = KACECFNECON.LEJAMOFMMPA;
						ABNMIDCBENB = KACECFNECON.ABNMIDCBENB;
						KNMNJDKJHDM = KACECFNECON.KNMNJDKJHDM;
						MJNOAMAFNHA = KACECFNECON.MJNOAMAFNHA;
						return true;
					}
				}
			}
		}
		return false;
	}

	// // RVA: 0x10C6AD0 Offset: 0x10C6AD0 VA: 0x10C6AD0
	// private bool HJLKMDHCGFP(KOPCFBCDBPC CCBEKGNDDBE, JBHCLFDBPKP BKGFCEIFMNF, GCAHJLOGMCI.NFCAJPIJFAM BJLONGBNPCI) { }

	// // RVA: 0x10C6E60 Offset: 0x10C6E60 VA: 0x10C6E60
	// public bool KHEKNNFCAOI_Init(List<KBPDNHOKEKD> BBKDLIPKADG, int MGBDCFIKBPM, GCAHJLOGMCI.KNMMOMEHDON INDDJNMPONH, bool IAHLNPMFJMH, int APHNELOFGAK) { }

	// // RVA: 0x10C7660 Offset: 0x10C7660 VA: 0x10C7660
	// public int GHINEFPPDMH() { }

	// // RVA: 0x10C7820 Offset: 0x10C7820 VA: 0x10C7820
	// public bool KHEKNNFCAOI_Init(KOPCFBCDBPC CCBEKGNDDBE, JBHCLFDBPKP BKGFCEIFMNF, int MGBDCFIKBPM, GCAHJLOGMCI.KNMMOMEHDON INDDJNMPONH, int APHNELOFGAK) { }

	// // RVA: 0x10C7A70 Offset: 0x10C7A70 VA: 0x10C7A70
	public bool EJGLNKNKLFC(int PHIGDFMDJBO, GCAHJLOGMCI.KNMMOMEHDON INDDJNMPONH)
	{
		MHKCPJDNJKI.Clear();
		LNPCOGEJGLL.Clear();
		DHIACJMOEBH.Clear();
		for(int i = 0; i < 11; i++)
		{
			MHKCPJDNJKI.Add(null);
			LNPCOGEJGLL.Add(null);
			DHIACJMOEBH.Add(0);
		}
		KBPDNHOKEKD_ProductId data = new KBPDNHOKEKD_ProductId();
		data.OCBHANFFLOO_SetTutoGachaProduct(1);
		KBPDNHOKEKD_ProductId data2 = new KBPDNHOKEKD_ProductId();
		data.OCBHANFFLOO_SetTutoGachaProduct(10);
		List<KBPDNHOKEKD_ProductId> l = new List<KBPDNHOKEKD_ProductId>();
		l.Add(data);
		l.Add(data2);
		bool b = DOMFHDPMCCO(l, GCAHJLOGMCI.NFCAJPIJFAM.AIMPCCIHKAJ_1/*1*/, true, false, 0);
		bool b2 = DOMFHDPMCCO(l, GCAHJLOGMCI.NFCAJPIJFAM.DIHBOGEPHFI_2/*2*/, false, false, 0);
		if(b && b2)
		{
			this.INDDJNMPONH_Category = INDDJNMPONH;
			MGBDCFIKBPM = PHIGDFMDJBO;
			IJADMGDHEIE = ((int)INDDJNMPONH * 10000 + PHIGDFMDJBO).ToString("D5");
			EEFLOOBOAGF = GCAHJLOGMCI.PMBGPACNPIN(INDDJNMPONH, JpStringLiterals.StringLiteral_11117, 0, 0);
		}
		return b && b2;
	}

	// // RVA: 0x10C7DCC Offset: 0x10C7DCC VA: 0x10C7DCC
	// public bool KIAIFPFBGJC(GCAHJLOGMCI.NFCAJPIJFAM BJLONGBNPCI, CACGCMBKHDI.HDHIKGLMOGF BHFHGFKBOHH, DJBHIFLHJLK HDFGHFOCHKE, DJBHIFLHJLK JGKOLBLPMPG) { }

	// // RVA: 0x10C8500 Offset: 0x10C8500 VA: 0x10C8500
	// public bool ICBNPNKJCBK(GCAHJLOGMCI.NFCAJPIJFAM BJLONGBNPCI, CDOPFBOHDEF BHFHGFKBOHH, DJBHIFLHJLK JGKOLBLPMPG, int BPNPBJALGHM = 1) { }

	// // RVA: 0x10C875C Offset: 0x10C875C VA: 0x10C875C
	// public void AHOOLEAGACO(IMCBBOAFION BHFHGFKBOHH, DJBHIFLHJLK JGKOLBLPMPG) { }

	// [IteratorStateMachineAttribute] // RVA: 0x6B6010 Offset: 0x6B6010 VA: 0x6B6010
	// // RVA: 0x10C87B4 Offset: 0x10C87B4 VA: 0x10C87B4
	// private IEnumerator NINJDNIAGEN_GetItemSetRecord(IMCBBOAFION BHFHGFKBOHH, DJBHIFLHJLK MOBEEPPKFLG) { }

	// // RVA: 0x10C8894 Offset: 0x10C8894 VA: 0x10C8894
	// public void OALDDFAJFDL(IMCBBOAFION BHFHGFKBOHH, DJBHIFLHJLK JGKOLBLPMPG) { }

	// [IteratorStateMachineAttribute] // RVA: 0x6B6088 Offset: 0x6B6088 VA: 0x6B6088
	// // RVA: 0x10C88EC Offset: 0x10C88EC VA: 0x10C88EC
	// private IEnumerator BAKEDPGFOLF_GetStepUpItemRecord(IMCBBOAFION BHFHGFKBOHH, DJBHIFLHJLK MOBEEPPKFLG) { }

	// // RVA: 0x10C89CC Offset: 0x10C89CC VA: 0x10C89CC
	// public static List<ANGEDJODMKO> KECIGJBEHBG(List<ANGEDJODMKO> PJJFEAHIPGL) { }

	// // RVA: 0x10C8F34 Offset: 0x10C8F34 VA: 0x10C8F34
	// public static List<MFDJIFIIPJD> ENFHLLHHJKE(List<MFDJIFIIPJD> HBHMAKNGKFK) { }

	// // RVA: 0x10C9170 Offset: 0x10C9170 VA: 0x10C9170
	public string KKODAOIJHMC(GCAHJLOGMCI.NFCAJPIJFAM BJLONGBNPCI)
	{
		IKMBBPDBECA d = HNDLKGOMMNM(BJLONGBNPCI);
		if (d == null)
			return "";
		if (BJLONGBNPCI == GCAHJLOGMCI.NFCAJPIJFAM.AIMPCCIHKAJ_1 && d is EBOCABJKMFB)
			return "";
		return d.MDEIKCBEHHC;
	}

	// // RVA: 0x10C923C Offset: 0x10C923C VA: 0x10C923C
	public int IEEHJPABKMP_GetOwnedQuantity()
	{
		if (MHKCPJDNJKI[3] == null)
		{
			if (MHKCPJDNJKI[1] == null)
				return 0;
			return MHKCPJDNJKI[1].HMFDJHEEGNN_BuyLimit;
		}
		return MHKCPJDNJKI[3].GIEBJDKLCDH_BoughtQuantity;
	}

	// // RVA: 0x10C9304 Offset: 0x10C9304 VA: 0x10C9304
	public int GBAMENANDAN_GetMaxLimit()
	{
		if(MHKCPJDNJKI[3] == null)
		{
			if (MHKCPJDNJKI[1] == null)
				return 0;
			return MHKCPJDNJKI[1].HMFDJHEEGNN_BuyLimit;
		}
		return MHKCPJDNJKI[3].HMFDJHEEGNN_BuyLimit;
	}

	// // RVA: 0x10C93CC Offset: 0x10C93CC VA: 0x10C93CC
	public int GECLFOEDJEI_GetOwnedQuantity()
	{
		if(MHKCPJDNJKI[4] == null)
		{
			if (MHKCPJDNJKI[2] == null)
				return 0;
			return MHKCPJDNJKI[2].GIEBJDKLCDH_BoughtQuantity;
		}
		return MHKCPJDNJKI[4].GIEBJDKLCDH_BoughtQuantity;
	}

	// // RVA: 0x10C9494 Offset: 0x10C9494 VA: 0x10C9494
	public int IBNBABPKLAA_GetMaxLimit()
	{
		if(MHKCPJDNJKI[4] == null)
		{
			if (MHKCPJDNJKI[2] == null)
				return 0;
			return MHKCPJDNJKI[2].HMFDJHEEGNN_BuyLimit;
		}
		return MHKCPJDNJKI[4].HMFDJHEEGNN_BuyLimit;
	}

	// // RVA: 0x10C955C Offset: 0x10C955C VA: 0x10C955C
	// public bool GPKAMGNBGAB(int APHNELOFGAK) { }

	// // RVA: 0x10C9990 Offset: 0x10C9990 VA: 0x10C9990
	// private bool GHLJANAEKFJ(int ADANONKNBKE) { }

	// // RVA: 0x10C9AD8 Offset: 0x10C9AD8 VA: 0x10C9AD8
	// public int HIPBEKBFNBG(int APHNELOFGAK) { }

	// // RVA: 0x10C9C8C Offset: 0x10C9C8C VA: 0x10C9C8C
	// public bool ALPOJNBHNDK(int APHNELOFGAK, long JHNMKKNEENE) { }

	// // RVA: 0x10C9EC4 Offset: 0x10C9EC4 VA: 0x10C9EC4
	// public string KAGBOMEDOLJ(int APHNELOFGAK) { }

	// // RVA: 0x10CA118 Offset: 0x10CA118 VA: 0x10CA118
	// public bool IJJOGGEBBPF(int APHNELOFGAK) { }

	// // RVA: 0x10CA3E0 Offset: 0x10CA3E0 VA: 0x10CA3E0
	// public int LPPJMOMKPKA(int APHNELOFGAK) { }

	// // RVA: 0x10CA804 Offset: 0x10CA804 VA: 0x10CA804
	// public int LMNGEPHLMKO() { }

	// // RVA: 0x10CA954 Offset: 0x10CA954 VA: 0x10CA954
	public int EDCAFNOBCOJ()
	{
		if(KACECFNECON != null && KACECFNECON.ANFKCPGENCM != null && KACECFNECON.ANFKCPGENCM.Count > 0)
		{
			List<MCKCJMLOAFP_CurrencyInfo> l1 = new List<MCKCJMLOAFP_CurrencyInfo>();
			for(int i = 0; i < KACECFNECON.ANFKCPGENCM.Count; i++)
			{
				int v = KACECFNECON.ANFKCPGENCM[i].DNJEJEANJGL_Value;
				MCKCJMLOAFP_CurrencyInfo c = CIOECGOMILE.HHCJCDFCLOB.BBEPLKNMICJ_Currencies.Find((MCKCJMLOAFP_CurrencyInfo GHPLINIACBB) =>
				{
					//0x10CCA48
					if (GHPLINIACBB.PPFNGGCBJKC_Id != v)
						return false;
					return GHPLINIACBB.BDLNMOIOMHK_Total > 0;
				});
				if(c != null)
				{
					l1.Add(c);
				}
			}
			if(l1.Count < 1)
			{
				return KACECFNECON.ANFKCPGENCM[0].DNJEJEANJGL_Value;
			}
			return l1[0].PPFNGGCBJKC_Id;
		}
		return 0;
	}

	// // RVA: 0x10CACD0 Offset: 0x10CACD0 VA: 0x10CACD0
	// public static bool GPKPIGPDFNL(List<LOBDIAABMKG> NNDGIAEFMOG, int HHIBBHFHENH, int GPDIDIJDKAG) { }

	// // RVA: 0x10C74DC Offset: 0x10C74DC VA: 0x10C74DC
	// public bool CKGECKPFFCC() { }

	// // RVA: 0x10CB01C Offset: 0x10CB01C VA: 0x10CB01C
	// public void EIHCALCFNEJ(LOBDIAABMKG DPBDFPPMIPH) { }
}
