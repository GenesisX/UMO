using System.Collections.Generic;
using XeApp.Game.Common;

public class JLKEOGLJNOD
{
	private BBHNACPENDM_ServerSaveData LDEGEHAEALK; // 0x8
	private CIFHILOJJFC NGHKJOEDLIP; // 0xC
	private bool NCCJGHMGJLL; // 0x10
	
	public List<FFHPBEPOMAK> BCJEAJPLGMB { get; private set; } // 0x14 BDPBHHMHLNI CMCEOEKKMLB PBBCDMMDBOH
	public List<FFHPBEPOMAK> CMOPCCAJAAO { get; private set; } // 0x18 ACKJKHCBAIE EADCJJBAGPK NPNIPFDIBMK
	public PNGOLKLFFLH JOKFNBLEILN { get; private set; } // 0x1C KAPPIKNNJLJ JEDNOGJBIMN OHFNALDNENG
	public StatusData JLJGCBOHJID { get; private set; } // 0x20 MHGEJIKLJOP CKAOBJJCOFO MKFJBBFNFPD
	public StatusData CMCKNKKCNDK { get; private set; } // 0x24 CLCJNFNMNBH  CNKGOPKANGF CHJGGLFGALP
	public CIFHILOJJFC DJPFJGKGOOF { get { return NGHKJOEDLIP; } } // JFBNIMDHEJO 0x14760D4
	// public string BHKALCOAHHO { get; set; } // NGMLFAGNJEA 0x14760DC FCOONLGMNCI 0x1476100
	// public int CDPKOIDDKIJ { get; } // PFDFNJHFIIJ 0x1476128
	// public bool EIGKIHENKNC { get; } // FHKHJHHICMD 0x147614C
	// public bool EMBFLMCNCHN { get; } // IJNCPACDJOB 0x1476310
	public int PDJEMLMOEPF { get { return NGHKJOEDLIP.FDBOPFEOENF[0].DIPKCALNIII_Id; } } // OICEHMGFBOG 0x147654C

	// // RVA: 0x14765F4 Offset: 0x14765F4 VA: 0x14765F4
	public JLKEOGLJNOD()
	{
		JLJGCBOHJID = new StatusData();
		CMCKNKKCNDK = new StatusData();
	}

