// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: JoinRoomRequest.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Pb {

  /// <summary>Holder for reflection information generated from JoinRoomRequest.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class JoinRoomRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for JoinRoomRequest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static JoinRoomRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVKb2luUm9vbVJlcXVlc3QucHJvdG8SAnBiIh0KD0pvaW5Sb29tUmVxdWVz",
            "dBIKCgJpZBgBIAEoBGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.JoinRoomRequest), global::Pb.JoinRoomRequest.Parser, new[]{ "Id" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class JoinRoomRequest : pb::IMessage<JoinRoomRequest> {
    private static readonly pb::MessageParser<JoinRoomRequest> _parser = new pb::MessageParser<JoinRoomRequest>(() => new JoinRoomRequest());
    public static pb::MessageParser<JoinRoomRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.JoinRoomRequestReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public JoinRoomRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public JoinRoomRequest(JoinRoomRequest other) : this() {
      id_ = other.id_;
    }

    public JoinRoomRequest Clone() {
      return new JoinRoomRequest(this);
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

    public override bool Equals(object other) {
      return Equals(other as JoinRoomRequest);
    }

    public bool Equals(JoinRoomRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0UL) hash ^= Id.GetHashCode();
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
    }

    public int CalculateSize() {
      int size = 0;
      if (Id != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Id);
      }
      return size;
    }

    public void MergeFrom(JoinRoomRequest other) {
      if (other == null) {
        return;
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