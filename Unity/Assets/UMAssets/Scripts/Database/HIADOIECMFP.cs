
using System.Collections.Generic;

[System.Obsolete("Use HIADOIECMFP_EventPresentCampaign", true)]
public class HIADOIECMFP { }
public class HIADOIECMFP_EventPresentCampaign : DIHHCBACKGG_DbSection
{
	public class ABHKBHBKAJH
	{
		public int OBGBAOLONDD; // 0x8
		public int HFNIHKOAMGC; // 0xC
		public string OPFGFINHFCE; // 0x10
		public string OCGFKMHNEOF; // 0x14
		public string FEMMDNIELFC; // 0x18
		public long BONDDBOFBND; // 0x20
		public long HPNOGLIFJOP; // 0x28
		public long LNFKGHNHJKE; // 0x30
		public long JGMDAOACOJF; // 0x38
		public long IDDBFFBPNGI; // 0x40
		public long KNLGKBBIBOH; // 0x48
		public int MJBKGOJBPAD; // 0x50
		public sbyte POGEFBMBPCB; // 0x54
		public sbyte AHKNMANFILO; // 0x55
		public sbyte MOEKELIIDEO; // 0x56
		public sbyte HKKNEAGCIEB; // 0x57
		public string OMCAOJJGOGG; // 0x58
		private NNJFKLBPBNK_SecureString EBGIDCIIGDO = new NNJFKLBPBNK_SecureString(); // 0x5C
		public int HIOOGLEJBKM; // 0x60
		public int FJCADCDNPMP; // 0x64
		public int[] EJBGHLOOLBC; // 0x68

		//public string OCDMGOGMHGE { get; set; } 0x1835640 HBAAAKFHDBB 0x1834888 NHJLJOIPOFK

		//// RVA: 0x1833DE4 Offset: 0x1833DE4 VA: 0x1833DE4
		//public void LHPDDGIJKNB() { }

		//// RVA: 0x183561C Offset: 0x183561C VA: 0x183561C
		//public uint CAOGDCBPBAN() { }
	}

	public class KEOBDBGPGPC
	{
		public int PPFNGGCBJKC; // 0x8
		public int HMFFHLPNMPH; // 0xC
		public string FEMMDNIELFC; // 0x10
		public string MCNPILDHLEE; // 0x14
		public string OJHJLJLCKAC; // 0x18
		public int PNFGDBDNODC; // 0x1C
		public int KCGJGPOFOCD; // 0x20
		public List<int> GLCLFMGPMAN = new List<int>(); // 0x24
		public List<int> MBJIFDBEDAC = new List<int>(); // 0x28

		//// RVA: 0x18356EC Offset: 0x18356EC VA: 0x18356EC
		//public void LHPDDGIJKNB(int PPFNGGCBJKC) { }

		//// RVA: 0x1834CE4 Offset: 0x1834CE4 VA: 0x1834CE4
		//public void KHEKNNFCAOI(int PPFNGGCBJKC, CEGMAIDIKLC JMHECKKKMLK) { }

		//// RVA: 0x1835624 Offset: 0x1835624 VA: 0x1835624
		//public uint CAOGDCBPBAN() { }
	}

	public class DFPGOAOKPBI
	{
		public int PPFNGGCBJKC; // 0x8
		public int KLCMKLPIDDJ; // 0xC
		public int BAOFEFFADPD; // 0x10
		public long FKPEAGGKNLC; // 0x18
		public long KOMKKBDABJP; // 0x20
		public string LJNAKDMILMC; // 0x28

		//// RVA: 0x183566C Offset: 0x183566C VA: 0x183566C
		//public void LHPDDGIJKNB(int PPFNGGCBJKC) { }

		//// RVA: 0x1835034 Offset: 0x1835034 VA: 0x1835034
		//public void KHEKNNFCAOI(int PPFNGGCBJKC, CEGMAIDIKLC JMHECKKKMLK) { }
	}

	public ABHKBHBKAJH NGHKJOEDLIP = new ABHKBHBKAJH(); // 0x20
	public List<DFPGOAOKPBI> EENHCEEKBBD = new List<DFPGOAOKPBI>(); // 0x24
	public List<KEOBDBGPGPC> OBPOHDENMHH = new List<KEOBDBGPGPC>(); // 0x28

