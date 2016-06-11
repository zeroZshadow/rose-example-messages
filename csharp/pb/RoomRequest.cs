// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: RoomRequest.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Pb {

  /// <summary>Holder for reflection information generated from RoomRequest.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class RoomRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for RoomRequest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoomRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFSb29tUmVxdWVzdC5wcm90bxICcGIiLAoLUm9vbVJlcXVlc3QSCgoCaWQY",
            "ASABKAQSEQoJYXV0aHRva2VuGAIgASgMYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.RoomRequest), global::Pb.RoomRequest.Parser, new[]{ "Id", "Authtoken" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class RoomRequest : pb::IMessage<RoomRequest> {
    private static readonly pb::MessageParser<RoomRequest> _parser = new pb::MessageParser<RoomRequest>(() => new RoomRequest());
    public static pb::MessageParser<RoomRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.RoomRequestReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public RoomRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public RoomRequest(RoomRequest other) : this() {
      id_ = other.id_;
      authtoken_ = other.authtoken_;
    }

    public RoomRequest Clone() {
      return new RoomRequest(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private ulong id_;
    public ulong Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "authtoken" field.</summary>
    public const int AuthtokenFieldNumber = 2;
    private pb::ByteString authtoken_ = pb::ByteString.Empty;
    public pb::ByteString Authtoken {
      get { return authtoken_; }
      set {
        authtoken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as RoomRequest);
    }

    public bool Equals(RoomRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Authtoken != other.Authtoken) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0UL) hash ^= Id.GetHashCode();
      if (Authtoken.Length != 0) hash ^= Authtoken.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Id);
      }
      if (Authtoken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Authtoken);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Id != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Id);
      }
      if (Authtoken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Authtoken);
      }
      return size;
    }

    public void MergeFrom(RoomRequest other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0UL) {
        Id = other.Id;
      }
      if (other.Authtoken.Length != 0) {
        Authtoken = other.Authtoken;
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
            Id = input.ReadUInt64();
            break;
          }
          case 18: {
            Authtoken = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
