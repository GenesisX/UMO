# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class BACFACJMMDL(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsBACFACJMMDL(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = BACFACJMMDL()
        x.Init(buf, n + offset)
        return x

    # BACFACJMMDL
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # BACFACJMMDL
    def FGONCIDNPDP(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # BACFACJMMDL
    def GKLKKGBNGFP(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

def BACFACJMMDLStart(builder): builder.StartObject(2)
def BACFACJMMDLAddFGONCIDNPDP(builder, FGONCIDNPDP): builder.PrependInt32Slot(0, FGONCIDNPDP, 0)
def BACFACJMMDLAddGKLKKGBNGFP(builder, GKLKKGBNGFP): builder.PrependInt32Slot(1, GKLKKGBNGFP, 0)
def BACFACJMMDLEnd(builder): return builder.EndObject()