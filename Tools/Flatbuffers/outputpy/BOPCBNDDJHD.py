# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class BOPCBNDDJHD(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsBOPCBNDDJHD(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = BOPCBNDDJHD()
        x.Init(buf, n + offset)
        return x

    # BOPCBNDDJHD
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # BOPCBNDDJHD
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # BOPCBNDDJHD
    def AGOIMGHMGOH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

    # BOPCBNDDJHD
    def JPLNJKHPFCI(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # BOPCBNDDJHD
    def HFEOJGNPDHI(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # BOPCBNDDJHD
    def EBONAKOCJCL(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # BOPCBNDDJHD
    def PJKMNDDCKIJ(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(14))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # BOPCBNDDJHD
    def EHIBOEAILLI(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(16))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # BOPCBNDDJHD
    def HCMOJIDKHHA(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(18))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # BOPCBNDDJHD
    def LFFMNLEJJMH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(20))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

def BOPCBNDDJHDStart(builder): builder.StartObject(9)
def BOPCBNDDJHDAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependUint32Slot(0, BBPHAPFBFHK, 0)
def BOPCBNDDJHDAddAGOIMGHMGOH(builder, AGOIMGHMGOH): builder.PrependUOffsetTRelativeSlot(1, flatbuffers.number_types.UOffsetTFlags.py_type(AGOIMGHMGOH), 0)
def BOPCBNDDJHDAddJPLNJKHPFCI(builder, JPLNJKHPFCI): builder.PrependInt32Slot(2, JPLNJKHPFCI, 0)
def BOPCBNDDJHDAddHFEOJGNPDHI(builder, HFEOJGNPDHI): builder.PrependInt32Slot(3, HFEOJGNPDHI, 0)
def BOPCBNDDJHDAddEBONAKOCJCL(builder, EBONAKOCJCL): builder.PrependInt32Slot(4, EBONAKOCJCL, 0)
def BOPCBNDDJHDAddPJKMNDDCKIJ(builder, PJKMNDDCKIJ): builder.PrependUint32Slot(5, PJKMNDDCKIJ, 0)
def BOPCBNDDJHDAddEHIBOEAILLI(builder, EHIBOEAILLI): builder.PrependUint32Slot(6, EHIBOEAILLI, 0)
def BOPCBNDDJHDAddHCMOJIDKHHA(builder, HCMOJIDKHHA): builder.PrependUint32Slot(7, HCMOJIDKHHA, 0)
def BOPCBNDDJHDAddLFFMNLEJJMH(builder, LFFMNLEJJMH): builder.PrependUint32Slot(8, LFFMNLEJJMH, 0)
def BOPCBNDDJHDEnd(builder): return builder.EndObject()