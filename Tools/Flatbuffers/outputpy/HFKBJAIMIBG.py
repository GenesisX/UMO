# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class HFKBJAIMIBG(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsHFKBJAIMIBG(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = HFKBJAIMIBG()
        x.Init(buf, n + offset)
        return x

    # HFKBJAIMIBG
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # HFKBJAIMIBG
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HFKBJAIMIBG
    def GJEJFAJHBME(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HFKBJAIMIBG
    def COPFAKAHEMN(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

def HFKBJAIMIBGStart(builder): builder.StartObject(3)
def HFKBJAIMIBGAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependInt32Slot(0, BBPHAPFBFHK, 0)
def HFKBJAIMIBGAddGJEJFAJHBME(builder, GJEJFAJHBME): builder.PrependInt32Slot(1, GJEJFAJHBME, 0)
def HFKBJAIMIBGAddCOPFAKAHEMN(builder, COPFAKAHEMN): builder.PrependInt32Slot(2, COPFAKAHEMN, 0)
def HFKBJAIMIBGEnd(builder): return builder.EndObject()