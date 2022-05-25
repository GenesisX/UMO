# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class ECDHHNAFLCJ(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsECDHHNAFLCJ(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = ECDHHNAFLCJ()
        x.Init(buf, n + offset)
        return x

    # ECDHHNAFLCJ
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # ECDHHNAFLCJ
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # ECDHHNAFLCJ
    def CFLMCGOJJJD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # ECDHHNAFLCJ
    def NNCHHHGHAKJ(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # ECDHHNAFLCJ
    def NNCHHHGHAKJLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # ECDHHNAFLCJ
    def NJLJEKDBPCH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # ECDHHNAFLCJ
    def MAOAGDBDBIB(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

def ECDHHNAFLCJStart(builder): builder.StartObject(5)
def ECDHHNAFLCJAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependUint32Slot(0, BBPHAPFBFHK, 0)
def ECDHHNAFLCJAddCFLMCGOJJJD(builder, CFLMCGOJJJD): builder.PrependUint32Slot(1, CFLMCGOJJJD, 0)
def ECDHHNAFLCJAddNNCHHHGHAKJ(builder, NNCHHHGHAKJ): builder.PrependUOffsetTRelativeSlot(2, flatbuffers.number_types.UOffsetTFlags.py_type(NNCHHHGHAKJ), 0)
def ECDHHNAFLCJStartNNCHHHGHAKJVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def ECDHHNAFLCJAddNJLJEKDBPCH(builder, NJLJEKDBPCH): builder.PrependUint32Slot(3, NJLJEKDBPCH, 0)
def ECDHHNAFLCJAddMAOAGDBDBIB(builder, MAOAGDBDBIB): builder.PrependUint32Slot(4, MAOAGDBDBIB, 0)
def ECDHHNAFLCJEnd(builder): return builder.EndObject()