public class BHLFHHBDGHO
{

	// RVA: 0xC7F450 Offset: 0xC7F450 VA: 0xC7F450
	public static void GEJEDJNKBOF(string CFIAJGOIOOC, IMCBBOAFION BHFHGFKBOHH, DJBHIFLHJLK FKKBDDDJKFB, DJBHIFLHJLK AOCANKOMKFG)
	{
		CDDNGKNGPDP_NgWordsValidate req = NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF_ServerRequester.IFFNCAFNEAG_AddRequest(new CDDNGKNGPDP_NgWordsValidate());
		req.LGFLNOJDHHC["word"] = CFIAJGOIOOC;
		req.NBFDEFGFLPJ = (SakashoErrorId CNAIDEAFAAM) =>
		{
			//0xC7F7E4
			return CNAIDEAFAAM == SakashoErrorId.INCLUDED_NG_WORDS;
		};
		req.BHFHGFKBOHH_OnSuccess = (CACGCMBKHDI_Request JIPCHHHLOMM) =>
		{
			//0xC7F7F4
			BHFHGFKBOHH();
		};
		req.MOBEEPPKFLG_OnFail = (CACGCMBKHDI_Request JIPCHHHLOMM) =>
		{
			//0xC7F820
			if(JIPCHHHLOMM.CJMFJOMECKI_ErrorId != SakashoErrorId.INCLUDED_NG_WORDS)
			{
				AOCANKOMKFG();
				return;
			}
			JHHBAFKMBDL.HHCJCDFCLOB.HNGIOFBLLDA(FKKBDDDJKFB);
		};
	}
}