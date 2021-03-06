// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: RoomResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Pb {

  /// <summary>Holder for reflection information generated from RoomResponse.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class RoomResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for RoomResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoomResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJSb29tUmVzcG9uc2UucHJvdG8SAnBiIisKDFJvb21SZXNwb25zZRIPCgdz",
            "dWNjZXNzGAEgASgIEgoKAmlkGAIgASgEYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.RoomResponse), global::Pb.RoomResponse.Parser, new[]{ "Success", "Id" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class RoomResponse : pb::IMessage<RoomResponse> {
    private static readonly pb::MessageParser<RoomResponse> _parser = new pb::MessageParser<RoomResponse>(() => new RoomResponse());
    public static pb::MessageParser<RoomResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.RoomResponseReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public RoomResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public RoomResponse(RoomResponse other) : this() {
      success_ = other.success_;
      id_ = other.id_;
    }

    public RoomResponse Clone() {
      return new RoomResponse(this);
    }

    /// <summary>Field number for the "success" field.</summary>
    public const int SuccessFieldNumber = 1;
    private bool success_;
    public bool Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private ulong id_;
    public ulong Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as RoomResponse);
    }

    public bool Equals(RoomResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Success != other.Success) return false;
      if (Id != other.Id) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Success != false) hash ^= Success.GetHashCode();
      if (Id != 0UL) hash ^= Id.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Success != false) {
        output.WriteRawTag(8);
        output.WriteBool(Success);
      }
      if (Id != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Id);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Success != false) {
        size += 1 + 1;
      }
      if (Id != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Id);
      }
      return size;
    }

    public void MergeFrom(RoomResponse other) {
      if (other == null) {
        return;
      }
      if (other.Success != false) {
        Success = other.Success;
      }
      if (other.Id != 0UL) {
        Id = other.Id;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Success = input.ReadBool();
            break;
          }
          case 16: {
            Id = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
