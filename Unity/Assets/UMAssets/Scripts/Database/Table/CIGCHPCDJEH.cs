// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class CIGCHPCDJEH : Table {
  public static CIGCHPCDJEH GetRootAsCIGCHPCDJEH(ByteBuffer _bb) { return GetRootAsCIGCHPCDJEH(_bb, new CIGCHPCDJEH()); }
  public static CIGCHPCDJEH GetRootAsCIGCHPCDJEH(ByteBuffer _bb, CIGCHPCDJEH obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public CIGCHPCDJEH __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int OJDNBBILGJC { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetHDHGOLJEKBA(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HDHGOLJEKBALength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetHDHGOLJEKBABytes() { return __vector_as_arraysegment(8); }
  public int GetMBAHAELMJLM(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MBAHAELMJLMLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetMBAHAELMJLMBytes() { return __vector_as_arraysegment(10); }

  public static Offset<CIGCHPCDJEH> CreateCIGCHPCDJEH(FlatBufferBuilder builder,
      int BBPHAPFBFHK = 0,
      int OJDNBBILGJC = 0,
      VectorOffset HDHGOLJEKBAOffset = default(VectorOffset),
      VectorOffset MBAHAELMJLMOffset = default(VectorOffset)) {
    builder.StartObject(4);
    CIGCHPCDJEH.AddMBAHAELMJLM(builder, MBAHAELMJLMOffset);
    CIGCHPCDJEH.AddHDHGOLJEKBA(builder, HDHGOLJEKBAOffset);
    CIGCHPCDJEH.AddOJDNBBILGJC(builder, OJDNBBILGJC);
    CIGCHPCDJEH.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return CIGCHPCDJEH.EndCIGCHPCDJEH(builder);
  }

  public static void StartCIGCHPCDJEH(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, int BBPHAPFBFHK) { builder.AddInt(0, BBPHAPFBFHK, 0); }
  public static void AddOJDNBBILGJC(FlatBufferBuilder builder, int OJDNBBILGJC) { builder.AddInt(1, OJDNBBILGJC, 0); }
  public static void AddHDHGOLJEKBA(FlatBufferBuilder builder, VectorOffset HDHGOLJEKBAOffset) { builder.AddOffset(2, HDHGOLJEKBAOffset.Value, 0); }
  public static VectorOffset CreateHDHGOLJEKBAVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHDHGOLJEKBAVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMBAHAELMJLM(FlatBufferBuilder builder, VectorOffset MBAHAELMJLMOffset) { builder.AddOffset(3, MBAHAELMJLMOffset.Value, 0); }
  public static VectorOffset CreateMBAHAELMJLMVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMBAHAELMJLMVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<CIGCHPCDJEH> EndCIGCHPCDJEH(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<CIGCHPCDJEH>(o);
  }
};
