// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneCastSkillCostMpCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SceneCastSkillCostMpCsReq.proto</summary>
  public static partial class SceneCastSkillCostMpCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneCastSkillCostMpCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneCastSkillCostMpCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9TY2VuZUNhc3RTa2lsbENvc3RNcENzUmVxLnByb3RvImcKGVNjZW5lQ2Fz",
            "dFNraWxsQ29zdE1wQ3NSZXESFgoOY2FzdF9lbnRpdHlfaWQYBiABKA0SEwoL",
            "c2tpbGxfaW5kZXgYDyABKA0SHQoVYXR0YWNrZWRfYnlfZW50aXR5X2lkGAsg",
            "ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SceneCastSkillCostMpCsReq), global::EggLink.DanhengServer.Proto.SceneCastSkillCostMpCsReq.Parser, new[]{ "CastEntityId", "SkillIndex", "AttackedByEntityId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SceneCastSkillCostMpCsReq : pb::IMessage<SceneCastSkillCostMpCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneCastSkillCostMpCsReq> _parser = new pb::MessageParser<SceneCastSkillCostMpCsReq>(() => new SceneCastSkillCostMpCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneCastSkillCostMpCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SceneCastSkillCostMpCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneCastSkillCostMpCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneCastSkillCostMpCsReq(SceneCastSkillCostMpCsReq other) : this() {
      castEntityId_ = other.castEntityId_;
      skillIndex_ = other.skillIndex_;
      attackedByEntityId_ = other.attackedByEntityId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneCastSkillCostMpCsReq Clone() {
      return new SceneCastSkillCostMpCsReq(this);
    }

    /// <summary>Field number for the "cast_entity_id" field.</summary>
    public const int CastEntityIdFieldNumber = 6;
    private uint castEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CastEntityId {
      get { return castEntityId_; }
      set {
        castEntityId_ = value;
      }
    }

    /// <summary>Field number for the "skill_index" field.</summary>
    public const int SkillIndexFieldNumber = 15;
    private uint skillIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkillIndex {
      get { return skillIndex_; }
      set {
        skillIndex_ = value;
      }
    }

    /// <summary>Field number for the "attacked_by_entity_id" field.</summary>
    public const int AttackedByEntityIdFieldNumber = 11;
    private uint attackedByEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AttackedByEntityId {
      get { return attackedByEntityId_; }
      set {
        attackedByEntityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneCastSkillCostMpCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneCastSkillCostMpCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CastEntityId != other.CastEntityId) return false;
      if (SkillIndex != other.SkillIndex) return false;
      if (AttackedByEntityId != other.AttackedByEntityId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CastEntityId != 0) hash ^= CastEntityId.GetHashCode();
      if (SkillIndex != 0) hash ^= SkillIndex.GetHashCode();
      if (AttackedByEntityId != 0) hash ^= AttackedByEntityId.GetHashCode();
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
      if (CastEntityId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CastEntityId);
      }
      if (AttackedByEntityId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(AttackedByEntityId);
      }
      if (SkillIndex != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SkillIndex);
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
      if (CastEntityId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CastEntityId);
      }
      if (AttackedByEntityId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(AttackedByEntityId);
      }
      if (SkillIndex != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SkillIndex);
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
      if (CastEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CastEntityId);
      }
      if (SkillIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillIndex);
      }
      if (AttackedByEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AttackedByEntityId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneCastSkillCostMpCsReq other) {
      if (other == null) {
        return;
      }
      if (other.CastEntityId != 0) {
        CastEntityId = other.CastEntityId;
      }
      if (other.SkillIndex != 0) {
        SkillIndex = other.SkillIndex;
      }
      if (other.AttackedByEntityId != 0) {
        AttackedByEntityId = other.AttackedByEntityId;
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
          case 48: {
            CastEntityId = input.ReadUInt32();
            break;
          }
          case 88: {
            AttackedByEntityId = input.ReadUInt32();
            break;
          }
          case 120: {
            SkillIndex = input.ReadUInt32();
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
          case 48: {
            CastEntityId = input.ReadUInt32();
            break;
          }
          case 88: {
            AttackedByEntityId = input.ReadUInt32();
            break;
          }
          case 120: {
            SkillIndex = input.ReadUInt32();
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