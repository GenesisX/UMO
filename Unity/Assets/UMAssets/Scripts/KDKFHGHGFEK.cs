
using System.Collections.Generic;
using UnityEngine;
using XeApp.Game.Common;

public class KDKFHGHGFEK
{
	public enum BAFEHAIGDOL
	{
		HJNNKCMLGFL = 0,
		FMLPIOFBCMA = 1,
		PFCFIMGGJJO = 2,
		GEENNEGMMCD = 3,
	}

	public enum MNBBLHKJBOJ
	{
		HJNNKCMLGFL = 0,
		FIHLMHDCFEO = 1,
		NFJPPHMCDBF = 2,
		OFBKNBLLFEM = 3,
		FDMBJAGLPLA = 4,
		KAONFJDOABE = 5,
		CAMKIILHPDE = 6,
	}

	public enum AANBHFEEDGP
	{
		HJNNKCMLGFL = 0,
		HPPAGEALCLK = 1,
		FIHMIDDLAKH = 1,
		IOEGFJMNDBM = 2,
		JJNIMNEJPOF = 3,
		OHKBCBLOHEF = 3,
	}
	
	private int[] NOHLPBMMHGE; // 0x64
	private int[] KGKGILMHPFN; // 0x68
	private static List<BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ> CIBDILHIBEG_PosterBef; // 0x0
	private static List<BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ> FFNENJELGIF_PosterAft; // 0x4
	private static List<BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ> KKIEEIGGJPK_ValkList; // 0x8
	private static List<BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ> JKNMNFKPEAA_CostumeList; // 0xC

	public int PPFNGGCBJKC_Id { get; private set; } // 0x8 FDGEMCPHJCB DEMEPMAEJOO HIGKAIDMOKN
	public EKLNMHFCAOI.FKGCBLHOOCL_Category NPADACLCNAN_Category { get; private set; } // 0xC GAGLCECFOPM OOPDEPLJIJL OCMGDHJFELC
	public string OPFGFINHFCE_Name { get; private set; } // 0x10 LGIIAPHCLPN DKJOHDGOIJE MJAMIGECMMF
	public string FEMMDNIELFC_Desc { get; private set; } // 0x14 GDKPKLJELJK JDHDMBHNKJD FNAJEJLLJOE
	public string DOIGLOBENMG { get; private set; } // 0x18 DEENOHGDMBK OFONPMEMOJB OGCPMJBBBLK
	public int FJFCNGNGIBN { get; private set; } // 0x1C PKNMGMMCPPJ OCNDKILHCJK NMEEPJEFADN
	public SeriesAttr.Type CPKMLLNADLJ_Serie { get; private set; } // 0x20 COPJCMLLIMO BJPJMGHCDNO BPKIOJBKNBP
	public int FBFLDFMFFOH { get; private set; } // 0x24 LMKEDCAPLEE HNLMNIOMOLI CHHJKABBIBL
	public int FLJPIHEEKOJ { get; private set; } // 0x28 BJNHJEMJOFB OBPAIHNNGDD GACABMLKLBP
	public int KGBAOKCMALD { get; private set; } // 0x2C KIHCOJIJICA FMOLFIOAFON CLHPGMPNHOF
	public int GBJFNGCDKPM { get; private set; } // 0x30 GHLFADHILNN CEJJMKODOGK HOHCEBMMACI
	public int FAKNMCIIAEM_IsAutoFlip { get; private set; } // 0x34 CLELCODBOBF CGDPJCABPDB JJFPNFCDNIC
	public int FNAKHNBAFGB { get; private set; } // 0x38 NJOIHAMCKHP IOBBDOKLIJD EDJPCMJJJCH
	public int FPCGPGJOKNH_CharaId { get; private set; } // 0x3C LEKPDGHPEJI ALFNIJMLAKF HGLMGFOOLGI
	public int EDEEMPJPFCP { get; private set; } // 0x40 NMNENMCBGOO LNELAEPIDOL FMPMDBENAGN
	public int HDHNEILDILJ { get; private set; } // 0x44 DIAPFECKENP MLECPDIKEPC LBGPIFGNOMF
	public int BHDHPCDLICO_Thickness { get; private set; } // 0x48 EMNLBCOMNPG AHKMMIGMMHJ CHFCMEBBCOG
	public int GJMHALIIPME_Type { get; private set; } // 0x4C EDGKPFBJAIN PJMOPGGDAEM FKLKNOBLCAK
	public bool GEMAFKNIKJN_IsOnShelf { get; private set; } // 0x50 JKPLAJNFKPC DKLPJBCLAHN NKIOCFFFHDF
	public int DBGAJBIBODC { get; private set; } // 0x54 JNBNBIGFFOM FFGNKPMHDIL GCCHDIOECNK
	public int EILKGEADKGH { get; private set; } // 0x58 PBIPJHCABED NPDDACIHBKD BJJMCKHBPNH
	public int AKKLMEPIJBN { get; private set; } // 0x5C AJGDNHHDKEA FPGPCCBECCF PCPAHCAOGPN
	public int BAGLABPGMMK { get; private set; } // 0x60 BDJEDIKLJMN JKPECJGJPCL FPHMBIBHPHN
	public int BFINGCJHOHI { get; private set; } // 0x6C PIAHJAJPLKA LFMCLIDAPHB EDAEPDGGFJJ
	public bool CADENLBDAEB_IsNew { get; private set; } // 0x70 HMFLCAALEKM KJGFPPLHLAB ILJHLPMDHPO
	public bool FMGBBKHJDEC_CanKira { get; private set; } // 0x71 EOPNLNOMPAH FHPAOOLILMF HHEGCPCPHHF

	//// RVA: 0xE74A08 Offset: 0xE74A08 VA: 0xE74A08
	public int PPOJIMKEGMF(int PPFNGGCBJKC)
	{
		if(PPFNGGCBJKC > -1 && NOHLPBMMHGE != null)
		{
			if(NOHLPBMMHGE.Length <= PPFNGGCBJKC)
				return 0;
			return NOHLPBMMHGE[PPFNGGCBJKC];
		}
		return 0;
	}

	//// RVA: 0xE74A5C Offset: 0xE74A5C VA: 0xE74A5C
	public int NBGONKHPADA(int PPFNGGCBJKC)
	{
		if(PPFNGGCBJKC > -1 && KGKGILMHPFN != null)
		{
			if(KGKGILMHPFN.Length <= PPFNGGCBJKC)
				return 0;
			return KGKGILMHPFN[PPFNGGCBJKC];
		}
		return 0;
	}

