// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class JAFMFLPLHEB : Table {
  public static JAFMFLPLHEB GetRootAsJAFMFLPLHEB(ByteBuffer _bb) { return GetRootAsJAFMFLPLHEB(_bb, new JAFMFLPLHEB()); }
  public static JAFMFLPLHEB GetRootAsJAFMFLPLHEB(ByteBuffer _bb, JAFMFLPLHEB obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public JAFMFLPLHEB __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public BNKFBEGNEHA GetNBIPMJGGIMM(int j) { return GetNBIPMJGGIMM(new BNKFBEGNEHA(), j); }
  public BNKFBEGNEHA GetNBIPMJGGIMM(BNKFBEGNEHA obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int NBIPMJGGIMMLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }
  public HHJALCFAKEC GetDGEFKIIOAIP(int j) { return GetDGEFKIIOAIP(new HHJALCFAKEC(), j); }
  public HHJALCFAKEC GetDGEFKIIOAIP(HHJALCFAKEC obj, int j) { int o = __offset(6); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int DGEFKIIOAIPLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<JAFMFLPLHEB> CreateJAFMFLPLHEB(FlatBufferBuilder builder,
      VectorOffset NBIPMJGGIMMOffset = default(VectorOffset),
      VectorOffset DGEFKIIOAIPOffset = default(VectorOffset)) {
    builder.StartObject(2);
    JAFMFLPLHEB.AddDGEFKIIOAIP(builder, DGEFKIIOAIPOffset);
    JAFMFLPLHEB.AddNBIPMJGGIMM(builder, NBIPMJGGIMMOffset);
    return JAFMFLPLHEB.EndJAFMFLPLHEB(builder);
  }

  public static void StartJAFMFLPLHEB(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddNBIPMJGGIMM(FlatBufferBuilder builder, VectorOffset NBIPMJGGIMMOffset) { builder.AddOffset(0, NBIPMJGGIMMOffset.Value, 0); }
  public static VectorOffset CreateNBIPMJGGIMMVector(FlatBufferBuilder builder, Offset<BNKFBEGNEHA>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartNBIPMJGGIMMVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDGEFKIIOAIP(FlatBufferBuilder builder, VectorOffset DGEFKIIOAIPOffset) { builder.AddOffset(1, DGEFKIIOAIPOffset.Value, 0); }
  public static VectorOffset CreateDGEFKIIOAIPVector(FlatBufferBuilder builder, Offset<HHJALCFAKEC>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartDGEFKIIOAIPVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<JAFMFLPLHEB> EndJAFMFLPLHEB(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<JAFMFLPLHEB>(o);
  }
};
