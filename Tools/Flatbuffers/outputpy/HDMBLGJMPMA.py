# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class HDMBLGJMPMA(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsHDMBLGJMPMA(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = HDMBLGJMPMA()
        x.Init(buf, n + offset)
        return x

    # HDMBLGJMPMA
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # HDMBLGJMPMA
    def FANPJEPOAFK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HDMBLGJMPMA
    def PENNDFJDJMP(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HDMBLGJMPMA
    def CNOIMMHCCIH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HDMBLGJMPMA
    def IDHMEJECPBO(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

def HDMBLGJMPMAStart(builder): builder.StartObject(4)
def HDMBLGJMPMAAddFANPJEPOAFK(builder, FANPJEPOAFK): builder.PrependInt32Slot(0, FANPJEPOAFK, 0)
def HDMBLGJMPMAAddPENNDFJDJMP(builder, PENNDFJDJMP): builder.PrependInt32Slot(1, PENNDFJDJMP, 0)
def HDMBLGJMPMAAddCNOIMMHCCIH(builder, CNOIMMHCCIH): builder.PrependInt32Slot(2, CNOIMMHCCIH, 0)
def HDMBLGJMPMAAddIDHMEJECPBO(builder, IDHMEJECPBO): builder.PrependInt32Slot(3, IDHMEJECPBO, 0)
def HDMBLGJMPMAEnd(builder): return builder.EndObject()