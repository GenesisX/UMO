
[System.Obsolete("Use AIBFEFOFMFK_LineLinkage", true)]
public class AIBFEFOFMFK_Line { }
public class AIBFEFOFMFK_LineLinkage : AILHMHMOKKA_BaseLinkage
{
	private const int JGFDMBLDIGP_LineVersion = 1;

	//// RVA: 0xCCA700 Offset: 0xCCA700 VA: 0xCCA700 Slot: 4
	public override void EMKKJILHOOB_GetLinkageStatus(IMCBBOAFION BHFHGFKBOHH, JFDNPFFOACP NIMPEHIECJH, DJBHIFLHJLK AOCANKOMKFG)
	{
		JEDJNIKPFLH_IsLinked = false;
		MOJEDCPFGJJ_IsVersionOk = false;
		LNBLBFPAKPP_GetLineLinkageStatus req = NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF_ServerRequester.IFFNCAFNEAG_AddRequest(new LNBLBFPAKPP_GetLineLinkageStatus());
		req.ICDEFIIADDO_Timeout = 15;
		req.NBFDEFGFLPJ = DGLAMLJFEDB_CheckError;
		req.BHFHGFKBOHH_OnSuccess = (CACGCMBKHDI_Request JIPCHHHLOMM) =>
		{
			//0xCCB0D4
			LNBLBFPAKPP_GetLineLinkageStatus r = JIPCHHHLOMM as LNBLBFPAKPP_GetLineLinkageStatus;
			JEDJNIKPFLH_IsLinked = r.NFEAMMJIMPG.EFKMIECABBK_LineLinkage;
			if (r.NFEAMMJIMPG.OOOIPFEGKFD_Version == JGFDMBLDIGP_LineVersion)
				MOJEDCPFGJJ_IsVersionOk = true;
			BHFHGFKBOHH();
		};
		req.MOBEEPPKFLG_OnFail = (CACGCMBKHDI_Request JIPCHHHLOMM) =>
		{
			//0xCCB418
			TodoLogger.LogError(0, "MOBEEPPKFLG_OnFail");
		};
	}

	//// RVA: 0xCCA99C Offset: 0xCCA99C VA: 0xCCA99C Slot: 5
	//public override void GGNBIHHFJMP(IMCBBOAFION BHFHGFKBOHH, JFDNPFFOACP NIMPEHIECJH, DJBHIFLHJLK AOCANKOMKFG) { }

	//// RVA: 0xCCABE4 Offset: 0xCCABE4 VA: 0xCCABE4 Slot: 6
	//public override void MOHPODEDIEK(IMCBBOAFION BHFHGFKBOHH, JFDNPFFOACP NIMPEHIECJH, DJBHIFLHJLK AOCANKOMKFG) { }

	//// RVA: 0xCCAE2C Offset: 0xCCAE2C VA: 0xCCAE2C Slot: 7
	//public override void BMJMJCIKALP(IMCBBOAFION BHFHGFKBOHH, JFDNPFFOACP NIMPEHIECJH, DJBHIFLHJLK AOCANKOMKFG) { }
}
