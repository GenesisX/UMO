
// Namespace: 
public class CEBFFLDKAEC // TypeDefIndex: 8690
{
	// Fields
	private int IPKONDLIDHC; // 0x8
	private int ENOBDCFHELD; // 0xC
	private int DLHDPLPLCAC; // 0x10
	private int FCEJCHGLFGN; // 0x14
	public FENCAJJBLBH.EIAPDOGALDK KGICDMIJGDF; // 0x18
	public FENCAJJBLBH NMNHBJIAPGG; // 0x1C

	// // Properties
	// public int DNJEJEANJGL { get; set; }

	// // Methods

	// // RVA: 0x12B124C Offset: 0x12B124C VA: 0x12B124C
	public int JADLONAJDAK() 
    { 
        return ENOBDCFHELD ^ DLHDPLPLCAC;
    }

	// // RVA: 0x12B125C Offset: 0x12B125C VA: 0x12B125C
	public void JFNEHIGOBHH(int NANNGLGOFKH)
    {
        KPOCKNCJBPN();
		DLHDPLPLCAC = ENOBDCFHELD ^ NANNGLGOFKH;
		IPKONDLIDHC = FCEJCHGLFGN ^ NANNGLGOFKH;
    }

	// // RVA: 0x12B1360 Offset: 0x12B1360 VA: 0x12B1360
	public CEBFFLDKAEC() 
	{ 
		KGICDMIJGDF = FENCAJJBLBH.EIAPDOGALDK.PNLBHBFOECC;
		IPKONDLIDHC = 0x5892df17;
		ENOBDCFHELD = 0x17854e73;
		DLHDPLPLCAC = 0x17854e73;
		FCEJCHGLFGN = 0x5892df17;
		NMNHBJIAPGG = null;
	}

	// // RVA: 0x12B13B0 Offset: 0x12B13B0 VA: 0x12B13B0
	// public void LHPDDGIJKNB(int HBDLKOBJHFP, int LMJDJEACHBC) { }

	// // RVA: 0x12B13CC Offset: 0x12B13CC VA: 0x12B13CC
	// public void DNBGDMBCLMI() { }

	// // RVA: 0x12B128C Offset: 0x12B128C VA: 0x12B128C
	public FENCAJJBLBH KPOCKNCJBPN() 
	{ 
		if(NMNHBJIAPGG == null)
		{
			if((ENOBDCFHELD ^ DLHDPLPLCAC) != (FCEJCHGLFGN ^ IPKONDLIDHC))
			{
				NMNHBJIAPGG = new FENCAJJBLBH(KGICDMIJGDF, 0, 0, "NetSecureValue");
			}
		}
		return NMNHBJIAPGG;
	}
}