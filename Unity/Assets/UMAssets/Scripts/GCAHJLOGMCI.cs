
public class GCAHJLOGMCI
{
	public enum KNMMOMEHDON_GachaType
	{
		HJNNKCMLGFL_0 = 0,
		CCAPCGPIIPF_1 = 1,
		PHABJLGFJNI_2 = 2,
		GENEIBGNMPH_3 = 3,
		JGDEHOGIENP_4 = 4,
		GKDFKDLFNAJ_5 = 5,
		BKNHBNINDOC_6 = 6,
		ANFKBNLLJFN_7 = 7,
		BCBJMKDAAKA_8 = 8,
		OOABDNHIEFK_9 = 9,
		DLOPEFGOAPD_10 = 10,
		AEFCOHJBLPO_11 = 11,
	}

	public enum NFCAJPIJFAM_SummonType
	{
		HJNNKCMLGFL_0 = 0,
		AIMPCCIHKAJ_1 = 1,
		DIHBOGEPHFI_2 = 2,
		ODDGKAKAGLE_3 = 3,
		AKHEAGMMIAM_4 = 4,
		GOAHICNDICO_5 = 5,
		LMHDFEKIDKG_6 = 6,
		OBLEFFEJGIJ_8 = 8,
		NGAHKKOBGPA_9 = 9,
		BPPLDIBMPKH_10 = 10,
		AEFCOHJBLPO_11 = 11,
	}

	private const int KBAHKEAEDEJ = 1000000;
	private const int HHOIIDMKCIG = 10;

	//// RVA: 0x16A9698 Offset: 0x16A9698 VA: 0x16A9698
	public static KNMMOMEHDON_GachaType OLMFIANJBOB_GetGachaType(int KAPMOPMDHJE)
	{
		return (KNMMOMEHDON_GachaType)((KAPMOPMDHJE / 1000000) % 100);
	}

	//// RVA: 0x16A96CC Offset: 0x16A96CC VA: 0x16A96CC
	public static int GPAJHMLOPNP_GetGachaId(int KAPMOPMDHJE)
	{
		return (KAPMOPMDHJE % 1000000) / 100;
	}

	//// RVA: 0x16A9704 Offset: 0x16A9704 VA: 0x16A9704
	//public static int AIAOCEGMOJP(int KAPMOPMDHJE) { }

	//// RVA: 0x16A971C Offset: 0x16A971C VA: 0x16A971C
	public static int BDJDDKBCHKO(int KAPMOPMDHJE)
	{
		return (KAPMOPMDHJE / 10) % 10;
	}

	//// RVA: 0x16A9748 Offset: 0x16A9748 VA: 0x16A9748
	public static NFCAJPIJFAM_SummonType HHFLDFFJICJ_GetGachaSummonType(int KAPMOPMDHJE)
	{
		return (NFCAJPIJFAM_SummonType)(KAPMOPMDHJE % 10);
	}

	//// RVA: 0x16A9768 Offset: 0x16A9768 VA: 0x16A9768
	public static long PMBGPACNPIN(KNMMOMEHDON_GachaType INDDJNMPONH, string OPFGFINHFCE, long KJBGCLPMLCG, long NMPMNPLGIEL = 0)
	{
		if(INDDJNMPONH != KNMMOMEHDON_GachaType.CCAPCGPIIPF_1/*1*/ && INDDJNMPONH != KNMMOMEHDON_GachaType.ANFKBNLLJFN_7/*7*/)
		{
			if(INDDJNMPONH == KNMMOMEHDON_GachaType.GENEIBGNMPH_3)
			{
				if(OPFGFINHFCE.Contains(JpStringLiterals.StringLiteral_10431))
				{
					NMPMNPLGIEL = 0;
					TodoLogger.LogError(TodoLogger.ToCheck, "PMBGPACNPIN values");
					return NMPMNPLGIEL | KJBGCLPMLCG | (0xff0000 << 32);
				}
			}
			if(NMPMNPLGIEL != 0)
			{
				TodoLogger.LogError(TodoLogger.ToCheck, "PMBGPACNPIN values");
				return NMPMNPLGIEL | KJBGCLPMLCG;
			}
			long val = 0;
			if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.GDEKCOOBLMA_System.IOIDJALFFJA_GachaSortPriority.TryGetValue((int)INDDJNMPONH, out val))
			{
				TodoLogger.LogError(TodoLogger.ToCheck, "PMBGPACNPIN values");
				return val | KJBGCLPMLCG;
			}
		}
		NMPMNPLGIEL = 0;
		TodoLogger.LogError(TodoLogger.ToCheck, "PMBGPACNPIN values");
		return NMPMNPLGIEL | KJBGCLPMLCG;
	}
}
