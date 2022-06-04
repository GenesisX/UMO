// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class GAJADNFKMEE : Table {
  public static GAJADNFKMEE GetRootAsGAJADNFKMEE(ByteBuffer _bb) { return GetRootAsGAJADNFKMEE(_bb, new GAJADNFKMEE()); }
  public static GAJADNFKMEE GetRootAsGAJADNFKMEE(ByteBuffer _bb, GAJADNFKMEE obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public GAJADNFKMEE __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint KMBNCDICCAJ { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint LMKLPPINLOK { get { int o = __offset(6); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint GetLGJDLFJCCLK(int j) { int o = __offset(8); return o != 0 ? bb.GetUint(__vector(o) + j * 4) : (uint)0; }
  public int LGJDLFJCCLKLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetLGJDLFJCCLKBytes() { return __vector_as_arraysegment(8); }
  public uint LIGDKLEFBNM { get { int o = __offset(10); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint GetBMICKLAGCCD(int j) { int o = __offset(12); return o != 0 ? bb.GetUint(__vector(o) + j * 4) : (uint)0; }
  public int BMICKLAGCCDLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetBMICKLAGCCDBytes() { return __vector_as_arraysegment(12); }
  public uint DGMDFCHIBKD { get { int o = __offset(14); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint GetDINDMDCKMCP(int j) { int o = __offset(16); return o != 0 ? bb.GetUint(__vector(o) + j * 4) : (uint)0; }
  public int DINDMDCKMCPLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetDINDMDCKMCPBytes() { return __vector_as_arraysegment(16); }
  public uint EJNIJBKBNGE { get { int o = __offset(18); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint GetEBDOOBOFLFM(int j) { int o = __offset(20); return o != 0 ? bb.GetUint(__vector(o) + j * 4) : (uint)0; }
  public int EBDOOBOFLFMLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetEBDOOBOFLFMBytes() { return __vector_as_arraysegment(20); }
  public uint FLNOLLMJOKE { get { int o = __offset(22); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint KHLNIPBFCNK { get { int o = __offset(24); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint EOHDEKFEONI { get { int o = __offset(26); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint FHKGIFCFEPI { get { int o = __offset(28); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint DMEMJNAEDHP { get { int o = __offset(30); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint JKKAICPJBOK { get { int o = __offset(32); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }

  public static Offset<GAJADNFKMEE> CreateGAJADNFKMEE(FlatBufferBuilder builder,
      uint KMBNCDICCAJ = 0,
      uint LMKLPPINLOK = 0,
      VectorOffset LGJDLFJCCLKOffset = default(VectorOffset),
      uint LIGDKLEFBNM = 0,
      VectorOffset BMICKLAGCCDOffset = default(VectorOffset),
      uint DGMDFCHIBKD = 0,
      VectorOffset DINDMDCKMCPOffset = default(VectorOffset),
      uint EJNIJBKBNGE = 0,
      VectorOffset EBDOOBOFLFMOffset = default(VectorOffset),
      uint FLNOLLMJOKE = 0,
      uint KHLNIPBFCNK = 0,
      uint EOHDEKFEONI = 0,
      uint FHKGIFCFEPI = 0,
      uint DMEMJNAEDHP = 0,
      uint JKKAICPJBOK = 0) {
    builder.StartObject(15);
    GAJADNFKMEE.AddJKKAICPJBOK(builder, JKKAICPJBOK);
    GAJADNFKMEE.AddDMEMJNAEDHP(builder, DMEMJNAEDHP);
    GAJADNFKMEE.AddFHKGIFCFEPI(builder, FHKGIFCFEPI);
    GAJADNFKMEE.AddEOHDEKFEONI(builder, EOHDEKFEONI);
    GAJADNFKMEE.AddKHLNIPBFCNK(builder, KHLNIPBFCNK);
    GAJADNFKMEE.AddFLNOLLMJOKE(builder, FLNOLLMJOKE);
    GAJADNFKMEE.AddEBDOOBOFLFM(builder, EBDOOBOFLFMOffset);
    GAJADNFKMEE.AddEJNIJBKBNGE(builder, EJNIJBKBNGE);
    GAJADNFKMEE.AddDINDMDCKMCP(builder, DINDMDCKMCPOffset);
    GAJADNFKMEE.AddDGMDFCHIBKD(builder, DGMDFCHIBKD);
    GAJADNFKMEE.AddBMICKLAGCCD(builder, BMICKLAGCCDOffset);
    GAJADNFKMEE.AddLIGDKLEFBNM(builder, LIGDKLEFBNM);
    GAJADNFKMEE.AddLGJDLFJCCLK(builder, LGJDLFJCCLKOffset);
    GAJADNFKMEE.AddLMKLPPINLOK(builder, LMKLPPINLOK);
    GAJADNFKMEE.AddKMBNCDICCAJ(builder, KMBNCDICCAJ);
    return GAJADNFKMEE.EndGAJADNFKMEE(builder);
  }

  public static void StartGAJADNFKMEE(FlatBufferBuilder builder) { builder.StartObject(15); }
  public static void AddKMBNCDICCAJ(FlatBufferBuilder builder, uint KMBNCDICCAJ) { builder.AddUint(0, KMBNCDICCAJ, 0); }
  public static void AddLMKLPPINLOK(FlatBufferBuilder builder, uint LMKLPPINLOK) { builder.AddUint(1, LMKLPPINLOK, 0); }
  public static void AddLGJDLFJCCLK(FlatBufferBuilder builder, VectorOffset LGJDLFJCCLKOffset) { builder.AddOffset(2, LGJDLFJCCLKOffset.Value, 0); }
  public static VectorOffset CreateLGJDLFJCCLKVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static void StartLGJDLFJCCLKVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLIGDKLEFBNM(FlatBufferBuilder builder, uint LIGDKLEFBNM) { builder.AddUint(3, LIGDKLEFBNM, 0); }
  public static void AddBMICKLAGCCD(FlatBufferBuilder builder, VectorOffset BMICKLAGCCDOffset) { builder.AddOffset(4, BMICKLAGCCDOffset.Value, 0); }
  public static VectorOffset CreateBMICKLAGCCDVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static void StartBMICKLAGCCDVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDGMDFCHIBKD(FlatBufferBuilder builder, uint DGMDFCHIBKD) { builder.AddUint(5, DGMDFCHIBKD, 0); }
  public static void AddDINDMDCKMCP(FlatBufferBuilder builder, VectorOffset DINDMDCKMCPOffset) { builder.AddOffset(6, DINDMDCKMCPOffset.Value, 0); }
  public static VectorOffset CreateDINDMDCKMCPVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static void StartDINDMDCKMCPVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEJNIJBKBNGE(FlatBufferBuilder builder, uint EJNIJBKBNGE) { builder.AddUint(7, EJNIJBKBNGE, 0); }
  public static void AddEBDOOBOFLFM(FlatBufferBuilder builder, VectorOffset EBDOOBOFLFMOffset) { builder.AddOffset(8, EBDOOBOFLFMOffset.Value, 0); }
  public static VectorOffset CreateEBDOOBOFLFMVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static void StartEBDOOBOFLFMVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFLNOLLMJOKE(FlatBufferBuilder builder, uint FLNOLLMJOKE) { builder.AddUint(9, FLNOLLMJOKE, 0); }
  public static void AddKHLNIPBFCNK(FlatBufferBuilder builder, uint KHLNIPBFCNK) { builder.AddUint(10, KHLNIPBFCNK, 0); }
  public static void AddEOHDEKFEONI(FlatBufferBuilder builder, uint EOHDEKFEONI) { builder.AddUint(11, EOHDEKFEONI, 0); }
  public static void AddFHKGIFCFEPI(FlatBufferBuilder builder, uint FHKGIFCFEPI) { builder.AddUint(12, FHKGIFCFEPI, 0); }
  public static void AddDMEMJNAEDHP(FlatBufferBuilder builder, uint DMEMJNAEDHP) { builder.AddUint(13, DMEMJNAEDHP, 0); }
  public static void AddJKKAICPJBOK(FlatBufferBuilder builder, uint JKKAICPJBOK) { builder.AddUint(14, JKKAICPJBOK, 0); }
  public static Offset<GAJADNFKMEE> EndGAJADNFKMEE(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<GAJADNFKMEE>(o);
  }
};
