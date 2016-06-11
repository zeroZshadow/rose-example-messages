// Code generated by protoc-gen-gogo.
// source: UpdateRoomRequest.proto
// DO NOT EDIT!

package pb

import proto "github.com/golang/protobuf/proto"
import fmt "fmt"
import math "math"

import io "io"

// Reference imports to suppress errors if they are not otherwise used.
var _ = proto.Marshal
var _ = fmt.Errorf
var _ = math.Inf

type UpdateRoomRequest struct {
	Room   *RoomInfo `protobuf:"bytes,1,opt,name=room" json:"room,omitempty"`
	Remove bool      `protobuf:"varint,2,opt,name=remove,proto3" json:"remove,omitempty"`
}

func (m *UpdateRoomRequest) Reset()         { *m = UpdateRoomRequest{} }
func (m *UpdateRoomRequest) String() string { return proto.CompactTextString(m) }
func (*UpdateRoomRequest) ProtoMessage()    {}
func (*UpdateRoomRequest) Descriptor() ([]byte, []int) {
	return fileDescriptorUpdateRoomRequest, []int{0}
}

func (m *UpdateRoomRequest) GetRoom() *RoomInfo {
	if m != nil {
		return m.Room
	}
	return nil
}

func init() {
	proto.RegisterType((*UpdateRoomRequest)(nil), "pb.UpdateRoomRequest")
}
func (m *UpdateRoomRequest) Marshal() (data []byte, err error) {
	size := m.Size()
	data = make([]byte, size)
	n, err := m.MarshalTo(data)
	if err != nil {
		return nil, err
	}
	return data[:n], nil
}

func (m *UpdateRoomRequest) MarshalTo(data []byte) (int, error) {
	var i int
	_ = i
	var l int
	_ = l
	if m.Room != nil {
		data[i] = 0xa
		i++
		i = encodeVarintUpdateRoomRequest(data, i, uint64(m.Room.Size()))
		n1, err := m.Room.MarshalTo(data[i:])
		if err != nil {
			return 0, err
		}
		i += n1
	}
	if m.Remove {
		data[i] = 0x10
		i++
		if m.Remove {
			data[i] = 1
		} else {
			data[i] = 0
		}
		i++
	}
	return i, nil
}

func encodeFixed64UpdateRoomRequest(data []byte, offset int, v uint64) int {
	data[offset] = uint8(v)
	data[offset+1] = uint8(v >> 8)
	data[offset+2] = uint8(v >> 16)
	data[offset+3] = uint8(v >> 24)
	data[offset+4] = uint8(v >> 32)
	data[offset+5] = uint8(v >> 40)
	data[offset+6] = uint8(v >> 48)
	data[offset+7] = uint8(v >> 56)
	return offset + 8
}
func encodeFixed32UpdateRoomRequest(data []byte, offset int, v uint32) int {
	data[offset] = uint8(v)
	data[offset+1] = uint8(v >> 8)
	data[offset+2] = uint8(v >> 16)
	data[offset+3] = uint8(v >> 24)
	return offset + 4
}
func encodeVarintUpdateRoomRequest(data []byte, offset int, v uint64) int {
	for v >= 1<<7 {
		data[offset] = uint8(v&0x7f | 0x80)
		v >>= 7
		offset++
	}
	data[offset] = uint8(v)
	return offset + 1
}
func (m *UpdateRoomRequest) Size() (n int) {
	var l int
	_ = l
	if m.Room != nil {
		l = m.Room.Size()
		n += 1 + l + sovUpdateRoomRequest(uint64(l))
	}
	if m.Remove {
		n += 2
	}
	return n
}

