// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class EDNGOONFHEO : Table {
  public static EDNGOONFHEO GetRootAsEDNGOONFHEO(ByteBuffer _bb) { return GetRootAsEDNGOONFHEO(_bb, new EDNGOONFHEO()); }
  public static EDNGOONFHEO GetRootAsEDNGOONFHEO(ByteBuffer _bb, EDNGOONFHEO obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public EDNGOONFHEO __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public CLPHCGNHCGC OPBPOOKODJK { get { return GetOPBPOOKODJK(new CLPHCGNHCGC()); } }
  public CLPHCGNHCGC GetOPBPOOKODJK(CLPHCGNHCGC obj) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(o + bb_pos), bb) : null; }
  public MBMMPMLDACB GetNJJINHMIOHN(int j) { return GetNJJINHMIOHN(new MBMMPMLDACB(), j); }
  public MBMMPMLDACB GetNJJINHMIOHN(MBMMPMLDACB obj, int j) { int o = __offset(6); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int NJJINHMIOHNLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public CLLJHAIJMHD GetNPFBHGKLIOM(int j) { return GetNPFBHGKLIOM(new CLLJHAIJMHD(), j); }
  public CLLJHAIJMHD GetNPFBHGKLIOM(CLLJHAIJMHD obj, int j) { int o = __offset(8); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int NPFBHGKLIOMLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public IONNGNNIKOG GetHHBHEKNMBHF(int j) { return GetHHBHEKNMBHF(new IONNGNNIKOG(), j); }
  public IONNGNNIKOG GetHHBHEKNMBHF(IONNGNNIKOG obj, int j) { int o = __offset(10); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int HHBHEKNMBHFLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public PAEHJMNAOKB GetAAAINBAEOFD(int j) { return GetAAAINBAEOFD(new PAEHJMNAOKB(), j); }
  public PAEHJMNAOKB GetAAAINBAEOFD(PAEHJMNAOKB obj, int j) { int o = __offset(12); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int AAAINBAEOFDLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<EDNGOONFHEO> CreateEDNGOONFHEO(FlatBufferBuilder builder,
      Offset<CLPHCGNHCGC> OPBPOOKODJKOffset = default(Offset<CLPHCGNHCGC>),
      VectorOffset NJJINHMIOHNOffset = default(VectorOffset),
      VectorOffset NPFBHGKLIOMOffset = default(VectorOffset),
      VectorOffset HHBHEKNMBHFOffset = default(VectorOffset),
      VectorOffset AAAINBAEOFDOffset = default(VectorOffset)) {
    builder.StartObject(5);
    EDNGOONFHEO.AddAAAINBAEOFD(builder, AAAINBAEOFDOffset);
    EDNGOONFHEO.AddHHBHEKNMBHF(builder, HHBHEKNMBHFOffset);
    EDNGOONFHEO.AddNPFBHGKLIOM(builder, NPFBHGKLIOMOffset);
    EDNGOONFHEO.AddNJJINHMIOHN(builder, NJJINHMIOHNOffset);
    EDNGOONFHEO.AddOPBPOOKODJK(builder, OPBPOOKODJKOffset);
    return EDNGOONFHEO.EndEDNGOONFHEO(builder);
  }

  public static void StartEDNGOONFHEO(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddOPBPOOKODJK(FlatBufferBuilder builder, Offset<CLPHCGNHCGC> OPBPOOKODJKOffset) { builder.AddOffset(0, OPBPOOKODJKOffset.Value, 0); }
  public static void AddNJJINHMIOHN(FlatBufferBuilder builder, VectorOffset NJJINHMIOHNOffset) { builder.AddOffset(1, NJJINHMIOHNOffset.Value, 0); }
  public static VectorOffset CreateNJJINHMIOHNVector(FlatBufferBuilder builder, Offset<MBMMPMLDACB>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartNJJINHMIOHNVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNPFBHGKLIOM(FlatBufferBuilder builder, VectorOffset NPFBHGKLIOMOffset) { builder.AddOffset(2, NPFBHGKLIOMOffset.Value, 0); }
  public static VectorOffset CreateNPFBHGKLIOMVector(FlatBufferBuilder builder, Offset<CLLJHAIJMHD>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartNPFBHGKLIOMVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHHBHEKNMBHF(FlatBufferBuilder builder, VectorOffset HHBHEKNMBHFOffset) { builder.AddOffset(3, HHBHEKNMBHFOffset.Value, 0); }
  public static VectorOffset CreateHHBHEKNMBHFVector(FlatBufferBuilder builder, Offset<IONNGNNIKOG>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartHHBHEKNMBHFVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAAAINBAEOFD(FlatBufferBuilder builder, VectorOffset AAAINBAEOFDOffset) { builder.AddOffset(4, AAAINBAEOFDOffset.Value, 0); }
  public static VectorOffset CreateAAAINBAEOFDVector(FlatBufferBuilder builder, Offset<PAEHJMNAOKB>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartAAAINBAEOFDVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<EDNGOONFHEO> EndEDNGOONFHEO(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<EDNGOONFHEO>(o);
  }
};