	// // RVA: 0x1476688 Offset: 0x1476688 VA: 0x1476688
	public void AADLCEDCNIC(List<GCIJNCFDNON> OPIBAPEGCLA, AMCGONHBGGF FOOJCAGEODG, int JPIDIENBGKH, int PPKEBOEJAKH)
	{
		if(FOOJCAGEODG.DIPKCALNIII_Id == 0)
		{
			BCJEAJPLGMB.Add(null);
		}
		else
		{
			AMCGONHBGGF PFEPMCNHEMJ = FOOJCAGEODG;
			FFHPBEPOMAK f = new FFHPBEPOMAK();
			List<GCIJNCFDNON> l = new List<GCIJNCFDNON>();
			l.Add(null);
			l.Add(null);
			GCIJNCFDNON g = null;
			if(PFEPMCNHEMJ.EBDNICPAFLB_SSlot[0] == 0)
			{
				g = null;
			}
			else if(OPIBAPEGCLA == null)
			{
				MMPBPOIFDAF_Scene.PMKOFEIONEG s = LDEGEHAEALK.PNLOINMCCKH_Scene.OPIBAPEGCLA.Find((MMPBPOIFDAF_Scene.PMKOFEIONEG IBDJFHFIIHN) =>
				{
					//0x147B7E4
					return IBDJFHFIIHN.PPFNGGCBJKC == PFEPMCNHEMJ.EBDNICPAFLB_SSlot[0];
				});
				g = new GCIJNCFDNON();
				g.KHEKNNFCAOI(PFEPMCNHEMJ.EBDNICPAFLB_SSlot[0], s.PDNIFBEGMHC_Mb, s.EMOJHJGHJLN, s.JPIPENJGGDD_Mlt, s.IELENGDJPHF_Ulk, s.MJBODMOLOBC_Luck, s.LHMOAJAIJCO_New, s.BEBJKJKBOGH_Date, s.DMNIMMGGJJJ_Leaf);
			}
			else
			{
				g = OPIBAPEGCLA.Find((GCIJNCFDNON AOIKKLBKEBC) =>
				{
					//0x147B86C
					return AOIKKLBKEBC.BCCHOBPJJKE == PFEPMCNHEMJ.EBDNICPAFLB_SSlot[0];
				});
			}
			if(PFEPMCNHEMJ.EBDNICPAFLB_SSlot[1] != 0)
			{
				if(OPIBAPEGCLA == null)
				{
					MMPBPOIFDAF_Scene.PMKOFEIONEG s = LDEGEHAEALK.PNLOINMCCKH_Scene.OPIBAPEGCLA.Find((MMPBPOIFDAF_Scene.PMKOFEIONEG IBDJFHFIIHN) =>
					{
						//0x147B8E8
						return IBDJFHFIIHN.PPFNGGCBJKC == PFEPMCNHEMJ.EBDNICPAFLB_SSlot[1];
					});
					GCIJNCFDNON h = new GCIJNCFDNON();
					l[0] = h;
					h.KHEKNNFCAOI(PFEPMCNHEMJ.EBDNICPAFLB_SSlot[1], s.PDNIFBEGMHC_Mb, s.EMOJHJGHJLN, s.JPIPENJGGDD_Mlt, s.IELENGDJPHF_Ulk, s.MJBODMOLOBC_Luck, s.LHMOAJAIJCO_New, s.BEBJKJKBOGH_Date, s.DMNIMMGGJJJ_Leaf);
				}
				else
				{
					GCIJNCFDNON h = OPIBAPEGCLA.Find((GCIJNCFDNON AOIKKLBKEBC) =>
					{
						//0x147B970
						return AOIKKLBKEBC.BCCHOBPJJKE == PFEPMCNHEMJ.EBDNICPAFLB_SSlot[1];
					});
					l[0] = h;
				}
			}
			if (PFEPMCNHEMJ.EBDNICPAFLB_SSlot[2] != 0)
			{
				if (OPIBAPEGCLA == null)
				{
					MMPBPOIFDAF_Scene.PMKOFEIONEG s = LDEGEHAEALK.PNLOINMCCKH_Scene.OPIBAPEGCLA.Find((MMPBPOIFDAF_Scene.PMKOFEIONEG IBDJFHFIIHN) =>
					{
						//0x147B9EC
						return IBDJFHFIIHN.PPFNGGCBJKC == PFEPMCNHEMJ.EBDNICPAFLB_SSlot[2];
					});
					GCIJNCFDNON h = new GCIJNCFDNON();
					l[1] = h;
					h.KHEKNNFCAOI(PFEPMCNHEMJ.EBDNICPAFLB_SSlot[2], s.PDNIFBEGMHC_Mb, s.EMOJHJGHJLN, s.JPIPENJGGDD_Mlt, s.IELENGDJPHF_Ulk, s.MJBODMOLOBC_Luck, s.LHMOAJAIJCO_New, s.BEBJKJKBOGH_Date, s.DMNIMMGGJJJ_Leaf);
				}
				else
				{
					GCIJNCFDNON h = OPIBAPEGCLA.Find((GCIJNCFDNON AOIKKLBKEBC) =>
					{
						//0x147BA74
						return AOIKKLBKEBC.BCCHOBPJJKE == PFEPMCNHEMJ.EBDNICPAFLB_SSlot[2];
					});
					l[1] = h;
				}
			}
			f.KHEKNNFCAOI(FOOJCAGEODG.DIPKCALNIII_Id, LDEGEHAEALK.DGCJCAHIAPP_Diva.LGKFMLIOPKL_GetDivaInfo(FOOJCAGEODG.DIPKCALNIII_Id).HEBKEJBDCBH_DivaLevel, JPIDIENBGKH, PPKEBOEJAKH, g, l, true);
			BCJEAJPLGMB.Add(f);
		}
	}

