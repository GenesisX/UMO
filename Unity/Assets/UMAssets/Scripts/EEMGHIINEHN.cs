using System.Collections.Generic;
using XeApp.Game;

public class EEMGHIINEHN
{
	public enum LMPEOKPFKCA
	{
		HONJMAFKFMA = 0,
		EKKJBJDFHFN = 1,
		DEPNDHEKPNC = 2,
		KMBLOGHDEMI = 3,
		AEFCOHJBLPO = 4,
	}

	public class OPANFJDIEGH
	{
		public GCIJNCFDNON_SceneInfo[] JOHLGBDOLNO_AssistScenes = new GCIJNCFDNON_SceneInfo[4]; // 0x8
		public string JCJNKBKMJFK_Name; // 0xC

		// RVA: 0x1C4A128 Offset: 0x1C4A128 VA: 0x1C4A128
		public OPANFJDIEGH()
		{
			for(int i = 0; i < JOHLGBDOLNO_AssistScenes.Length; i++)
			{
				JOHLGBDOLNO_AssistScenes[i] = new GCIJNCFDNON_SceneInfo();
			}
		}

		// RVA: 0x1C4B364 Offset: 0x1C4B364 VA: 0x1C4B364
		public void LDHHJFHGGMA(BBHNACPENDM_ServerSaveData LDEGEHAEALK)
		{
			JNMFKOHFAFB_PublicStatus.ONCMONJIPCD assist = LDEGEHAEALK.MHEAEGMIKIE_PublicStatus.MGMFOJPNDGA_AssistData;
			for(int i = 0; i < JOHLGBDOLNO_AssistScenes.Length; i++)
			{
				if(assist.JOHLGBDOLNO_DataList[i].PPFNGGCBJKC_Id > 0)
				{
					JOHLGBDOLNO_AssistScenes[i].KHEKNNFCAOI(assist.JOHLGBDOLNO_DataList[i].PPFNGGCBJKC_Id,
						assist.JOHLGBDOLNO_DataList[i].PDNIFBEGMHC_Mb,
						assist.JOHLGBDOLNO_DataList[i].EMOJHJGHJLN_Sb,
						assist.JOHLGBDOLNO_DataList[i].JPIPENJGGDD_Mlt, 1,
						assist.JOHLGBDOLNO_DataList[i].MJBODMOLOBC_Luck, false, 0, 
						assist.JOHLGBDOLNO_DataList[i].DMNIMMGGJJJ_Leaf);
				}
			}
			JCJNKBKMJFK_Name = assist.JCJNKBKMJFK_Name;
		}
	}

	private List<OPANFJDIEGH> NPDOIBMDEGK = new List<OPANFJDIEGH>(); // 0x8

	//// RVA: 0x1C49D40 Offset: 0x1C49D40 VA: 0x1C49D40
	private void AODCGBBHKDJ(BBHNACPENDM_ServerSaveData LDEGEHAEALK, int IGNIIEBMFIN = 0)
	{
		JNMFKOHFAFB_PublicStatus.ONCMONJIPCD saveAssistPlate = LDEGEHAEALK.IGNHLKEMJND_AssistPlate.LDIINNKMLLO[IGNIIEBMFIN];
		OPANFJDIEGH data = new OPANFJDIEGH();
		for(int i = 0; i < saveAssistPlate.JOHLGBDOLNO_DataList.Length; i++)
		{
			if(saveAssistPlate.JOHLGBDOLNO_DataList[i].PPFNGGCBJKC_Id > 0)
			{
				MMPBPOIFDAF_Scene.PMKOFEIONEG saveScene = LDEGEHAEALK.PNLOINMCCKH_Scene.OPIBAPEGCLA[saveAssistPlate.JOHLGBDOLNO_DataList[i].PPFNGGCBJKC_Id - 1];
				data.JOHLGBDOLNO_AssistScenes[i].KHEKNNFCAOI(saveScene.PPFNGGCBJKC_Id, saveScene.PDNIFBEGMHC_Mb, saveScene.EMOJHJGHJLN_Sb, saveScene.JPIPENJGGDD_Mlt, 1, saveScene.MJBODMOLOBC_Luck, saveScene.LHMOAJAIJCO_New, saveScene.DMNIMMGGJJJ_Leaf);
			}
		}
		data.JCJNKBKMJFK_Name = saveAssistPlate.JCJNKBKMJFK_Name;
		NPDOIBMDEGK.Add(data);
	}

	//// RVA: 0x1C4A250 Offset: 0x1C4A250 VA: 0x1C4A250
	public void KHEKNNFCAOI()
	{
		NPDOIBMDEGK.Clear();
		for(int i = 0; i < 5; i++)
		{
			AODCGBBHKDJ(CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave, i);
		}
	}

