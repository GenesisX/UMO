# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class KAKPINDJHMG(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsKAKPINDJHMG(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = KAKPINDJHMG()
        x.Init(buf, n + offset)
        return x

    # KAKPINDJHMG
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # KAKPINDJHMG
    def NMEEJNHKPCN(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # KAKPINDJHMG
    def NMEEJNHKPCNLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # KAKPINDJHMG
    def CNOKDINCFAO(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # KAKPINDJHMG
    def NGGAJCBPGFI(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # KAKPINDJHMG
    def NGGAJCBPGFILength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

def KAKPINDJHMGStart(builder): builder.StartObject(3)
def KAKPINDJHMGAddNMEEJNHKPCN(builder, NMEEJNHKPCN): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(NMEEJNHKPCN), 0)
def KAKPINDJHMGStartNMEEJNHKPCNVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def KAKPINDJHMGAddCNOKDINCFAO(builder, CNOKDINCFAO): builder.PrependUint32Slot(1, CNOKDINCFAO, 0)
def KAKPINDJHMGAddNGGAJCBPGFI(builder, NGGAJCBPGFI): builder.PrependUOffsetTRelativeSlot(2, flatbuffers.number_types.UOffsetTFlags.py_type(NGGAJCBPGFI), 0)
def KAKPINDJHMGStartNGGAJCBPGFIVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def KAKPINDJHMGEnd(builder): return builder.EndObject()