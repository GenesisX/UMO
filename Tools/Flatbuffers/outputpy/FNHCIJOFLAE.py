# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class FNHCIJOFLAE(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsFNHCIJOFLAE(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = FNHCIJOFLAE()
        x.Init(buf, n + offset)
        return x

    # FNHCIJOFLAE
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # FNHCIJOFLAE
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # FNHCIJOFLAE
    def CFLMCGOJJJD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # FNHCIJOFLAE
    def GLIIHLOLPEF(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # FNHCIJOFLAE
    def BNDAHALMIPE(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # FNHCIJOFLAE
    def CNNEAFFOPAO(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

    # FNHCIJOFLAE
    def GOIOMMIEMJF(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(14))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

    # FNHCIJOFLAE
    def ONBMIJLCFBD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(16))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

    # FNHCIJOFLAE
    def NNNCOKLKPIH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(18))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

def FNHCIJOFLAEStart(builder): builder.StartObject(8)
def FNHCIJOFLAEAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependInt32Slot(0, BBPHAPFBFHK, 0)
def FNHCIJOFLAEAddCFLMCGOJJJD(builder, CFLMCGOJJJD): builder.PrependInt32Slot(1, CFLMCGOJJJD, 0)
def FNHCIJOFLAEAddGLIIHLOLPEF(builder, GLIIHLOLPEF): builder.PrependInt32Slot(2, GLIIHLOLPEF, 0)
def FNHCIJOFLAEAddBNDAHALMIPE(builder, BNDAHALMIPE): builder.PrependInt32Slot(3, BNDAHALMIPE, 0)
def FNHCIJOFLAEAddCNNEAFFOPAO(builder, CNNEAFFOPAO): builder.PrependUOffsetTRelativeSlot(4, flatbuffers.number_types.UOffsetTFlags.py_type(CNNEAFFOPAO), 0)
def FNHCIJOFLAEAddGOIOMMIEMJF(builder, GOIOMMIEMJF): builder.PrependUOffsetTRelativeSlot(5, flatbuffers.number_types.UOffsetTFlags.py_type(GOIOMMIEMJF), 0)
def FNHCIJOFLAEAddONBMIJLCFBD(builder, ONBMIJLCFBD): builder.PrependUOffsetTRelativeSlot(6, flatbuffers.number_types.UOffsetTFlags.py_type(ONBMIJLCFBD), 0)
def FNHCIJOFLAEAddNNNCOKLKPIH(builder, NNNCOKLKPIH): builder.PrependUOffsetTRelativeSlot(7, flatbuffers.number_types.UOffsetTFlags.py_type(NNNCOKLKPIH), 0)
def FNHCIJOFLAEEnd(builder): return builder.EndObject()
