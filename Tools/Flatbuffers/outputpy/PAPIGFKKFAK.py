# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class PAPIGFKKFAK(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsPAPIGFKKFAK(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = PAPIGFKKFAK()
        x.Init(buf, n + offset)
        return x

    # PAPIGFKKFAK
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # PAPIGFKKFAK
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # PAPIGFKKFAK
    def HJNPKHJJDBB(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # PAPIGFKKFAK
    def LEFPIGNDJNC(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Int32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # PAPIGFKKFAK
    def LEFPIGNDJNCLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # PAPIGFKKFAK
    def BNCIPLKECMC(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # PAPIGFKKFAK
    def BNCIPLKECMCLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # PAPIGFKKFAK
    def OOJBHHPJONJ(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # PAPIGFKKFAK
    def OOJBHHPJONJLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # PAPIGFKKFAK
    def ALPALMJMJJK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(14))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

def PAPIGFKKFAKStart(builder): builder.StartObject(6)
def PAPIGFKKFAKAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependUint32Slot(0, BBPHAPFBFHK, 0)
def PAPIGFKKFAKAddHJNPKHJJDBB(builder, HJNPKHJJDBB): builder.PrependUint32Slot(1, HJNPKHJJDBB, 0)
def PAPIGFKKFAKAddLEFPIGNDJNC(builder, LEFPIGNDJNC): builder.PrependUOffsetTRelativeSlot(2, flatbuffers.number_types.UOffsetTFlags.py_type(LEFPIGNDJNC), 0)
def PAPIGFKKFAKStartLEFPIGNDJNCVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def PAPIGFKKFAKAddBNCIPLKECMC(builder, BNCIPLKECMC): builder.PrependUOffsetTRelativeSlot(3, flatbuffers.number_types.UOffsetTFlags.py_type(BNCIPLKECMC), 0)
def PAPIGFKKFAKStartBNCIPLKECMCVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def PAPIGFKKFAKAddOOJBHHPJONJ(builder, OOJBHHPJONJ): builder.PrependUOffsetTRelativeSlot(4, flatbuffers.number_types.UOffsetTFlags.py_type(OOJBHHPJONJ), 0)
def PAPIGFKKFAKStartOOJBHHPJONJVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def PAPIGFKKFAKAddALPALMJMJJK(builder, ALPALMJMJJK): builder.PrependInt32Slot(5, ALPALMJMJJK, 0)
def PAPIGFKKFAKEnd(builder): return builder.EndObject()