# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class NGMAEKGBJCM(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsNGMAEKGBJCM(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = NGMAEKGBJCM()
        x.Init(buf, n + offset)
        return x

    # NGMAEKGBJCM
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # NGMAEKGBJCM
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # NGMAEKGBJCM
    def CFLMCGOJJJD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # NGMAEKGBJCM
    def NMDCNDPDNMM(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # NGMAEKGBJCM
    def NJLJEKDBPCH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # NGMAEKGBJCM
    def MAOAGDBDBIB(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

def NGMAEKGBJCMStart(builder): builder.StartObject(5)
def NGMAEKGBJCMAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependUint32Slot(0, BBPHAPFBFHK, 0)
def NGMAEKGBJCMAddCFLMCGOJJJD(builder, CFLMCGOJJJD): builder.PrependUint32Slot(1, CFLMCGOJJJD, 0)
def NGMAEKGBJCMAddNMDCNDPDNMM(builder, NMDCNDPDNMM): builder.PrependUint32Slot(2, NMDCNDPDNMM, 0)
def NGMAEKGBJCMAddNJLJEKDBPCH(builder, NJLJEKDBPCH): builder.PrependUint32Slot(3, NJLJEKDBPCH, 0)
def NGMAEKGBJCMAddMAOAGDBDBIB(builder, MAOAGDBDBIB): builder.PrependUint32Slot(4, MAOAGDBDBIB, 0)
def NGMAEKGBJCMEnd(builder): return builder.EndObject()