	// // RVA: 0x1477544 Offset: 0x1477544 VA: 0x1477544
	public void GDLBMOFJLII(DKDMLOBCPFC FOGJAIKOFDP, int JPIDIENBGKH, int PPKEBOEJAKH)
	{
		if(FOGJAIKOFDP.DIPKCALNIII == 0)
		{
			CMOPCCAJAAO.Add(null);
		}
		else
		{
			FFHPBEPOMAK f = new FFHPBEPOMAK();
			f.KHEKNNFCAOI(FOGJAIKOFDP.DIPKCALNIII, LDEGEHAEALK.DGCJCAHIAPP_Diva.LGKFMLIOPKL_GetDivaInfo(FOGJAIKOFDP.DIPKCALNIII).HEBKEJBDCBH_DivaLevel, JPIDIENBGKH, PPKEBOEJAKH, null, null, true);
			CMOPCCAJAAO.Add(f);
		}
	}

	// // RVA: 0x14776E0 Offset: 0x14776E0 VA: 0x14776E0
	public void GFBCLEFGGIK(List<GCIJNCFDNON> OPIBAPEGCLA)
	{
		if (BCJEAJPLGMB == null)
			BCJEAJPLGMB = new List<FFHPBEPOMAK>(3);
		BCJEAJPLGMB.Clear();
		for (int i = 0; i < 3; i++)
		{
			AMCGONHBGGF a = NGHKJOEDLIP.FDBOPFEOENF[i];
			DEKKMGAFJCG_Diva.MNNLOBDPCCH_DivaInfo divaDb = LDEGEHAEALK.DGCJCAHIAPP_Diva.LGKFMLIOPKL_GetDivaInfo(a.DIPKCALNIII_Id);
			AADLCEDCNIC(OPIBAPEGCLA, a, divaDb.BEEAIAAJOHD_CostumeId, divaDb.AFNIOJHODAG_CostumeColorId);
		}
		if (CMOPCCAJAAO == null)
			CMOPCCAJAAO = new List<FFHPBEPOMAK>();
		CMOPCCAJAAO.Clear();
		for(int i = 0; i < 2; i++)
		{
			DKDMLOBCPFC d = NGHKJOEDLIP.KAKGHFFOAEJ[i];
			GDLBMOFJLII(d, d.BEEAIAAJOHD, d.AFNIOJHODAG);
		}
	}

	// // RVA: 0x1477AA4 Offset: 0x1477AA4 VA: 0x1477AA4
	public void HDKIBGDDCHB(List<GCIJNCFDNON> OPIBAPEGCLA)
	{
		if (BCJEAJPLGMB == null)
			BCJEAJPLGMB = new List<FFHPBEPOMAK>();
		BCJEAJPLGMB.Clear();
		for(int i = 0; i < 3; i++)
		{
			AMCGONHBGGF a = NGHKJOEDLIP.FDBOPFEOENF[i];
			AADLCEDCNIC(OPIBAPEGCLA, a, a.BEEAIAAJOHD_CId, a.AFNIOJHODAG_ColId);
		}
		if (CMOPCCAJAAO == null)
			CMOPCCAJAAO = new List<FFHPBEPOMAK>();
		CMOPCCAJAAO.Clear();
		for (int i = 0; i < 2; i++)
		{
			DKDMLOBCPFC d = NGHKJOEDLIP.KAKGHFFOAEJ[i];
			GDLBMOFJLII(d, d.BEEAIAAJOHD, d.AFNIOJHODAG);
		}
	}

