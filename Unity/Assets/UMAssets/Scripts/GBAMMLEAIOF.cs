using System.Text;

public class GBAMMLEAIOF
{
	private const int FBGGEFFJJHB = 23;
	public byte[] EJJEHEHFMGO; // 0x8
	public int PGEDKFOIPIP_EventIdx; // 0xC

	// // RVA: 0x1401894 Offset: 0x1401894 VA: 0x1401894
	public void KHEKNNFCAOI_Init(int PGEDKFOIPIP, byte[] IDLHJIOMJBK)
	{
		EJJEHEHFMGO = IDLHJIOMJBK;
		this.PGEDKFOIPIP_EventIdx = PGEDKFOIPIP;
		for(int i = 0; i < IDLHJIOMJBK.Length; i++)
		{
			EJJEHEHFMGO[i] = (byte)(EJJEHEHFMGO[i] ^ 0x17);
			IDLHJIOMJBK = EJJEHEHFMGO;
		}
	}

	// // RVA: 0x1401938 Offset: 0x1401938 VA: 0x1401938
	public void KHEKNNFCAOI_Init(int PGEDKFOIPIP, EDOHBJAPLPF_JsonData AAEDAEHIONI, KIJECNFNNDB_JsonWriter LAFGAPBDKML)
	{
		LAFGAPBDKML.LCABGAFGNFL_Reset();
		IKPIMINCOPI_JsonMapper.EJCOJCGIBNG_ToJson(AAEDAEHIONI, LAFGAPBDKML);
		KHEKNNFCAOI_Init(PGEDKFOIPIP, Encoding.UTF8.GetBytes(LAFGAPBDKML.ToString()));
	}

	// // RVA: 0x1401A54 Offset: 0x1401A54 VA: 0x1401A54
	public void KHEKNNFCAOI_Init(int PGEDKFOIPIP, byte[] IDLHJIOMJBK, int POMLAOPLMNA, int MOIECBABHNP)
    {
        this.PGEDKFOIPIP_EventIdx = PGEDKFOIPIP;
        EJJEHEHFMGO = new byte[MOIECBABHNP];
        for(int i = 0; i < MOIECBABHNP; i++)
        {
            EJJEHEHFMGO[i] = IDLHJIOMJBK[i + POMLAOPLMNA];
        }
    }

	// // RVA: 0x1401B74 Offset: 0x1401B74 VA: 0x1401B74
	public string HGJLBEBNMIP_LogData()
	{
		byte[] data = new byte[EJJEHEHFMGO.Length];
		for(int i = 0; i < data.Length; i++)
		{
			data[i] = (byte)(EJJEHEHFMGO[i] ^ 0x17);
		}
		return Encoding.UTF8.GetString(data);
	}
}
