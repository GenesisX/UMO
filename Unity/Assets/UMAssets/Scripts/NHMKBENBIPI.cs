
using System.Collections;
using System.Collections.Generic;
using XeApp.Game.Common;

public class NHMKBENBIPI
{
	public DJBHIFLHJLK FGGJNGCAFGK; // 0x10
	private JEHIAIPJNJF_FileDownloader JKJCKIMGJLM; // 0x14
	private string EHBEPOAMOFC; // 0x18
	private bool LIHOHDBDGMK; // 0x1C
	private bool IGHEMOPCHEA; // 0x1D
	private string JCMJBMBMJAK; // 0x20
	private static List<GCGNICILKLD_AssetFileInfo> ICCMKHKNAMJ; // 0x0

	public OMIFMMJPMDJ OEPPEGHGNNO { get; set; } // 0x8 KPEKONPJHCL LKCDOGAFPNM NPJJMDFAIII
	public OBHIGCFPKJN MAIHLKPEHJN { get; set; } // 0xC EAIFOAGPGGH KCLBNOKEPIG OCIMGEFKKLM
	public bool HIGBANIDIFK { get; set; } // 0x1E JOPAIHDCPFD POGACHHNMMA AHHDPJJKAJA
	//private static string FPCIBJLJOFI { get; } 0x1891348 NOJDHDJNPAL
	//private static string LBEPLOJBFCM { get; } 0x18913A4 KHCOOFHPKGE

	// RVA: 0x1891400 Offset: 0x1891400 VA: 0x1891400 Slot: 1
	~NHMKBENBIPI()
	{
		if(JKJCKIMGJLM != null)
		{
			JKJCKIMGJLM.Dispose();
			JKJCKIMGJLM = null;
		}
	}

	// RVA: 0x189147C Offset: 0x189147C VA: 0x189147C
	public void OFLDICKPNFD(bool CJPFICKPJPP, DJBHIFLHJLK FGGJNGCAFGK)
	{
		if(CJPFICKPJPP)
		{
			MAIHLKPEHJN = JHHBAFKMBDL.HHCJCDFCLOB.JDIDDHBIGIO;
		}
		else
		{
			MAIHLKPEHJN = EEHMGCMAOAB;
		}
		this.FGGJNGCAFGK = FGGJNGCAFGK;
	}

	//// RVA: 0x1891588 Offset: 0x1891588 VA: 0x1891588
	//public void DOEFFEHKKGC(Action AGPNLAKFKCN, Action NIMPEHIECJH, Action MOBEEPPKFLG) { }

	//// RVA: 0x18917BC Offset: 0x18917BC VA: 0x18917BC
	//public void BEOMIIOBGOJ(bool HGEJBINBHIC, Action OHBJNCLNKMG, IMCBBOAFION BHFHGFKBOHH, JFDNPFFOACP NIMPEHIECJH, DJBHIFLHJLK MOBEEPPKFLG) { }

	// RVA: 0x18919E8 Offset: 0x18919E8 VA: 0x18919E8
	public void PAHGEEOFEPM(bool HGEJBINBHIC, IMCBBOAFION BHFHGFKBOHH, JFDNPFFOACP NIMPEHIECJH, DJBHIFLHJLK MOBEEPPKFLG)
	{
		if(!HIGBANIDIFK)
		{
			HIGBANIDIFK = true;
			JCMJBMBMJAK = CJMOKHDNBNB.FIPFFELDIOG_PersistentPath + "/data";
			LIHOHDBDGMK = false;
			N.a.StartCoroutineWatched(EOFJPNPFGDM_Coroutine_Install(HGEJBINBHIC, BHFHGFKBOHH, NIMPEHIECJH, MOBEEPPKFLG));
		}
	}

	// RVA: 0x1891BFC Offset: 0x1891BFC VA: 0x1891BFC
	public void CEDCKHPBKLL(bool HGEJBINBHIC)
	{
		TodoLogger.LogError(0, "CEDCKHPBKLL");
	}

	//[IteratorStateMachineAttribute] // RVA: 0x6BAD8C Offset: 0x6BAD8C VA: 0x6BAD8C
	//// RVA: 0x18916E4 Offset: 0x18916E4 VA: 0x18916E4
	//private IEnumerator FCIDKNPDBIN(Action AGPNLAKFKCN, Action NIMPEHIECJH, Action MOBEEPPKFLG) { }

