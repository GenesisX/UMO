

[System.Obsolete("Use BKNLPABECOB_FacebookLinkage", true)]
public class BKNLPABECOB { }
public class BKNLPABECOB_FacebookLinkage : AILHMHMOKKA_BaseLinkage
{
	private string NOBJMCIIHKO; // 0xC

	//// RVA: 0xC890E0 Offset: 0xC890E0 VA: 0xC890E0 Slot: 4
	public override void EMKKJILHOOB_GetLinkageStatus(IMCBBOAFION BHFHGFKBOHH, JFDNPFFOACP NIMPEHIECJH, DJBHIFLHJLK AOCANKOMKFG)
	{
		JEDJNIKPFLH_IsLinked = false;
		NCBEKFBAFCL_GetFacebookLinkageStatus req = NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF_ServerRequester.IFFNCAFNEAG_AddRequest(new NCBEKFBAFCL_GetFacebookLinkageStatus());
		req.ICDEFIIADDO_Timeout = 15;
		req.NBFDEFGFLPJ = DGLAMLJFEDB_CheckError;
		req.BHFHGFKBOHH_OnSuccess = (CACGCMBKHDI_Request JIPCHHHLOMM) =>
		{
			//0xC89A84
			NCBEKFBAFCL_GetFacebookLinkageStatus r = JIPCHHHLOMM as NCBEKFBAFCL_GetFacebookLinkageStatus;
			JEDJNIKPFLH_IsLinked = r.NFEAMMJIMPG.EMEGKEGFJBK_FacebookLinkage;
			BHFHGFKBOHH();
		};
		req.MOBEEPPKFLG_OnFail = (CACGCMBKHDI_Request JIPCHHHLOMM) =>
		{
			//0xC89C5C
			TodoLogger.LogError(0, "MOBEEPPKFLG_OnFail");
		};
	}

	//// RVA: 0xC8935C Offset: 0xC8935C VA: 0xC8935C Slot: 5
	//public override void GGNBIHHFJMP(IMCBBOAFION BHFHGFKBOHH, JFDNPFFOACP NIMPEHIECJH, DJBHIFLHJLK AOCANKOMKFG) { }

	//// RVA: 0xC895A4 Offset: 0xC895A4 VA: 0xC895A4 Slot: 6
	//public override void MOHPODEDIEK(IMCBBOAFION BHFHGFKBOHH, JFDNPFFOACP NIMPEHIECJH, DJBHIFLHJLK AOCANKOMKFG) { }

	//// RVA: 0xC897EC Offset: 0xC897EC VA: 0xC897EC Slot: 7
	//public override void BMJMJCIKALP(IMCBBOAFION BHFHGFKBOHH, JFDNPFFOACP NIMPEHIECJH, DJBHIFLHJLK AOCANKOMKFG) { }
}
