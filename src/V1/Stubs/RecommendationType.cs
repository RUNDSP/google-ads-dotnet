// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/enums/recommendation_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/enums/recommendation_type.proto</summary>
  public static partial class RecommendationTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/enums/recommendation_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RecommendationTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lbnVtcy9yZWNvbW1lbmRhdGlv",
            "bl90eXBlLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5lbnVtcxoc",
            "Z29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byLPAgoWUmVjb21tZW5kYXRp",
            "b25UeXBlRW51bSK0AgoSUmVjb21tZW5kYXRpb25UeXBlEg8KC1VOU1BFQ0lG",
            "SUVEEAASCwoHVU5LTk9XThABEhMKD0NBTVBBSUdOX0JVREdFVBACEgsKB0tF",
            "WVdPUkQQAxILCgdURVhUX0FEEAQSFQoRVEFSR0VUX0NQQV9PUFRfSU4QBRIf",
            "ChtNQVhJTUlaRV9DT05WRVJTSU9OU19PUFRfSU4QBhIXChNFTkhBTkNFRF9D",
            "UENfT1BUX0lOEAcSGgoWU0VBUkNIX1BBUlRORVJTX09QVF9JThAIEhoKFk1B",
            "WElNSVpFX0NMSUNLU19PUFRfSU4QCRIYChRPUFRJTUlaRV9BRF9ST1RBVElP",
            "ThAKEhYKEktFWVdPUkRfTUFUQ0hfVFlQRRAOEhYKEk1PVkVfVU5VU0VEX0JV",
            "REdFVBAPQuwBCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEuZW51bXNC",
            "F1JlY29tbWVuZGF0aW9uVHlwZVByb3RvUAFaQmdvb2dsZS5nb2xhbmcub3Jn",
            "L2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MS9lbnVtcztl",
            "bnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxLkVudW1zygId",
            "R29vZ2xlXEFkc1xHb29nbGVBZHNcVjFcRW51bXPqAiFHb29nbGU6OkFkczo6",
            "R29vZ2xlQWRzOjpWMTo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Enums.RecommendationTypeEnum), global::Google.Ads.GoogleAds.V1.Enums.RecommendationTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Enums.RecommendationTypeEnum.Types.RecommendationType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing types of recommendations.
  /// </summary>
  public sealed partial class RecommendationTypeEnum : pb::IMessage<RecommendationTypeEnum> {
    private static readonly pb::MessageParser<RecommendationTypeEnum> _parser = new pb::MessageParser<RecommendationTypeEnum>(() => new RecommendationTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RecommendationTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Enums.RecommendationTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RecommendationTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RecommendationTypeEnum(RecommendationTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RecommendationTypeEnum Clone() {
      return new RecommendationTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RecommendationTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RecommendationTypeEnum other) {
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
    public void MergeFrom(RecommendationTypeEnum other) {
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
    /// <summary>Container for nested types declared in the RecommendationTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Types of recommendations.
      /// </summary>
      public enum RecommendationType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Budget recommendation for budget constrained campaigns.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET")] CampaignBudget = 2,
        /// <summary>
        /// Keyword recommendation.
        /// </summary>
        [pbr::OriginalName("KEYWORD")] Keyword = 3,
        /// <summary>
        /// Recommendation to add a new text ad.
        /// </summary>
        [pbr::OriginalName("TEXT_AD")] TextAd = 4,
        /// <summary>
        /// Recommendation to update a campaign to use a Target CPA bidding strategy.
        /// </summary>
        [pbr::OriginalName("TARGET_CPA_OPT_IN")] TargetCpaOptIn = 5,
        /// <summary>
        /// Recommendation to update a campaign to use the Maximize Conversions
        /// bidding strategy.
        /// </summary>
        [pbr::OriginalName("MAXIMIZE_CONVERSIONS_OPT_IN")] MaximizeConversionsOptIn = 6,
        /// <summary>
        /// Recommendation to enable Enhanced Cost Per Click for a campaign.
        /// </summary>
        [pbr::OriginalName("ENHANCED_CPC_OPT_IN")] EnhancedCpcOptIn = 7,
        /// <summary>
        /// Recommendation to start showing your campaign's ads on Google Search
        /// Partners Websites.
        /// </summary>
        [pbr::OriginalName("SEARCH_PARTNERS_OPT_IN")] SearchPartnersOptIn = 8,
        /// <summary>
        /// Recommendation to update a campaign to use a Maximize Clicks bidding
        /// strategy.
        /// </summary>
        [pbr::OriginalName("MAXIMIZE_CLICKS_OPT_IN")] MaximizeClicksOptIn = 9,
        /// <summary>
        /// Recommendation to start using the "Optimize" ad rotation setting for the
        /// given ad group.
        /// </summary>
        [pbr::OriginalName("OPTIMIZE_AD_ROTATION")] OptimizeAdRotation = 10,
        /// <summary>
        /// Recommendation to change an existing keyword from one match type to a
        /// broader match type.
        /// </summary>
        [pbr::OriginalName("KEYWORD_MATCH_TYPE")] KeywordMatchType = 14,
        /// <summary>
        /// Recommendation to move unused budget from one budget to a constrained
        /// budget.
        /// </summary>
        [pbr::OriginalName("MOVE_UNUSED_BUDGET")] MoveUnusedBudget = 15,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
