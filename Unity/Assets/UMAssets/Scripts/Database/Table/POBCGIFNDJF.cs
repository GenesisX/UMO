// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class POBCGIFNDJF : Table {
  public static POBCGIFNDJF GetRootAsPOBCGIFNDJF(ByteBuffer _bb) { return GetRootAsPOBCGIFNDJF(_bb, new POBCGIFNDJF()); }
  public static POBCGIFNDJF GetRootAsPOBCGIFNDJF(ByteBuffer _bb, POBCGIFNDJF obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public POBCGIFNDJF __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CFLMCGOJJJD { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GLIIHLOLPEF { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int BNDAHALMIPE { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string CNNEAFFOPAO { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetCNNEAFFOPAOBytes() { return __vector_as_arraysegment(12); }
  public string ONBMIJLCFBD { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetONBMIJLCFBDBytes() { return __vector_as_arraysegment(14); }
  public string NNNCOKLKPIH { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetNNNCOKLKPIHBytes() { return __vector_as_arraysegment(16); }

  public static Offset<POBCGIFNDJF> CreatePOBCGIFNDJF(FlatBufferBuilder builder,
      int BBPHAPFBFHK = 0,
      int CFLMCGOJJJD = 0,
      int GLIIHLOLPEF = 0,
      int BNDAHALMIPE = 0,
      StringOffset CNNEAFFOPAOOffset = default(StringOffset),
      StringOffset ONBMIJLCFBDOffset = default(StringOffset),
      StringOffset NNNCOKLKPIHOffset = default(StringOffset)) {
    builder.StartObject(7);
    POBCGIFNDJF.AddNNNCOKLKPIH(builder, NNNCOKLKPIHOffset);
    POBCGIFNDJF.AddONBMIJLCFBD(builder, ONBMIJLCFBDOffset);
    POBCGIFNDJF.AddCNNEAFFOPAO(builder, CNNEAFFOPAOOffset);
    POBCGIFNDJF.AddBNDAHALMIPE(builder, BNDAHALMIPE);
    POBCGIFNDJF.AddGLIIHLOLPEF(builder, GLIIHLOLPEF);
    POBCGIFNDJF.AddCFLMCGOJJJD(builder, CFLMCGOJJJD);
    POBCGIFNDJF.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return POBCGIFNDJF.EndPOBCGIFNDJF(builder);
  }

  public static void StartPOBCGIFNDJF(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, int BBPHAPFBFHK) { builder.AddInt(0, BBPHAPFBFHK, 0); }
  public static void AddCFLMCGOJJJD(FlatBufferBuilder builder, int CFLMCGOJJJD) { builder.AddInt(1, CFLMCGOJJJD, 0); }
  public static void AddGLIIHLOLPEF(FlatBufferBuilder builder, int GLIIHLOLPEF) { builder.AddInt(2, GLIIHLOLPEF, 0); }
  public static void AddBNDAHALMIPE(FlatBufferBuilder builder, int BNDAHALMIPE) { builder.AddInt(3, BNDAHALMIPE, 0); }
  public static void AddCNNEAFFOPAO(FlatBufferBuilder builder, StringOffset CNNEAFFOPAOOffset) { builder.AddOffset(4, CNNEAFFOPAOOffset.Value, 0); }
  public static void AddONBMIJLCFBD(FlatBufferBuilder builder, StringOffset ONBMIJLCFBDOffset) { builder.AddOffset(5, ONBMIJLCFBDOffset.Value, 0); }
  public static void AddNNNCOKLKPIH(FlatBufferBuilder builder, StringOffset NNNCOKLKPIHOffset) { builder.AddOffset(6, NNNCOKLKPIHOffset.Value, 0); }
  public static Offset<POBCGIFNDJF> EndPOBCGIFNDJF(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<POBCGIFNDJF>(o);
  }
};
