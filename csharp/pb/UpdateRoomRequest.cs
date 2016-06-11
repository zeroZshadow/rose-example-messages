// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: UpdateRoomRequest.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Pb {

  /// <summary>Holder for reflection information generated from UpdateRoomRequest.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class UpdateRoomRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for UpdateRoomRequest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UpdateRoomRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdVcGRhdGVSb29tUmVxdWVzdC5wcm90bxICcGIaDlJvb21JbmZvLnByb3Rv",
            "Ij8KEVVwZGF0ZVJvb21SZXF1ZXN0EhoKBHJvb20YASABKAsyDC5wYi5Sb29t",
            "SW5mbxIOCgZyZW1vdmUYAiABKAhiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Pb.RoomInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.UpdateRoomRequest), global::Pb.UpdateRoomRequest.Parser, new[]{ "Room", "Remove" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UpdateRoomRequest : pb::IMessage<UpdateRoomRequest> {
    private static readonly pb::MessageParser<UpdateRoomRequest> _parser = new pb::MessageParser<UpdateRoomRequest>(() => new UpdateRoomRequest());
    public static pb::MessageParser<UpdateRoomRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.UpdateRoomRequestReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public UpdateRoomRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public UpdateRoomRequest(UpdateRoomRequest other) : this() {
      Room = other.room_ != null ? other.Room.Clone() : null;
      remove_ = other.remove_;
    }

    public UpdateRoomRequest Clone() {
      return new UpdateRoomRequest(this);
    }

    /// <summary>Field number for the "room" field.</summary>
    public const int RoomFieldNumber = 1;
    private global::Pb.RoomInfo room_;
    public global::Pb.RoomInfo Room {
      get { return room_; }
      set {
        room_ = value;
      }
    }

    /// <summary>Field number for the "remove" field.</summary>
    public const int RemoveFieldNumber = 2;
    private bool remove_;
    public bool Remove {
      get { return remove_; }
      set {
        remove_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as UpdateRoomRequest);
    }

    public bool Equals(UpdateRoomRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Room, other.Room)) return false;
      if (Remove != other.Remove) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (room_ != null) hash ^= Room.GetHashCode();
      if (Remove != false) hash ^= Remove.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (room_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Room);
      }
      if (Remove != false) {
        output.WriteRawTag(16);
        output.WriteBool(Remove);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (room_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Room);
      }
      if (Remove != false) {
        size += 1 + 1;
      }
      return size;
    }

    public void MergeFrom(UpdateRoomRequest other) {
      if (other == null) {
        return;
      }
      if (other.room_ != null) {
        if (room_ == null) {
          room_ = new global::Pb.RoomInfo();
        }
        Room.MergeFrom(other.Room);
      }
      if (other.Remove != false) {
        Remove = other.Remove;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (room_ == null) {
              room_ = new global::Pb.RoomInfo();
            }
            input.ReadMessage(room_);
            break;
          }
          case 16: {
            Remove = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
