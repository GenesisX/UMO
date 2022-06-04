// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class KBACMNEFKPH : Table {
  public static KBACMNEFKPH GetRootAsKBACMNEFKPH(ByteBuffer _bb) { return GetRootAsKBACMNEFKPH(_bb, new KBACMNEFKPH()); }
  public static KBACMNEFKPH GetRootAsKBACMNEFKPH(ByteBuffer _bb, KBACMNEFKPH obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public KBACMNEFKPH __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint CFLMCGOJJJD { get { int o = __offset(6); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint IAPFGOHKAGE { get { int o = __offset(8); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint HBMAMCJNDIH { get { int o = __offset(10); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint PMPNFFNPDPJ { get { int o = __offset(12); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint NJLJEKDBPCH { get { int o = __offset(14); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint MAOAGDBDBIB { get { int o = __offset(16); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }

  public static Offset<KBACMNEFKPH> CreateKBACMNEFKPH(FlatBufferBuilder builder,
      uint BBPHAPFBFHK = 0,
      uint CFLMCGOJJJD = 0,
      uint IAPFGOHKAGE = 0,
      uint HBMAMCJNDIH = 0,
      uint PMPNFFNPDPJ = 0,
      uint NJLJEKDBPCH = 0,
      uint MAOAGDBDBIB = 0) {
    builder.StartObject(7);
    KBACMNEFKPH.AddMAOAGDBDBIB(builder, MAOAGDBDBIB);
    KBACMNEFKPH.AddNJLJEKDBPCH(builder, NJLJEKDBPCH);
    KBACMNEFKPH.AddPMPNFFNPDPJ(builder, PMPNFFNPDPJ);
    KBACMNEFKPH.AddHBMAMCJNDIH(builder, HBMAMCJNDIH);
    KBACMNEFKPH.AddIAPFGOHKAGE(builder, IAPFGOHKAGE);
    KBACMNEFKPH.AddCFLMCGOJJJD(builder, CFLMCGOJJJD);
    KBACMNEFKPH.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return KBACMNEFKPH.EndKBACMNEFKPH(builder);
  }

  public static void StartKBACMNEFKPH(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, uint BBPHAPFBFHK) { builder.AddUint(0, BBPHAPFBFHK, 0); }
  public static void AddCFLMCGOJJJD(FlatBufferBuilder builder, uint CFLMCGOJJJD) { builder.AddUint(1, CFLMCGOJJJD, 0); }
  public static void AddIAPFGOHKAGE(FlatBufferBuilder builder, uint IAPFGOHKAGE) { builder.AddUint(2, IAPFGOHKAGE, 0); }
  public static void AddHBMAMCJNDIH(FlatBufferBuilder builder, uint HBMAMCJNDIH) { builder.AddUint(3, HBMAMCJNDIH, 0); }
  public static void AddPMPNFFNPDPJ(FlatBufferBuilder builder, uint PMPNFFNPDPJ) { builder.AddUint(4, PMPNFFNPDPJ, 0); }
  public static void AddNJLJEKDBPCH(FlatBufferBuilder builder, uint NJLJEKDBPCH) { builder.AddUint(5, NJLJEKDBPCH, 0); }
  public static void AddMAOAGDBDBIB(FlatBufferBuilder builder, uint MAOAGDBDBIB) { builder.AddUint(6, MAOAGDBDBIB, 0); }
  public static Offset<KBACMNEFKPH> EndKBACMNEFKPH(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<KBACMNEFKPH>(o);
  }
};
