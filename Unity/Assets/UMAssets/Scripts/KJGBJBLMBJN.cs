
public class KJGBJBLMBJN
{
	public BLHNHKMMPAD HBODCMLFDOB = new BLHNHKMMPAD(); // 0x8
	public string OPFGFINHFCE_Name; // 0xC
	public int BHCIFFILAKJ_Strg; // 0x10
	public int PCPKGJIMLGO_Crypted; // 0x14

	public int PBJLLAOJMAK_PId { get { return PCPKGJIMLGO_Crypted ^ 0x749f717e; } set { PCPKGJIMLGO_Crypted = value ^ 0x749f717e; } } //0x1A02F00 FOAOPKGHJGM 0x1A02F14 JGEILGLALBP

	// RVA: 0x1A02F28 Offset: 0x1A02F28 VA: 0x1A02F28
	public void LHPDDGIJKNB()
    {
        HBODCMLFDOB.LHPDDGIJKNB();
        OPFGFINHFCE_Name = "";
        BHCIFFILAKJ_Strg = 0;
        PBJLLAOJMAK_PId = 0;
    }

	// // RVA: 0x1A02FC4 Offset: 0x1A02FC4 VA: 0x1A02FC4
	public bool AGBOGBEOFME(KJGBJBLMBJN OIKJFMGEICL)
	{
		if(!HBODCMLFDOB.AGBOGBEOFME(OIKJFMGEICL.HBODCMLFDOB))
			return false;
		if(OPFGFINHFCE_Name != OIKJFMGEICL.OPFGFINHFCE_Name)
			return false;
		if(PCPKGJIMLGO_Crypted != OIKJFMGEICL.PCPKGJIMLGO_Crypted)
			return false;
		if(BHCIFFILAKJ_Strg != OIKJFMGEICL.BHCIFFILAKJ_Strg)
			return false;
		return true;
	}

	// // RVA: 0x1A03064 Offset: 0x1A03064 VA: 0x1A03064
	public void ODDIHGPONFL(KJGBJBLMBJN OIKJFMGEICL)
	{
		OPFGFINHFCE_Name = OIKJFMGEICL.OPFGFINHFCE_Name;
		HBODCMLFDOB.ODDIHGPONFL(OIKJFMGEICL.HBODCMLFDOB);
		PCPKGJIMLGO_Crypted = OIKJFMGEICL.PCPKGJIMLGO_Crypted;
		BHCIFFILAKJ_Strg = OIKJFMGEICL.BHCIFFILAKJ_Strg;
	}

	// // RVA: 0x1A030E8 Offset: 0x1A030E8 VA: 0x1A030E8
	public EDOHBJAPLPF_JsonData OKJPIBHMKMJ()
	{
		EDOHBJAPLPF_JsonData res = HBODCMLFDOB.NOJCMGAFAAC();
		res["pid"] = PBJLLAOJMAK_PId;
		res["name"] = OPFGFINHFCE_Name;
		res["strg"] = BHCIFFILAKJ_Strg;
		return res;
	}
}