	// // RVA: 0x1477E3C Offset: 0x1477E3C VA: 0x1477E3C
	public void PJOOMNIEGPP(List<FFHPBEPOMAK> NBIGLBMHEDC, BBHNACPENDM_ServerSaveData AHEFHIMGIBI)
	{
		LDEGEHAEALK = AHEFHIMGIBI;
		NGHKJOEDLIP = AHEFHIMGIBI.MLAFAACKKBG_Unit.GCINIJEMHFK(0);
		BCJEAJPLGMB = new List<FFHPBEPOMAK>(3);
		for(int i = 0; i < 3; i++)
		{
			AMCGONHBGGF a = NGHKJOEDLIP.FDBOPFEOENF[i];
			if (a.DIPKCALNIII_Id == 0)
			{
				BCJEAJPLGMB.Add(null);
			}
			else
			{
				BCJEAJPLGMB.Add(NBIGLBMHEDC[a.DIPKCALNIII_Id - 1]);
			}
		}
		CMOPCCAJAAO = new List<FFHPBEPOMAK>(2);
		for(int i = 0; i < 2; i++)
		{
			DKDMLOBCPFC d = NGHKJOEDLIP.KAKGHFFOAEJ[i];
			if(d.DIPKCALNIII != 0)
			{
				CMOPCCAJAAO.Add(null);
			}
			else
			{
				CMOPCCAJAAO.Add(NBIGLBMHEDC[d.DIPKCALNIII - 1]);
			}
		}
		if (NGHKJOEDLIP.FODKKJIDDKN_VfId == 0)
			JOKFNBLEILN = null;
		else
		{
			if (JOKFNBLEILN == null)
				JOKFNBLEILN = new PNGOLKLFFLH();
			JOKFNBLEILN.KHEKNNFCAOI_Init(NGHKJOEDLIP.FODKKJIDDKN_VfId, NGHKJOEDLIP.GCCNMFHELCB, 0);
		}
		HCDGELDHFHB();
	}

