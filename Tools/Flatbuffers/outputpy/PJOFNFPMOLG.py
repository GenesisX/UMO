# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class PJOFNFPMOLG(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsPJOFNFPMOLG(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = PJOFNFPMOLG()
        x.Init(buf, n + offset)
        return x

    # PJOFNFPMOLG
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # PJOFNFPMOLG
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # PJOFNFPMOLG
    def BLJLFEDLAME(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # PJOFNFPMOLG
    def DALJDMJEJGE(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # PJOFNFPMOLG
    def IDJCFCJMBCF(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # PJOFNFPMOLG
    def NAGPKLGDNDA(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # PJOFNFPMOLG
    def BNDEBMLCMNB(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(14))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

def PJOFNFPMOLGStart(builder): builder.StartObject(6)
def PJOFNFPMOLGAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependUint32Slot(0, BBPHAPFBFHK, 0)
def PJOFNFPMOLGAddBLJLFEDLAME(builder, BLJLFEDLAME): builder.PrependUint32Slot(1, BLJLFEDLAME, 0)
def PJOFNFPMOLGAddDALJDMJEJGE(builder, DALJDMJEJGE): builder.PrependUint32Slot(2, DALJDMJEJGE, 0)
def PJOFNFPMOLGAddIDJCFCJMBCF(builder, IDJCFCJMBCF): builder.PrependUint32Slot(3, IDJCFCJMBCF, 0)
def PJOFNFPMOLGAddNAGPKLGDNDA(builder, NAGPKLGDNDA): builder.PrependUint32Slot(4, NAGPKLGDNDA, 0)
def PJOFNFPMOLGAddBNDEBMLCMNB(builder, BNDEBMLCMNB): builder.PrependUint32Slot(5, BNDEBMLCMNB, 0)
def PJOFNFPMOLGEnd(builder): return builder.EndObject()