// Code generated by protoc-gen-gogo.
// source: CreateRoomResponse.proto
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

type CreateRoomResponse struct {
	Success   bool   `protobuf:"varint,1,opt,name=success,proto3" json:"success,omitempty"`
	Id        uint64 `protobuf:"varint,2,opt,name=id,proto3" json:"id,omitempty"`
	Address   string `protobuf:"bytes,3,opt,name=address,proto3" json:"address,omitempty"`
	Authtoken []byte `protobuf:"bytes,4,opt,name=authtoken,proto3" json:"authtoken,omitempty"`
}

func (m *CreateRoomResponse) Reset()         { *m = CreateRoomResponse{} }
func (m *CreateRoomResponse) String() string { return proto.CompactTextString(m) }
func (*CreateRoomResponse) ProtoMessage()    {}
func (*CreateRoomResponse) Descriptor() ([]byte, []int) {
	return fileDescriptorCreateRoomResponse, []int{0}
}

func init() {
	proto.RegisterType((*CreateRoomResponse)(nil), "pb.CreateRoomResponse")
}
func (m *CreateRoomResponse) Marshal() (data []byte, err error) {
	size := m.Size()
	data = make([]byte, size)
	n, err := m.MarshalTo(data)
	if err != nil {
		return nil, err
	}
	return data[:n], nil
}

func (m *CreateRoomResponse) MarshalTo(data []byte) (int, error) {
	var i int
	_ = i
	var l int
	_ = l
	if m.Success {
		data[i] = 0x8
		i++
		if m.Success {
			data[i] = 1
		} else {
			data[i] = 0
		}
		i++
	}
	if m.Id != 0 {
		data[i] = 0x10
		i++
		i = encodeVarintCreateRoomResponse(data, i, uint64(m.Id))
	}
	if len(m.Address) > 0 {
		data[i] = 0x1a
		i++
		i = encodeVarintCreateRoomResponse(data, i, uint64(len(m.Address)))
		i += copy(data[i:], m.Address)
	}
	if len(m.Authtoken) > 0 {
		data[i] = 0x22
		i++
		i = encodeVarintCreateRoomResponse(data, i, uint64(len(m.Authtoken)))
		i += copy(data[i:], m.Authtoken)
	}
	return i, nil
}