	// // RVA: 0x1478230 Offset: 0x1478230 VA: 0x1478230
	public void KHEKNNFCAOI_Init(int JBKOEGJGKMC, List<GCIJNCFDNON> OPIBAPEGCLA, BBHNACPENDM_ServerSaveData AHEFHIMGIBI)
	{
		if(AHEFHIMGIBI == null)
		{
			LDEGEHAEALK = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave;
		}
		else
		{
			LDEGEHAEALK = AHEFHIMGIBI;
		}
		NGHKJOEDLIP = LDEGEHAEALK.MLAFAACKKBG_Unit.GCINIJEMHFK(JBKOEGJGKMC);
		if(NGHKJOEDLIP == null)
		{
			UnityEngine.Debug.LogError("setting not found!!");
			return;
		}
		if(BCJEAJPLGMB == null)
		{
			BCJEAJPLGMB = new List<FFHPBEPOMAK>();
		}
		BCJEAJPLGMB.Clear();
		for(int i = 0; i < 3; i++)
		{
			AMCGONHBGGF a = NGHKJOEDLIP.FDBOPFEOENF[i];
			if(a.DIPKCALNIII_Id == 0)
			{
				BCJEAJPLGMB.Add(null);
			}
			else
			{
				FFHPBEPOMAK b = new FFHPBEPOMAK();
				List<GCIJNCFDNON> l = new List<GCIJNCFDNON>();
				l.Add(null);
				l.Add(null);
				GCIJNCFDNON g = null;
				if (a.EBDNICPAFLB_SSlot[0] == 0)
				{

				}
				else if(OPIBAPEGCLA == null)
				{
					MMPBPOIFDAF_Scene.PMKOFEIONEG m = LDEGEHAEALK.PNLOINMCCKH_Scene.OPIBAPEGCLA.Find((MMPBPOIFDAF_Scene.PMKOFEIONEG IBDJFHFIIHN) =>
					{
						//0x147BAF0
						return IBDJFHFIIHN.PPFNGGCBJKC == a.EBDNICPAFLB_SSlot[0];
					});
					g = new GCIJNCFDNON();
					g.KHEKNNFCAOI(a.EBDNICPAFLB_SSlot[0], m.PDNIFBEGMHC_Mb, m.EMOJHJGHJLN, m.JPIPENJGGDD_Mlt, m.IELENGDJPHF_Ulk, m.MJBODMOLOBC_Luck, m.LHMOAJAIJCO_New, m.BEBJKJKBOGH_Date, m.DMNIMMGGJJJ_Leaf);
				}
				else
				{
					g = OPIBAPEGCLA.Find((GCIJNCFDNON AOIKKLBKEBC) =>
					{
						//0x147BB78
						return AOIKKLBKEBC.BCCHOBPJJKE == a.EBDNICPAFLB_SSlot[0];
					});
				}
				if (a.EBDNICPAFLB_SSlot[1] != 0)
				{
					if (OPIBAPEGCLA == null)
					{
						MMPBPOIFDAF_Scene.PMKOFEIONEG m = LDEGEHAEALK.PNLOINMCCKH_Scene.OPIBAPEGCLA.Find((MMPBPOIFDAF_Scene.PMKOFEIONEG IBDJFHFIIHN) =>
						{
							//0x147BBF4
							return IBDJFHFIIHN.PPFNGGCBJKC == a.EBDNICPAFLB_SSlot[1];
						});
						GCIJNCFDNON h = new GCIJNCFDNON();
						l[0] = h;
						h.KHEKNNFCAOI(a.EBDNICPAFLB_SSlot[1], m.PDNIFBEGMHC_Mb, m.EMOJHJGHJLN, m.JPIPENJGGDD_Mlt, m.IELENGDJPHF_Ulk, m.MJBODMOLOBC_Luck, m.LHMOAJAIJCO_New, m.BEBJKJKBOGH_Date, m.DMNIMMGGJJJ_Leaf);
					}
					else
					{
						GCIJNCFDNON h = OPIBAPEGCLA.Find((GCIJNCFDNON AOIKKLBKEBC) =>
						{
							//0x147BC7C
							return AOIKKLBKEBC.BCCHOBPJJKE == a.EBDNICPAFLB_SSlot[1];
						});
						l[0] = h;
					}
				}
				if (a.EBDNICPAFLB_SSlot[2] != 0)
				{
					if (OPIBAPEGCLA == null)
					{
						MMPBPOIFDAF_Scene.PMKOFEIONEG m = LDEGEHAEALK.PNLOINMCCKH_Scene.OPIBAPEGCLA.Find((MMPBPOIFDAF_Scene.PMKOFEIONEG IBDJFHFIIHN) =>
						{
							//0x147BCF8
							return IBDJFHFIIHN.PPFNGGCBJKC == a.EBDNICPAFLB_SSlot[2];
						});
						GCIJNCFDNON h = new GCIJNCFDNON();
						l[1] = h;
						h.KHEKNNFCAOI(a.EBDNICPAFLB_SSlot[2], m.PDNIFBEGMHC_Mb, m.EMOJHJGHJLN, m.JPIPENJGGDD_Mlt, m.IELENGDJPHF_Ulk, m.MJBODMOLOBC_Luck, m.LHMOAJAIJCO_New, m.BEBJKJKBOGH_Date, m.DMNIMMGGJJJ_Leaf);
					}
					else
					{
						GCIJNCFDNON h = OPIBAPEGCLA.Find((GCIJNCFDNON AOIKKLBKEBC) =>
						{
							//0x147BD80
							return AOIKKLBKEBC.BCCHOBPJJKE == a.EBDNICPAFLB_SSlot[2];
						});
						l[1] = h;
					}
				}
				b.KHEKNNFCAOI(a.DIPKCALNIII_Id, LDEGEHAEALK.DGCJCAHIAPP_Diva.LGKFMLIOPKL_GetDivaInfo(a.DIPKCALNIII_Id).HEBKEJBDCBH_DivaLevel, a.BEEAIAAJOHD_CId, a.AFNIOJHODAG_ColId, g, l, true);
				BCJEAJPLGMB.Add(b);
			}
		}
		if(CMOPCCAJAAO == null)
			CMOPCCAJAAO = new List<FFHPBEPOMAK>();
		CMOPCCAJAAO.Clear();
		for(int i = 0; i < 2; i++)
		{
			DKDMLOBCPFC d = NGHKJOEDLIP.KAKGHFFOAEJ[i];
			if(d.DIPKCALNIII == 0)
			{
				CMOPCCAJAAO.Add(null);
			}
			else
			{
				FFHPBEPOMAK f = new FFHPBEPOMAK();
				f.KHEKNNFCAOI(d.DIPKCALNIII, LDEGEHAEALK.DGCJCAHIAPP_Diva.LGKFMLIOPKL_GetDivaInfo(d.DIPKCALNIII).HEBKEJBDCBH_DivaLevel, d.BEEAIAAJOHD, d.AFNIOJHODAG, null, null, true);
				CMOPCCAJAAO.Add(f);
			}
		}
		if(NGHKJOEDLIP.FODKKJIDDKN_VfId == 0)
		{
			JOKFNBLEILN = null;
		}
		else
		{
			if (JOKFNBLEILN == null)
				JOKFNBLEILN = new PNGOLKLFFLH();
			JOKFNBLEILN.KHEKNNFCAOI_Init(NGHKJOEDLIP.FODKKJIDDKN_VfId, NGHKJOEDLIP.GCCNMFHELCB, 0);
		}
		HCDGELDHFHB();
	}

