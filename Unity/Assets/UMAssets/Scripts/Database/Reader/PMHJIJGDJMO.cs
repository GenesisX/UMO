using FlatBuffers;
using System.Collections.Generic;

public class FBCAIGGLGMK
{
	public uint PPFNGGCBJKC { get; set; } // 0x8 FDGEMCPHJCB DEMEPMAEJOO HIGKAIDMOKN
	public uint PLALNIIBLOF { get; set; } // 0xC DFMNDOMAPAB JPCJNLHHIPE JJFJNEJLBDG
	public uint FNEIADJMHHO { get; set; } // 0x10 PJFAGECNJCF FAPDANAMOKF JIHDPPHAAOJ
	public uint KOMKKBDABJP { get; set; } // 0x14 JPPMFGFLNGH MOMCBDJIGKO NECMHGINPDE
	public string[] EHDDADDKMFI { get; set; } // 0x18 MCAKELLLNIO IFFJALDBDDI LMLHCMMIEJH
	public string GENIJOLKBNH { get; set; } // 0x1C IDAFBNJFLAE BJIGPDFOCBK CIJOJAMNIEC
	public int BFINGCJHOHI { get; set; } // 0x20 PIAHJAJPLKA LFMCLIDAPHB EDAEPDGGFJJ
	public int OEOIHIIIMCK { get; set; } // 0x24 CJPIOPLFGFA BLMLNFDOJHF IJLDMBPEGAK
}
public class PMHJIJGDJMO
{
	public FBCAIGGLGMK[] MDFFJJKBDFC { get; set; } // 0x8 MLEEAALCDDB CGKHDMIDHGN MDIFADGJNNH
	public static PMHJIJGDJMO HEGEKFMJNCC(byte[] NIODCJLINJN)// 0xFEFAF0
	{
		ByteBuffer buffer = new ByteBuffer(NIODCJLINJN);
		CFFBOCDCDCJ res_readData = CFFBOCDCDCJ.GetRootAsCFFBOCDCDCJ(buffer);
		PMHJIJGDJMO res_data = new PMHJIJGDJMO();

		List<FBCAIGGLGMK> MDFFJJKBDFC_list = new List<FBCAIGGLGMK>();
		for(int MDFFJJKBDFC_idx = 0; MDFFJJKBDFC_idx < res_readData.CGHMONDBJAILength; MDFFJJKBDFC_idx++)
		{
			ACFFNDFGCHL MDFFJJKBDFC_readData = res_readData.GetCGHMONDBJAI(MDFFJJKBDFC_idx);
			FBCAIGGLGMK MDFFJJKBDFC_data = new FBCAIGGLGMK();

			MDFFJJKBDFC_data.PPFNGGCBJKC = MDFFJJKBDFC_readData.BBPHAPFBFHK;
			MDFFJJKBDFC_data.PLALNIIBLOF = MDFFJJKBDFC_readData.CFLMCGOJJJD;
			MDFFJJKBDFC_data.FNEIADJMHHO = MDFFJJKBDFC_readData.GLIIHLOLPEF;
			MDFFJJKBDFC_data.KOMKKBDABJP = MDFFJJKBDFC_readData.BNDAHALMIPE;
			List<string> EHDDADDKMFI_list = new List<string>();
			for(int EHDDADDKMFI_idx = 0; EHDDADDKMFI_idx < MDFFJJKBDFC_readData.BKLDFCFKFOMLength; EHDDADDKMFI_idx++)
			{
				EHDDADDKMFI_list.Add(MDFFJJKBDFC_readData.GetBKLDFCFKFOM(EHDDADDKMFI_idx));
			}
			MDFFJJKBDFC_data.EHDDADDKMFI = EHDDADDKMFI_list.ToArray();

			MDFFJJKBDFC_data.GENIJOLKBNH = MDFFJJKBDFC_readData.IOKCFIHFBHG;
			MDFFJJKBDFC_data.BFINGCJHOHI = MDFFJJKBDFC_readData.CLEEFGNMCEL;
			MDFFJJKBDFC_data.OEOIHIIIMCK = MDFFJJKBDFC_readData.GKMDCGBFHPM;
			MDFFJJKBDFC_list.Add(MDFFJJKBDFC_data);
		}
		res_data.MDFFJJKBDFC = MDFFJJKBDFC_list.ToArray();

		return res_data;
	}
}
