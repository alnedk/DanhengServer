// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetAssistHistoryScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetAssistHistoryScRsp.proto</summary>
  public static partial class GetAssistHistoryScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetAssistHistoryScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetAssistHistoryScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtHZXRBc3Npc3RIaXN0b3J5U2NSc3AucHJvdG8igwEKFUdldEFzc2lzdEhp",
            "c3RvcnlTY1JzcBITCgtOQUVMSk1KSUpFRhgIIAEoDRIaChJ0b2RheV91c2Vf",
            "dWlkX2xpc3QYBCADKA0SEwoLR01DSUVDSklHTE8YBSABKA0SDwoHcmV0Y29k",
            "ZRgJIAEoDRITCgtDREFJT0JCR1BGShgLIAEoDUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetAssistHistoryScRsp), global::EggLink.DanhengServer.Proto.GetAssistHistoryScRsp.Parser, new[]{ "NAELJMJIJEF", "TodayUseUidList", "GMCIECJIGLO", "Retcode", "CDAIOBBGPFJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetAssistHistoryScRsp : pb::IMessage<GetAssistHistoryScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAssistHistoryScRsp> _parser = new pb::MessageParser<GetAssistHistoryScRsp>(() => new GetAssistHistoryScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetAssistHistoryScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetAssistHistoryScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAssistHistoryScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAssistHistoryScRsp(GetAssistHistoryScRsp other) : this() {
      nAELJMJIJEF_ = other.nAELJMJIJEF_;
      todayUseUidList_ = other.todayUseUidList_.Clone();
      gMCIECJIGLO_ = other.gMCIECJIGLO_;
      retcode_ = other.retcode_;
      cDAIOBBGPFJ_ = other.cDAIOBBGPFJ_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAssistHistoryScRsp Clone() {
      return new GetAssistHistoryScRsp(this);
    }

    /// <summary>Field number for the "NAELJMJIJEF" field.</summary>
    public const int NAELJMJIJEFFieldNumber = 8;
    private uint nAELJMJIJEF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NAELJMJIJEF {
      get { return nAELJMJIJEF_; }
      set {
        nAELJMJIJEF_ = value;
      }
    }

    /// <summary>Field number for the "today_use_uid_list" field.</summary>
    public const int TodayUseUidListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_todayUseUidList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> todayUseUidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TodayUseUidList {
      get { return todayUseUidList_; }
    }

    /// <summary>Field number for the "GMCIECJIGLO" field.</summary>
    public const int GMCIECJIGLOFieldNumber = 5;
    private uint gMCIECJIGLO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GMCIECJIGLO {
      get { return gMCIECJIGLO_; }
      set {
        gMCIECJIGLO_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 9;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "CDAIOBBGPFJ" field.</summary>
    public const int CDAIOBBGPFJFieldNumber = 11;
    private uint cDAIOBBGPFJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CDAIOBBGPFJ {
      get { return cDAIOBBGPFJ_; }
      set {
        cDAIOBBGPFJ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetAssistHistoryScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetAssistHistoryScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NAELJMJIJEF != other.NAELJMJIJEF) return false;
      if(!todayUseUidList_.Equals(other.todayUseUidList_)) return false;
      if (GMCIECJIGLO != other.GMCIECJIGLO) return false;
      if (Retcode != other.Retcode) return false;
      if (CDAIOBBGPFJ != other.CDAIOBBGPFJ) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NAELJMJIJEF != 0) hash ^= NAELJMJIJEF.GetHashCode();
      hash ^= todayUseUidList_.GetHashCode();
      if (GMCIECJIGLO != 0) hash ^= GMCIECJIGLO.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (CDAIOBBGPFJ != 0) hash ^= CDAIOBBGPFJ.GetHashCode();
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
      todayUseUidList_.WriteTo(output, _repeated_todayUseUidList_codec);
      if (GMCIECJIGLO != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GMCIECJIGLO);
      }
      if (NAELJMJIJEF != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(NAELJMJIJEF);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Retcode);
      }
      if (CDAIOBBGPFJ != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CDAIOBBGPFJ);
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
      todayUseUidList_.WriteTo(ref output, _repeated_todayUseUidList_codec);
      if (GMCIECJIGLO != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GMCIECJIGLO);
      }
      if (NAELJMJIJEF != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(NAELJMJIJEF);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Retcode);
      }
      if (CDAIOBBGPFJ != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CDAIOBBGPFJ);
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
      if (NAELJMJIJEF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NAELJMJIJEF);
      }
      size += todayUseUidList_.CalculateSize(_repeated_todayUseUidList_codec);
      if (GMCIECJIGLO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GMCIECJIGLO);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (CDAIOBBGPFJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CDAIOBBGPFJ);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetAssistHistoryScRsp other) {
      if (other == null) {
        return;
      }
      if (other.NAELJMJIJEF != 0) {
        NAELJMJIJEF = other.NAELJMJIJEF;
      }
      todayUseUidList_.Add(other.todayUseUidList_);
      if (other.GMCIECJIGLO != 0) {
        GMCIECJIGLO = other.GMCIECJIGLO;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.CDAIOBBGPFJ != 0) {
        CDAIOBBGPFJ = other.CDAIOBBGPFJ;
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
          case 34:
          case 32: {
            todayUseUidList_.AddEntriesFrom(input, _repeated_todayUseUidList_codec);
            break;
          }
          case 40: {
            GMCIECJIGLO = input.ReadUInt32();
            break;
          }
          case 64: {
            NAELJMJIJEF = input.ReadUInt32();
            break;
          }
          case 72: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 88: {
            CDAIOBBGPFJ = input.ReadUInt32();
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
          case 34:
          case 32: {
            todayUseUidList_.AddEntriesFrom(ref input, _repeated_todayUseUidList_codec);
            break;
          }
          case 40: {
            GMCIECJIGLO = input.ReadUInt32();
            break;
          }
          case 64: {
            NAELJMJIJEF = input.ReadUInt32();
            break;
          }
          case 72: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 88: {
            CDAIOBBGPFJ = input.ReadUInt32();
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