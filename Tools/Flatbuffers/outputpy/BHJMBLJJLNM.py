# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class BHJMBLJJLNM(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsBHJMBLJJLNM(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = BHJMBLJJLNM()
        x.Init(buf, n + offset)
        return x

    # BHJMBLJJLNM
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # BHJMBLJJLNM
    def AGOIMGHMGOH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

    # BHJMBLJJLNM
    def KJFEBMBHKOC(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

def BHJMBLJJLNMStart(builder): builder.StartObject(2)
def BHJMBLJJLNMAddAGOIMGHMGOH(builder, AGOIMGHMGOH): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(AGOIMGHMGOH), 0)
def BHJMBLJJLNMAddKJFEBMBHKOC(builder, KJFEBMBHKOC): builder.PrependUOffsetTRelativeSlot(1, flatbuffers.number_types.UOffsetTFlags.py_type(KJFEBMBHKOC), 0)
def BHJMBLJJLNMEnd(builder): return builder.EndObject()