	//[IteratorStateMachineAttribute] // RVA: 0x6BAE04 Offset: 0x6BAE04 VA: 0x6BAE04
	//// RVA: 0x18918D8 Offset: 0x18918D8 VA: 0x18918D8
	//private IEnumerator FENMAPOLNOC(bool HGEJBINBHIC, Action OHBJNCLNKMG, IMCBBOAFION BHFHGFKBOHH, JFDNPFFOACP NIMPEHIECJH, DJBHIFLHJLK MOBEEPPKFLG) { }

	//[IteratorStateMachineAttribute] // RVA: 0x6BAE7C Offset: 0x6BAE7C VA: 0x6BAE7C
	//// RVA: 0x1891B04 Offset: 0x1891B04 VA: 0x1891B04
	private IEnumerator EOFJPNPFGDM_Coroutine_Install(bool HGEJBINBHIC, IMCBBOAFION BHFHGFKBOHH, JFDNPFFOACP NIMPEHIECJH, DJBHIFLHJLK MOBEEPPKFLG)
	{
		PopupWindowControl FPHDNEOEMEJ; // 0x34
		int NNHHACPMPPO; // 0x38
		float OFDNPDCLMGA; // 0x3C
		float BNNHBBCCPDD; // 0x40

		//0x1895D34
		TodoLogger.LogError(1, "EOFJPNPFGDM_Coroutine_Install");
		yield return null;
		BHFHGFKBOHH();
	}

	//// RVA: 0x1891C74 Offset: 0x1891C74 VA: 0x1891C74
	//private void DCGHGLMJEOK(bool EFGBODACPJF) { }

	//// RVA: 0x1891E40 Offset: 0x1891E40 VA: 0x1891E40
	//private bool ALDMHFCFECK(int INDDJNMPONH, float LNAHJANMJNM) { }

	//// RVA: 0x1891E48 Offset: 0x1891E48 VA: 0x1891E48
	private void EEHMGCMAOAB(string DOGDHKIEBJA, IMCBBOAFION KLMFJJCNBIP, JFDNPFFOACP NEFKBBNKNPP)
	{
		TodoLogger.LogError(0, "EEHMGCMAOAB");
	}

	//[IteratorStateMachineAttribute] // RVA: 0x6BAEF4 Offset: 0x6BAEF4 VA: 0x6BAEF4
	//// RVA: 0x1891E74 Offset: 0x1891E74 VA: 0x1891E74
	//private IEnumerator ECKPOFGNBFI(Action NIMPEHIECJH) { }

	//[IteratorStateMachineAttribute] // RVA: 0x6BAF6C Offset: 0x6BAF6C VA: 0x6BAF6C
	//// RVA: 0x1891F3C Offset: 0x1891F3C VA: 0x1891F3C
	//private IEnumerator LOLGOEKFGGH(Action NIMPEHIECJH) { }

	//[IteratorStateMachineAttribute] // RVA: 0x6BAFE4 Offset: 0x6BAFE4 VA: 0x6BAFE4
	//// RVA: 0x1892004 Offset: 0x1892004 VA: 0x1892004
	//private IEnumerator DNBCFNBBCIP(Action MOBEEPPKFLG) { }

	//[IteratorStateMachineAttribute] // RVA: 0x6BB05C Offset: 0x6BB05C VA: 0x6BB05C
	//// RVA: 0x18920CC Offset: 0x18920CC VA: 0x18920CC
	//private IEnumerator HKBHCEBAACH(Action AGPNLAKFKCN, Action NIMPEHIECJH) { }

	//// RVA: 0x1892194 Offset: 0x1892194 VA: 0x1892194
	//private void MABKDNHNDAL(ref List<string> JOJMBFBGMGN, string CJJJPKJHOGM) { }

	//// RVA: 0x18923A0 Offset: 0x18923A0 VA: 0x18923A0
	//public static List<GCGNICILKLD> IAPEABPJPOE(string OGCDNCDMLCA, IKAHKDKIGNA CBLEBKOJJDB, List<string> JOJMBFBGMGN) { }

	//// RVA: 0x1892CD4 Offset: 0x1892CD4 VA: 0x1892CD4
	//private static void EPGFLLGCKGA(List<string> EKHOLFOKEGN, List<int> NIPOOEMMMNK) { }
}
