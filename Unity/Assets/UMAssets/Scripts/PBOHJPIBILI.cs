
using UnityEngine;

public class PBOHJPIBILI
{
	public const int IBNJHOIDKLH = 100;

	// // RVA: 0xCBD7E8 Offset: 0xCBD7E8 VA: 0xCBD7E8
	public static int PFNBNKCPFLP_GetCannonStockMax()
    {
        return IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.HNMMJINNHII_Game.LPJLEHAJADA("mcannon_stock_max", 1);
    }

	// RVA: 0xCBD8D8 Offset: 0xCBD8D8 VA: 0xCBD8D8
	public static void GLEPHGKFFLL(out int GGNOGNOBJLP_CurrentStock, out int HLANCDFJFIA_CurrentGauge, out bool ANKEMCJFFIO_IsMax)
    {
        GGNOGNOBJLP_CurrentStock = 0;
        HLANCDFJFIA_CurrentGauge = 0;
        ANKEMCJFFIO_IsMax = false;
        GGNOGNOBJLP_CurrentStock = Mathf.Min(CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.KCCLEHLLOFG_Common.IKLFJPAGHJG_McGauge / 100, PFNBNKCPFLP_GetCannonStockMax());
        HLANCDFJFIA_CurrentGauge = GGNOGNOBJLP_CurrentStock * -100 + CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.KCCLEHLLOFG_Common.IKLFJPAGHJG_McGauge;
        ANKEMCJFFIO_IsMax = 99 < HLANCDFJFIA_CurrentGauge && PFNBNKCPFLP_GetCannonStockMax() <= GGNOGNOBJLP_CurrentStock;
    }

	// // RVA: 0xCBDA5C Offset: 0xCBDA5C VA: 0xCBDA5C
	public static int JMJOBHFFBGC_GetMcGauge()
    {
        return CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.KCCLEHLLOFG_Common.IKLFJPAGHJG_McGauge;
    }

	// // RVA: 0xCBDB38 Offset: 0xCBDB38 VA: 0xCBDB38
	public static void PGAGKCDGOIN_AddMcGauge(int OEOIHIIIMCK)
    {
        CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.KCCLEHLLOFG_Common.IKLFJPAGHJG_McGauge = Mathf.Min(CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.KCCLEHLLOFG_Common.IKLFJPAGHJG_McGauge + OEOIHIIIMCK, PBOHJPIBILI.PFNBNKCPFLP_GetCannonStockMax() * 100 + 100);
    }

	// // RVA: 0xCBDC90 Offset: 0xCBDC90 VA: 0xCBDC90
	// public static bool EFOHKCAOFFE(bool DDGFCOPPBBN = True) { }

	// // RVA: 0xCBDDE0 Offset: 0xCBDDE0 VA: 0xCBDDE0
	// public static int DIDALOAJHBE(int KIJAPOFAGPN) { }

	// // RVA: 0xCBDF5C Offset: 0xCBDF5C VA: 0xCBDF5C
	// public static int GJPMPGIIPHA(int KIJAPOFAGPN) { }

	// // RVA: 0xCBE138 Offset: 0xCBE138 VA: 0xCBE138
	// public static int BPAOMGFCODD(int KIJAPOFAGPN, IMCBBOAFION BHFHGFKBOHH) { }
}
