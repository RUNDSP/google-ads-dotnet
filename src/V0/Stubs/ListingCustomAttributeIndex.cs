// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/listing_custom_attribute_index.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/listing_custom_attribute_index.proto</summary>
  public static partial class ListingCustomAttributeIndexReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/listing_custom_attribute_index.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ListingCustomAttributeIndexReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9saXN0aW5nX2N1c3Rv",
            "bV9hdHRyaWJ1dGVfaW5kZXgucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYwLmVudW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvItcBCh9M",
            "aXN0aW5nQ3VzdG9tQXR0cmlidXRlSW5kZXhFbnVtIrMBChtMaXN0aW5nQ3Vz",
            "dG9tQXR0cmlidXRlSW5kZXgSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dO",
            "EAESFgoSQ1VTVE9NX0FUVFJJQlVURV8wEAISFgoSQ1VTVE9NX0FUVFJJQlVU",
            "RV8xEAMSFgoSQ1VTVE9NX0FUVFJJQlVURV8yEAQSFgoSQ1VTVE9NX0FUVFJJ",
            "QlVURV8zEAUSFgoSQ1VTVE9NX0FUVFJJQlVURV80EAZC9QEKIWNvbS5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52MC5lbnVtc0IgTGlzdGluZ0N1c3RvbUF0dHJp",
            "YnV0ZUluZGV4UHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YwL2VudW1zO2VudW1zogIDR0FB",
            "qgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjAuRW51bXPKAh1Hb29nbGVcQWRz",
            "XEdvb2dsZUFkc1xWMFxFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6",
            "OlYwOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.ListingCustomAttributeIndexEnum), global::Google.Ads.GoogleAds.V0.Enums.ListingCustomAttributeIndexEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.ListingCustomAttributeIndexEnum.Types.ListingCustomAttributeIndex) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the index of the listing custom attribute.
  /// </summary>
  public sealed partial class ListingCustomAttributeIndexEnum : pb::IMessage<ListingCustomAttributeIndexEnum> {
    private static readonly pb::MessageParser<ListingCustomAttributeIndexEnum> _parser = new pb::MessageParser<ListingCustomAttributeIndexEnum>(() => new ListingCustomAttributeIndexEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListingCustomAttributeIndexEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.ListingCustomAttributeIndexReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListingCustomAttributeIndexEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListingCustomAttributeIndexEnum(ListingCustomAttributeIndexEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListingCustomAttributeIndexEnum Clone() {
      return new ListingCustomAttributeIndexEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListingCustomAttributeIndexEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListingCustomAttributeIndexEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListingCustomAttributeIndexEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ListingCustomAttributeIndexEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The index of the listing custom attribute.
      /// </summary>
      public enum ListingCustomAttributeIndex {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// First listing custom attribute.
        /// </summary>
        [pbr::OriginalName("CUSTOM_ATTRIBUTE_0")] CustomAttribute0 = 2,
        /// <summary>
        /// Second listing custom attribute.
        /// </summary>
        [pbr::OriginalName("CUSTOM_ATTRIBUTE_1")] CustomAttribute1 = 3,
        /// <summary>
        /// Third listing custom attribute.
        /// </summary>
        [pbr::OriginalName("CUSTOM_ATTRIBUTE_2")] CustomAttribute2 = 4,
        /// <summary>
        /// Fourth listing custom attribute.
        /// </summary>
        [pbr::OriginalName("CUSTOM_ATTRIBUTE_3")] CustomAttribute3 = 5,
        /// <summary>
        /// Fifth listing custom attribute.
        /// </summary>
        [pbr::OriginalName("CUSTOM_ATTRIBUTE_4")] CustomAttribute4 = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
