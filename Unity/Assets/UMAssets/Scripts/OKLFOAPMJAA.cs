
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OKLFOAPMJAA
{
	public delegate bool IGJCFFIGKIJ(ANPBHCNJIDI.NNPGLGHDBKN FJEAKGIIKIL);

	public class BABPHOEGLPC
	{
		internal ANPBHCNJIDI LPEPBLHCGKP; // 0x8
		internal int BIDNGGDPPIM_AutoUpdateInterval; // 0xC
		internal int GNIINAKDJPA; // 0x10
		internal int LDACLKFJEHH; // 0x14
		internal List<ANPBHCNJIDI.NNPGLGHDBKN> LKMKNEGCCHF; // 0x18
		internal IGJCFFIGKIJ PGJIPJCOCGE; // 0x1C
		internal AHAENNIFOAF.IAOPMEAIHLH DCPBHPPFJOH; // 0x20
		internal int LJMIFOIACKO; // 0x24
		internal bool DPNKNANKDAM; // 0x28

		// RVA: 0x14A0960 Offset: 0x14A0960 VA: 0x14A0960
		public BABPHOEGLPC(string LFGDLECGDCL, int MKLHCKJEKKC, int PLBOJBHAPLO, int EMGJJFKONHK, bool LAGDKBMDHLD = false, IGJCFFIGKIJ CHKHBIMFOHO = null)
		{
			OBKGEDCKHHE(LFGDLECGDCL, MKLHCKJEKKC, PLBOJBHAPLO, EMGJJFKONHK, LAGDKBMDHLD, CHKHBIMFOHO);
		}

		// RVA: 0x14A0C1C Offset: 0x14A0C1C VA: 0x14A0C1C
		public BABPHOEGLPC(string LFGDLECGDCL, int EMGJJFKONHK, bool LAGDKBMDHLD = false, IGJCFFIGKIJ CHKHBIMFOHO = null)
		{
			int bbs_comment_load_count = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.HNMMJINNHII_Game.LPJLEHAJADA("bbs_comment_load_count", 10);
			OBKGEDCKHHE(LFGDLECGDCL, bbs_comment_load_count, bbs_comment_load_count, EMGJJFKONHK, LAGDKBMDHLD, CHKHBIMFOHO);
		}

		//// RVA: 0x14A28CC Offset: 0x14A28CC VA: 0x14A28CC
		private void OBKGEDCKHHE(string LFGDLECGDCL, int MKLHCKJEKKC, int PLBOJBHAPLO, int EMGJJFKONHK, bool LAGDKBMDHLD, IGJCFFIGKIJ CHKHBIMFOHO)
		{
			LPEPBLHCGKP = new ANPBHCNJIDI();
			LPEPBLHCGKP.OBKGEDCKHHE(LFGDLECGDCL, EMGJJFKONHK, false);
			DPNKNANKDAM = LAGDKBMDHLD;
			GNIINAKDJPA = Mathf.Min(MKLHCKJEKKC, 30);
			LDACLKFJEHH = PLBOJBHAPLO;
			BIDNGGDPPIM_AutoUpdateInterval = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.HNMMJINNHII_Game.LPJLEHAJADA("bbs_auto_update_interval", 10);
			LKMKNEGCCHF = new List<ANPBHCNJIDI.NNPGLGHDBKN>(MKLHCKJEKKC);
			if(CHKHBIMFOHO == null)
			{
				CHKHBIMFOHO = (ANPBHCNJIDI.NNPGLGHDBKN FJEAKGIIKIL) =>
				{
					//0x14A2C84
					return true;
				};
			}
			PGJIPJCOCGE = CHKHBIMFOHO;
			DCPBHPPFJOH = AHAENNIFOAF.IAOPMEAIHLH.HJNNKCMLGFL_M1;
			LJMIFOIACKO = 0;
		}

		//// RVA: 0x14A0D6C Offset: 0x14A0D6C VA: 0x14A0D6C
		//public void EEBMKLOIEMB(int KILBPECFBPC) { }

		//// RVA: 0x14A0D9C Offset: 0x14A0D9C VA: 0x14A0D9C
		//public void PFMOHFOOBCL(AHAENNIFOAF.IAOPMEAIHLH NDLBNLHHJDI) { }

		//[IteratorStateMachineAttribute] // RVA: 0x6C2E40 Offset: 0x6C2E40 VA: 0x6C2E40
		//// RVA: 0x14A1250 Offset: 0x14A1250 VA: 0x14A1250
		internal IEnumerator MBPIBLCIOMJ_Coroutine_Update(int KPNKPGLPDHI, IMCBBOAFION BHFHGFKBOHH, DJBHIFLHJLK MOBEEPPKFLG)
		{
			//0x14A4160
			LPEPBLHCGKP.HGBINHBILCP();
			yield return Co.R(DGGKAEPHMAJ_Coroutine_Next(KPNKPGLPDHI, GNIINAKDJPA, LDACLKFJEHH, BHFHGFKBOHH, MOBEEPPKFLG, true));
		}

		//[IteratorStateMachineAttribute] // RVA: 0x6C2EB8 Offset: 0x6C2EB8 VA: 0x6C2EB8
		//// RVA: 0x14A1BAC Offset: 0x14A1BAC VA: 0x14A1BAC
		internal IEnumerator DGGKAEPHMAJ_Coroutine_Next(int KPNKPGLPDHI, int MKLHCKJEKKC, int PLBOJBHAPLO, IMCBBOAFION BHFHGFKBOHH, DJBHIFLHJLK MOBEEPPKFLG, bool HOLDBIDPJFJ)
		{
			PIGBKEIAMPE_FriendManager FEAAEDHHBNB; // 0x34
			List<ANPBHCNJIDI.NNPGLGHDBKN> DDDNLHPAPAK; // 0x38
			int AAIHMICJENB; // 0x3C
			int BDGBGAEAMPK; // 0x40

			//0x14A30DC
			FEAAEDHHBNB = CIOECGOMILE.HHCJCDFCLOB.CHNJPFCKFOI_FriendManager;
			if(DPNKNANKDAM)
			{
				bool PLOOEECNHFB = false;
				bool NPNNPNAIONN = false;
				FEAAEDHHBNB.EKIJICIBGOG_GetBlacklist(false, () =>
				{
					//0x14A2C94
					PLOOEECNHFB = true;
				}, (CACGCMBKHDI_Request HKICMNAACDA) =>
				{
					//0x14A2CA0
					NPNNPNAIONN = true;
				}, (CACGCMBKHDI_Request HKICMNAACDA) =>
				{
					//0x14A2CAC
					NPNNPNAIONN = true;
				});
				while(!NPNNPNAIONN && !PLOOEECNHFB)
					yield return null;
				if(NPNNPNAIONN)
				{
					MOBEEPPKFLG();
					yield break;
				}
			}
			DDDNLHPAPAK = new List<ANPBHCNJIDI.NNPGLGHDBKN>(MKLHCKJEKKC);
			AAIHMICJENB = LPEPBLHCGKP.HDMKAIKOMCB.Count;
			BDGBGAEAMPK = 0;
			while(true)
			{
				bool PLOOEECNHFB = false;
				bool NPNNPNAIONN = false;
				LPEPBLHCGKP.GBLHONFLPPD(KPNKPGLPDHI, MKLHCKJEKKC, () =>
				{
					//0x14A2CC0
					PLOOEECNHFB = true;
				}, () =>
				{
					//0x14A2CCC
					NPNNPNAIONN = true;
				});
				while(!NPNNPNAIONN && !PLOOEECNHFB)
				{
					yield return null;
				}
				if (NPNNPNAIONN)
					break;
				for(int i = AAIHMICJENB; i < LPEPBLHCGKP.HDMKAIKOMCB.Count; i++)
				{
					if(!DPNKNANKDAM || !FEAAEDHHBNB.DIGEHCDEAON_IsBlacklisted(LPEPBLHCGKP.HDMKAIKOMCB[i].MLPEHNBNOGD))
					{
						//LAB_014a3620
						if(PGJIPJCOCGE(LPEPBLHCGKP.HDMKAIKOMCB[i]))
						{
							DDDNLHPAPAK.Add(LPEPBLHCGKP.HDMKAIKOMCB[i]);
							BDGBGAEAMPK++;
						}
					}
				}
				AAIHMICJENB = LPEPBLHCGKP.HDMKAIKOMCB.Count;
				if(PLBOJBHAPLO <= BDGBGAEAMPK || !LPEPBLHCGKP.GMNAECEEHHJ())
				{
					HOLDBIDPJFJ = false;
					LKMKNEGCCHF.Clear();
					LKMKNEGCCHF.AddRange(DDDNLHPAPAK);
					BHFHGFKBOHH();
					yield break;
				}
			}
			MOBEEPPKFLG();
		}

		//[IteratorStateMachineAttribute] // RVA: 0x6C2F30 Offset: 0x6C2F30 VA: 0x6C2F30
		//// RVA: 0x14A22E4 Offset: 0x14A22E4 VA: 0x14A22E4
		//internal IEnumerator NPJFFIBIAAJ(int KPNKPGLPDHI, int PLBOJBHAPLO, IMCBBOAFION BHFHGFKBOHH, DJBHIFLHJLK MOBEEPPKFLG) { }
	}

	private BABPHOEGLPC JNBFDCGMECE; // 0x8
	private KKLGJPAIHJN FBEGBNBANPO; // 0xC
	private KKLGJPAIHJN NINFIBPLBFO; // 0x10
	private KKLGJPAIHJN GIGGFFIEDEK; // 0x14
	public bool OKNCPELPJJO; // 0x18
	public bool FKPJGFFFCDG; // 0x19

	//public bool NOJFNLBKDMH { get; }
	//public bool PIDLMDEPHMD { get; }
	//public bool AHDINMJFBNI { get; }

	//// RVA: 0x14A07C8 Offset: 0x14A07C8 VA: 0x14A07C8
	private int LPJLEHAJADA(string PIBLLGLCJEO, int MNCOAGOKNAO)
	{
		return IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.HNMMJINNHII_Game.LPJLEHAJADA(PIBLLGLCJEO, MNCOAGOKNAO);
	}

	//// RVA: 0x14A08A8 Offset: 0x14A08A8 VA: 0x14A08A8
	//public void OBKGEDCKHHE(string LFGDLECGDCL, int MKLHCKJEKKC, int PLBOJBHAPLO, int EMGJJFKONHK, bool LAGDKBMDHLD = False, OKLFOAPMJAA.IGJCFFIGKIJ OLCDBKOJLKE) { }

	//// RVA: 0x14A0B80 Offset: 0x14A0B80 VA: 0x14A0B80
	public void OBKGEDCKHHE(string LFGDLECGDCL, int EMGJJFKONHK, bool LAGDKBMDHLD = false, IGJCFFIGKIJ OLCDBKOJLKE = null)
	{
		JNBFDCGMECE = new BABPHOEGLPC(LFGDLECGDCL, EMGJJFKONHK, LAGDKBMDHLD, OLCDBKOJLKE);
		OBKGEDCKHHE();
	}

	//// RVA: 0x14A09AC Offset: 0x14A09AC VA: 0x14A09AC
	public void OBKGEDCKHHE()
	{
		FBEGBNBANPO = new KKLGJPAIHJN(LPJLEHAJADA("bbs_update_button_interval", 3), 0);
		NINFIBPLBFO = new KKLGJPAIHJN(LPJLEHAJADA("bbs_write_button_interval", 3), 0);
		GIGGFFIEDEK = new KKLGJPAIHJN(LPJLEHAJADA("bbs_no_touch_wait", 60), NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF_ServerRequester.FJDBNGEPKHL.KMEFBNBFJHI_GetServerTime());
	}

	//// RVA: 0x14A0D44 Offset: 0x14A0D44 VA: 0x14A0D44
	public void EEBMKLOIEMB(int KILBPECFBPC)
	{
		JNBFDCGMECE.BIDNGGDPPIM_AutoUpdateInterval = KILBPECFBPC;
	}

	//// RVA: 0x14A0D74 Offset: 0x14A0D74 VA: 0x14A0D74
	public void PFMOHFOOBCL(AHAENNIFOAF.IAOPMEAIHLH NDLBNLHHJDI)
	{
		JNBFDCGMECE.DCPBHPPFJOH = NDLBNLHHJDI;
	}

	//// RVA: 0x14A0DA4 Offset: 0x14A0DA4 VA: 0x14A0DA4
	//public void FLFJILIIMGI(OKLFOAPMJAA.BABPHOEGLPC LHAFADCJBME) { }

	//// RVA: 0x14A0DAC Offset: 0x14A0DAC VA: 0x14A0DAC
	public int NJMOALFKKIK()
	{
		return JNBFDCGMECE.LKMKNEGCCHF.Count;
	}

	//// RVA: 0x14A0E38 Offset: 0x14A0E38 VA: 0x14A0E38
	public ANPBHCNJIDI.NNPGLGHDBKN NOEMAKFEICB(int OIPCCBHIKIA)
	{
		return JNBFDCGMECE.LKMKNEGCCHF[OIPCCBHIKIA];
	}

	//// RVA: 0x14A0ECC Offset: 0x14A0ECC VA: 0x14A0ECC
	//public int KJFPHBPJDDF() { }

	//// RVA: 0x14A0F6C Offset: 0x14A0F6C VA: 0x14A0F6C
	//public ANPBHCNJIDI.NNPGLGHDBKN JMBDOIIIDJH(int OIPCCBHIKIA) { }

	//// RVA: 0x14A1014 Offset: 0x14A1014 VA: 0x14A1014
	//public int EIGJOKAABIH() { }

	//// RVA: 0x14A1038 Offset: 0x14A1038 VA: 0x14A1038
	//public bool ODBFIJCJCCB() { }

	//// RVA: 0x14A1064 Offset: 0x14A1064 VA: 0x14A1064
	public void JLEFHIOELGH(int KPNKPGLPDHI, IMCBBOAFION BHFHGFKBOHH, DJBHIFLHJLK MOBEEPPKFLG, bool BELNGJDDEIB = true)
	{
		if(!BELNGJDDEIB)
		{
			FBEGBNBANPO.IDAPJFGJHND();
		}
		FKPJGFFFCDG = true;
		N.a.StartCoroutineWatched(JNBFDCGMECE.MBPIBLCIOMJ_Coroutine_Update(KPNKPGLPDHI, () =>
		{
			//0x14A23E4
			if(BELNGJDDEIB)
			{
				FBEGBNBANPO.BALEALPHEEJ();
				CNIGPEOGKAD();
			}
			BHFHGFKBOHH();
			FKPJGFFFCDG = false;
		}, () =>
		{
			//0x14A248C
			FBEGBNBANPO.BALEALPHEEJ();
			MOBEEPPKFLG();
			FKPJGFFFCDG = false;
		}));
	}

	//// RVA: 0x14A1328 Offset: 0x14A1328 VA: 0x14A1328
	private void CNIGPEOGKAD()
	{
		TodoLogger.LogError(0, "CNIGPEOGKAD");
	}

	//// RVA: 0x14A1760 Offset: 0x14A1760 VA: 0x14A1760
	public void FBANBDCOEJL(int KPNKPGLPDHI, IMCBBOAFION OKLICHHNKEA, DJBHIFLHJLK MOBEEPPKFLG)
	{
		long t = NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF_ServerRequester.FJDBNGEPKHL.KMEFBNBFJHI_GetServerTime();
		if(!GIGGFFIEDEK.DKMLDEDKPBA)
		{
			if(FBEGBNBANPO.NILMFDDLCMM(JNBFDCGMECE.BIDNGGDPPIM_AutoUpdateInterval) && !FKPJGFFFCDG && !OKNCPELPJJO)
			{
				OKNCPELPJJO = true;
				JLEFHIOELGH(KPNKPGLPDHI, () =>
				{
					//0x14A250C
					OKNCPELPJJO = false;
					OKLICHHNKEA();
				}, () =>
				{
					//0x14A2558
					OKNCPELPJJO = false;
					MOBEEPPKFLG();
				}, true);
			}
		}
	}

	//// RVA: 0x14A19E0 Offset: 0x14A19E0 VA: 0x14A19E0
	public void MFFPEIEMGGM()
	{
		GIGGFFIEDEK.BALEALPHEEJ();
	}

	//// RVA: 0x14A1A0C Offset: 0x14A1A0C VA: 0x14A1A0C
	public bool JFLNJEIOFDE()
	{
		TodoLogger.LogError(0, "JFLNJEIOFDE");
		return false;
	}

	//// RVA: 0x14A1B0C Offset: 0x14A1B0C VA: 0x14A1B0C
	//public void HDHACKFJKGM(int KPNKPGLPDHI, IMCBBOAFION BHFHGFKBOHH, DJBHIFLHJLK MOBEEPPKFLG) { }

	//// RVA: 0x14A1CD4 Offset: 0x14A1CD4 VA: 0x14A1CD4
	public bool ONOLJCIOKOC()
	{
		return NINFIBPLBFO.DKMLDEDKPBA;
	}

	//// RVA: 0x14A1D00 Offset: 0x14A1D00 VA: 0x14A1D00
	public void NPIBJOGODKG(int KPNKPGLPDHI, ANPBHCNJIDI.NNPGLGHDBKN HCAHCFGPJIF, IMCBBOAFION BHFHGFKBOHH, DJBHIFLHJLK MOBEEPPKFLG, DJBHIFLHJLK NKGHADCBGJO)
	{
		NINFIBPLBFO.IDAPJFGJHND();
		FKPJGFFFCDG = true;
		JNBFDCGMECE.LPEPBLHCGKP.NPIBJOGODKG(KPNKPGLPDHI, HCAHCFGPJIF, () =>
		{
			//0x14A25A4
			FKPJGFFFCDG = false;
			NINFIBPLBFO.BALEALPHEEJ();
			BHFHGFKBOHH();
		}, () =>
		{
			//0x14A2624
			FKPJGFFFCDG = false;
			NINFIBPLBFO.BALEALPHEEJ();
			MOBEEPPKFLG();
		}, () =>
		{
			//0x14A26A4
			FKPJGFFFCDG = false;
			NINFIBPLBFO.BALEALPHEEJ();
			NKGHADCBGJO();
		});
	}

	//// RVA: 0x14A1EEC Offset: 0x14A1EEC VA: 0x14A1EEC
	//public void HCMMMCFFGCA(ANPBHCNJIDI.NNPGLGHDBKN HCAHCFGPJIF, IMCBBOAFION BHFHGFKBOHH, DJBHIFLHJLK MOBEEPPKFLG) { }

	//// RVA: 0x14A20AC Offset: 0x14A20AC VA: 0x14A20AC
	//public void NCLDLJLAEBK(ANPBHCNJIDI.NNPGLGHDBKN HCAHCFGPJIF, IMCBBOAFION BHFHGFKBOHH, DJBHIFLHJLK MOBEEPPKFLG) { }

	//// RVA: 0x14A2170 Offset: 0x14A2170 VA: 0x14A2170
	//public void DADODHBGLKP(int KPNKPGLPDHI, int PLBOJBHAPLO, Action<List<ANPBHCNJIDI.NNPGLGHDBKN>> BHFHGFKBOHH, DJBHIFLHJLK MOBEEPPKFLG) { }
}
