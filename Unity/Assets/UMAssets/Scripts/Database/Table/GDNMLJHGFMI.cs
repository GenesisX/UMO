// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class GDNMLJHGFMI : Table {
  public static GDNMLJHGFMI GetRootAsGDNMLJHGFMI(ByteBuffer _bb) { return GetRootAsGDNMLJHGFMI(_bb, new GDNMLJHGFMI()); }
  public static GDNMLJHGFMI GetRootAsGDNMLJHGFMI(ByteBuffer _bb, GDNMLJHGFMI obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public GDNMLJHGFMI __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint KJFEBMBHKOC { get { int o = __offset(6); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }

  public static Offset<GDNMLJHGFMI> CreateGDNMLJHGFMI(FlatBufferBuilder builder,
      uint BBPHAPFBFHK = 0,
      uint KJFEBMBHKOC = 0) {
    builder.StartObject(2);
    GDNMLJHGFMI.AddKJFEBMBHKOC(builder, KJFEBMBHKOC);
    GDNMLJHGFMI.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return GDNMLJHGFMI.EndGDNMLJHGFMI(builder);
  }

  public static void StartGDNMLJHGFMI(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, uint BBPHAPFBFHK) { builder.AddUint(0, BBPHAPFBFHK, 0); }
  public static void AddKJFEBMBHKOC(FlatBufferBuilder builder, uint KJFEBMBHKOC) { builder.AddUint(1, KJFEBMBHKOC, 0); }
  public static Offset<GDNMLJHGFMI> EndGDNMLJHGFMI(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<GDNMLJHGFMI>(o);
  }
};

