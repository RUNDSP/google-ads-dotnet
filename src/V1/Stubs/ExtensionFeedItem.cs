// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/resources/extension_feed_item.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/resources/extension_feed_item.proto</summary>
  public static partial class ExtensionFeedItemReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/resources/extension_feed_item.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExtensionFeedItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9yZXNvdXJjZXMvZXh0ZW5zaW9u",
            "X2ZlZWRfaXRlbS5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEucmVz",
            "b3VyY2VzGi9nb29nbGUvYWRzL2dvb2dsZWFkcy92MS9jb21tb24vZXh0ZW5z",
            "aW9ucy5wcm90bxoyZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjEvZW51bXMvZXh0",
            "ZW5zaW9uX3R5cGUucHJvdG8aNGdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxL2Vu",
            "dW1zL2ZlZWRfaXRlbV9zdGF0dXMucHJvdG8aHmdvb2dsZS9wcm90b2J1Zi93",
            "cmFwcGVycy5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byLP",
            "BwoRRXh0ZW5zaW9uRmVlZEl0ZW0SFQoNcmVzb3VyY2VfbmFtZRgBIAEoCRJW",
            "Cg5leHRlbnNpb25fdHlwZRgNIAEoDjI+Lmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYxLmVudW1zLkV4dGVuc2lvblR5cGVFbnVtLkV4dGVuc2lvblR5cGUSNQoP",
            "c3RhcnRfZGF0ZV90aW1lGAUgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmlu",
            "Z1ZhbHVlEjMKDWVuZF9kYXRlX3RpbWUYBiABKAsyHC5nb29nbGUucHJvdG9i",
            "dWYuU3RyaW5nVmFsdWUSUAoGc3RhdHVzGAQgASgOMkAuZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjEuZW51bXMuRmVlZEl0ZW1TdGF0dXNFbnVtLkZlZWRJdGVt",
            "U3RhdHVzEk4KEnNpdGVsaW5rX2ZlZWRfaXRlbRgCIAEoCzIwLmdvb2dsZS5h",
            "ZHMuZ29vZ2xlYWRzLnYxLmNvbW1vbi5TaXRlbGlua0ZlZWRJdGVtSAASYQoc",
            "c3RydWN0dXJlZF9zbmlwcGV0X2ZlZWRfaXRlbRgDIAEoCzI5Lmdvb2dsZS5h",
            "ZHMuZ29vZ2xlYWRzLnYxLmNvbW1vbi5TdHJ1Y3R1cmVkU25pcHBldEZlZWRJ",
            "dGVtSAASRAoNYXBwX2ZlZWRfaXRlbRgHIAEoCzIrLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYxLmNvbW1vbi5BcHBGZWVkSXRlbUgAEkYKDmNhbGxfZmVlZF9p",
            "dGVtGAggASgLMiwuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEuY29tbW9uLkNh",
            "bGxGZWVkSXRlbUgAEkwKEWNhbGxvdXRfZmVlZF9pdGVtGAkgASgLMi8uZ29v",
            "Z2xlLmFkcy5nb29nbGVhZHMudjEuY29tbW9uLkNhbGxvdXRGZWVkSXRlbUgA",
            "ElUKFnRleHRfbWVzc2FnZV9mZWVkX2l0ZW0YCiABKAsyMy5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52MS5jb21tb24uVGV4dE1lc3NhZ2VGZWVkSXRlbUgAEkgK",
            "D3ByaWNlX2ZlZWRfaXRlbRgLIAEoCzItLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYxLmNvbW1vbi5QcmljZUZlZWRJdGVtSAASUAoTcHJvbW90aW9uX2ZlZWRf",
            "aXRlbRgMIAEoCzIxLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLmNvbW1vbi5Q",
            "cm9tb3Rpb25GZWVkSXRlbUgAQgsKCWV4dGVuc2lvbkKDAgolY29tLmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnYxLnJlc291cmNlc0IWRXh0ZW5zaW9uRmVlZEl0",
            "ZW1Qcm90b1ABWkpnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2Fkcy9nb29nbGVhZHMvdjEvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dB",
            "QaoCIUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxLlJlc291cmNlc8oCIUdvb2ds",
            "ZVxBZHNcR29vZ2xlQWRzXFYxXFJlc291cmNlc+oCJUdvb2dsZTo6QWRzOjpH",
            "b29nbGVBZHM6OlYxOjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V1.Common.ExtensionsReflection.Descriptor, global::Google.Ads.GoogleAds.V1.Enums.ExtensionTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V1.Enums.FeedItemStatusReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Resources.ExtensionFeedItem), global::Google.Ads.GoogleAds.V1.Resources.ExtensionFeedItem.Parser, new[]{ "ResourceName", "ExtensionType", "StartDateTime", "EndDateTime", "Status", "SitelinkFeedItem", "StructuredSnippetFeedItem", "AppFeedItem", "CallFeedItem", "CalloutFeedItem", "TextMessageFeedItem", "PriceFeedItem", "PromotionFeedItem" }, new[]{ "Extension" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An extension feed item.
  /// </summary>
  public sealed partial class ExtensionFeedItem : pb::IMessage<ExtensionFeedItem> {
    private static readonly pb::MessageParser<ExtensionFeedItem> _parser = new pb::MessageParser<ExtensionFeedItem>(() => new ExtensionFeedItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ExtensionFeedItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Resources.ExtensionFeedItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExtensionFeedItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExtensionFeedItem(ExtensionFeedItem other) : this() {
      resourceName_ = other.resourceName_;
      extensionType_ = other.extensionType_;
      StartDateTime = other.StartDateTime;
      EndDateTime = other.EndDateTime;
      status_ = other.status_;
      switch (other.ExtensionCase) {
        case ExtensionOneofCase.SitelinkFeedItem:
          SitelinkFeedItem = other.SitelinkFeedItem.Clone();
          break;
        case ExtensionOneofCase.StructuredSnippetFeedItem:
          StructuredSnippetFeedItem = other.StructuredSnippetFeedItem.Clone();
          break;
        case ExtensionOneofCase.AppFeedItem:
          AppFeedItem = other.AppFeedItem.Clone();
          break;
        case ExtensionOneofCase.CallFeedItem:
          CallFeedItem = other.CallFeedItem.Clone();
          break;
        case ExtensionOneofCase.CalloutFeedItem:
          CalloutFeedItem = other.CalloutFeedItem.Clone();
          break;
        case ExtensionOneofCase.TextMessageFeedItem:
          TextMessageFeedItem = other.TextMessageFeedItem.Clone();
          break;
        case ExtensionOneofCase.PriceFeedItem:
          PriceFeedItem = other.PriceFeedItem.Clone();
          break;
        case ExtensionOneofCase.PromotionFeedItem:
          PromotionFeedItem = other.PromotionFeedItem.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExtensionFeedItem Clone() {
      return new ExtensionFeedItem(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the extension feed item.
    /// Extension feed item resource names have the form:
    ///
    /// `customers/{customer_id}/extensionFeedItems/{feed_item_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "extension_type" field.</summary>
    public const int ExtensionTypeFieldNumber = 13;
    private global::Google.Ads.GoogleAds.V1.Enums.ExtensionTypeEnum.Types.ExtensionType extensionType_ = 0;
    /// <summary>
    /// The extension type of the extension feed item.
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Enums.ExtensionTypeEnum.Types.ExtensionType ExtensionType {
      get { return extensionType_; }
      set {
        extensionType_ = value;
      }
    }

    /// <summary>Field number for the "start_date_time" field.</summary>
    public const int StartDateTimeFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _single_startDateTime_codec = pb::FieldCodec.ForClassWrapper<string>(42);
    private string startDateTime_;
    /// <summary>
    /// Start time in which this feed item is effective and can begin serving.
    /// The format is "YYYY-MM-DD HH:MM:SS".
    /// Examples: "2018-03-05 09:15:00" or "2018-02-01 14:34:30"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StartDateTime {
      get { return startDateTime_; }
      set {
        startDateTime_ = value;
      }
    }

    /// <summary>Field number for the "end_date_time" field.</summary>
    public const int EndDateTimeFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _single_endDateTime_codec = pb::FieldCodec.ForClassWrapper<string>(50);
    private string endDateTime_;
    /// <summary>
    /// End time in which this feed item is no longer effective and will stop
    /// serving.
    /// The format is "YYYY-MM-DD HH:MM:SS".
    /// Examples: "2018-03-05 09:15:00" or "2018-02-01 14:34:30"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EndDateTime {
      get { return endDateTime_; }
      set {
        endDateTime_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V1.Enums.FeedItemStatusEnum.Types.FeedItemStatus status_ = 0;
    /// <summary>
    /// Status of the feed item.
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Enums.FeedItemStatusEnum.Types.FeedItemStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "sitelink_feed_item" field.</summary>
    public const int SitelinkFeedItemFieldNumber = 2;
    /// <summary>
    /// Sitelink extension.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Common.SitelinkFeedItem SitelinkFeedItem {
      get { return extensionCase_ == ExtensionOneofCase.SitelinkFeedItem ? (global::Google.Ads.GoogleAds.V1.Common.SitelinkFeedItem) extension_ : null; }
      set {
        extension_ = value;
        extensionCase_ = value == null ? ExtensionOneofCase.None : ExtensionOneofCase.SitelinkFeedItem;
      }
    }

    /// <summary>Field number for the "structured_snippet_feed_item" field.</summary>
    public const int StructuredSnippetFeedItemFieldNumber = 3;
    /// <summary>
    /// Structured snippet extension.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Common.StructuredSnippetFeedItem StructuredSnippetFeedItem {
      get { return extensionCase_ == ExtensionOneofCase.StructuredSnippetFeedItem ? (global::Google.Ads.GoogleAds.V1.Common.StructuredSnippetFeedItem) extension_ : null; }
      set {
        extension_ = value;
        extensionCase_ = value == null ? ExtensionOneofCase.None : ExtensionOneofCase.StructuredSnippetFeedItem;
      }
    }

    /// <summary>Field number for the "app_feed_item" field.</summary>
    public const int AppFeedItemFieldNumber = 7;
    /// <summary>
    /// App extension.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Common.AppFeedItem AppFeedItem {
      get { return extensionCase_ == ExtensionOneofCase.AppFeedItem ? (global::Google.Ads.GoogleAds.V1.Common.AppFeedItem) extension_ : null; }
      set {
        extension_ = value;
        extensionCase_ = value == null ? ExtensionOneofCase.None : ExtensionOneofCase.AppFeedItem;
      }
    }

    /// <summary>Field number for the "call_feed_item" field.</summary>
    public const int CallFeedItemFieldNumber = 8;
    /// <summary>
    /// Call extension.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Common.CallFeedItem CallFeedItem {
      get { return extensionCase_ == ExtensionOneofCase.CallFeedItem ? (global::Google.Ads.GoogleAds.V1.Common.CallFeedItem) extension_ : null; }
      set {
        extension_ = value;
        extensionCase_ = value == null ? ExtensionOneofCase.None : ExtensionOneofCase.CallFeedItem;
      }
    }

    /// <summary>Field number for the "callout_feed_item" field.</summary>
    public const int CalloutFeedItemFieldNumber = 9;
    /// <summary>
    /// Callout extension.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Common.CalloutFeedItem CalloutFeedItem {
      get { return extensionCase_ == ExtensionOneofCase.CalloutFeedItem ? (global::Google.Ads.GoogleAds.V1.Common.CalloutFeedItem) extension_ : null; }
      set {
        extension_ = value;
        extensionCase_ = value == null ? ExtensionOneofCase.None : ExtensionOneofCase.CalloutFeedItem;
      }
    }

    /// <summary>Field number for the "text_message_feed_item" field.</summary>
    public const int TextMessageFeedItemFieldNumber = 10;
    /// <summary>
    /// Text message extension.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Common.TextMessageFeedItem TextMessageFeedItem {
      get { return extensionCase_ == ExtensionOneofCase.TextMessageFeedItem ? (global::Google.Ads.GoogleAds.V1.Common.TextMessageFeedItem) extension_ : null; }
      set {
        extension_ = value;
        extensionCase_ = value == null ? ExtensionOneofCase.None : ExtensionOneofCase.TextMessageFeedItem;
      }
    }

    /// <summary>Field number for the "price_feed_item" field.</summary>
    public const int PriceFeedItemFieldNumber = 11;
    /// <summary>
    /// Price extension.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Common.PriceFeedItem PriceFeedItem {
      get { return extensionCase_ == ExtensionOneofCase.PriceFeedItem ? (global::Google.Ads.GoogleAds.V1.Common.PriceFeedItem) extension_ : null; }
      set {
        extension_ = value;
        extensionCase_ = value == null ? ExtensionOneofCase.None : ExtensionOneofCase.PriceFeedItem;
      }
    }

    /// <summary>Field number for the "promotion_feed_item" field.</summary>
    public const int PromotionFeedItemFieldNumber = 12;
    /// <summary>
    /// Promotion extension.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Common.PromotionFeedItem PromotionFeedItem {
      get { return extensionCase_ == ExtensionOneofCase.PromotionFeedItem ? (global::Google.Ads.GoogleAds.V1.Common.PromotionFeedItem) extension_ : null; }
      set {
        extension_ = value;
        extensionCase_ = value == null ? ExtensionOneofCase.None : ExtensionOneofCase.PromotionFeedItem;
      }
    }

    private object extension_;
    /// <summary>Enum of possible cases for the "extension" oneof.</summary>
    public enum ExtensionOneofCase {
      None = 0,
      SitelinkFeedItem = 2,
      StructuredSnippetFeedItem = 3,
      AppFeedItem = 7,
      CallFeedItem = 8,
      CalloutFeedItem = 9,
      TextMessageFeedItem = 10,
      PriceFeedItem = 11,
      PromotionFeedItem = 12,
    }
    private ExtensionOneofCase extensionCase_ = ExtensionOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExtensionOneofCase ExtensionCase {
      get { return extensionCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearExtension() {
      extensionCase_ = ExtensionOneofCase.None;
      extension_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ExtensionFeedItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ExtensionFeedItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (ExtensionType != other.ExtensionType) return false;
      if (StartDateTime != other.StartDateTime) return false;
      if (EndDateTime != other.EndDateTime) return false;
      if (Status != other.Status) return false;
      if (!object.Equals(SitelinkFeedItem, other.SitelinkFeedItem)) return false;
      if (!object.Equals(StructuredSnippetFeedItem, other.StructuredSnippetFeedItem)) return false;
      if (!object.Equals(AppFeedItem, other.AppFeedItem)) return false;
      if (!object.Equals(CallFeedItem, other.CallFeedItem)) return false;
      if (!object.Equals(CalloutFeedItem, other.CalloutFeedItem)) return false;
      if (!object.Equals(TextMessageFeedItem, other.TextMessageFeedItem)) return false;
      if (!object.Equals(PriceFeedItem, other.PriceFeedItem)) return false;
      if (!object.Equals(PromotionFeedItem, other.PromotionFeedItem)) return false;
      if (ExtensionCase != other.ExtensionCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (ExtensionType != 0) hash ^= ExtensionType.GetHashCode();
      if (startDateTime_ != null) hash ^= StartDateTime.GetHashCode();
      if (endDateTime_ != null) hash ^= EndDateTime.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
      if (extensionCase_ == ExtensionOneofCase.SitelinkFeedItem) hash ^= SitelinkFeedItem.GetHashCode();
      if (extensionCase_ == ExtensionOneofCase.StructuredSnippetFeedItem) hash ^= StructuredSnippetFeedItem.GetHashCode();
      if (extensionCase_ == ExtensionOneofCase.AppFeedItem) hash ^= AppFeedItem.GetHashCode();
      if (extensionCase_ == ExtensionOneofCase.CallFeedItem) hash ^= CallFeedItem.GetHashCode();
      if (extensionCase_ == ExtensionOneofCase.CalloutFeedItem) hash ^= CalloutFeedItem.GetHashCode();
      if (extensionCase_ == ExtensionOneofCase.TextMessageFeedItem) hash ^= TextMessageFeedItem.GetHashCode();
      if (extensionCase_ == ExtensionOneofCase.PriceFeedItem) hash ^= PriceFeedItem.GetHashCode();
      if (extensionCase_ == ExtensionOneofCase.PromotionFeedItem) hash ^= PromotionFeedItem.GetHashCode();
      hash ^= (int) extensionCase_;
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
      if (extensionCase_ == ExtensionOneofCase.SitelinkFeedItem) {
        output.WriteRawTag(18);
        output.WriteMessage(SitelinkFeedItem);
      }
      if (extensionCase_ == ExtensionOneofCase.StructuredSnippetFeedItem) {
        output.WriteRawTag(26);
        output.WriteMessage(StructuredSnippetFeedItem);
      }
      if (Status != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
      if (startDateTime_ != null) {
        _single_startDateTime_codec.WriteTagAndValue(output, StartDateTime);
      }
      if (endDateTime_ != null) {
        _single_endDateTime_codec.WriteTagAndValue(output, EndDateTime);
      }
      if (extensionCase_ == ExtensionOneofCase.AppFeedItem) {
        output.WriteRawTag(58);
        output.WriteMessage(AppFeedItem);
      }
      if (extensionCase_ == ExtensionOneofCase.CallFeedItem) {
        output.WriteRawTag(66);
        output.WriteMessage(CallFeedItem);
      }
      if (extensionCase_ == ExtensionOneofCase.CalloutFeedItem) {
        output.WriteRawTag(74);
        output.WriteMessage(CalloutFeedItem);
      }
      if (extensionCase_ == ExtensionOneofCase.TextMessageFeedItem) {
        output.WriteRawTag(82);
        output.WriteMessage(TextMessageFeedItem);
      }
      if (extensionCase_ == ExtensionOneofCase.PriceFeedItem) {
        output.WriteRawTag(90);
        output.WriteMessage(PriceFeedItem);
      }
      if (extensionCase_ == ExtensionOneofCase.PromotionFeedItem) {
        output.WriteRawTag(98);
        output.WriteMessage(PromotionFeedItem);
      }
      if (ExtensionType != 0) {
        output.WriteRawTag(104);
        output.WriteEnum((int) ExtensionType);
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
      if (ExtensionType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ExtensionType);
      }
      if (startDateTime_ != null) {
        size += _single_startDateTime_codec.CalculateSizeWithTag(StartDateTime);
      }
      if (endDateTime_ != null) {
        size += _single_endDateTime_codec.CalculateSizeWithTag(EndDateTime);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (extensionCase_ == ExtensionOneofCase.SitelinkFeedItem) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SitelinkFeedItem);
      }
      if (extensionCase_ == ExtensionOneofCase.StructuredSnippetFeedItem) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StructuredSnippetFeedItem);
      }
      if (extensionCase_ == ExtensionOneofCase.AppFeedItem) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AppFeedItem);
      }
      if (extensionCase_ == ExtensionOneofCase.CallFeedItem) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CallFeedItem);
      }
      if (extensionCase_ == ExtensionOneofCase.CalloutFeedItem) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CalloutFeedItem);
      }
      if (extensionCase_ == ExtensionOneofCase.TextMessageFeedItem) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TextMessageFeedItem);
      }
      if (extensionCase_ == ExtensionOneofCase.PriceFeedItem) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PriceFeedItem);
      }
      if (extensionCase_ == ExtensionOneofCase.PromotionFeedItem) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PromotionFeedItem);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ExtensionFeedItem other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.ExtensionType != 0) {
        ExtensionType = other.ExtensionType;
      }
      if (other.startDateTime_ != null) {
        if (startDateTime_ == null || other.StartDateTime != "") {
          StartDateTime = other.StartDateTime;
        }
      }
      if (other.endDateTime_ != null) {
        if (endDateTime_ == null || other.EndDateTime != "") {
          EndDateTime = other.EndDateTime;
        }
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      switch (other.ExtensionCase) {
        case ExtensionOneofCase.SitelinkFeedItem:
          if (SitelinkFeedItem == null) {
            SitelinkFeedItem = new global::Google.Ads.GoogleAds.V1.Common.SitelinkFeedItem();
          }
          SitelinkFeedItem.MergeFrom(other.SitelinkFeedItem);
          break;
        case ExtensionOneofCase.StructuredSnippetFeedItem:
          if (StructuredSnippetFeedItem == null) {
            StructuredSnippetFeedItem = new global::Google.Ads.GoogleAds.V1.Common.StructuredSnippetFeedItem();
          }
          StructuredSnippetFeedItem.MergeFrom(other.StructuredSnippetFeedItem);
          break;
        case ExtensionOneofCase.AppFeedItem:
          if (AppFeedItem == null) {
            AppFeedItem = new global::Google.Ads.GoogleAds.V1.Common.AppFeedItem();
          }
          AppFeedItem.MergeFrom(other.AppFeedItem);
          break;
        case ExtensionOneofCase.CallFeedItem:
          if (CallFeedItem == null) {
            CallFeedItem = new global::Google.Ads.GoogleAds.V1.Common.CallFeedItem();
          }
          CallFeedItem.MergeFrom(other.CallFeedItem);
          break;
        case ExtensionOneofCase.CalloutFeedItem:
          if (CalloutFeedItem == null) {
            CalloutFeedItem = new global::Google.Ads.GoogleAds.V1.Common.CalloutFeedItem();
          }
          CalloutFeedItem.MergeFrom(other.CalloutFeedItem);
          break;
        case ExtensionOneofCase.TextMessageFeedItem:
          if (TextMessageFeedItem == null) {
            TextMessageFeedItem = new global::Google.Ads.GoogleAds.V1.Common.TextMessageFeedItem();
          }
          TextMessageFeedItem.MergeFrom(other.TextMessageFeedItem);
          break;
        case ExtensionOneofCase.PriceFeedItem:
          if (PriceFeedItem == null) {
            PriceFeedItem = new global::Google.Ads.GoogleAds.V1.Common.PriceFeedItem();
          }
          PriceFeedItem.MergeFrom(other.PriceFeedItem);
          break;
        case ExtensionOneofCase.PromotionFeedItem:
          if (PromotionFeedItem == null) {
            PromotionFeedItem = new global::Google.Ads.GoogleAds.V1.Common.PromotionFeedItem();
          }
          PromotionFeedItem.MergeFrom(other.PromotionFeedItem);
          break;
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
          case 18: {
            global::Google.Ads.GoogleAds.V1.Common.SitelinkFeedItem subBuilder = new global::Google.Ads.GoogleAds.V1.Common.SitelinkFeedItem();
            if (extensionCase_ == ExtensionOneofCase.SitelinkFeedItem) {
              subBuilder.MergeFrom(SitelinkFeedItem);
            }
            input.ReadMessage(subBuilder);
            SitelinkFeedItem = subBuilder;
            break;
          }
          case 26: {
            global::Google.Ads.GoogleAds.V1.Common.StructuredSnippetFeedItem subBuilder = new global::Google.Ads.GoogleAds.V1.Common.StructuredSnippetFeedItem();
            if (extensionCase_ == ExtensionOneofCase.StructuredSnippetFeedItem) {
              subBuilder.MergeFrom(StructuredSnippetFeedItem);
            }
            input.ReadMessage(subBuilder);
            StructuredSnippetFeedItem = subBuilder;
            break;
          }
          case 32: {
            status_ = (global::Google.Ads.GoogleAds.V1.Enums.FeedItemStatusEnum.Types.FeedItemStatus) input.ReadEnum();
            break;
          }
          case 42: {
            string value = _single_startDateTime_codec.Read(input);
            if (startDateTime_ == null || value != "") {
              StartDateTime = value;
            }
            break;
          }
          case 50: {
            string value = _single_endDateTime_codec.Read(input);
            if (endDateTime_ == null || value != "") {
              EndDateTime = value;
            }
            break;
          }
          case 58: {
            global::Google.Ads.GoogleAds.V1.Common.AppFeedItem subBuilder = new global::Google.Ads.GoogleAds.V1.Common.AppFeedItem();
            if (extensionCase_ == ExtensionOneofCase.AppFeedItem) {
              subBuilder.MergeFrom(AppFeedItem);
            }
            input.ReadMessage(subBuilder);
            AppFeedItem = subBuilder;
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V1.Common.CallFeedItem subBuilder = new global::Google.Ads.GoogleAds.V1.Common.CallFeedItem();
            if (extensionCase_ == ExtensionOneofCase.CallFeedItem) {
              subBuilder.MergeFrom(CallFeedItem);
            }
            input.ReadMessage(subBuilder);
            CallFeedItem = subBuilder;
            break;
          }
          case 74: {
            global::Google.Ads.GoogleAds.V1.Common.CalloutFeedItem subBuilder = new global::Google.Ads.GoogleAds.V1.Common.CalloutFeedItem();
            if (extensionCase_ == ExtensionOneofCase.CalloutFeedItem) {
              subBuilder.MergeFrom(CalloutFeedItem);
            }
            input.ReadMessage(subBuilder);
            CalloutFeedItem = subBuilder;
            break;
          }
          case 82: {
            global::Google.Ads.GoogleAds.V1.Common.TextMessageFeedItem subBuilder = new global::Google.Ads.GoogleAds.V1.Common.TextMessageFeedItem();
            if (extensionCase_ == ExtensionOneofCase.TextMessageFeedItem) {
              subBuilder.MergeFrom(TextMessageFeedItem);
            }
            input.ReadMessage(subBuilder);
            TextMessageFeedItem = subBuilder;
            break;
          }
          case 90: {
            global::Google.Ads.GoogleAds.V1.Common.PriceFeedItem subBuilder = new global::Google.Ads.GoogleAds.V1.Common.PriceFeedItem();
            if (extensionCase_ == ExtensionOneofCase.PriceFeedItem) {
              subBuilder.MergeFrom(PriceFeedItem);
            }
            input.ReadMessage(subBuilder);
            PriceFeedItem = subBuilder;
            break;
          }
          case 98: {
            global::Google.Ads.GoogleAds.V1.Common.PromotionFeedItem subBuilder = new global::Google.Ads.GoogleAds.V1.Common.PromotionFeedItem();
            if (extensionCase_ == ExtensionOneofCase.PromotionFeedItem) {
              subBuilder.MergeFrom(PromotionFeedItem);
            }
            input.ReadMessage(subBuilder);
            PromotionFeedItem = subBuilder;
            break;
          }
          case 104: {
            extensionType_ = (global::Google.Ads.GoogleAds.V1.Enums.ExtensionTypeEnum.Types.ExtensionType) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
