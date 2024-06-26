// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PropExtraInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PropExtraInfo.proto</summary>
  public static partial class PropExtraInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for PropExtraInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PropExtraInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQcm9wRXh0cmFJbmZvLnByb3RvGhJQcm9wQWVvbkluZm8ucHJvdG8aE1By",
            "b3BSb2d1ZUluZm8ucHJvdG8aGFByb3BDaGVzc1JvZ3VlSW5mby5wcm90byKE",
            "AQoNUHJvcEV4dHJhSW5mbxIiCgpyb2d1ZV9pbmZvGAwgASgLMg4uUHJvcFJv",
            "Z3VlSW5mbxIgCglhZW9uX2luZm8YDyABKAsyDS5Qcm9wQWVvbkluZm8SLQoQ",
            "Y2hlc3Nfcm9ndWVfaW5mbxgLIAEoCzITLlByb3BDaGVzc1JvZ3VlSW5mb0Ie",
            "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PropAeonInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.PropRogueInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.PropChessRogueInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PropExtraInfo), global::EggLink.DanhengServer.Proto.PropExtraInfo.Parser, new[]{ "RogueInfo", "AeonInfo", "ChessRogueInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PropExtraInfo : pb::IMessage<PropExtraInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PropExtraInfo> _parser = new pb::MessageParser<PropExtraInfo>(() => new PropExtraInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PropExtraInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PropExtraInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PropExtraInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PropExtraInfo(PropExtraInfo other) : this() {
      rogueInfo_ = other.rogueInfo_ != null ? other.rogueInfo_.Clone() : null;
      aeonInfo_ = other.aeonInfo_ != null ? other.aeonInfo_.Clone() : null;
      chessRogueInfo_ = other.chessRogueInfo_ != null ? other.chessRogueInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PropExtraInfo Clone() {
      return new PropExtraInfo(this);
    }

    /// <summary>Field number for the "rogue_info" field.</summary>
    public const int RogueInfoFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.PropRogueInfo rogueInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PropRogueInfo RogueInfo {
      get { return rogueInfo_; }
      set {
        rogueInfo_ = value;
      }
    }

    /// <summary>Field number for the "aeon_info" field.</summary>
    public const int AeonInfoFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.PropAeonInfo aeonInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PropAeonInfo AeonInfo {
      get { return aeonInfo_; }
      set {
        aeonInfo_ = value;
      }
    }

    /// <summary>Field number for the "chess_rogue_info" field.</summary>
    public const int ChessRogueInfoFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.PropChessRogueInfo chessRogueInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PropChessRogueInfo ChessRogueInfo {
      get { return chessRogueInfo_; }
      set {
        chessRogueInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PropExtraInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PropExtraInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueInfo, other.RogueInfo)) return false;
      if (!object.Equals(AeonInfo, other.AeonInfo)) return false;
      if (!object.Equals(ChessRogueInfo, other.ChessRogueInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueInfo_ != null) hash ^= RogueInfo.GetHashCode();
      if (aeonInfo_ != null) hash ^= AeonInfo.GetHashCode();
      if (chessRogueInfo_ != null) hash ^= ChessRogueInfo.GetHashCode();
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
      if (chessRogueInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(ChessRogueInfo);
      }
      if (rogueInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(RogueInfo);
      }
      if (aeonInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(AeonInfo);
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
      if (chessRogueInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(ChessRogueInfo);
      }
      if (rogueInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(RogueInfo);
      }
      if (aeonInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(AeonInfo);
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
      if (rogueInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueInfo);
      }
      if (aeonInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AeonInfo);
      }
      if (chessRogueInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChessRogueInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PropExtraInfo other) {
      if (other == null) {
        return;
      }
      if (other.rogueInfo_ != null) {
        if (rogueInfo_ == null) {
          RogueInfo = new global::EggLink.DanhengServer.Proto.PropRogueInfo();
        }
        RogueInfo.MergeFrom(other.RogueInfo);
      }
      if (other.aeonInfo_ != null) {
        if (aeonInfo_ == null) {
          AeonInfo = new global::EggLink.DanhengServer.Proto.PropAeonInfo();
        }
        AeonInfo.MergeFrom(other.AeonInfo);
      }
      if (other.chessRogueInfo_ != null) {
        if (chessRogueInfo_ == null) {
          ChessRogueInfo = new global::EggLink.DanhengServer.Proto.PropChessRogueInfo();
        }
        ChessRogueInfo.MergeFrom(other.ChessRogueInfo);
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
          case 90: {
            if (chessRogueInfo_ == null) {
              ChessRogueInfo = new global::EggLink.DanhengServer.Proto.PropChessRogueInfo();
            }
            input.ReadMessage(ChessRogueInfo);
            break;
          }
          case 98: {
            if (rogueInfo_ == null) {
              RogueInfo = new global::EggLink.DanhengServer.Proto.PropRogueInfo();
            }
            input.ReadMessage(RogueInfo);
            break;
          }
          case 122: {
            if (aeonInfo_ == null) {
              AeonInfo = new global::EggLink.DanhengServer.Proto.PropAeonInfo();
            }
            input.ReadMessage(AeonInfo);
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
          case 90: {
            if (chessRogueInfo_ == null) {
              ChessRogueInfo = new global::EggLink.DanhengServer.Proto.PropChessRogueInfo();
            }
            input.ReadMessage(ChessRogueInfo);
            break;
          }
          case 98: {
            if (rogueInfo_ == null) {
              RogueInfo = new global::EggLink.DanhengServer.Proto.PropRogueInfo();
            }
            input.ReadMessage(RogueInfo);
            break;
          }
          case 122: {
            if (aeonInfo_ == null) {
              AeonInfo = new global::EggLink.DanhengServer.Proto.PropAeonInfo();
            }
            input.ReadMessage(AeonInfo);
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