func encodeFixed64CreateRoomResponse(data []byte, offset int, v uint64) int {
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
func encodeFixed32CreateRoomResponse(data []byte, offset int, v uint32) int {
	data[offset] = uint8(v)
	data[offset+1] = uint8(v >> 8)
	data[offset+2] = uint8(v >> 16)
	data[offset+3] = uint8(v >> 24)
	return offset + 4
}
func encodeVarintCreateRoomResponse(data []byte, offset int, v uint64) int {
	for v >= 1<<7 {
		data[offset] = uint8(v&0x7f | 0x80)
		v >>= 7
		offset++
	}
	data[offset] = uint8(v)
	return offset + 1
}
func (m *CreateRoomResponse) Size() (n int) {
	var l int
	_ = l
	if m.Success {
		n += 2
	}
	if m.Id != 0 {
		n += 1 + sovCreateRoomResponse(uint64(m.Id))
	}
	l = len(m.Address)
	if l > 0 {
		n += 1 + l + sovCreateRoomResponse(uint64(l))
	}
	l = len(m.Authtoken)
	if l > 0 {
		n += 1 + l + sovCreateRoomResponse(uint64(l))
	}
	return n
}

func sovCreateRoomResponse(x uint64) (n int) {
	for {
		n++
		x >>= 7
		if x == 0 {
			break
		}
	}
	return n
}
func sozCreateRoomResponse(x uint64) (n int) {
	return sovCreateRoomResponse(uint64((x << 1) ^ uint64((int64(x) >> 63))))
}
func (m *CreateRoomResponse) Unmarshal(data []byte) error {
	l := len(data)
	iNdEx := 0
	for iNdEx < l {
		preIndex := iNdEx
		var wire uint64
		for shift := uint(0); ; shift += 7 {
			if shift >= 64 {
				return ErrIntOverflowCreateRoomResponse
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
			return fmt.Errorf("proto: CreateRoomResponse: wiretype end group for non-group")
		}
		if fieldNum <= 0 {
			return fmt.Errorf("proto: CreateRoomResponse: illegal tag %d (wire type %d)", fieldNum, wire)
		}
		switch fieldNum {
		case 1:
			if wireType != 0 {
				return fmt.Errorf("proto: wrong wireType = %d for field Success", wireType)
			}
			var v int
			for shift := uint(0); ; shift += 7 {
				if shift >= 64 {
					return ErrIntOverflowCreateRoomResponse
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
			m.Success = bool(v != 0)
		case 2:
			if wireType != 0 {
				return fmt.Errorf("proto: wrong wireType = %d for field Id", wireType)
			}
			m.Id = 0
			for shift := uint(0); ; shift += 7 {
				if shift >= 64 {
					return ErrIntOverflowCreateRoomResponse
				}
				if iNdEx >= l {
					return io.ErrUnexpectedEOF
				}
				b := data[iNdEx]
				iNdEx++
				m.Id |= (uint64(b) & 0x7F) << shift
				if b < 0x80 {
					break
				}
			}
		case 3:
			if wireType != 2 {
				return fmt.Errorf("proto: wrong wireType = %d for field Address", wireType)
			}
			var stringLen uint64
			for shift := uint(0); ; shift += 7 {
				if shift >= 64 {
					return ErrIntOverflowCreateRoomResponse
				}
				if iNdEx >= l {
					return io.ErrUnexpectedEOF
				}
				b := data[iNdEx]
				iNdEx++
				stringLen |= (uint64(b) & 0x7F) << shift
				if b < 0x80 {
					break
				}
			}
			intStringLen := int(stringLen)
			if intStringLen < 0 {
				return ErrInvalidLengthCreateRoomResponse
			}
			postIndex := iNdEx + intStringLen
			if postIndex > l {
				return io.ErrUnexpectedEOF
			}
			m.Address = string(data[iNdEx:postIndex])
			iNdEx = postIndex
		case 4:
			if wireType != 2 {
				return fmt.Errorf("proto: wrong wireType = %d for field Authtoken", wireType)
			}
			var byteLen int
			for shift := uint(0); ; shift += 7 {
				if shift >= 64 {
					return ErrIntOverflowCreateRoomResponse
				}
				if iNdEx >= l {
					return io.ErrUnexpectedEOF
				}
				b := data[iNdEx]
				iNdEx++
				byteLen |= (int(b) & 0x7F) << shift
				if b < 0x80 {
					break
				}
			}
			if byteLen < 0 {
				return ErrInvalidLengthCreateRoomResponse
			}
			postIndex := iNdEx + byteLen
			if postIndex > l {
				return io.ErrUnexpectedEOF
			}
			m.Authtoken = append(m.Authtoken[:0], data[iNdEx:postIndex]...)
			if m.Authtoken == nil {
				m.Authtoken = []byte{}
			}
			iNdEx = postIndex
		default:
			iNdEx = preIndex
			skippy, err := skipCreateRoomResponse(data[iNdEx:])
			if err != nil {
				return err
			}
			if skippy < 0 {
				return ErrInvalidLengthCreateRoomResponse
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
func skipCreateRoomResponse(data []byte) (n int, err error) {
	l := len(data)
	iNdEx := 0
	for iNdEx < l {
		var wire uint64
		for shift := uint(0); ; shift += 7 {
			if shift >= 64 {
				return 0, ErrIntOverflowCreateRoomResponse
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
					return 0, ErrIntOverflowCreateRoomResponse
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
					return 0, ErrIntOverflowCreateRoomResponse
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
				return 0, ErrInvalidLengthCreateRoomResponse
			}
			return iNdEx, nil
		case 3:
			for {
				var innerWire uint64
				var start int = iNdEx
				for shift := uint(0); ; shift += 7 {
					if shift >= 64 {
						return 0, ErrIntOverflowCreateRoomResponse
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
				next, err := skipCreateRoomResponse(data[start:])
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
	ErrInvalidLengthCreateRoomResponse = fmt.Errorf("proto: negative length found during unmarshaling")
	ErrIntOverflowCreateRoomResponse   = fmt.Errorf("proto: integer overflow")
)

var fileDescriptorCreateRoomResponse = []byte{
	// 150 bytes of a gzipped FileDescriptorProto
	0x1f, 0x8b, 0x08, 0x00, 0x00, 0x09, 0x6e, 0x88, 0x02, 0xff, 0xe2, 0x92, 0x70, 0x2e, 0x4a, 0x4d,
	0x2c, 0x49, 0x0d, 0xca, 0xcf, 0xcf, 0x0d, 0x4a, 0x2d, 0x2e, 0xc8, 0xcf, 0x2b, 0x4e, 0xd5, 0x2b,
	0x28, 0xca, 0x2f, 0xc9, 0x17, 0x62, 0x2a, 0x48, 0x52, 0x2a, 0xe3, 0x12, 0xc2, 0x94, 0x17, 0x92,
	0xe0, 0x62, 0x2f, 0x2e, 0x4d, 0x4e, 0x4e, 0x2d, 0x2e, 0x96, 0x60, 0x54, 0x60, 0xd4, 0xe0, 0x08,
	0x82, 0x71, 0x85, 0xf8, 0xb8, 0x98, 0x32, 0x53, 0x24, 0x98, 0x80, 0x82, 0x2c, 0x41, 0x40, 0x16,
	0x48, 0x65, 0x62, 0x4a, 0x4a, 0x11, 0x48, 0x25, 0x33, 0x50, 0x90, 0x33, 0x08, 0xc6, 0x15, 0x92,
	0xe1, 0xe2, 0x4c, 0x2c, 0x2d, 0xc9, 0x28, 0xc9, 0xcf, 0x4e, 0xcd, 0x93, 0x60, 0x01, 0xca, 0xf1,
	0x04, 0x21, 0x04, 0x9c, 0x04, 0x4e, 0x3c, 0x92, 0x63, 0xbc, 0x00, 0xc4, 0x0f, 0x80, 0x78, 0xc6,
	0x63, 0x39, 0x86, 0x24, 0x36, 0xb0, 0xa3, 0x8c, 0x01, 0x01, 0x00, 0x00, 0xff, 0xff, 0xff, 0x3f,
	0xa0, 0xb8, 0xb0, 0x00, 0x00, 0x00,
}