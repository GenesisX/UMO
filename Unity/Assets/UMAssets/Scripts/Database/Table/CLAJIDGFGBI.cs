// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class CLAJIDGFGBI : Table {
  public static CLAJIDGFGBI GetRootAsCLAJIDGFGBI(ByteBuffer _bb) { return GetRootAsCLAJIDGFGBI(_bb, new CLAJIDGFGBI()); }
  public static CLAJIDGFGBI GetRootAsCLAJIDGFGBI(ByteBuffer _bb, CLAJIDGFGBI obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public CLAJIDGFGBI __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public GIOEHOIPHLK GetKEKBKDMMKGM(int j) { return GetKEKBKDMMKGM(new GIOEHOIPHLK(), j); }
  public GIOEHOIPHLK GetKEKBKDMMKGM(GIOEHOIPHLK obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int KEKBKDMMKGMLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<CLAJIDGFGBI> CreateCLAJIDGFGBI(FlatBufferBuilder builder,
      VectorOffset KEKBKDMMKGMOffset = default(VectorOffset)) {
    builder.StartObject(1);
    CLAJIDGFGBI.AddKEKBKDMMKGM(builder, KEKBKDMMKGMOffset);
    return CLAJIDGFGBI.EndCLAJIDGFGBI(builder);
  }

  public static void StartCLAJIDGFGBI(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddKEKBKDMMKGM(FlatBufferBuilder builder, VectorOffset KEKBKDMMKGMOffset) { builder.AddOffset(0, KEKBKDMMKGMOffset.Value, 0); }
  public static VectorOffset CreateKEKBKDMMKGMVector(FlatBufferBuilder builder, Offset<GIOEHOIPHLK>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartKEKBKDMMKGMVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<CLAJIDGFGBI> EndCLAJIDGFGBI(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<CLAJIDGFGBI>(o);
  }
};