	// // RVA: 0x1479958 Offset: 0x1479958 VA: 0x1479958
	public void MDMJCIAJBKG(int CGIGOFKGCII, int JBKOEGJGKMC, List<GCIJNCFDNON> OPIBAPEGCLA, List<FFHPBEPOMAK> NBIGLBMHEDC, BBHNACPENDM_ServerSaveData AHEFHIMGIBI)
	{
		NCCJGHMGJLL = true;
		if(AHEFHIMGIBI == null)
		{
			AHEFHIMGIBI = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave;
		}
		LDEGEHAEALK = AHEFHIMGIBI;
		NGHKJOEDLIP = AHEFHIMGIBI.KMBJGAHCBDI_UnitGoDiva.ALDOJAEAMCJ(CGIGOFKGCII, JBKOEGJGKMC);
		if(NGHKJOEDLIP == null)
		{
			UnityEngine.Debug.LogError("setting not found!!");
			return;
		}
		GFBCLEFGGIK(OPIBAPEGCLA);
		if(NGHKJOEDLIP.FODKKJIDDKN_VfId == 0)
		{
			JOKFNBLEILN = null;
		}
		else
		{
			if (JOKFNBLEILN == null)
				JOKFNBLEILN = new PNGOLKLFFLH();
			JOKFNBLEILN.KHEKNNFCAOI_Init(NGHKJOEDLIP.FODKKJIDDKN_VfId, NGHKJOEDLIP.GCCNMFHELCB);
		}
		HCDGELDHFHB();
	}

