// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OBAEGEOBMNJ.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from OBAEGEOBMNJ.proto</summary>
  public static partial class OBAEGEOBMNJReflection {

    #region Descriptor
    /// <summary>File descriptor for OBAEGEOBMNJ.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OBAEGEOBMNJReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFPQkFFR0VPQk1OSi5wcm90byJXCgtPQkFFR0VPQk1OShILCgNleHAYAiAB",
            "KA0SDAoEcmFuaxgBIAEoDRILCgN0aWQYDCABKA0SDQoFbGV2ZWwYDSABKA0S",
            "EQoJcHJvbW90aW9uGA8gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.OBAEGEOBMNJ), global::EggLink.DanhengServer.Proto.OBAEGEOBMNJ.Parser, new[]{ "Exp", "Rank", "Tid", "Level", "Promotion" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class OBAEGEOBMNJ : pb::IMessage<OBAEGEOBMNJ>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OBAEGEOBMNJ> _parser = new pb::MessageParser<OBAEGEOBMNJ>(() => new OBAEGEOBMNJ());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OBAEGEOBMNJ> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.OBAEGEOBMNJReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OBAEGEOBMNJ() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OBAEGEOBMNJ(OBAEGEOBMNJ other) : this() {
      exp_ = other.exp_;
      rank_ = other.rank_;
      tid_ = other.tid_;
      level_ = other.level_;
      promotion_ = other.promotion_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OBAEGEOBMNJ Clone() {
      return new OBAEGEOBMNJ(this);
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 2;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "rank" field.</summary>
    public const int RankFieldNumber = 1;
    private uint rank_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Rank {
      get { return rank_; }
      set {
        rank_ = value;
      }
    }

    /// <summary>Field number for the "tid" field.</summary>
    public const int TidFieldNumber = 12;
    private uint tid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Tid {
      get { return tid_; }
      set {
        tid_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 13;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "promotion" field.</summary>
    public const int PromotionFieldNumber = 15;
    private uint promotion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Promotion {
      get { return promotion_; }
      set {
        promotion_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OBAEGEOBMNJ);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OBAEGEOBMNJ other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Exp != other.Exp) return false;
      if (Rank != other.Rank) return false;
      if (Tid != other.Tid) return false;
      if (Level != other.Level) return false;
      if (Promotion != other.Promotion) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (Rank != 0) hash ^= Rank.GetHashCode();
      if (Tid != 0) hash ^= Tid.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (Promotion != 0) hash ^= Promotion.GetHashCode();
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
      if (Rank != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Rank);
      }
      if (Exp != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Exp);
      }
      if (Tid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Tid);
      }
      if (Level != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Level);
      }
      if (Promotion != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Promotion);
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
      if (Rank != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Rank);
      }
      if (Exp != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Exp);
      }
      if (Tid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Tid);
      }
      if (Level != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Level);
      }
      if (Promotion != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Promotion);
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
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (Rank != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Rank);
      }
      if (Tid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Tid);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (Promotion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Promotion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OBAEGEOBMNJ other) {
      if (other == null) {
        return;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.Rank != 0) {
        Rank = other.Rank;
      }
      if (other.Tid != 0) {
        Tid = other.Tid;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.Promotion != 0) {
        Promotion = other.Promotion;
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
          case 8: {
            Rank = input.ReadUInt32();
            break;
          }
          case 16: {
            Exp = input.ReadUInt32();
            break;
          }
          case 96: {
            Tid = input.ReadUInt32();
            break;
          }
          case 104: {
            Level = input.ReadUInt32();
            break;
          }
          case 120: {
            Promotion = input.ReadUInt32();
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
          case 8: {
            Rank = input.ReadUInt32();
            break;
          }
          case 16: {
            Exp = input.ReadUInt32();
            break;
          }
          case 96: {
            Tid = input.ReadUInt32();
            break;
          }
          case 104: {
            Level = input.ReadUInt32();
            break;
          }
          case 120: {
            Promotion = input.ReadUInt32();
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
