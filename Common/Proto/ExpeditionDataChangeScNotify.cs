// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ExpeditionDataChangeScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ExpeditionDataChangeScNotify.proto</summary>
  public static partial class ExpeditionDataChangeScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ExpeditionDataChangeScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExpeditionDataChangeScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJFeHBlZGl0aW9uRGF0YUNoYW5nZVNjTm90aWZ5LnByb3RvGhhBY3Rpdml0",
            "eUV4cGVkaXRpb24ucHJvdG8aEEV4cGVkaXRpb24ucHJvdG8iqQEKHEV4cGVk",
            "aXRpb25EYXRhQ2hhbmdlU2NOb3RpZnkSIAoLRUxFRE1LR0ZDSUYYByADKAsy",
            "Cy5FeHBlZGl0aW9uEhMKC0RDRUxDUE1GT0hCGAogASgNEhMKC0tFSUFLUE9F",
            "RU5OGAwgAygNEigKC05QUEZEQklBUE5FGA0gAygLMhMuQWN0aXZpdHlFeHBl",
            "ZGl0aW9uEhMKC0hISk1ESENLQ0VEGAsgAygNQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ActivityExpeditionReflection.Descriptor, global::EggLink.DanhengServer.Proto.ExpeditionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ExpeditionDataChangeScNotify), global::EggLink.DanhengServer.Proto.ExpeditionDataChangeScNotify.Parser, new[]{ "ELEDMKGFCIF", "DCELCPMFOHB", "KEIAKPOEENN", "NPPFDBIAPNE", "HHJMDHCKCED" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ExpeditionDataChangeScNotify : pb::IMessage<ExpeditionDataChangeScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExpeditionDataChangeScNotify> _parser = new pb::MessageParser<ExpeditionDataChangeScNotify>(() => new ExpeditionDataChangeScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExpeditionDataChangeScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ExpeditionDataChangeScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExpeditionDataChangeScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExpeditionDataChangeScNotify(ExpeditionDataChangeScNotify other) : this() {
      eLEDMKGFCIF_ = other.eLEDMKGFCIF_.Clone();
      dCELCPMFOHB_ = other.dCELCPMFOHB_;
      kEIAKPOEENN_ = other.kEIAKPOEENN_.Clone();
      nPPFDBIAPNE_ = other.nPPFDBIAPNE_.Clone();
      hHJMDHCKCED_ = other.hHJMDHCKCED_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExpeditionDataChangeScNotify Clone() {
      return new ExpeditionDataChangeScNotify(this);
    }

    /// <summary>Field number for the "ELEDMKGFCIF" field.</summary>
    public const int ELEDMKGFCIFFieldNumber = 7;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Expedition> _repeated_eLEDMKGFCIF_codec
        = pb::FieldCodec.ForMessage(58, global::EggLink.DanhengServer.Proto.Expedition.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Expedition> eLEDMKGFCIF_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Expedition>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Expedition> ELEDMKGFCIF {
      get { return eLEDMKGFCIF_; }
    }

    /// <summary>Field number for the "DCELCPMFOHB" field.</summary>
    public const int DCELCPMFOHBFieldNumber = 10;
    private uint dCELCPMFOHB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DCELCPMFOHB {
      get { return dCELCPMFOHB_; }
      set {
        dCELCPMFOHB_ = value;
      }
    }

    /// <summary>Field number for the "KEIAKPOEENN" field.</summary>
    public const int KEIAKPOEENNFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_kEIAKPOEENN_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> kEIAKPOEENN_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> KEIAKPOEENN {
      get { return kEIAKPOEENN_; }
    }

    /// <summary>Field number for the "NPPFDBIAPNE" field.</summary>
    public const int NPPFDBIAPNEFieldNumber = 13;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ActivityExpedition> _repeated_nPPFDBIAPNE_codec
        = pb::FieldCodec.ForMessage(106, global::EggLink.DanhengServer.Proto.ActivityExpedition.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ActivityExpedition> nPPFDBIAPNE_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ActivityExpedition>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ActivityExpedition> NPPFDBIAPNE {
      get { return nPPFDBIAPNE_; }
    }

    /// <summary>Field number for the "HHJMDHCKCED" field.</summary>
    public const int HHJMDHCKCEDFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_hHJMDHCKCED_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> hHJMDHCKCED_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HHJMDHCKCED {
      get { return hHJMDHCKCED_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExpeditionDataChangeScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExpeditionDataChangeScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!eLEDMKGFCIF_.Equals(other.eLEDMKGFCIF_)) return false;
      if (DCELCPMFOHB != other.DCELCPMFOHB) return false;
      if(!kEIAKPOEENN_.Equals(other.kEIAKPOEENN_)) return false;
      if(!nPPFDBIAPNE_.Equals(other.nPPFDBIAPNE_)) return false;
      if(!hHJMDHCKCED_.Equals(other.hHJMDHCKCED_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= eLEDMKGFCIF_.GetHashCode();
      if (DCELCPMFOHB != 0) hash ^= DCELCPMFOHB.GetHashCode();
      hash ^= kEIAKPOEENN_.GetHashCode();
      hash ^= nPPFDBIAPNE_.GetHashCode();
      hash ^= hHJMDHCKCED_.GetHashCode();
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
      eLEDMKGFCIF_.WriteTo(output, _repeated_eLEDMKGFCIF_codec);
      if (DCELCPMFOHB != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DCELCPMFOHB);
      }
      hHJMDHCKCED_.WriteTo(output, _repeated_hHJMDHCKCED_codec);
      kEIAKPOEENN_.WriteTo(output, _repeated_kEIAKPOEENN_codec);
      nPPFDBIAPNE_.WriteTo(output, _repeated_nPPFDBIAPNE_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      eLEDMKGFCIF_.WriteTo(ref output, _repeated_eLEDMKGFCIF_codec);
      if (DCELCPMFOHB != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DCELCPMFOHB);
      }
      hHJMDHCKCED_.WriteTo(ref output, _repeated_hHJMDHCKCED_codec);
      kEIAKPOEENN_.WriteTo(ref output, _repeated_kEIAKPOEENN_codec);
      nPPFDBIAPNE_.WriteTo(ref output, _repeated_nPPFDBIAPNE_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += eLEDMKGFCIF_.CalculateSize(_repeated_eLEDMKGFCIF_codec);
      if (DCELCPMFOHB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DCELCPMFOHB);
      }
      size += kEIAKPOEENN_.CalculateSize(_repeated_kEIAKPOEENN_codec);
      size += nPPFDBIAPNE_.CalculateSize(_repeated_nPPFDBIAPNE_codec);
      size += hHJMDHCKCED_.CalculateSize(_repeated_hHJMDHCKCED_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ExpeditionDataChangeScNotify other) {
      if (other == null) {
        return;
      }
      eLEDMKGFCIF_.Add(other.eLEDMKGFCIF_);
      if (other.DCELCPMFOHB != 0) {
        DCELCPMFOHB = other.DCELCPMFOHB;
      }
      kEIAKPOEENN_.Add(other.kEIAKPOEENN_);
      nPPFDBIAPNE_.Add(other.nPPFDBIAPNE_);
      hHJMDHCKCED_.Add(other.hHJMDHCKCED_);
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
          case 58: {
            eLEDMKGFCIF_.AddEntriesFrom(input, _repeated_eLEDMKGFCIF_codec);
            break;
          }
          case 80: {
            DCELCPMFOHB = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            hHJMDHCKCED_.AddEntriesFrom(input, _repeated_hHJMDHCKCED_codec);
            break;
          }
          case 98:
          case 96: {
            kEIAKPOEENN_.AddEntriesFrom(input, _repeated_kEIAKPOEENN_codec);
            break;
          }
          case 106: {
            nPPFDBIAPNE_.AddEntriesFrom(input, _repeated_nPPFDBIAPNE_codec);
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
          case 58: {
            eLEDMKGFCIF_.AddEntriesFrom(ref input, _repeated_eLEDMKGFCIF_codec);
            break;
          }
          case 80: {
            DCELCPMFOHB = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            hHJMDHCKCED_.AddEntriesFrom(ref input, _repeated_hHJMDHCKCED_codec);
            break;
          }
          case 98:
          case 96: {
            kEIAKPOEENN_.AddEntriesFrom(ref input, _repeated_kEIAKPOEENN_codec);
            break;
          }
          case 106: {
            nPPFDBIAPNE_.AddEntriesFrom(ref input, _repeated_nPPFDBIAPNE_codec);
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