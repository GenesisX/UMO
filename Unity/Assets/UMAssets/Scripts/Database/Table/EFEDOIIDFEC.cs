// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class EFEDOIIDFEC : Table {
  public static EFEDOIIDFEC GetRootAsEFEDOIIDFEC(ByteBuffer _bb) { return GetRootAsEFEDOIIDFEC(_bb, new EFEDOIIDFEC()); }
  public static EFEDOIIDFEC GetRootAsEFEDOIIDFEC(ByteBuffer _bb, EFEDOIIDFEC obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public EFEDOIIDFEC __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public string AGOIMGHMGOH { get { int o = __offset(4); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetAGOIMGHMGOHBytes() { return __vector_as_arraysegment(4); }
  public string KJFEBMBHKOC { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetKJFEBMBHKOCBytes() { return __vector_as_arraysegment(6); }

  public static Offset<EFEDOIIDFEC> CreateEFEDOIIDFEC(FlatBufferBuilder builder,
      StringOffset AGOIMGHMGOHOffset = default(StringOffset),
      StringOffset KJFEBMBHKOCOffset = default(StringOffset)) {
    builder.StartObject(2);
    EFEDOIIDFEC.AddKJFEBMBHKOC(builder, KJFEBMBHKOCOffset);
    EFEDOIIDFEC.AddAGOIMGHMGOH(builder, AGOIMGHMGOHOffset);
    return EFEDOIIDFEC.EndEFEDOIIDFEC(builder);
  }

  public static void StartEFEDOIIDFEC(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddAGOIMGHMGOH(FlatBufferBuilder builder, StringOffset AGOIMGHMGOHOffset) { builder.AddOffset(0, AGOIMGHMGOHOffset.Value, 0); }
  public static void AddKJFEBMBHKOC(FlatBufferBuilder builder, StringOffset KJFEBMBHKOCOffset) { builder.AddOffset(1, KJFEBMBHKOCOffset.Value, 0); }
  public static Offset<EFEDOIIDFEC> EndEFEDOIIDFEC(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<EFEDOIIDFEC>(o);
  }
};