	//// RVA: 0xE74AE0 Offset: 0xE74AE0 VA: 0xE74AE0
	public void KHEKNNFCAOI(int PPFNGGCBJKC, EKLNMHFCAOI.FKGCBLHOOCL_Category NPADACLCNAN)
	{
		LHPDDGIJKNB();
		if(PPFNGGCBJKC < 1)
			return;
		if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database == null)
			return;
		if(CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave == null)
			return;
		OPFGFINHFCE_Name = EKLNMHFCAOI.INCKKODFJAP_GetItemName(NPADACLCNAN, PPFNGGCBJKC);
		FEMMDNIELFC_Desc = EKLNMHFCAOI.ILKGBGOCLAO_GetItemDesc(NPADACLCNAN, PPFNGGCBJKC);
		EILKGEADKGH = 0;
		FMGBBKHJDEC_CanKira = false;
		switch(NPADACLCNAN)
		{
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.GPMKJNDHDCP_DecoItemBg:
			{
				if(PPFNGGCBJKC < 1)
					return;
				if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.GJLHEJPHEDA_ItemsBg.Count < PPFNGGCBJKC)
					return;
				NDBFKHKMMCE_DecoItem.EHLEEEBJLAM_BgItem dbItem = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.GJLHEJPHEDA_ItemsBg[PPFNGGCBJKC - 1];
				if(dbItem.PLALNIIBLOF_Enabled != 2)
					return;
				FJFCNGNGIBN = dbItem.FJFCNGNGIBN;
				CPKMLLNADLJ_Serie = (SeriesAttr.Type)dbItem.CPKMLLNADLJ;
				FLJPIHEEKOJ = dbItem.EKLIPGELKCL;
				GJMHALIIPME_Type = 0;
				BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ saveItem = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.OMMNKDEODJP_DecoItem.DJHBDDGEKGO_Bgs.Find((BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ JPAEDJJFFOI) =>
				{
					//0xE7B6DC
					return PPFNGGCBJKC == JPAEDJJFFOI.PPFNGGCBJKC_Id;
				});
				if(saveItem != null)
					CADENLBDAEB_IsNew = saveItem.CADENLBDAEB_IsNew;
				break;
			}
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.OKPAJOALDCG_DecoItemObj:
			{
				if(PPFNGGCBJKC < 1)
					return;
				if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.GHOLIPLDMPJ_ItemsObj.Count < PPFNGGCBJKC)
					return;
				NDBFKHKMMCE_DecoItem.NIBEBIGPKLA_ObjItem dbItem = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.GHOLIPLDMPJ_ItemsObj[PPFNGGCBJKC - 1];
				if(dbItem.PLALNIIBLOF_Enabled != 2)
					return;
				FJFCNGNGIBN = dbItem.FJFCNGNGIBN_Attribute;
				CPKMLLNADLJ_Serie = (SeriesAttr.Type)dbItem.CPKMLLNADLJ;
				FLJPIHEEKOJ = dbItem.EKLIPGELKCL;
				GBJFNGCDKPM = dbItem.GBJFNGCDKPM;
				FAKNMCIIAEM_IsAutoFlip = dbItem.FAKNMCIIAEM_IsAutoFlip;
				EDEEMPJPFCP = dbItem.NGILPOOLBCF;
				HDHNEILDILJ = dbItem.JINEKNIBOFI;
				BHDHPCDLICO_Thickness = dbItem.BHDHPCDLICO;
				GJMHALIIPME_Type = dbItem.GBJFNGCDKPM;
				GEMAFKNIKJN_IsOnShelf = dbItem.CMMNFCJNIOO_IsOnShelf == 1;
				EILKGEADKGH = dbItem.EILKGEADKGH;
				BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ saveItem = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.OMMNKDEODJP_DecoItem.KPMFLNOELIN_Objs.Find((BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ JPAEDJJFFOI) =>
				{
					//0xE7B720
					return PPFNGGCBJKC == JPAEDJJFFOI.PPFNGGCBJKC_Id;
				});
				if(saveItem != null)
					CADENLBDAEB_IsNew = saveItem.CADENLBDAEB_IsNew;
				break;
			}
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.MCKHJLHKMJD_DecoItemChara:
			{
				if(PPFNGGCBJKC < 1)
					return;
				if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.KHCACDIKJLG_ItemsChara.Count < PPFNGGCBJKC)
					return;
				NDBFKHKMMCE_DecoItem.CCHHGIJMLBN_CharaItem dbItem = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.KHCACDIKJLG_ItemsChara[PPFNGGCBJKC - 1];
				if(dbItem.PLALNIIBLOF_Enabled != 2)
					return;
				CPKMLLNADLJ_Serie = (SeriesAttr.Type)dbItem.CPKMLLNADLJ;
				FLJPIHEEKOJ = dbItem.EKLIPGELKCL;
				GJMHALIIPME_Type = dbItem.CPKMLLNADLJ;
				GBJFNGCDKPM = dbItem.GBJFNGCDKPM;
				FPCGPGJOKNH_CharaId = dbItem.JBFLEDKDFCO;
				BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ saveItem = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.OMMNKDEODJP_DecoItem.PEBDEIKBCCM_Chars.Find((BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ JPAEDJJFFOI) =>
				{
					//0xE7B7A8
					return PPFNGGCBJKC == JPAEDJJFFOI.PPFNGGCBJKC_Id;
				});
				if(saveItem != null)
					CADENLBDAEB_IsNew = saveItem.CADENLBDAEB_IsNew;
				break;
			}
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.ICIMCGOJEMD_StampItemSerif:
			{
				if(PPFNGGCBJKC < 1)
					return;
				if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.GAPONCJOKAC_DecoStamp.DMKMNGELNAE_Serif.Count < PPFNGGCBJKC)
					return;
				IHFIAFDLAAK_DecoStamp.MCBOAJEIFNP dbItem = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.GAPONCJOKAC_DecoStamp.DMKMNGELNAE_Serif[PPFNGGCBJKC - 1];
				if(dbItem.PLALNIIBLOF_Enabled != 2)
					return;
				CPKMLLNADLJ_Serie = (SeriesAttr.Type)dbItem.CPKMLLNADLJ;
				FLJPIHEEKOJ = dbItem.EKLIPGELKCL;
				GBJFNGCDKPM = dbItem.GBJFNGCDKPM_FrameId;
				FPCGPGJOKNH_CharaId = dbItem.JBFLEDKDFCO;
				GJMHALIIPME_Type = dbItem.DMEDKJPOLCH;
				DBGAJBIBODC = dbItem.LDLGLHBGOKE_FontSize;
				IOEKHJBOMDH_DecoStamp.GFPPDCEPLCM SItem = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.FJPOELGFPBP_DecoStamp.DMKMNGELNAE_Serif.Find((IOEKHJBOMDH_DecoStamp.GFPPDCEPLCM JPAEDJJFFOI) =>
				{
					//0xE7B7EC
					return PPFNGGCBJKC == JPAEDJJFFOI.PPFNGGCBJKC_Id;
				});
				if(SItem != null)
				{
					CADENLBDAEB_IsNew = SItem.CADENLBDAEB_IsNew;
				}
				DOIGLOBENMG = NCPPAHHCCAO.GHHOBKGGADG(PPFNGGCBJKC);
				break;
			}
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.BMMBLLOKNPF_DecoItemSp:
			{
				if(PPFNGGCBJKC < 1)
					return;
				if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.GMONECJCJFK_Sp.Count < PPFNGGCBJKC)
					return;
				NDBFKHKMMCE_DecoItem.FIDBAFHNGCF dbItem = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.GMONECJCJFK_Sp[PPFNGGCBJKC - 1];
				if(dbItem.PLALNIIBLOF_Enabled != 2)
					return;
				FJFCNGNGIBN = dbItem.FJFCNGNGIBN_Attribute;
				CPKMLLNADLJ_Serie = (SeriesAttr.Type)dbItem.CPKMLLNADLJ;
				FLJPIHEEKOJ = dbItem.EKLIPGELKCL;
				GBJFNGCDKPM = dbItem.GBJFNGCDKPM;
				FAKNMCIIAEM_IsAutoFlip = dbItem.FAKNMCIIAEM_IsAutoFlip;
				EDEEMPJPFCP = dbItem.NGILPOOLBCF;
				HDHNEILDILJ = dbItem.JINEKNIBOFI;
				BHDHPCDLICO_Thickness = dbItem.BHDHPCDLICO;
				GJMHALIIPME_Type = dbItem.DMEDKJPOLCH;
				GEMAFKNIKJN_IsOnShelf = dbItem.CMMNFCJNIOO_IsOnShelf == 1;
				FNAKHNBAFGB = dbItem.KIJAPOFAGPN_ItemId;
				if(EKLNMHFCAOI.BKHFLDMOGBD_GetItemCategory(FNAKHNBAFGB) == EKLNMHFCAOI.FKGCBLHOOCL_Category.ADCAAALBAIF_Medal)
				{
					int id2 = EKLNMHFCAOI.DEACAHNLMNI_getItemId(FNAKHNBAFGB);
					if(id2 == 0)
					{
						FNAKHNBAFGB = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.ICICKEBMEFA_Medal.DNEKJCKEOHL_GetMonthlyItemFullId(NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF_ServerRequester.FJDBNGEPKHL.KMEFBNBFJHI_GetServerTime());
					}
				}
				if(GBJFNGCDKPM == 12)
				{
					if(dbItem.ADECCOKCCDH > 0)
					{
						if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.ONODAPNHMPB.Count >= dbItem.ADECCOKCCDH)
						{
							NDBFKHKMMCE_DecoItem.PELPLGBMOII d = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.ONODAPNHMPB[dbItem.ADECCOKCCDH - 1];
							BAGLABPGMMK = d.AGHJAAMABPI;
							NOHLPBMMHGE = GDMGBCFMBPH(ref d.IPGHEIAFCHE);
							KGKGILMHPFN = GDMGBCFMBPH(ref d.MILFOEODPDK);
						}
					}
				}
				BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ saveItem = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.OMMNKDEODJP_DecoItem.NBKAMFFIOOG_Sp.Find((BCGFHLIEKLJ_DecoItem.GNGFGEIAGJL JPAEDJJFFOI) =>
				{
					//0xE7B764
					return PPFNGGCBJKC == JPAEDJJFFOI.PPFNGGCBJKC_Id;
				});
				if(saveItem != null)
					CADENLBDAEB_IsNew = saveItem.CADENLBDAEB_IsNew;
				break;
			}
			default:
				break;
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.OOMMOOIIPJE_DecoItemPoster:
			{
				if(PPFNGGCBJKC < 1)
					return;
				if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.COLIEKINOPB_ItemsPoster.Count < PPFNGGCBJKC)
					return;
				NDBFKHKMMCE_DecoItem.IEOEMNPLANK_PosterItem dbItem = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.COLIEKINOPB_ItemsPoster[PPFNGGCBJKC - 1];
				if(dbItem.PLALNIIBLOF_Enabled != 2)
					return;
				FJFCNGNGIBN = 3;
				CPKMLLNADLJ_Serie = (SeriesAttr.Type)dbItem.CPKMLLNADLJ;
				FLJPIHEEKOJ = dbItem.EKLIPGELKCL;
				GJMHALIIPME_Type = 99;
				BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ saveItem = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.OMMNKDEODJP_DecoItem.PFNNIMBMKDL_Posters.Find((BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ JPAEDJJFFOI) =>
				{
					//0xE7B830
					return PPFNGGCBJKC == JPAEDJJFFOI.PPFNGGCBJKC_Id;
				});
				if(saveItem != null)
					CADENLBDAEB_IsNew = saveItem.CADENLBDAEB_IsNew;
				break;
			}
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.AEFGOANHNMG_DecoItemPosterSceneBef:
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.KKGHNKKGLCO_DecoItemPosterSceneAft:
			{
				if(PPFNGGCBJKC < 1)
					return;
				if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.ECNHDEHADGL_Scene.CDENCMNHNGA_SceneList.Count < PPFNGGCBJKC)
					return;
				MMPBPOIFDAF_Scene.PMKOFEIONEG sIte = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.PNLOINMCCKH_Scene.OPIBAPEGCLA[PPFNGGCBJKC - 1];
				FJFCNGNGIBN = 3;
				MLIBEPGADJH_Scene.KKLDOOJBJMN dbItem = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.ECNHDEHADGL_Scene.CDENCMNHNGA_SceneList[PPFNGGCBJKC - 1];
				CPKMLLNADLJ_Serie = dbItem.AIHCEGFANAM_Serie;
				FLJPIHEEKOJ = dbItem.EKLIPGELKCL_Rarity;
				GJMHALIIPME_Type = 99;
				CADENLBDAEB_IsNew = sIte.JECJALJEDPP(NPADACLCNAN == EKLNMHFCAOI.FKGCBLHOOCL_Category.KKGHNKKGLCO_DecoItemPosterSceneAft ? 1 : 0);
				if(NPADACLCNAN == EKLNMHFCAOI.FKGCBLHOOCL_Category.KKGHNKKGLCO_DecoItemPosterSceneAft)
				{
					FMGBBKHJDEC_CanKira = 0 < IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.ECNHDEHADGL_Scene.ELKHCOEMNOJ(PPFNGGCBJKC, sIte.DMNIMMGGJJJ_Leaf, IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.HDGOHBFKKDM_LimitOver);
				}
				break;
			}
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.HEMGMACMGAB_DecoItemVFFigure:
			{
				if(PPFNGGCBJKC < 1)
					return;
				if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.PEOALFEGNDH_Valkyrie.CDENCMNHNGA_ValkyrieList.Count < PPFNGGCBJKC)
					return;
				JPIANKEOOMB_Valkyrie.KJPIDJOMODA_ValkyrieInfo dbItem = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.PEOALFEGNDH_Valkyrie.CDENCMNHNGA_ValkyrieList[PPFNGGCBJKC - 1];
				CPKMLLNADLJ_Serie = (SeriesAttr.Type)dbItem.AIHCEGFANAM_Sa;
				FJFCNGNGIBN = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.LPJLEHAJADA("attr_vffigure", 12);
				FLJPIHEEKOJ = 1;
				GBJFNGCDKPM = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.LPJLEHAJADA("typ_vffigure", 3);
				GJMHALIIPME_Type = GBJFNGCDKPM;
				EDEEMPJPFCP = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.LPJLEHAJADA("offset_x_vffigure", 0);
				HDHNEILDILJ = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.LPJLEHAJADA("offset_y_vffigure", 0);
				BHDHPCDLICO_Thickness = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.LPJLEHAJADA("thickness_vffigure", 20);
				OIGEIIGKMNH_Valkyrie.HLNPGNNPCGO_ValkyrieInfo sIt = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.JJFFBDLIOCF_Valkyrie.CNGNBKNBKGI_ValkList[PPFNGGCBJKC - 1];
				CADENLBDAEB_IsNew = sIt.FJKIELICMAH_DvfNew;
				break;
			}
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.NNBMEEPOBIO_DecoItemCostumeTorso:
			{
				if(PPFNGGCBJKC < 1)
					return;
				if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.MFPNGNMFEAL_Costume.CDENCMNHNGA_Costumes.Count < PPFNGGCBJKC)
					return;
				LCLCCHLDNHJ_Costume.ILODJKFJJDO_CostumeInfo dbItem = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.MFPNGNMFEAL_Costume.CDENCMNHNGA_Costumes[PPFNGGCBJKC - 1];
				CPKMLLNADLJ_Serie = (SeriesAttr.Type)IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.MGFMPKLLGHE_Diva.GCINIJEMHFK_GetInfo(dbItem.AHHJLDLAPAN_PrismDivaId).AIHCEGFANAM_Attr;
				FJFCNGNGIBN = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.LPJLEHAJADA("attr_costume_torso", 12);
				FLJPIHEEKOJ = 1;
				GBJFNGCDKPM = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.LPJLEHAJADA("typ_costume_torso", 3);
				GJMHALIIPME_Type = GBJFNGCDKPM;
				EDEEMPJPFCP = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.LPJLEHAJADA("offset_x_costume_torso", 0);
				HDHNEILDILJ = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.LPJLEHAJADA("offset_y_costume_torso", 0);
				BHDHPCDLICO_Thickness = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.LPJLEHAJADA("thickness_costume_torso", 20);
				EBFLJMOCLNA_Costume.ILFJDCICIKN sIt = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.BEKHNNCGIEL_Costume.FABAGMLEKIB_List[PPFNGGCBJKC - 1];
				CADENLBDAEB_IsNew = sIt.GPOJCDOEDFD(0);
				break;
			}
		}
		NPADACLCNAN_Category = NPADACLCNAN;
		PPFNGGCBJKC_Id = PPFNGGCBJKC;
		int itemId = 0;
		if(NPADACLCNAN != 0)
		{
			itemId = EKLNMHFCAOI.GJEEGMCBGGM_GetItemFullId(NPADACLCNAN, PPFNGGCBJKC);
		}
		KGBAOKCMALD = itemId;
		FBFLDFMFFOH = EKLNMHFCAOI.FABCKNDLPDH_GetItemRarity(NPADACLCNAN, PPFNGGCBJKC);
		BFINGCJHOHI = EKLNMHFCAOI.ALHCGDMEMID_GetNumItems(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database, CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave, NPADACLCNAN, PPFNGGCBJKC, null);
		AKKLMEPIJBN = DOEMNGNEILE(NPADACLCNAN);
	}

	//// RVA: 0xE76BE4 Offset: 0xE76BE4 VA: 0xE76BE4
	public void LHPDDGIJKNB()
	{
		PPFNGGCBJKC_Id = 0;
		FPCGPGJOKNH_CharaId = 0;
		EDEEMPJPFCP = 0;
		HDHNEILDILJ = 0;
		BHDHPCDLICO_Thickness = 0;
		KGBAOKCMALD = 0;
		GBJFNGCDKPM = 0;
		FAKNMCIIAEM_IsAutoFlip = 0;
		FNAKHNBAFGB = 0;
		FJFCNGNGIBN = 0;
		CPKMLLNADLJ_Serie = 0;
		FBFLDFMFFOH = 0;
		FLJPIHEEKOJ = 0;
		AKKLMEPIJBN = 0;
		BAGLABPGMMK = 0;
		NOHLPBMMHGE = null;
		KGKGILMHPFN = null;
		OPFGFINHFCE_Name = "";
		FEMMDNIELFC_Desc = "";
		DOIGLOBENMG = "";
		NPADACLCNAN_Category = 0;
		DBGAJBIBODC = 0;
		GJMHALIIPME_Type = 0;
		GEMAFKNIKJN_IsOnShelf = false;
		BHDHPCDLICO_Thickness = 0;
		GJMHALIIPME_Type = 0;
		BFINGCJHOHI = 0;
		CADENLBDAEB_IsNew = false;
		FMGBBKHJDEC_CanKira = false;
	}

	//// RVA: 0xE76E6C Offset: 0xE76E6C VA: 0xE76E6C
	public void ODDIHGPONFL(KDKFHGHGFEK GPBJHKLFCEP)
	{
		PPFNGGCBJKC_Id = GPBJHKLFCEP.PPFNGGCBJKC_Id;
		OPFGFINHFCE_Name = GPBJHKLFCEP.OPFGFINHFCE_Name;
		FEMMDNIELFC_Desc = GPBJHKLFCEP.FEMMDNIELFC_Desc;
		DOIGLOBENMG = GPBJHKLFCEP.DOIGLOBENMG;
		NPADACLCNAN_Category = GPBJHKLFCEP.NPADACLCNAN_Category;
		FJFCNGNGIBN = GPBJHKLFCEP.FJFCNGNGIBN;
		CPKMLLNADLJ_Serie = GPBJHKLFCEP.CPKMLLNADLJ_Serie;
		FBFLDFMFFOH = GPBJHKLFCEP.FBFLDFMFFOH;
		FLJPIHEEKOJ = GPBJHKLFCEP.FLJPIHEEKOJ;
		KGBAOKCMALD = GPBJHKLFCEP.KGBAOKCMALD;
		GBJFNGCDKPM = GPBJHKLFCEP.GBJFNGCDKPM;
		BFINGCJHOHI = GPBJHKLFCEP.BFINGCJHOHI;
		FAKNMCIIAEM_IsAutoFlip = GPBJHKLFCEP.FAKNMCIIAEM_IsAutoFlip;
		FNAKHNBAFGB = GPBJHKLFCEP.FNAKHNBAFGB;
		FPCGPGJOKNH_CharaId = GPBJHKLFCEP.FPCGPGJOKNH_CharaId;
		EDEEMPJPFCP = GPBJHKLFCEP.EDEEMPJPFCP;
		HDHNEILDILJ = GPBJHKLFCEP.HDHNEILDILJ;
		BHDHPCDLICO_Thickness = GPBJHKLFCEP.BHDHPCDLICO_Thickness;
		GJMHALIIPME_Type = GPBJHKLFCEP.GJMHALIIPME_Type;
		GEMAFKNIKJN_IsOnShelf = GPBJHKLFCEP.GEMAFKNIKJN_IsOnShelf;
		DBGAJBIBODC = GPBJHKLFCEP.DBGAJBIBODC;
		AKKLMEPIJBN = GPBJHKLFCEP.AKKLMEPIJBN;
		CADENLBDAEB_IsNew = GPBJHKLFCEP.CADENLBDAEB_IsNew;
		BAGLABPGMMK = GPBJHKLFCEP.BAGLABPGMMK;
		if(GPBJHKLFCEP.NOHLPBMMHGE != null)
			NOHLPBMMHGE = GPBJHKLFCEP.NOHLPBMMHGE.Clone() as int[];
		if(GPBJHKLFCEP.KGKGILMHPFN != null)
			KGKGILMHPFN = GPBJHKLFCEP.KGKGILMHPFN.Clone() as int[];
	}

	//// RVA: 0xE772C8 Offset: 0xE772C8 VA: 0xE772C8
	public bool OHAMGNMKOII()
	{
		if(NPADACLCNAN_Category >= EKLNMHFCAOI.FKGCBLHOOCL_Category.OOMMOOIIPJE_DecoItemPoster && NPADACLCNAN_Category <= EKLNMHFCAOI.FKGCBLHOOCL_Category.KKGHNKKGLCO_DecoItemPosterSceneAft)
			return FLJPIHEEKOJ > 5;
		return false;
	}

	//// RVA: 0xE772F4 Offset: 0xE772F4 VA: 0xE772F4
	public static List<KDKFHGHGFEK> FKDIMODKKJD()
	{
		List<KDKFHGHGFEK> res = new List<KDKFHGHGFEK>();
		FKDIMODKKJD(ref res);
		return res; 
	}

	//// RVA: 0xE773B0 Offset: 0xE773B0 VA: 0xE773B0
	public static void FKDIMODKKJD(ref List<KDKFHGHGFEK> NNDGIAEFMOG)
	{
		NNDGIAEFMOG.Clear();
		FKDIMODKKJD(NDBFKHKMMCE_DecoItem.ANMODBDBNPK.DBAMIACJODJ.PMJFENNOEJD_Bg, ref NNDGIAEFMOG);
		FKDIMODKKJD(NDBFKHKMMCE_DecoItem.ANMODBDBNPK.DBAMIACJODJ.JKMLKAMHJIF_Obj, ref NNDGIAEFMOG);
		FKDIMODKKJD(NDBFKHKMMCE_DecoItem.ANMODBDBNPK.DBAMIACJODJ.MIIELMELDBO_Char, ref NNDGIAEFMOG);
		FKDIMODKKJD(NDBFKHKMMCE_DecoItem.ANMODBDBNPK.DBAMIACJODJ.BKLKNLDCJIO_Stamp, ref NNDGIAEFMOG);
		FKDIMODKKJD(NDBFKHKMMCE_DecoItem.ANMODBDBNPK.DBAMIACJODJ.AAAOOKJAMGE_Sp, ref NNDGIAEFMOG);
	}

	//// RVA: 0xE78E64 Offset: 0xE78E64 VA: 0xE78E64
	public static bool JBLGOGMHCFP_UpdatePosterCache()
	{
		bool res = false;
		if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database != null && CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave != null)
		{
			if(CIBDILHIBEG_PosterBef == null)
				CIBDILHIBEG_PosterBef = new List<BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ>();
			CIBDILHIBEG_PosterBef.Clear();
			if(FFNENJELGIF_PosterAft == null)
				FFNENJELGIF_PosterAft = new List<BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ>();
			FFNENJELGIF_PosterAft.Clear();
			for(int i = 0; i < CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.PNLOINMCCKH_Scene.OPIBAPEGCLA.Count; i++)
			{
				int cnt = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.PNLOINMCCKH_Scene.HOLEDOLMJCB(i + 1, IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.ECNHDEHADGL_Scene, 0);
				int cnt2 = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.PNLOINMCCKH_Scene.HOLEDOLMJCB(i + 1, IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.ECNHDEHADGL_Scene, 1);
				if(cnt > 0)
				{
					BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ data = new BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ();
					data.PPFNGGCBJKC_Id = i + 1;
					data.BFINGCJHOHI_Cnt = cnt;
					CIBDILHIBEG_PosterBef.Add(data);
					res = true;
				}
				if(cnt2 > 0)
				{
					BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ data = new BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ();
					data.PPFNGGCBJKC_Id = i + 1;
					data.BFINGCJHOHI_Cnt = cnt2;
					FFNENJELGIF_PosterAft.Add(data);
					res = true;
				}
			}
		}
		return res;
	}

	//// RVA: 0xE794B0 Offset: 0xE794B0 VA: 0xE794B0
	public static bool CEMDACGFKFP_UpdateValkCache()
	{
		bool res = false;
		if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database != null && CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave != null)
		{
			if(KKIEEIGGJPK_ValkList == null)
			{
				KKIEEIGGJPK_ValkList = new List<BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ>();
			}
			KKIEEIGGJPK_ValkList.Clear();
			for(int i = 0; i < CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.JJFFBDLIOCF_Valkyrie.CNGNBKNBKGI_ValkList.Count; i++)
			{
				int cnt = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.JJFFBDLIOCF_Valkyrie.NBFPEPBFEHI(i + 1, IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.PEOALFEGNDH_Valkyrie);
				if(cnt > 0)
				{
					BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ data = new BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ();
					data.PPFNGGCBJKC_Id = i + 1;
					data.BFINGCJHOHI_Cnt = cnt;
					KKIEEIGGJPK_ValkList.Add(data);
					res = true;
				}
            }
		}
		return res;
	}

	//// RVA: 0xE79890 Offset: 0xE79890 VA: 0xE79890
	public static bool EOACAIMCBCG_UpdateCostumeCache()
	{
		bool res = false;
		if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database != null && CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave != null)
		{
			if(JKNMNFKPEAA_CostumeList == null)
				JKNMNFKPEAA_CostumeList = new List<BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ>();
			JKNMNFKPEAA_CostumeList.Clear();
			for(int i = 0; i < CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.BEKHNNCGIEL_Costume.FABAGMLEKIB_List.Count; i++)
			{
				int cnt = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.BEKHNNCGIEL_Costume.LMLGEDEJCJO(i + 1, IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.MFPNGNMFEAL_Costume, true);
				if(cnt > 0)
				{
					BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ data = new BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ();
					data.PPFNGGCBJKC_Id = i + 1;
					data.BFINGCJHOHI_Cnt = cnt;
					JKNMNFKPEAA_CostumeList.Add(data);
					res = true;
				}
			}
		}
		return res;
	}

	//// RVA: 0xE79C80 Offset: 0xE79C80 VA: 0xE79C80
	public static List<KDKFHGHGFEK> FKDIMODKKJD(NDBFKHKMMCE_DecoItem.ANMODBDBNPK.DBAMIACJODJ NPADACLCNAN)
	{
		List<KDKFHGHGFEK> res = new List<KDKFHGHGFEK>();
		FKDIMODKKJD(NPADACLCNAN, ref res);
		return res;
	}

	//// RVA: 0xE77490 Offset: 0xE77490 VA: 0xE77490
	public static void FKDIMODKKJD(NDBFKHKMMCE_DecoItem.ANMODBDBNPK.DBAMIACJODJ NPADACLCNAN, ref List<KDKFHGHGFEK> NNDGIAEFMOG)
	{
		if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database != null && CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave != null)
		{
			switch(NPADACLCNAN)
			{
				case NDBFKHKMMCE_DecoItem.ANMODBDBNPK.DBAMIACJODJ.PMJFENNOEJD_Bg:
					for(int i = 0; i < CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.OMMNKDEODJP_DecoItem.DJHBDDGEKGO_Bgs.Count; i++)
					{
                        BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ it = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.OMMNKDEODJP_DecoItem.DJHBDDGEKGO_Bgs[i];
						if(it.BFINGCJHOHI_Cnt > 0)
						{
							KDKFHGHGFEK data = new KDKFHGHGFEK();
							data.KHEKNNFCAOI(it.PPFNGGCBJKC_Id, EKLNMHFCAOI.FKGCBLHOOCL_Category.GPMKJNDHDCP_DecoItemBg);
							if(data.PPFNGGCBJKC_Id > 0)
							{
								NNDGIAEFMOG.Add(data);
							}
						}
                    }
					break;
				case NDBFKHKMMCE_DecoItem.ANMODBDBNPK.DBAMIACJODJ.JKMLKAMHJIF_Obj:
					for(int i = 0; i < CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.OMMNKDEODJP_DecoItem.KPMFLNOELIN_Objs.Count; i++)
					{
                        BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ it = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.OMMNKDEODJP_DecoItem.KPMFLNOELIN_Objs[i];
						if(it.BFINGCJHOHI_Cnt > 0)
						{
							KDKFHGHGFEK data = new KDKFHGHGFEK();
							data.KHEKNNFCAOI(it.PPFNGGCBJKC_Id, EKLNMHFCAOI.FKGCBLHOOCL_Category.OKPAJOALDCG_DecoItemObj);
							if(data.PPFNGGCBJKC_Id > 0)
							{
								NNDGIAEFMOG.Add(data);
							}
						}
					}
					for(int i = 0; i < CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.OMMNKDEODJP_DecoItem.PFNNIMBMKDL_Posters.Count; i++)
					{
                        BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ it = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.OMMNKDEODJP_DecoItem.PFNNIMBMKDL_Posters[i];
						if(it.BFINGCJHOHI_Cnt > 0)
						{
							KDKFHGHGFEK data = new KDKFHGHGFEK();
							data.KHEKNNFCAOI(it.PPFNGGCBJKC_Id, EKLNMHFCAOI.FKGCBLHOOCL_Category.OOMMOOIIPJE_DecoItemPoster);
							if(data.PPFNGGCBJKC_Id > 0)
							{
								NNDGIAEFMOG.Add(data);
							}
						}
					}
					List<KDKFHGHGFEK> l = new List<KDKFHGHGFEK>();
					l.Clear();
					CEMDACGFKFP_UpdateValkCache();
					for(int i = 0; i < KKIEEIGGJPK_ValkList.Count; i++)
					{
						if(KKIEEIGGJPK_ValkList[i].BFINGCJHOHI_Cnt > 0)
						{
							KDKFHGHGFEK data = new KDKFHGHGFEK();
							data.KHEKNNFCAOI(KKIEEIGGJPK_ValkList[i].PPFNGGCBJKC_Id, EKLNMHFCAOI.FKGCBLHOOCL_Category.HEMGMACMGAB_DecoItemVFFigure);
							if(data.PPFNGGCBJKC_Id > 0)
							{
								l.Add(data);
							}
						}
					}
					NNDGIAEFMOG.AddRange(l);
					List<KDKFHGHGFEK> l2 = new List<KDKFHGHGFEK>();
					l2.Clear();
					EOACAIMCBCG_UpdateCostumeCache();
					for(int i = 0; i < JKNMNFKPEAA_CostumeList.Count; i++)
					{
						if(JKNMNFKPEAA_CostumeList[i].BFINGCJHOHI_Cnt > 0)
						{
							KDKFHGHGFEK data = new KDKFHGHGFEK();
							data.KHEKNNFCAOI(JKNMNFKPEAA_CostumeList[i].PPFNGGCBJKC_Id, EKLNMHFCAOI.FKGCBLHOOCL_Category.NNBMEEPOBIO_DecoItemCostumeTorso);
							if(data.PPFNGGCBJKC_Id > 0)
							{
                                LCLCCHLDNHJ_Costume.ILODJKFJJDO_CostumeInfo dbCos = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.MFPNGNMFEAL_Costume.CDENCMNHNGA_Costumes[data.PPFNGGCBJKC_Id - 1];
								data.EILKGEADKGH = data.PPFNGGCBJKC_Id * 10 + dbCos.AHHJLDLAPAN_PrismDivaId * 100000;
                                l2.Add(data);
							}
						}
					}
					NNDGIAEFMOG.AddRange(l2);
					l2 = new List<KDKFHGHGFEK>();
					l2.Clear();
					JBLGOGMHCFP_UpdatePosterCache();
					for(int i = 0; i < CIBDILHIBEG_PosterBef.Count; i++)
					{
						if(CIBDILHIBEG_PosterBef[i].BFINGCJHOHI_Cnt > 0)
						{
							KDKFHGHGFEK data = new KDKFHGHGFEK();
							data.KHEKNNFCAOI(CIBDILHIBEG_PosterBef[i].PPFNGGCBJKC_Id, EKLNMHFCAOI.FKGCBLHOOCL_Category.AEFGOANHNMG_DecoItemPosterSceneBef);
							if(data.PPFNGGCBJKC_Id > 0)
							{
								l2.Add(data);
							}
						}
					}
					for(int i = 0; i < FFNENJELGIF_PosterAft.Count; i++)
					{
						if(FFNENJELGIF_PosterAft[i].BFINGCJHOHI_Cnt > 0)
						{
							KDKFHGHGFEK data = new KDKFHGHGFEK();
							data.KHEKNNFCAOI(FFNENJELGIF_PosterAft[i].PPFNGGCBJKC_Id, EKLNMHFCAOI.FKGCBLHOOCL_Category.KKGHNKKGLCO_DecoItemPosterSceneAft);
							if(data.PPFNGGCBJKC_Id > 0)
							{
								l2.Add(data);
							}
						}
					}
					l2.Sort((KDKFHGHGFEK HKICMNAACDA, KDKFHGHGFEK BNKHBCBJBKI) =>
					{
						//0xE7B598
						int res = HKICMNAACDA.PPFNGGCBJKC_Id.CompareTo(BNKHBCBJBKI.PPFNGGCBJKC_Id);
						if(res == 0)
						{
							res = ((int)HKICMNAACDA.NPADACLCNAN_Category).CompareTo((int)BNKHBCBJBKI.NPADACLCNAN_Category);
						}
						return res;
					});
					NNDGIAEFMOG.AddRange(l2);
					return;
				case NDBFKHKMMCE_DecoItem.ANMODBDBNPK.DBAMIACJODJ.MIIELMELDBO_Char:
					for(int i = 0; i < CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.OMMNKDEODJP_DecoItem.PEBDEIKBCCM_Chars.Count; i++)
					{
                        BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ it = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.OMMNKDEODJP_DecoItem.PEBDEIKBCCM_Chars[i];
						if(it.BFINGCJHOHI_Cnt > 0)
						{
							KDKFHGHGFEK data = new KDKFHGHGFEK();
							data.KHEKNNFCAOI(it.PPFNGGCBJKC_Id, EKLNMHFCAOI.FKGCBLHOOCL_Category.MCKHJLHKMJD_DecoItemChara);
							if(data.PPFNGGCBJKC_Id > 0)
							{
								NNDGIAEFMOG.Add(data);
							}
						}
                    }
					break;
				case NDBFKHKMMCE_DecoItem.ANMODBDBNPK.DBAMIACJODJ.BKLKNLDCJIO_Stamp:
					for(int i = 0; i < CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.FJPOELGFPBP_DecoStamp.DMKMNGELNAE_Serif.Count; i++)
					{
                        IOEKHJBOMDH_DecoStamp.GFPPDCEPLCM it = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.FJPOELGFPBP_DecoStamp.DMKMNGELNAE_Serif[i];
                        if (it.BFINGCJHOHI_Cnt > 0)
						{
							KDKFHGHGFEK data = new KDKFHGHGFEK();
							data.KHEKNNFCAOI(it.PPFNGGCBJKC_Id, EKLNMHFCAOI.FKGCBLHOOCL_Category.ICIMCGOJEMD_StampItemSerif);
							if(data.PPFNGGCBJKC_Id > 0)
							{
								NNDGIAEFMOG.Add(data);
							}
						}
                    }
					break;
				case NDBFKHKMMCE_DecoItem.ANMODBDBNPK.DBAMIACJODJ.AAAOOKJAMGE_Sp:
					for(int i = 0; i < CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.OMMNKDEODJP_DecoItem.NBKAMFFIOOG_Sp.Count; i++)
					{
                        BCGFHLIEKLJ_DecoItem.AKAHOEBACGJ it = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.OMMNKDEODJP_DecoItem.NBKAMFFIOOG_Sp[i];
						if(it.BFINGCJHOHI_Cnt > 0)
						{
							KDKFHGHGFEK data = new KDKFHGHGFEK();
							data.KHEKNNFCAOI(it.PPFNGGCBJKC_Id, EKLNMHFCAOI.FKGCBLHOOCL_Category.BMMBLLOKNPF_DecoItemSp);
							if(data.PPFNGGCBJKC_Id > 0)
							{
								NNDGIAEFMOG.Add(data);
							}
						}
                    }
					break;
			}
		}
	}

	//// RVA: 0xE79D4C Offset: 0xE79D4C VA: 0xE79D4C
	public static bool ALBPEEPPNOI(int KIJAPOFAGPN)
	{
		int itemId = EKLNMHFCAOI.DEACAHNLMNI_getItemId(KIJAPOFAGPN);
		int a = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.GMONECJCJFK_Sp[itemId - 1].GBJFNGCDKPM;
		return a > 0 && a - 1 < 3;
	}

	//// RVA: 0xE79EC0 Offset: 0xE79EC0 VA: 0xE79EC0
	public static bool HANJGFKOGGO(int KIJAPOFAGPN)
	{
		EKLNMHFCAOI.FKGCBLHOOCL_Category cat = EKLNMHFCAOI.BKHFLDMOGBD_GetItemCategory(KIJAPOFAGPN);
		int id = EKLNMHFCAOI.DEACAHNLMNI_getItemId(KIJAPOFAGPN);
		if (cat != EKLNMHFCAOI.FKGCBLHOOCL_Category.BMMBLLOKNPF_DecoItemSp)
			return false;
		return IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.GMONECJCJFK_Sp[id - 1].GBJFNGCDKPM > 0 && IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.GMONECJCJFK_Sp[id - 1].GBJFNGCDKPM - 1 < 3;
	}

	//// RVA: 0xE7A04C Offset: 0xE7A04C VA: 0xE7A04C
	public static bool HMAOJBKJIOJ(int KIJAPOFAGPN, int DMBFOMLCGBG, int OMMKKNPGNPH)
	{
		if(ALBPEEPPNOI(KIJAPOFAGPN))
		{
			if(!KKDMFKGMHLD(DMBFOMLCGBG))
			{
				int itemId = EKLNMHFCAOI.DEACAHNLMNI_getItemId(KIJAPOFAGPN);
				BCGFHLIEKLJ_DecoItem.GNGFGEIAGJL s = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.OMMNKDEODJP_DecoItem.NBKAMFFIOOG_Sp[itemId - 1];
				NDBFKHKMMCE_DecoItem.FIDBAFHNGCF db = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.GMONECJCJFK_Sp[itemId - 1];
				List<NEGELNMPEPH_DecoSpSetting.DAGLEHBMBLF> l = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.BGKKOOGPEFD_DecoSpSetting.ILCGCPIGAFP[DMBFOMLCGBG];
				if(OMMKKNPGNPH >= l[db.GBJFNGCDKPM - 1].BCGKLONODHO)
					return true;
			}
		}
		return false;
	}

	//// RVA: 0xE7A520 Offset: 0xE7A520 VA: 0xE7A520
	public static int DFMGMEDILKB(int KIJAPOFAGPN)
	{
		return CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.OMMNKDEODJP_DecoItem.NBKAMFFIOOG_Sp[EKLNMHFCAOI.DEACAHNLMNI_getItemId(KIJAPOFAGPN) - 1].ANAJIAENLNB_Level;
	}

	//// RVA: 0xE7A410 Offset: 0xE7A410 VA: 0xE7A410
	public static bool KKDMFKGMHLD(int DMBFOMLCGBG)
	{
		return IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.BGKKOOGPEFD_DecoSpSetting.ILCGCPIGAFP.Count <= DMBFOMLCGBG;
	}

	//// RVA: 0xE7A68C Offset: 0xE7A68C VA: 0xE7A68C
	public static bool HMDOAKPBLFL(int KIJAPOFAGPN, int DMBFOMLCGBG, long JHNMKKNEENE)
	{
		return IOKFJAIDMLD(KIJAPOFAGPN, DMBFOMLCGBG, JHNMKKNEENE) > 0;
	}

	//// RVA: 0xE7A73C Offset: 0xE7A73C VA: 0xE7A73C
	public static int IOKFJAIDMLD(int KIJAPOFAGPN, int DMBFOMLCGBG, long JHNMKKNEENE)
	{
		int itemId = EKLNMHFCAOI.DEACAHNLMNI_getItemId(KIJAPOFAGPN);
		BCGFHLIEKLJ_DecoItem.GNGFGEIAGJL s = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.OMMNKDEODJP_DecoItem.NBKAMFFIOOG_Sp[itemId - 1];
		List<NEGELNMPEPH_DecoSpSetting.DAGLEHBMBLF> l = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.BGKKOOGPEFD_DecoSpSetting.ILCGCPIGAFP[DMBFOMLCGBG - 1];
		NDBFKHKMMCE_DecoItem.FIDBAFHNGCF db = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.GMONECJCJFK_Sp[itemId - 1];
		return Mathf.Min((int)((s.EMHCHMHMFHJ_ChargeTimeOffset + (JHNMKKNEENE - s.FOONCJDLLIK_ChargeTime)) % GGEGLPOMJCK(KIJAPOFAGPN, DMBFOMLCGBG)), l[db.GBJFNGCDKPM - 1].NANNGLGOFKH);
	}

	//// RVA: 0xE7ADE4 Offset: 0xE7ADE4 VA: 0xE7ADE4
	public static long CFNHNIMKPCI_GetChargeTimeOffset(BCGFHLIEKLJ_DecoItem.GNGFGEIAGJL BBFIGEOBOMB, long JHNMKKNEENE)
	{
		int id = EKLNMHFCAOI.DEACAHNLMNI_getItemId(BBFIGEOBOMB.PPFNGGCBJKC_Id);
		NDBFKHKMMCE_DecoItem.FIDBAFHNGCF dbItem = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.GMONECJCJFK_Sp[id - 1];
		List<NEGELNMPEPH_DecoSpSetting.DAGLEHBMBLF> l = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.BGKKOOGPEFD_DecoSpSetting.ILCGCPIGAFP[BBFIGEOBOMB.ANAJIAENLNB_Level - 1];
		NEGELNMPEPH_DecoSpSetting.DAGLEHBMBLF data = l[dbItem.GBJFNGCDKPM];
		long t = BBFIGEOBOMB.EMHCHMHMFHJ_ChargeTimeOffset + JHNMKKNEENE - BBFIGEOBOMB.FOONCJDLLIK_ChargeTime;
		long res = 0;
		if(t < data.KPBJHHHMOJE * 60)
		{
			long t2 = t - GGEGLPOMJCK(BBFIGEOBOMB.PPFNGGCBJKC_Id, BBFIGEOBOMB.ANAJIAENLNB_Level) * IOKFJAIDMLD(BBFIGEOBOMB.PPFNGGCBJKC_Id, BBFIGEOBOMB.ANAJIAENLNB_Level, JHNMKKNEENE);
			if(t2 != 0)
				res = t2;
		}
		return res;
	}

	//// RVA: 0xE7AB60 Offset: 0xE7AB60 VA: 0xE7AB60
	public static long GGEGLPOMJCK(int KIJAPOFAGPN, int CIEOBFIIPLD)
	{
		int itemId = EKLNMHFCAOI.DEACAHNLMNI_getItemId(KIJAPOFAGPN);
		NDBFKHKMMCE_DecoItem.FIDBAFHNGCF db = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.GMONECJCJFK_Sp[itemId - 1];
		List<NEGELNMPEPH_DecoSpSetting.DAGLEHBMBLF> l = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.BGKKOOGPEFD_DecoSpSetting.ILCGCPIGAFP[CIEOBFIIPLD - 1];
		return (l[db.GBJFNGCDKPM - 1].KPBJHHHMOJE * 60) / l[db.GBJFNGCDKPM - 1].NANNGLGOFKH;
	}

	//// RVA: 0xE7B21C Offset: 0xE7B21C VA: 0xE7B21C
	//public List<int> FGEADBNLMDB(List<int> LJNPPPOBHFK) { }

	//// RVA: 0xE7B224 Offset: 0xE7B224 VA: 0xE7B224
	public static bool LDKPACJFPFK(int KIJAPOFAGPN, out TransitionUniqueId PGIIDPEGGPI)
	{
		PGIIDPEGGPI = TransitionUniqueId.TITLE;
		if(EKLNMHFCAOI.BKHFLDMOGBD_GetItemCategory(KIJAPOFAGPN) == EKLNMHFCAOI.FKGCBLHOOCL_Category.BMMBLLOKNPF_DecoItemSp)
		{
			int id = EKLNMHFCAOI.DEACAHNLMNI_getItemId(KIJAPOFAGPN);
			NDBFKHKMMCE_DecoItem.FIDBAFHNGCF dbItem = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.EPAHOAKPAJJ_DecoItem.GMONECJCJFK_Sp[id - 1];
			if(dbItem.GBJFNGCDKPM == 4)
				PGIIDPEGGPI = TransitionUniqueId.MUSICSELECT;
			else if(dbItem.GBJFNGCDKPM == 6)
				PGIIDPEGGPI = TransitionUniqueId.GACHA2;
			else if(dbItem.GBJFNGCDKPM == 5)
				PGIIDPEGGPI = TransitionUniqueId.SETTINGMENU;
			else
				return false;
			return true;
		}
		return false;
	}

	//// RVA: 0xE7B410 Offset: 0xE7B410 VA: 0xE7B410
	//public static int EIMPNCHJFOB() { }

	//// RVA: 0xE76C90 Offset: 0xE76C90 VA: 0xE76C90
	private static int[] GDMGBCFMBPH(ref CEBFFLDKAEC_SecureInt[] BGGANFLMLDA)
	{
		int[] res = new int[BGGANFLMLDA.Length];
		for(int i = 0; i < BGGANFLMLDA.Length; i++)
		{
			res[i] = BGGANFLMLDA[i].DNJEJEANJGL_Value;
		}
		return res;
	}

	//// RVA: 0xE76DC4 Offset: 0xE76DC4 VA: 0xE76DC4
	private int DOEMNGNEILE(EKLNMHFCAOI.FKGCBLHOOCL_Category JONPKLHMOBL)
	{
		switch(JONPKLHMOBL)
		{
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.GPMKJNDHDCP_DecoItemBg:
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.MCKHJLHKMJD_DecoItemChara:
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.ICIMCGOJEMD_StampItemSerif:
				return (int)JONPKLHMOBL - 26;
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.OKPAJOALDCG_DecoItemObj:
				return 1;
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.BMMBLLOKNPF_DecoItemSp:
				return 11;
			default:
				return -1;
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.OOMMOOIIPJE_DecoItemPoster:
				return 5;
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.AEFGOANHNMG_DecoItemPosterSceneBef:
				return 6;
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.KKGHNKKGLCO_DecoItemPosterSceneAft:
				return 7;
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.ICJOEDJECAP_DecoSetItem:
				return 8;
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.HEMGMACMGAB_DecoItemVFFigure:
				return 9;
			case EKLNMHFCAOI.FKGCBLHOOCL_Category.NNBMEEPOBIO_DecoItemCostumeTorso:
				return 10;
		}
		return 1;
	}
}
