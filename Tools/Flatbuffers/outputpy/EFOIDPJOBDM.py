# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class EFOIDPJOBDM(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsEFOIDPJOBDM(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = EFOIDPJOBDM()
        x.Init(buf, n + offset)
        return x

    # EFOIDPJOBDM
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # EFOIDPJOBDM
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # EFOIDPJOBDM
    def OFMGALJGDAO(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # EFOIDPJOBDM
    def CFLMCGOJJJD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # EFOIDPJOBDM
    def HBHEHJDPEBI(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # EFOIDPJOBDM
    def KJFEBMBHKOC(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # EFOIDPJOBDM
    def GEJGMBBCFEE(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(14))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # EFOIDPJOBDM
    def AEAKMMJLLDK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(16))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # EFOIDPJOBDM
    def ODBPKGJPLMD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(18))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

def EFOIDPJOBDMStart(builder): builder.StartObject(8)
def EFOIDPJOBDMAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependInt32Slot(0, BBPHAPFBFHK, 0)
def EFOIDPJOBDMAddOFMGALJGDAO(builder, OFMGALJGDAO): builder.PrependInt32Slot(1, OFMGALJGDAO, 0)
def EFOIDPJOBDMAddCFLMCGOJJJD(builder, CFLMCGOJJJD): builder.PrependInt32Slot(2, CFLMCGOJJJD, 0)
def EFOIDPJOBDMAddHBHEHJDPEBI(builder, HBHEHJDPEBI): builder.PrependInt32Slot(3, HBHEHJDPEBI, 0)
def EFOIDPJOBDMAddKJFEBMBHKOC(builder, KJFEBMBHKOC): builder.PrependInt32Slot(4, KJFEBMBHKOC, 0)
def EFOIDPJOBDMAddGEJGMBBCFEE(builder, GEJGMBBCFEE): builder.PrependInt32Slot(5, GEJGMBBCFEE, 0)
def EFOIDPJOBDMAddAEAKMMJLLDK(builder, AEAKMMJLLDK): builder.PrependInt32Slot(6, AEAKMMJLLDK, 0)
def EFOIDPJOBDMAddODBPKGJPLMD(builder, ODBPKGJPLMD): builder.PrependUint32Slot(7, ODBPKGJPLMD, 0)
def EFOIDPJOBDMEnd(builder): return builder.EndObject()