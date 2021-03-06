// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/services/display_keyword_view_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/services/display_keyword_view_service.proto</summary>
  public static partial class DisplayKeywordViewServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/services/display_keyword_view_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DisplayKeywordViewServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9zZXJ2aWNlcy9kaXNwbGF5X2tl",
            "eXdvcmRfdmlld19zZXJ2aWNlLnByb3RvEiBnb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MS5zZXJ2aWNlcxo8Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjEvcmVzb3Vy",
            "Y2VzL2Rpc3BsYXlfa2V5d29yZF92aWV3LnByb3RvGhxnb29nbGUvYXBpL2Fu",
            "bm90YXRpb25zLnByb3RvIjUKHEdldERpc3BsYXlLZXl3b3JkVmlld1JlcXVl",
            "c3QSFQoNcmVzb3VyY2VfbmFtZRgBIAEoCTLrAQoZRGlzcGxheUtleXdvcmRW",
            "aWV3U2VydmljZRLNAQoVR2V0RGlzcGxheUtleXdvcmRWaWV3Ej4uZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjEuc2VydmljZXMuR2V0RGlzcGxheUtleXdvcmRW",
            "aWV3UmVxdWVzdBo1Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLnJlc291cmNl",
            "cy5EaXNwbGF5S2V5d29yZFZpZXciPYLT5JMCNxI1L3YxL3tyZXNvdXJjZV9u",
            "YW1lPWN1c3RvbWVycy8qL2Rpc3BsYXlLZXl3b3JkVmlld3MvKn1ChQIKJGNv",
            "bS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5zZXJ2aWNlc0IeRGlzcGxheUtl",
            "eXdvcmRWaWV3U2VydmljZVByb3RvUAFaSGdvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MS9zZXJ2aWNlcztz",
            "ZXJ2aWNlc6ICA0dBQaoCIEdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxLlNlcnZp",
            "Y2VzygIgR29vZ2xlXEFkc1xHb29nbGVBZHNcVjFcU2VydmljZXPqAiRHb29n",
            "bGU6OkFkczo6R29vZ2xlQWRzOjpWMTo6U2VydmljZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V1.Resources.DisplayKeywordViewReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Services.GetDisplayKeywordViewRequest), global::Google.Ads.GoogleAds.V1.Services.GetDisplayKeywordViewRequest.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [DisplayKeywordViewService.GetDisplayKeywordView][google.ads.googleads.v1.services.DisplayKeywordViewService.GetDisplayKeywordView].
  /// </summary>
  public sealed partial class GetDisplayKeywordViewRequest : pb::IMessage<GetDisplayKeywordViewRequest> {
    private static readonly pb::MessageParser<GetDisplayKeywordViewRequest> _parser = new pb::MessageParser<GetDisplayKeywordViewRequest>(() => new GetDisplayKeywordViewRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetDisplayKeywordViewRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Services.DisplayKeywordViewServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetDisplayKeywordViewRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetDisplayKeywordViewRequest(GetDisplayKeywordViewRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetDisplayKeywordViewRequest Clone() {
      return new GetDisplayKeywordViewRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the display keyword view to fetch.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetDisplayKeywordViewRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetDisplayKeywordViewRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetDisplayKeywordViewRequest other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
