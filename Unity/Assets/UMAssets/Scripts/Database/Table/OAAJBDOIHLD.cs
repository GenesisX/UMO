// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class OAAJBDOIHLD : Table {
  public static OAAJBDOIHLD GetRootAsOAAJBDOIHLD(ByteBuffer _bb) { return GetRootAsOAAJBDOIHLD(_bb, new OAAJBDOIHLD()); }
  public static OAAJBDOIHLD GetRootAsOAAJBDOIHLD(ByteBuffer _bb, OAAJBDOIHLD obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public OAAJBDOIHLD __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public int GetLEFPIGNDJNC(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LEFPIGNDJNCLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetLEFPIGNDJNCBytes() { return __vector_as_arraysegment(6); }
  public uint GetBNCIPLKECMC(int j) { int o = __offset(8); return o != 0 ? bb.GetUint(__vector(o) + j * 4) : (uint)0; }
  public int BNCIPLKECMCLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetBNCIPLKECMCBytes() { return __vector_as_arraysegment(8); }
  public int CDNLIGMMGBA { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<OAAJBDOIHLD> CreateOAAJBDOIHLD(FlatBufferBuilder builder,
      uint BBPHAPFBFHK = 0,
      VectorOffset LEFPIGNDJNCOffset = default(VectorOffset),
      VectorOffset BNCIPLKECMCOffset = default(VectorOffset),
      int CDNLIGMMGBA = 0) {
    builder.StartObject(4);
    OAAJBDOIHLD.AddCDNLIGMMGBA(builder, CDNLIGMMGBA);
    OAAJBDOIHLD.AddBNCIPLKECMC(builder, BNCIPLKECMCOffset);
    OAAJBDOIHLD.AddLEFPIGNDJNC(builder, LEFPIGNDJNCOffset);
    OAAJBDOIHLD.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return OAAJBDOIHLD.EndOAAJBDOIHLD(builder);
  }

  public static void StartOAAJBDOIHLD(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, uint BBPHAPFBFHK) { builder.AddUint(0, BBPHAPFBFHK, 0); }
  public static void AddLEFPIGNDJNC(FlatBufferBuilder builder, VectorOffset LEFPIGNDJNCOffset) { builder.AddOffset(1, LEFPIGNDJNCOffset.Value, 0); }
  public static VectorOffset CreateLEFPIGNDJNCVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLEFPIGNDJNCVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBNCIPLKECMC(FlatBufferBuilder builder, VectorOffset BNCIPLKECMCOffset) { builder.AddOffset(2, BNCIPLKECMCOffset.Value, 0); }
  public static VectorOffset CreateBNCIPLKECMCVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static void StartBNCIPLKECMCVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCDNLIGMMGBA(FlatBufferBuilder builder, int CDNLIGMMGBA) { builder.AddInt(3, CDNLIGMMGBA, 0); }
  public static Offset<OAAJBDOIHLD> EndOAAJBDOIHLD(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<OAAJBDOIHLD>(o);
  }
};
