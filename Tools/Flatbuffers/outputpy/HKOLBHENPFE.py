# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class HKOLBHENPFE(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsHKOLBHENPFE(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = HKOLBHENPFE()
        x.Init(buf, n + offset)
        return x

    # HKOLBHENPFE
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # HKOLBHENPFE
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # HKOLBHENPFE
    def IIDCFMHCPLJ(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

    # HKOLBHENPFE
    def LMLNKHMPOIG(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HKOLBHENPFE
    def GKLHNNBMGKH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HKOLBHENPFE
    def OJPOLKBHIKP(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HKOLBHENPFE
    def PGIKNMMIPKG(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(14))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HKOLBHENPFE
    def JGLECHJPIGM(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(16))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HKOLBHENPFE
    def OFELDHPINMB(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(18))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

def HKOLBHENPFEStart(builder): builder.StartObject(8)
def HKOLBHENPFEAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependUint32Slot(0, BBPHAPFBFHK, 0)
def HKOLBHENPFEAddIIDCFMHCPLJ(builder, IIDCFMHCPLJ): builder.PrependUOffsetTRelativeSlot(1, flatbuffers.number_types.UOffsetTFlags.py_type(IIDCFMHCPLJ), 0)
def HKOLBHENPFEAddLMLNKHMPOIG(builder, LMLNKHMPOIG): builder.PrependInt32Slot(2, LMLNKHMPOIG, 0)
def HKOLBHENPFEAddGKLHNNBMGKH(builder, GKLHNNBMGKH): builder.PrependInt32Slot(3, GKLHNNBMGKH, 0)
def HKOLBHENPFEAddOJPOLKBHIKP(builder, OJPOLKBHIKP): builder.PrependInt32Slot(4, OJPOLKBHIKP, 0)
def HKOLBHENPFEAddPGIKNMMIPKG(builder, PGIKNMMIPKG): builder.PrependInt32Slot(5, PGIKNMMIPKG, 0)
def HKOLBHENPFEAddJGLECHJPIGM(builder, JGLECHJPIGM): builder.PrependInt32Slot(6, JGLECHJPIGM, 0)
def HKOLBHENPFEAddOFELDHPINMB(builder, OFELDHPINMB): builder.PrependInt32Slot(7, OFELDHPINMB, 0)
def HKOLBHENPFEEnd(builder): return builder.EndObject()