	public Dictionary<string, NNJFKLBPBNK_SecureString> FJOEBCMGDMI { get; private set; } // 0x2C IHKPIFIBECO GAMGELHIHHI DDDEJIJGGBJ
	public Dictionary<string, CEBFFLDKAEC_SecureInt> OHJFBLFELNK { get; private set; } // 0x30 KLDCHOIPJGB AEMNOGNEBOJ DGKDBOAMNBB

	//// RVA: 0x18338D8 Offset: 0x18338D8 VA: 0x18338D8
	//public string EFEGBHACJAL(string LJNAKDMILMC, string KKMJBMKHGNH) { }

	//// RVA: 0x18339BC Offset: 0x18339BC VA: 0x18339BC
	//public int LPJLEHAJADA(string LJNAKDMILMC, int KKMJBMKHGNH) { }

	// RVA: 0x1833AA0 Offset: 0x1833AA0 VA: 0x1833AA0
	public HIADOIECMFP_EventPresentCampaign()
	{
		JIKKNHIAEKG_BlockName = "";
		LNIMEIMBCMF = false;
		OHJFBLFELNK = new Dictionary<string, CEBFFLDKAEC_SecureInt>();
		FJOEBCMGDMI = new Dictionary<string, NNJFKLBPBNK_SecureString>();
		LMHMIIKCGPE = 36;
	}

	// RVA: 0x1833CCC Offset: 0x1833CCC VA: 0x1833CCC Slot: 8
	protected override void KMBPACJNEOF()
	{
		TodoLogger.LogError(TodoLogger.Database, "HIADOIECMFP_EventPresentCampaign.KMBPACJNEOF");
	}

	// RVA: 0x1833E94 Offset: 0x1833E94 VA: 0x1833E94 Slot: 9
	public override bool IIEMACPEEBJ(byte[] DBBGALAPFGC)
	{
		TodoLogger.LogError(TodoLogger.Database, "HIADOIECMFP_EventPresentCampaign.IIEMACPEEBJ");
		return true;
	}

	// RVA: 0x1834880 Offset: 0x1834880 VA: 0x1834880 Slot: 10
	public override bool IIEMACPEEBJ(EDOHBJAPLPF_JsonData OILEIIEIBHP, int KAPMOPMDHJE)
	{
		TodoLogger.LogError(TodoLogger.Database, "HIADOIECMFP_EventPresentCampaign.IIEMACPEEBJ");
		return true;
	}

	//// RVA: 0x1834180 Offset: 0x1834180 VA: 0x1834180
	//private bool DGKKMKLCEDF(CEGMAIDIKLC JMHECKKKMLK) { }

	//// RVA: 0x18348BC Offset: 0x18348BC VA: 0x18348BC
	//private bool DGKKMKLCEDF(EDOHBJAPLPF IDLHJIOMJBK, int KAPMOPMDHJE) { }

	//// RVA: 0x18348C4 Offset: 0x18348C4 VA: 0x18348C4
	//private void EEEKPHDPJHG(List<int> NNDGIAEFMOG, EDOHBJAPLPF OBHAFLMHAKG, string OPFGFINHFCE, ref bool NGJDHLGMHMH) { }

	//// RVA: 0x1834AA4 Offset: 0x1834AA4 VA: 0x1834AA4
	//private void EEEKPHDPJHG(List<int> NNDGIAEFMOG, string OAIBJJHGCNM) { }

	//// RVA: 0x18345B4 Offset: 0x18345B4 VA: 0x18345B4
	//private bool HMGBIBOJDBA(CEGMAIDIKLC JMHECKKKMLK) { }

	//// RVA: 0x1834718 Offset: 0x1834718 VA: 0x1834718
	//private bool AFLBFOPMIME(CEGMAIDIKLC JMHECKKKMLK) { }

	// RVA: 0x1835510 Offset: 0x1835510 VA: 0x1835510 Slot: 11
	public override uint CAOGDCBPBAN()
	{
		TodoLogger.LogError(TodoLogger.DbIntegrityCheck, "HIADOIECMFP_EventPresentCampaign.CAOGDCBPBAN");
		return 0;
	}
}