func sovUpdateRoomRequest(x uint64) (n int) {
	for {
		n++
		x >>= 7
		if x == 0 {
			break
		}
	}
	return n
}
func sozUpdateRoomRequest(x uint64) (n int) {
	return sovUpdateRoomRequest(uint64((x << 1) ^ uint64((int64(x) >> 63))))
}
func (m *UpdateRoomRequest) Unmarshal(data []byte) error {
	l := len(data)
	iNdEx := 0
	for iNdEx < l {
		preIndex := iNdEx
		var wire uint64
		for shift := uint(0); ; shift += 7 {
			if shift >= 64 {
				return ErrIntOverflowUpdateRoomRequest
			}
			if iNdEx >= l {
				return io.ErrUnexpectedEOF
			}
			b := data[iNdEx]
			iNdEx++
			wire |= (uint64(b) & 0x7F) << shift
			if b < 0x80 {
				break
			}
		}
		fieldNum := int32(wire >> 3)
		wireType := int(wire & 0x7)
		if wireType == 4 {
			return fmt.Errorf("proto: UpdateRoomRequest: wiretype end group for non-group")
		}
		if fieldNum <= 0 {
			return fmt.Errorf("proto: UpdateRoomRequest: illegal tag %d (wire type %d)", fieldNum, wire)
		}
		switch fieldNum {
		case 1:
			if wireType != 2 {
				return fmt.Errorf("proto: wrong wireType = %d for field Room", wireType)
			}
			var msglen int
			for shift := uint(0); ; shift += 7 {
				if shift >= 64 {
					return ErrIntOverflowUpdateRoomRequest
				}
				if iNdEx >= l {
					return io.ErrUnexpectedEOF
				}
				b := data[iNdEx]
				iNdEx++
				msglen |= (int(b) & 0x7F) << shift
				if b < 0x80 {
					break
				}
			}
			if msglen < 0 {
				return ErrInvalidLengthUpdateRoomRequest
			}
			postIndex := iNdEx + msglen
			if postIndex > l {
				return io.ErrUnexpectedEOF
			}
			if m.Room == nil {
				m.Room = &RoomInfo{}
			}
			if err := m.Room.Unmarshal(data[iNdEx:postIndex]); err != nil {
				return err
			}
			iNdEx = postIndex
		case 2:
			if wireType != 0 {
				return fmt.Errorf("proto: wrong wireType = %d for field Remove", wireType)
			}
			var v int
			for shift := uint(0); ; shift += 7 {
				if shift >= 64 {
					return ErrIntOverflowUpdateRoomRequest
				}
				if iNdEx >= l {
					return io.ErrUnexpectedEOF
				}
				b := data[iNdEx]
				iNdEx++
				v |= (int(b) & 0x7F) << shift
				if b < 0x80 {
					break
				}
			}
			m.Remove = bool(v != 0)
		default:
			iNdEx = preIndex
			skippy, err := skipUpdateRoomRequest(data[iNdEx:])
			if err != nil {
				return err
			}
			if skippy < 0 {
				return ErrInvalidLengthUpdateRoomRequest
			}
			if (iNdEx + skippy) > l {
				return io.ErrUnexpectedEOF
			}
			iNdEx += skippy
		}
	}

	if iNdEx > l {
		return io.ErrUnexpectedEOF
	}
	return nil
}
func skipUpdateRoomRequest(data []byte) (n int, err error) {
	l := len(data)
	iNdEx := 0
	for iNdEx < l {
		var wire uint64
		for shift := uint(0); ; shift += 7 {
			if shift >= 64 {
				return 0, ErrIntOverflowUpdateRoomRequest
			}
			if iNdEx >= l {
				return 0, io.ErrUnexpectedEOF
			}
			b := data[iNdEx]
			iNdEx++
			wire |= (uint64(b) & 0x7F) << shift
			if b < 0x80 {
				break
			}
		}
		wireType := int(wire & 0x7)
		switch wireType {
		case 0:
			for shift := uint(0); ; shift += 7 {
				if shift >= 64 {
					return 0, ErrIntOverflowUpdateRoomRequest
				}
				if iNdEx >= l {
					return 0, io.ErrUnexpectedEOF
				}
				iNdEx++
				if data[iNdEx-1] < 0x80 {
					break
				}
			}
			return iNdEx, nil
		case 1:
			iNdEx += 8
			return iNdEx, nil
		case 2:
			var length int
			for shift := uint(0); ; shift += 7 {
				if shift >= 64 {
					return 0, ErrIntOverflowUpdateRoomRequest
				}
				if iNdEx >= l {
					return 0, io.ErrUnexpectedEOF
				}
				b := data[iNdEx]
				iNdEx++
				length |= (int(b) & 0x7F) << shift
				if b < 0x80 {
					break
				}
			}
			iNdEx += length
			if length < 0 {
				return 0, ErrInvalidLengthUpdateRoomRequest
			}
			return iNdEx, nil
		case 3:
			for {
				var innerWire uint64
				var start int = iNdEx
				for shift := uint(0); ; shift += 7 {
					if shift >= 64 {
						return 0, ErrIntOverflowUpdateRoomRequest
					}
					if iNdEx >= l {
						return 0, io.ErrUnexpectedEOF
					}
					b := data[iNdEx]
					iNdEx++
					innerWire |= (uint64(b) & 0x7F) << shift
					if b < 0x80 {
						break
					}
				}
				innerWireType := int(innerWire & 0x7)
				if innerWireType == 4 {
					break
				}
				next, err := skipUpdateRoomRequest(data[start:])
				if err != nil {
					return 0, err
				}
				iNdEx = start + next
			}
			return iNdEx, nil
		case 4:
			return iNdEx, nil
		case 5:
			iNdEx += 4
			return iNdEx, nil
		default:
			return 0, fmt.Errorf("proto: illegal wireType %d", wireType)
		}
	}
	panic("unreachable")
}

