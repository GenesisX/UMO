# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class NKMABFBAGCI(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsNKMABFBAGCI(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = NKMABFBAGCI()
        x.Init(buf, n + offset)
        return x

    # NKMABFBAGCI
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # NKMABFBAGCI
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # NKMABFBAGCI
    def LEFPIGNDJNC(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Int32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # NKMABFBAGCI
    def LEFPIGNDJNCLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # NKMABFBAGCI
    def BNCIPLKECMC(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Int32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # NKMABFBAGCI
    def BNCIPLKECMCLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # NKMABFBAGCI
    def NGGAJCBPGFI(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Int32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # NKMABFBAGCI
    def NGGAJCBPGFILength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # NKMABFBAGCI
    def NMEEJNHKPCN(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Int32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # NKMABFBAGCI
    def NMEEJNHKPCNLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

def NKMABFBAGCIStart(builder): builder.StartObject(5)
def NKMABFBAGCIAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependInt32Slot(0, BBPHAPFBFHK, 0)
def NKMABFBAGCIAddLEFPIGNDJNC(builder, LEFPIGNDJNC): builder.PrependUOffsetTRelativeSlot(1, flatbuffers.number_types.UOffsetTFlags.py_type(LEFPIGNDJNC), 0)
def NKMABFBAGCIStartLEFPIGNDJNCVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def NKMABFBAGCIAddBNCIPLKECMC(builder, BNCIPLKECMC): builder.PrependUOffsetTRelativeSlot(2, flatbuffers.number_types.UOffsetTFlags.py_type(BNCIPLKECMC), 0)
def NKMABFBAGCIStartBNCIPLKECMCVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def NKMABFBAGCIAddNGGAJCBPGFI(builder, NGGAJCBPGFI): builder.PrependUOffsetTRelativeSlot(3, flatbuffers.number_types.UOffsetTFlags.py_type(NGGAJCBPGFI), 0)
def NKMABFBAGCIStartNGGAJCBPGFIVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def NKMABFBAGCIAddNMEEJNHKPCN(builder, NMEEJNHKPCN): builder.PrependUOffsetTRelativeSlot(4, flatbuffers.number_types.UOffsetTFlags.py_type(NMEEJNHKPCN), 0)
def NKMABFBAGCIStartNMEEJNHKPCNVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def NKMABFBAGCIEnd(builder): return builder.EndObject()
