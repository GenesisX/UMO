# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class GLBBAECGHNN(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsGLBBAECGHNN(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = GLBBAECGHNN()
        x.Init(buf, n + offset)
        return x

    # GLBBAECGHNN
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # GLBBAECGHNN
    def EKEPMNOOFEF(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            x = self._tab.Vector(o)
            x += flatbuffers.number_types.UOffsetTFlags.py_type(j) * 4
            x = self._tab.Indirect(x)
            from .IJHCOCLJICA import IJHCOCLJICA
            obj = IJHCOCLJICA()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

    # GLBBAECGHNN
    def EKEPMNOOFEFLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # GLBBAECGHNN
    def DIOINIDFAMF(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            x = self._tab.Vector(o)
            x += flatbuffers.number_types.UOffsetTFlags.py_type(j) * 4
            x = self._tab.Indirect(x)
            from .ABHNDHFIFLB import ABHNDHFIFLB
            obj = ABHNDHFIFLB()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

    # GLBBAECGHNN
    def DIOINIDFAMFLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # GLBBAECGHNN
    def NJJINHMIOHN(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            x = self._tab.Vector(o)
            x += flatbuffers.number_types.UOffsetTFlags.py_type(j) * 4
            x = self._tab.Indirect(x)
            from .MJMHMHKFDNC import MJMHMHKFDNC
            obj = MJMHMHKFDNC()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

    # GLBBAECGHNN
    def NJJINHMIOHNLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # GLBBAECGHNN
    def NPFBHGKLIOM(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            x = self._tab.Vector(o)
            x += flatbuffers.number_types.UOffsetTFlags.py_type(j) * 4
            x = self._tab.Indirect(x)
            from .OIJDGALEEAI import OIJDGALEEAI
            obj = OIJDGALEEAI()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

    # GLBBAECGHNN
    def NPFBHGKLIOMLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

def GLBBAECGHNNStart(builder): builder.StartObject(4)
def GLBBAECGHNNAddEKEPMNOOFEF(builder, EKEPMNOOFEF): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(EKEPMNOOFEF), 0)
def GLBBAECGHNNStartEKEPMNOOFEFVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def GLBBAECGHNNAddDIOINIDFAMF(builder, DIOINIDFAMF): builder.PrependUOffsetTRelativeSlot(1, flatbuffers.number_types.UOffsetTFlags.py_type(DIOINIDFAMF), 0)
def GLBBAECGHNNStartDIOINIDFAMFVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def GLBBAECGHNNAddNJJINHMIOHN(builder, NJJINHMIOHN): builder.PrependUOffsetTRelativeSlot(2, flatbuffers.number_types.UOffsetTFlags.py_type(NJJINHMIOHN), 0)
def GLBBAECGHNNStartNJJINHMIOHNVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def GLBBAECGHNNAddNPFBHGKLIOM(builder, NPFBHGKLIOM): builder.PrependUOffsetTRelativeSlot(3, flatbuffers.number_types.UOffsetTFlags.py_type(NPFBHGKLIOM), 0)
def GLBBAECGHNNStartNPFBHGKLIOMVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def GLBBAECGHNNEnd(builder): return builder.EndObject()