	// // RVA: 0x1479B98 Offset: 0x1479B98 VA: 0x1479B98
	public void ALIMIMCBKFH(int CGIGOFKGCII, int JBKOEGJGKMC, List<GCIJNCFDNON> OPIBAPEGCLA, BBHNACPENDM_ServerSaveData AHEFHIMGIBI)
	{
		NCCJGHMGJLL = true;
		if(AHEFHIMGIBI == null)
		{
			AHEFHIMGIBI = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave;
		}
		LDEGEHAEALK = AHEFHIMGIBI;
		NGHKJOEDLIP = AHEFHIMGIBI.KMBJGAHCBDI_UnitGoDiva.ALDOJAEAMCJ(CGIGOFKGCII, JBKOEGJGKMC);
		if (NGHKJOEDLIP == null)
		{
			UnityEngine.Debug.LogError("setting not found!!");
			return;
		}
		HDKIBGDDCHB(OPIBAPEGCLA);
		if(NGHKJOEDLIP.FODKKJIDDKN_VfId == 0)
		{
			JOKFNBLEILN = null;
		}
		else
		{
			if(JOKFNBLEILN == null)
				JOKFNBLEILN = new PNGOLKLFFLH();
			JOKFNBLEILN.KHEKNNFCAOI_Init(NGHKJOEDLIP.FODKKJIDDKN_VfId, NGHKJOEDLIP.GCCNMFHELCB, 0);
		}
		HCDGELDHFHB();
	}

	// // RVA: 0x1479DD8 Offset: 0x1479DD8 VA: 0x1479DD8
	// public void KMLFHLOBPNH(List<GCIJNCFDNON> OPIBAPEGCLA) { }

	// // RVA: 0x1479EA8 Offset: 0x1479EA8 VA: 0x1479EA8
	// public void MLNLDMABAEA(int AHHJLDLAPAN, List<GCIJNCFDNON> OPIBAPEGCLA) { }

	// // RVA: 0x1479F88 Offset: 0x1479F88 VA: 0x1479F88
	// public void GHNBDOLODJK(JLKEOGLJNOD GPBJHKLFCEP) { }

	// // RVA: 0x1479FD4 Offset: 0x1479FD4 VA: 0x1479FD4
	// public void BBKOIKGPLFM(JLKEOGLJNOD GPBJHKLFCEP) { }

	// // RVA: 0x147A020 Offset: 0x147A020 VA: 0x147A020
	// public void LDPCJAKOKHB(int GPPEFLKGGGJ, int GCCNMFHELCB = -1) { }

	// // RVA: 0x147A148 Offset: 0x147A148 VA: 0x147A148
	// public void ACGHDBEELGF(int GCCNMFHELCB) { }

	// // RVA: 0x147821C Offset: 0x147821C VA: 0x147821C
	public void HCDGELDHFHB()
	{
		if (NCCJGHMGJLL)
			ELHBGKLLOIO();
		else
			GLGPDEHOLIJ();
	}

	// // RVA: 0x147A7C0 Offset: 0x147A7C0 VA: 0x147A7C0
	private void GLGPDEHOLIJ()
	{
		JLJGCBOHJID.Clear();
		if (BCJEAJPLGMB != null)
		{
			for (int i = 0; i < BCJEAJPLGMB.Count; i++)
			{
				AMCGONHBGGF a = NGHKJOEDLIP.FDBOPFEOENF[i];
				FFHPBEPOMAK f = BCJEAJPLGMB[i];
				if(f == null)
				{
					a.DIPKCALNIII_Id = 0;
					a.BEEAIAAJOHD_CId = 0;
					a.AFNIOJHODAG_ColId = 0;
					a.EBDNICPAFLB_SSlot[0] = 0;
					a.EBDNICPAFLB_SSlot[1] = 0;
					a.EBDNICPAFLB_SSlot[2] = 0;
				}
				else
				{
					f.HCDGELDHFHB();
					JLJGCBOHJID.Add(f.CMCKNKKCNDK_EquippedStatus);
					a.DIPKCALNIII_Id = f.AHHJLDLAPAN_DivaId;
					a.BEEAIAAJOHD_CId = f.JPIDIENBGKH;
					a.AFNIOJHODAG_ColId = f.EKFONBFDAAP_ColorId;
					a.EBDNICPAFLB_SSlot[0] = f.FGFIBOBAPIA;
					a.EBDNICPAFLB_SSlot[1] = f.DJICAKGOGFO[0];
					a.EBDNICPAFLB_SSlot[2] = f.DJICAKGOGFO[1];
				}
			}
		}
		if (CMOPCCAJAAO != null)
		{
			for (int i = 0; i < CMOPCCAJAAO.Count; i++)
			{
				DKDMLOBCPFC d = NGHKJOEDLIP.KAKGHFFOAEJ[i];
				FFHPBEPOMAK f = CMOPCCAJAAO[i];
				if (f == null)
				{
					d.DIPKCALNIII = 0;
					d.BEEAIAAJOHD = 0;
					d.AFNIOJHODAG = 0;
				}
				else
				{
					d.DIPKCALNIII = f.AHHJLDLAPAN_DivaId;
					d.BEEAIAAJOHD = f.JPIDIENBGKH;
					d.AFNIOJHODAG = f.EKFONBFDAAP_ColorId;
				}
			}
		}
		CMCKNKKCNDK.Copy(JLJGCBOHJID);
	}

