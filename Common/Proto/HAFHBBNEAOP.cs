// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HAFHBBNEAOP.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HAFHBBNEAOP.proto</summary>
  public static partial class HAFHBBNEAOPReflection {

    #region Descriptor
    /// <summary>File descriptor for HAFHBBNEAOP.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HAFHBBNEAOPReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFIQUZIQkJORUFPUC5wcm90byI5CgtIQUZIQkJORUFPUBITCgtNR0ZFREFB",
            "Rk9JQhgFIAEoDRIVCg1tYWluX3N0b3J5X2lkGA0gASgNQh6qAhtFZ2dMaW5r",
            "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HAFHBBNEAOP), global::EggLink.DanhengServer.Proto.HAFHBBNEAOP.Parser, new[]{ "MGFEDAAFOIB", "MainStoryId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HAFHBBNEAOP : pb::IMessage<HAFHBBNEAOP>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HAFHBBNEAOP> _parser = new pb::MessageParser<HAFHBBNEAOP>(() => new HAFHBBNEAOP());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HAFHBBNEAOP> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HAFHBBNEAOPReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HAFHBBNEAOP() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HAFHBBNEAOP(HAFHBBNEAOP other) : this() {
      mGFEDAAFOIB_ = other.mGFEDAAFOIB_;
      mainStoryId_ = other.mainStoryId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HAFHBBNEAOP Clone() {
      return new HAFHBBNEAOP(this);
    }

    /// <summary>Field number for the "MGFEDAAFOIB" field.</summary>
    public const int MGFEDAAFOIBFieldNumber = 5;
    private uint mGFEDAAFOIB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MGFEDAAFOIB {
      get { return mGFEDAAFOIB_; }
      set {
        mGFEDAAFOIB_ = value;
      }
    }

    /// <summary>Field number for the "main_story_id" field.</summary>
    public const int MainStoryIdFieldNumber = 13;
    private uint mainStoryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MainStoryId {
      get { return mainStoryId_; }
      set {
        mainStoryId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HAFHBBNEAOP);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HAFHBBNEAOP other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MGFEDAAFOIB != other.MGFEDAAFOIB) return false;
      if (MainStoryId != other.MainStoryId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MGFEDAAFOIB != 0) hash ^= MGFEDAAFOIB.GetHashCode();
      if (MainStoryId != 0) hash ^= MainStoryId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (MGFEDAAFOIB != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MGFEDAAFOIB);
      }
      if (MainStoryId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MainStoryId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (MGFEDAAFOIB != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MGFEDAAFOIB);
      }
      if (MainStoryId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MainStoryId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (MGFEDAAFOIB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MGFEDAAFOIB);
      }
      if (MainStoryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MainStoryId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HAFHBBNEAOP other) {
      if (other == null) {
        return;
      }
      if (other.MGFEDAAFOIB != 0) {
        MGFEDAAFOIB = other.MGFEDAAFOIB;
      }
      if (other.MainStoryId != 0) {
        MainStoryId = other.MainStoryId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 40: {
            MGFEDAAFOIB = input.ReadUInt32();
            break;
          }
          case 104: {
            MainStoryId = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 40: {
            MGFEDAAFOIB = input.ReadUInt32();
            break;
          }
          case 104: {
            MainStoryId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