var (
	ErrInvalidLengthUpdateRoomRequest = fmt.Errorf("proto: negative length found during unmarshaling")
	ErrIntOverflowUpdateRoomRequest   = fmt.Errorf("proto: integer overflow")
)

var fileDescriptorUpdateRoomRequest = []byte{
	// 131 bytes of a gzipped FileDescriptorProto
	0x1f, 0x8b, 0x08, 0x00, 0x00, 0x09, 0x6e, 0x88, 0x02, 0xff, 0xe2, 0x12, 0x0f, 0x2d, 0x48, 0x49,
	0x2c, 0x49, 0x0d, 0xca, 0xcf, 0xcf, 0x0d, 0x4a, 0x2d, 0x2c, 0x4d, 0x2d, 0x2e, 0xd1, 0x2b, 0x28,
	0xca, 0x2f, 0xc9, 0x17, 0x62, 0x2a, 0x48, 0x92, 0xe2, 0x03, 0x09, 0x7b, 0xe6, 0xa5, 0xe5, 0x43,
	0xc4, 0x94, 0x7c, 0xb9, 0x04, 0x31, 0x94, 0x0b, 0x29, 0x70, 0xb1, 0x14, 0x01, 0xb9, 0x12, 0x8c,
	0x0a, 0x8c, 0x1a, 0xdc, 0x46, 0x3c, 0x7a, 0x05, 0x49, 0x7a, 0x30, 0x6d, 0x41, 0x60, 0x19, 0x21,
	0x31, 0x2e, 0xb6, 0xa2, 0xd4, 0xdc, 0xfc, 0xb2, 0x54, 0x09, 0x26, 0xa0, 0x1a, 0x8e, 0x20, 0x28,
	0xcf, 0x49, 0xe0, 0xc4, 0x23, 0x39, 0xc6, 0x0b, 0x40, 0xfc, 0x00, 0x88, 0x67, 0x3c, 0x96, 0x63,
	0x48, 0x62, 0x03, 0xdb, 0x63, 0x0c, 0x08, 0x00, 0x00, 0xff, 0xff, 0x9c, 0x79, 0x4f, 0x0b, 0x96,
	0x00, 0x00, 0x00,
}