	// // RVA: 0x147A1A4 Offset: 0x147A1A4 VA: 0x147A1A4
	private void ELHBGKLLOIO()
	{
		JLJGCBOHJID.Clear();
		if (BCJEAJPLGMB != null)
		{
			for (int i = 0; i < BCJEAJPLGMB.Count; i++)
			{
				AMCGONHBGGF a = NGHKJOEDLIP.FDBOPFEOENF[i];
				FFHPBEPOMAK f = BCJEAJPLGMB[i];
				if (f == null)
				{
					a.DIPKCALNIII_Id = 0;
					a.BEEAIAAJOHD_CId = 0;
					a.AFNIOJHODAG_ColId = 0;
					a.EBDNICPAFLB_SSlot[0] = 0;
					a.EBDNICPAFLB_SSlot[1] = 0;
					a.EBDNICPAFLB_SSlot[2] = 0;
				}
				else
				{
					if (i == 0)
						f.HCDGELDHFHB();
					else
						f.ELHBGKLLOIO();
					JLJGCBOHJID.Add(f.CMCKNKKCNDK_EquippedStatus);
					a.DIPKCALNIII_Id = f.AHHJLDLAPAN_DivaId;
					a.BEEAIAAJOHD_CId = f.JPIDIENBGKH;
					a.AFNIOJHODAG_ColId = f.EKFONBFDAAP_ColorId;
					a.EBDNICPAFLB_SSlot[0] = f.FGFIBOBAPIA;
					a.EBDNICPAFLB_SSlot[1] = f.DJICAKGOGFO[0];
					a.EBDNICPAFLB_SSlot[2] = f.DJICAKGOGFO[1];
				}
			}
		}
		if(CMOPCCAJAAO != null)
		{
			for(int i = 0; i < CMOPCCAJAAO.Count; i++)
			{
				DKDMLOBCPFC d = NGHKJOEDLIP.KAKGHFFOAEJ[i];
				FFHPBEPOMAK f = CMOPCCAJAAO[i];
				if(f == null)
				{
					d.DIPKCALNIII = 0;
					d.BEEAIAAJOHD = 0;
					d.AFNIOJHODAG = 0;
				}
				else
				{
					d.DIPKCALNIII = f.AHHJLDLAPAN_DivaId;
					d.BEEAIAAJOHD = f.JPIDIENBGKH;
					d.AFNIOJHODAG = f.EKFONBFDAAP_ColorId;
				}
			}
			CMCKNKKCNDK.Copy(JLJGCBOHJID);
		}
	}

	// // RVA: 0x147ADCC Offset: 0x147ADCC VA: 0x147ADCC
	// public DEKKMGAFJCG.IFHCNLAODKG JOGOEIEKIHP(int BCCHOBPJJKE) { }

	// // RVA: 0x147B23C Offset: 0x147B23C VA: 0x147B23C
	// public void FLFBBPLPNMO(GCIJNCFDNON PNLOINMCCKH, int FGLPICCAPEH, int NGEADPGADLI) { }
}
