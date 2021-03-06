// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ListRoomsResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Pb {

  /// <summary>Holder for reflection information generated from ListRoomsResponse.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class ListRoomsResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for ListRoomsResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ListRoomsResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdMaXN0Um9vbXNSZXNwb25zZS5wcm90bxICcGIaDlJvb21JbmZvLnByb3Rv",
            "IkAKEUxpc3RSb29tc1Jlc3BvbnNlEg4KBnJlZ2lvbhgBIAEoCRIbCgVyb29t",
            "cxgCIAMoCzIMLnBiLlJvb21JbmZvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Pb.RoomInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.ListRoomsResponse), global::Pb.ListRoomsResponse.Parser, new[]{ "Region", "Rooms" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ListRoomsResponse : pb::IMessage<ListRoomsResponse> {
    private static readonly pb::MessageParser<ListRoomsResponse> _parser = new pb::MessageParser<ListRoomsResponse>(() => new ListRoomsResponse());
    public static pb::MessageParser<ListRoomsResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.ListRoomsResponseReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ListRoomsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ListRoomsResponse(ListRoomsResponse other) : this() {
      region_ = other.region_;
      rooms_ = other.rooms_.Clone();
    }

    public ListRoomsResponse Clone() {
      return new ListRoomsResponse(this);
    }

    /// <summary>Field number for the "region" field.</summary>
    public const int RegionFieldNumber = 1;
    private string region_ = "";
    public string Region {
      get { return region_; }
      set {
        region_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "rooms" field.</summary>
    public const int RoomsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Pb.RoomInfo> _repeated_rooms_codec
        = pb::FieldCodec.ForMessage(18, global::Pb.RoomInfo.Parser);
    private readonly pbc::RepeatedField<global::Pb.RoomInfo> rooms_ = new pbc::RepeatedField<global::Pb.RoomInfo>();
    public pbc::RepeatedField<global::Pb.RoomInfo> Rooms {
      get { return rooms_; }
    }

    public override bool Equals(object other) {
      return Equals(other as ListRoomsResponse);
    }

    public bool Equals(ListRoomsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Region != other.Region) return false;
      if(!rooms_.Equals(other.rooms_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Region.Length != 0) hash ^= Region.GetHashCode();
      hash ^= rooms_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Region.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Region);
      }
      rooms_.WriteTo(output, _repeated_rooms_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (Region.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Region);
      }
      size += rooms_.CalculateSize(_repeated_rooms_codec);
      return size;
    }

    public void MergeFrom(ListRoomsResponse other) {
      if (other == null) {
        return;
      }
      if (other.Region.Length != 0) {
        Region = other.Region;
      }
      rooms_.Add(other.rooms_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Region = input.ReadString();
            break;
          }
          case 18: {
            rooms_.AddEntriesFrom(input, _repeated_rooms_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
