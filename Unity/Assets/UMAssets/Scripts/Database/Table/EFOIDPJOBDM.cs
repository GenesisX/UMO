// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class EFOIDPJOBDM : Table {
  public static EFOIDPJOBDM GetRootAsEFOIDPJOBDM(ByteBuffer _bb) { return GetRootAsEFOIDPJOBDM(_bb, new EFOIDPJOBDM()); }
  public static EFOIDPJOBDM GetRootAsEFOIDPJOBDM(ByteBuffer _bb, EFOIDPJOBDM obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public EFOIDPJOBDM __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int OFMGALJGDAO { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CFLMCGOJJJD { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int HBHEHJDPEBI { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int KJFEBMBHKOC { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GEJGMBBCFEE { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AEAKMMJLLDK { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public uint ODBPKGJPLMD { get { int o = __offset(18); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }

  public static Offset<EFOIDPJOBDM> CreateEFOIDPJOBDM(FlatBufferBuilder builder,
      int BBPHAPFBFHK = 0,
      int OFMGALJGDAO = 0,
      int CFLMCGOJJJD = 0,
      int HBHEHJDPEBI = 0,
      int KJFEBMBHKOC = 0,
      int GEJGMBBCFEE = 0,
      int AEAKMMJLLDK = 0,
      uint ODBPKGJPLMD = 0) {
    builder.StartObject(8);
    EFOIDPJOBDM.AddODBPKGJPLMD(builder, ODBPKGJPLMD);
    EFOIDPJOBDM.AddAEAKMMJLLDK(builder, AEAKMMJLLDK);
    EFOIDPJOBDM.AddGEJGMBBCFEE(builder, GEJGMBBCFEE);
    EFOIDPJOBDM.AddKJFEBMBHKOC(builder, KJFEBMBHKOC);
    EFOIDPJOBDM.AddHBHEHJDPEBI(builder, HBHEHJDPEBI);
    EFOIDPJOBDM.AddCFLMCGOJJJD(builder, CFLMCGOJJJD);
    EFOIDPJOBDM.AddOFMGALJGDAO(builder, OFMGALJGDAO);
    EFOIDPJOBDM.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return EFOIDPJOBDM.EndEFOIDPJOBDM(builder);
  }

  public static void StartEFOIDPJOBDM(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, int BBPHAPFBFHK) { builder.AddInt(0, BBPHAPFBFHK, 0); }
  public static void AddOFMGALJGDAO(FlatBufferBuilder builder, int OFMGALJGDAO) { builder.AddInt(1, OFMGALJGDAO, 0); }
  public static void AddCFLMCGOJJJD(FlatBufferBuilder builder, int CFLMCGOJJJD) { builder.AddInt(2, CFLMCGOJJJD, 0); }
  public static void AddHBHEHJDPEBI(FlatBufferBuilder builder, int HBHEHJDPEBI) { builder.AddInt(3, HBHEHJDPEBI, 0); }
  public static void AddKJFEBMBHKOC(FlatBufferBuilder builder, int KJFEBMBHKOC) { builder.AddInt(4, KJFEBMBHKOC, 0); }
  public static void AddGEJGMBBCFEE(FlatBufferBuilder builder, int GEJGMBBCFEE) { builder.AddInt(5, GEJGMBBCFEE, 0); }
  public static void AddAEAKMMJLLDK(FlatBufferBuilder builder, int AEAKMMJLLDK) { builder.AddInt(6, AEAKMMJLLDK, 0); }
  public static void AddODBPKGJPLMD(FlatBufferBuilder builder, uint ODBPKGJPLMD) { builder.AddUint(7, ODBPKGJPLMD, 0); }
  public static Offset<EFOIDPJOBDM> EndEFOIDPJOBDM(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<EFOIDPJOBDM>(o);
  }
};
