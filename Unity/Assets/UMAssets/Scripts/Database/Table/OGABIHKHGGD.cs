// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class OGABIHKHGGD : Table {
  public static OGABIHKHGGD GetRootAsOGABIHKHGGD(ByteBuffer _bb) { return GetRootAsOGABIHKHGGD(_bb, new OGABIHKHGGD()); }
  public static OGABIHKHGGD GetRootAsOGABIHKHGGD(ByteBuffer _bb, OGABIHKHGGD obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public OGABIHKHGGD __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public HLGKEMBLPMP OPBPOOKODJK { get { return GetOPBPOOKODJK(new HLGKEMBLPMP()); } }
  public HLGKEMBLPMP GetOPBPOOKODJK(HLGKEMBLPMP obj) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(o + bb_pos), bb) : null; }
  public CLBPBGIPFPP GetAJMKEFMPKHB(int j) { return GetAJMKEFMPKHB(new CLBPBGIPFPP(), j); }
  public CLBPBGIPFPP GetAJMKEFMPKHB(CLBPBGIPFPP obj, int j) { int o = __offset(6); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int AJMKEFMPKHBLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public LKEFGGDDBJK GetOIJINAJFMCB(int j) { return GetOIJINAJFMCB(new LKEFGGDDBJK(), j); }
  public LKEFGGDDBJK GetOIJINAJFMCB(LKEFGGDDBJK obj, int j) { int o = __offset(8); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int OIJINAJFMCBLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public JACLMHBOGIE GetNJJINHMIOHN(int j) { return GetNJJINHMIOHN(new JACLMHBOGIE(), j); }
  public JACLMHBOGIE GetNJJINHMIOHN(JACLMHBOGIE obj, int j) { int o = __offset(10); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int NJJINHMIOHNLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public OJFDBJJIMMA GetNPFBHGKLIOM(int j) { return GetNPFBHGKLIOM(new OJFDBJJIMMA(), j); }
  public OJFDBJJIMMA GetNPFBHGKLIOM(OJFDBJJIMMA obj, int j) { int o = __offset(12); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int NPFBHGKLIOMLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public OHMMAIEEGMO GetFBAHAFKCMMH(int j) { return GetFBAHAFKCMMH(new OHMMAIEEGMO(), j); }
  public OHMMAIEEGMO GetFBAHAFKCMMH(OHMMAIEEGMO obj, int j) { int o = __offset(14); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int FBAHAFKCMMHLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<OGABIHKHGGD> CreateOGABIHKHGGD(FlatBufferBuilder builder,
      Offset<HLGKEMBLPMP> OPBPOOKODJKOffset = default(Offset<HLGKEMBLPMP>),
      VectorOffset AJMKEFMPKHBOffset = default(VectorOffset),
      VectorOffset OIJINAJFMCBOffset = default(VectorOffset),
      VectorOffset NJJINHMIOHNOffset = default(VectorOffset),
      VectorOffset NPFBHGKLIOMOffset = default(VectorOffset),
      VectorOffset FBAHAFKCMMHOffset = default(VectorOffset)) {
    builder.StartObject(6);
    OGABIHKHGGD.AddFBAHAFKCMMH(builder, FBAHAFKCMMHOffset);
    OGABIHKHGGD.AddNPFBHGKLIOM(builder, NPFBHGKLIOMOffset);
    OGABIHKHGGD.AddNJJINHMIOHN(builder, NJJINHMIOHNOffset);
    OGABIHKHGGD.AddOIJINAJFMCB(builder, OIJINAJFMCBOffset);
    OGABIHKHGGD.AddAJMKEFMPKHB(builder, AJMKEFMPKHBOffset);
    OGABIHKHGGD.AddOPBPOOKODJK(builder, OPBPOOKODJKOffset);
    return OGABIHKHGGD.EndOGABIHKHGGD(builder);
  }

  public static void StartOGABIHKHGGD(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddOPBPOOKODJK(FlatBufferBuilder builder, Offset<HLGKEMBLPMP> OPBPOOKODJKOffset) { builder.AddOffset(0, OPBPOOKODJKOffset.Value, 0); }
  public static void AddAJMKEFMPKHB(FlatBufferBuilder builder, VectorOffset AJMKEFMPKHBOffset) { builder.AddOffset(1, AJMKEFMPKHBOffset.Value, 0); }
  public static VectorOffset CreateAJMKEFMPKHBVector(FlatBufferBuilder builder, Offset<CLBPBGIPFPP>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartAJMKEFMPKHBVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddOIJINAJFMCB(FlatBufferBuilder builder, VectorOffset OIJINAJFMCBOffset) { builder.AddOffset(2, OIJINAJFMCBOffset.Value, 0); }
  public static VectorOffset CreateOIJINAJFMCBVector(FlatBufferBuilder builder, Offset<LKEFGGDDBJK>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartOIJINAJFMCBVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNJJINHMIOHN(FlatBufferBuilder builder, VectorOffset NJJINHMIOHNOffset) { builder.AddOffset(3, NJJINHMIOHNOffset.Value, 0); }
  public static VectorOffset CreateNJJINHMIOHNVector(FlatBufferBuilder builder, Offset<JACLMHBOGIE>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartNJJINHMIOHNVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNPFBHGKLIOM(FlatBufferBuilder builder, VectorOffset NPFBHGKLIOMOffset) { builder.AddOffset(4, NPFBHGKLIOMOffset.Value, 0); }
  public static VectorOffset CreateNPFBHGKLIOMVector(FlatBufferBuilder builder, Offset<OJFDBJJIMMA>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartNPFBHGKLIOMVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFBAHAFKCMMH(FlatBufferBuilder builder, VectorOffset FBAHAFKCMMHOffset) { builder.AddOffset(5, FBAHAFKCMMHOffset.Value, 0); }
  public static VectorOffset CreateFBAHAFKCMMHVector(FlatBufferBuilder builder, Offset<OHMMAIEEGMO>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartFBAHAFKCMMHVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<OGABIHKHGGD> EndOGABIHKHGGD(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<OGABIHKHGGD>(o);
  }
};
