using UnityEngine;

public class HHEIANIHCNH { }
public class HHEIANIHCNH_RequestPlayerStatus : CACGCMBKHDI_Request
{
	public HEHLBMMFMPL NFEAMMJIMPG { get; private set; } // 0x7C OHEIOONIIKB LFOJDJCNOHB x17574D0 KMKEGMGKCBA 0x17574D8

	// // RVA: 0x17574E0 Offset: 0x17574E0 VA: 0x17574E0 Slot: 12
	public override void DHLDNIEELHO()
    {
        EBGACDGNCAA = SakashoUserToken.GetPlayerStatus(this.DCKLDDCAJAP, this.MEOCKCJBDAD);
    }

	// // RVA: 0x17575BC Offset: 0x17575BC VA: 0x17575BC Slot: 13
	public override void MGFNKDPHFGI(MonoBehaviour DANMJLOBLIE)
    {
        EDOHBJAPLPF_JsonData json = IKPIMINCOPI_JsonMapper.PFAMKCGJKKL_ToObject(NGCAIEGPLKD_result);
        NFEAMMJIMPG = new HEHLBMMFMPL();
        NFEAMMJIMPG.KHEKNNFCAOI(json);
    }
}

public class HEHLBMMFMPL
{
	public int EKFHOJIGHHH_IsCreated; // 0x8
	public int EHGBICNIBKE_PlayerId; // 0xC
	public int JFMEKPDHJPP_PlayerAccountStatus; // 0x10

	// public bool NNJKNHKFPBB { get; }

	// RVA: 0x1748038 Offset: 0x1748038 VA: 0x1748038
	public bool OGADPAILFBC()
    {
        return EKFHOJIGHHH_IsCreated == 1;
    }

	// // RVA: 0x1748048 Offset: 0x1748048 VA: 0x1748048
	public void KHEKNNFCAOI(EDOHBJAPLPF_JsonData IDLHJIOMJBK)
    {
        EKFHOJIGHHH_IsCreated = 1;
        if(IDLHJIOMJBK.BBAJPINMOEP_Contains(AFEHLCGHAEE_Strings.EKFHOJIGHHH_is_created/*"is_created"*/))
        {
            EKFHOJIGHHH_IsCreated = (int)IDLHJIOMJBK[AFEHLCGHAEE_Strings.EKFHOJIGHHH_is_created];
        }
        EHGBICNIBKE_PlayerId = 0;
        if(IDLHJIOMJBK.BBAJPINMOEP_Contains(AFEHLCGHAEE_Strings.EHGBICNIBKE_player_id/*"player_id"*/))
        {
            EHGBICNIBKE_PlayerId = (int)IDLHJIOMJBK[AFEHLCGHAEE_Strings.EHGBICNIBKE_player_id];
        }
        JFMEKPDHJPP_PlayerAccountStatus = 0;
        if(IDLHJIOMJBK.BBAJPINMOEP_Contains(AFEHLCGHAEE_Strings.JFMEKPDHJPP_player_account_status/*"player_account_status"*/))
        {
            JFMEKPDHJPP_PlayerAccountStatus = (int)IDLHJIOMJBK[AFEHLCGHAEE_Strings.JFMEKPDHJPP_player_account_status];
        }
    }
}