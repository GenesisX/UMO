# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class HCNLBIAHFHK(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsHCNLBIAHFHK(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = HCNLBIAHFHK()
        x.Init(buf, n + offset)
        return x

    # HCNLBIAHFHK
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # HCNLBIAHFHK
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HCNLBIAHFHK
    def LPJPOOHJKAE(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HCNLBIAHFHK
    def KJFEBMBHKOC(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HCNLBIAHFHK
    def LAIEPFCPDLK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

def HCNLBIAHFHKStart(builder): builder.StartObject(4)
def HCNLBIAHFHKAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependInt32Slot(0, BBPHAPFBFHK, 0)
def HCNLBIAHFHKAddLPJPOOHJKAE(builder, LPJPOOHJKAE): builder.PrependInt32Slot(1, LPJPOOHJKAE, 0)
def HCNLBIAHFHKAddKJFEBMBHKOC(builder, KJFEBMBHKOC): builder.PrependInt32Slot(2, KJFEBMBHKOC, 0)
def HCNLBIAHFHKAddLAIEPFCPDLK(builder, LAIEPFCPDLK): builder.PrependInt32Slot(3, LAIEPFCPDLK, 0)
def HCNLBIAHFHKEnd(builder): return builder.EndObject()