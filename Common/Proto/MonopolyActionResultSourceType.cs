// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonopolyActionResultSourceType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MonopolyActionResultSourceType.proto</summary>
  public static partial class MonopolyActionResultSourceTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for MonopolyActionResultSourceType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonopolyActionResultSourceTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRNb25vcG9seUFjdGlvblJlc3VsdFNvdXJjZVR5cGUucHJvdG8qrAMKHk1v",
            "bm9wb2x5QWN0aW9uUmVzdWx0U291cmNlVHlwZRIrCidNT05PUE9MWV9BQ1RJ",
            "T05fUkVTVUxUX1NPVVJDRV9UWVBFX05PTkUQABItCilNT05PUE9MWV9BQ1RJ",
            "T05fUkVTVUxUX1NPVVJDRV9UWVBFX0VGRkVDVBABEjIKLk1PTk9QT0xZX0FD",
            "VElPTl9SRVNVTFRfU09VUkNFX1RZUEVfQVNTRVRfQk9OVVMQAhIwCixNT05P",
            "UE9MWV9BQ1RJT05fUkVTVUxUX1NPVVJDRV9UWVBFX0FTU0VUX1RBWBADEjQK",
            "ME1PTk9QT0xZX0FDVElPTl9SRVNVTFRfU09VUkNFX1RZUEVfQVNTRVRfVVBH",
            "UkFERRAEEjIKLk1PTk9QT0xZX0FDVElPTl9SRVNVTFRfU09VUkNFX1RZUEVf",
            "R0FNRV9TRVRUTEUQBRIwCixNT05PUE9MWV9BQ1RJT05fUkVTVUxUX1NPVVJD",
            "RV9UWVBFX0JVWV9HT09EUxAGEiwKKE1PTk9QT0xZX0FDVElPTl9SRVNVTFRf",
            "U09VUkNFX1RZUEVfQ0xJQ0sQB0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.MonopolyActionResultSourceType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum MonopolyActionResultSourceType {
    [pbr::OriginalName("MONOPOLY_ACTION_RESULT_SOURCE_TYPE_NONE")] None = 0,
    [pbr::OriginalName("MONOPOLY_ACTION_RESULT_SOURCE_TYPE_EFFECT")] Effect = 1,
    [pbr::OriginalName("MONOPOLY_ACTION_RESULT_SOURCE_TYPE_ASSET_BONUS")] AssetBonus = 2,
    [pbr::OriginalName("MONOPOLY_ACTION_RESULT_SOURCE_TYPE_ASSET_TAX")] AssetTax = 3,
    [pbr::OriginalName("MONOPOLY_ACTION_RESULT_SOURCE_TYPE_ASSET_UPGRADE")] AssetUpgrade = 4,
    [pbr::OriginalName("MONOPOLY_ACTION_RESULT_SOURCE_TYPE_GAME_SETTLE")] GameSettle = 5,
    [pbr::OriginalName("MONOPOLY_ACTION_RESULT_SOURCE_TYPE_BUY_GOODS")] BuyGoods = 6,
    [pbr::OriginalName("MONOPOLY_ACTION_RESULT_SOURCE_TYPE_CLICK")] Click = 7,
  }

  #endregion

}

#endregion Designer generated code
