using FlatBuffers;
using System.Collections.Generic;

public class BPIFDOECJPH
{
	public int PPFNGGCBJKC { get; set; } // 0x8 FDGEMCPHJCB DEMEPMAEJOO HIGKAIDMOKN
	public int JPFMJHLCMJL { get; set; } // 0xC PIJIPMOBEIJ LLFFAPHPGFJ PMGNHNIKHLE
	public int MJMPANIBFED { get; set; } // 0x10 GGAJJGLDIII LPHIIIAOHBE POHHJDNBLOD
}
public class LBMIEHAHNFD
{
	public BPIFDOECJPH[] NNCNIHFAPBO { get; set; } // 0x8 MOOJCMAAIPD CFNFEFAGEFM DMPLBFJCPDE
	public static LBMIEHAHNFD HEGEKFMJNCC(byte[] NIODCJLINJN)// 0xD99910
	{
		ByteBuffer buffer = new ByteBuffer(NIODCJLINJN);
		IBBBNNBOBLD res_readData = IBBBNNBOBLD.GetRootAsIBBBNNBOBLD(buffer);
		LBMIEHAHNFD res_data = new LBMIEHAHNFD();

		List<BPIFDOECJPH> NNCNIHFAPBO_list = new List<BPIFDOECJPH>();
		for(int NNCNIHFAPBO_idx = 0; NNCNIHFAPBO_idx < res_readData.EIACEFFDPEFLength; NNCNIHFAPBO_idx++)
		{
			HFKBJAIMIBG NNCNIHFAPBO_readData = res_readData.GetEIACEFFDPEF(NNCNIHFAPBO_idx);
			BPIFDOECJPH NNCNIHFAPBO_data = new BPIFDOECJPH();

			NNCNIHFAPBO_data.PPFNGGCBJKC = NNCNIHFAPBO_readData.BBPHAPFBFHK;
			NNCNIHFAPBO_data.JPFMJHLCMJL = NNCNIHFAPBO_readData.GJEJFAJHBME;
			NNCNIHFAPBO_data.MJMPANIBFED = NNCNIHFAPBO_readData.COPFAKAHEMN;
			NNCNIHFAPBO_list.Add(NNCNIHFAPBO_data);
		}
		res_data.NNCNIHFAPBO = NNCNIHFAPBO_list.ToArray();

		return res_data;
	}
}