	//// RVA: 0x1C4A348 Offset: 0x1C4A348 VA: 0x1C4A348
	public void CLFGOPNDGNL_SetScene(GCIJNCFDNON_SceneInfo IFGEJDMMAHE, int IGNIIEBMFIN, int IMJIADPJJMM)
	{
		if (CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave != null)
		{
			NPDOIBMDEGK[IGNIIEBMFIN].JOHLGBDOLNO_AssistScenes[IMJIADPJJMM].KHEKNNFCAOI(IFGEJDMMAHE.BCCHOBPJJKE_SceneId, IFGEJDMMAHE.KBOLNIBLIND, IFGEJDMMAHE.ODKMKEHJOCK, IFGEJDMMAHE.JPIPENJGGDD_NumBoard, IFGEJDMMAHE.IELENGDJPHF, IFGEJDMMAHE.MJBODMOLOBC_Luck, false, 0, IFGEJDMMAHE.MKHFCGPJPFI_LimitOverCount);
			CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.IGNHLKEMJND_AssistPlate.LDIINNKMLLO[IGNIIEBMFIN].JOHLGBDOLNO_DataList[IMJIADPJJMM].DOMFHDPMCCO(IFGEJDMMAHE.BCCHOBPJJKE_SceneId, IFGEJDMMAHE.KBOLNIBLIND, IFGEJDMMAHE.ODKMKEHJOCK, IFGEJDMMAHE.MJBODMOLOBC_Luck, IFGEJDMMAHE.JPIPENJGGDD_NumBoard, IFGEJDMMAHE.MKHFCGPJPFI_LimitOverCount);
		}
	}

	//// RVA: 0x1C4A6FC Offset: 0x1C4A6FC VA: 0x1C4A6FC
	public void IONKIJLHJDP()
	{
		GCIJNCFDNON_SceneInfo scene = new GCIJNCFDNON_SceneInfo();
		KHEKNNFCAOI();
		for(int i = 0; i < NPDOIBMDEGK.Count; i++)
		{
			for(int j = 0; j < NPDOIBMDEGK[i].JOHLGBDOLNO_AssistScenes.Length; j++)
			{
				if(NPDOIBMDEGK[i].JOHLGBDOLNO_AssistScenes[j].BCCHOBPJJKE_SceneId > 0)
				{
					CLFGOPNDGNL_SetScene(GameManager.Instance.ViewPlayerData.OPIBAPEGCLA_Scenes[NPDOIBMDEGK[i].JOHLGBDOLNO_AssistScenes[j].BCCHOBPJJKE_SceneId - 1], i, j);
				}
			}
		}
		AIMMBGFMFOD(ILHBCOMKHOO());
	}

	//// RVA: 0x1C4AC78 Offset: 0x1C4AC78 VA: 0x1C4AC78
	public void NODLMHKAGFD_RemoveScene(int IGNIIEBMFIN, int IMJIADPJJMM)
	{
		if (CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave == null)
			return;
		NPDOIBMDEGK[IGNIIEBMFIN].JOHLGBDOLNO_AssistScenes[IMJIADPJJMM] = new GCIJNCFDNON_SceneInfo();
		CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.IGNHLKEMJND_AssistPlate.LDIINNKMLLO[IGNIIEBMFIN].JOHLGBDOLNO_DataList[IMJIADPJJMM].KMBPACJNEOF_Reset();
	}

	//// RVA: 0x1C4AEB8 Offset: 0x1C4AEB8 VA: 0x1C4AEB8
	public void EGENJDLKEJP(int IGNIIEBMFIN, string JAOODKBNALI)
	{
		CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.IGNHLKEMJND_AssistPlate.LDIINNKMLLO[IGNIIEBMFIN].JCJNKBKMJFK_Name = JAOODKBNALI;
	}

	//// RVA: 0x1C4AAF4 Offset: 0x1C4AAF4 VA: 0x1C4AAF4
	public void AIMMBGFMFOD(int IGNIIEBMFIN)
	{
		JNMFKOHFAFB_PublicStatus.ONCMONJIPCD data = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.IGNHLKEMJND_AssistPlate.LDIINNKMLLO[IGNIIEBMFIN];
		CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.MHEAEGMIKIE_PublicStatus.MGMFOJPNDGA_AssistData.DOMFHDPMCCO(data.JOHLGBDOLNO_DataList, data.JCJNKBKMJFK_Name);
	}

	//// RVA: 0x1C4AFCC Offset: 0x1C4AFCC VA: 0x1C4AFCC
	public void CEIOGBFIDKI_SetPage(int IGNIIEBMFIN)
	{
		CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.IGNHLKEMJND_AssistPlate.HODDNKENKHD_Page = IGNIIEBMFIN;
	}

	//// RVA: 0x1C4B0A0 Offset: 0x1C4B0A0 VA: 0x1C4B0A0
	public OPANFJDIEGH IOKHHOCMNKA(int IGNIIEBMFIN)
	{
		return NPDOIBMDEGK[IGNIIEBMFIN];
	}

	//// RVA: 0x1C4B120 Offset: 0x1C4B120 VA: 0x1C4B120
	//public EEMGHIINEHN.OPANFJDIEGH IOKHHOCMNKA() { }

	//// RVA: 0x1C4B204 Offset: 0x1C4B204 VA: 0x1C4B204
	public GCIJNCFDNON_SceneInfo ELBLMMPEKPH_GetAssistScene(int IGNIIEBMFIN, int IMJIADPJJMM)
	{
		return NPDOIBMDEGK[IGNIIEBMFIN].JOHLGBDOLNO_AssistScenes[IMJIADPJJMM];
	}

	//// RVA: 0x1C4AA20 Offset: 0x1C4AA20 VA: 0x1C4AA20
	public int ILHBCOMKHOO()
	{
		return CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.IGNHLKEMJND_AssistPlate.HODDNKENKHD_Page;
	}
}
