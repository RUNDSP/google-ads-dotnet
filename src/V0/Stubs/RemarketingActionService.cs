// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/services/remarketing_action_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/services/remarketing_action_service.proto</summary>
  public static partial class RemarketingActionServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/services/remarketing_action_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RemarketingActionServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkFnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9zZXJ2aWNlcy9yZW1hcmtldGlu",
            "Z19hY3Rpb25fc2VydmljZS5wcm90bxIgZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djAuc2VydmljZXMaOmdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YwL3Jlc291cmNl",
            "cy9yZW1hcmtldGluZ19hY3Rpb24ucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3Rh",
            "dGlvbnMucHJvdG8aIGdvb2dsZS9wcm90b2J1Zi9maWVsZF9tYXNrLnByb3Rv",
            "Gh5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8aF2dvb2dsZS9ycGMv",
            "c3RhdHVzLnByb3RvIjQKG0dldFJlbWFya2V0aW5nQWN0aW9uUmVxdWVzdBIV",
            "Cg1yZXNvdXJjZV9uYW1lGAEgASgJIrgBCh9NdXRhdGVSZW1hcmtldGluZ0Fj",
            "dGlvbnNSZXF1ZXN0EhMKC2N1c3RvbWVyX2lkGAEgASgJElAKCm9wZXJhdGlv",
            "bnMYAiADKAsyPC5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5zZXJ2aWNlcy5S",
            "ZW1hcmtldGluZ0FjdGlvbk9wZXJhdGlvbhIXCg9wYXJ0aWFsX2ZhaWx1cmUY",
            "AyABKAgSFQoNdmFsaWRhdGVfb25seRgEIAEoCCLqAQoaUmVtYXJrZXRpbmdB",
            "Y3Rpb25PcGVyYXRpb24SLwoLdXBkYXRlX21hc2sYBCABKAsyGi5nb29nbGUu",
            "cHJvdG9idWYuRmllbGRNYXNrEkYKBmNyZWF0ZRgBIAEoCzI0Lmdvb2dsZS5h",
            "ZHMuZ29vZ2xlYWRzLnYwLnJlc291cmNlcy5SZW1hcmtldGluZ0FjdGlvbkgA",
            "EkYKBnVwZGF0ZRgCIAEoCzI0Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLnJl",
            "c291cmNlcy5SZW1hcmtldGluZ0FjdGlvbkgAQgsKCW9wZXJhdGlvbiKnAQog",
            "TXV0YXRlUmVtYXJrZXRpbmdBY3Rpb25zUmVzcG9uc2USMQoVcGFydGlhbF9m",
            "YWlsdXJlX2Vycm9yGAMgASgLMhIuZ29vZ2xlLnJwYy5TdGF0dXMSUAoHcmVz",
            "dWx0cxgCIAMoCzI/Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLnNlcnZpY2Vz",
            "Lk11dGF0ZVJlbWFya2V0aW5nQWN0aW9uUmVzdWx0IjYKHU11dGF0ZVJlbWFy",
            "a2V0aW5nQWN0aW9uUmVzdWx0EhUKDXJlc291cmNlX25hbWUYASABKAkyzgMK",
            "GFJlbWFya2V0aW5nQWN0aW9uU2VydmljZRLJAQoUR2V0UmVtYXJrZXRpbmdB",
            "Y3Rpb24SPS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5zZXJ2aWNlcy5HZXRS",
            "ZW1hcmtldGluZ0FjdGlvblJlcXVlc3QaNC5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MC5yZXNvdXJjZXMuUmVtYXJrZXRpbmdBY3Rpb24iPILT5JMCNhI0L3Yw",
            "L3tyZXNvdXJjZV9uYW1lPWN1c3RvbWVycy8qL3JlbWFya2V0aW5nQWN0aW9u",
            "cy8qfRLlAQoYTXV0YXRlUmVtYXJrZXRpbmdBY3Rpb25zEkEuZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjAuc2VydmljZXMuTXV0YXRlUmVtYXJrZXRpbmdBY3Rp",
            "b25zUmVxdWVzdBpCLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLnNlcnZpY2Vz",
            "Lk11dGF0ZVJlbWFya2V0aW5nQWN0aW9uc1Jlc3BvbnNlIkKC0+STAjwiNy92",
            "MC9jdXN0b21lcnMve2N1c3RvbWVyX2lkPSp9L3JlbWFya2V0aW5nQWN0aW9u",
            "czptdXRhdGU6ASpChAIKJGNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5z",
            "ZXJ2aWNlc0IdUmVtYXJrZXRpbmdBY3Rpb25TZXJ2aWNlUHJvdG9QAVpIZ29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xl",
            "YWRzL3YwL3NlcnZpY2VzO3NlcnZpY2VzogIDR0FBqgIgR29vZ2xlLkFkcy5H",
            "b29nbGVBZHMuVjAuU2VydmljZXPKAiBHb29nbGVcQWRzXEdvb2dsZUFkc1xW",
            "MFxTZXJ2aWNlc+oCJEdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYwOjpTZXJ2",
            "aWNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V0.Resources.RemarketingActionReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Rpc.StatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.GetRemarketingActionRequest), global::Google.Ads.GoogleAds.V0.Services.GetRemarketingActionRequest.Parser, new[]{ "ResourceName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.MutateRemarketingActionsRequest), global::Google.Ads.GoogleAds.V0.Services.MutateRemarketingActionsRequest.Parser, new[]{ "CustomerId", "Operations", "PartialFailure", "ValidateOnly" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.RemarketingActionOperation), global::Google.Ads.GoogleAds.V0.Services.RemarketingActionOperation.Parser, new[]{ "UpdateMask", "Create", "Update" }, new[]{ "Operation" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.MutateRemarketingActionsResponse), global::Google.Ads.GoogleAds.V0.Services.MutateRemarketingActionsResponse.Parser, new[]{ "PartialFailureError", "Results" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.MutateRemarketingActionResult), global::Google.Ads.GoogleAds.V0.Services.MutateRemarketingActionResult.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [RemarketingActionService.GetRemarketingAction][google.ads.googleads.v0.services.RemarketingActionService.GetRemarketingAction].
  /// </summary>
  public sealed partial class GetRemarketingActionRequest : pb::IMessage<GetRemarketingActionRequest> {
    private static readonly pb::MessageParser<GetRemarketingActionRequest> _parser = new pb::MessageParser<GetRemarketingActionRequest>(() => new GetRemarketingActionRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetRemarketingActionRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.RemarketingActionServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetRemarketingActionRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetRemarketingActionRequest(GetRemarketingActionRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetRemarketingActionRequest Clone() {
      return new GetRemarketingActionRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the remarketing action to fetch.
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
      return Equals(other as GetRemarketingActionRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetRemarketingActionRequest other) {
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
    public void MergeFrom(GetRemarketingActionRequest other) {
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

  /// <summary>
  /// Request message for [RemarketingActionService.MutateRemarketingActions][google.ads.googleads.v0.services.RemarketingActionService.MutateRemarketingActions].
  /// </summary>
  public sealed partial class MutateRemarketingActionsRequest : pb::IMessage<MutateRemarketingActionsRequest> {
    private static readonly pb::MessageParser<MutateRemarketingActionsRequest> _parser = new pb::MessageParser<MutateRemarketingActionsRequest>(() => new MutateRemarketingActionsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateRemarketingActionsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.RemarketingActionServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateRemarketingActionsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateRemarketingActionsRequest(MutateRemarketingActionsRequest other) : this() {
      customerId_ = other.customerId_;
      operations_ = other.operations_.Clone();
      partialFailure_ = other.partialFailure_;
      validateOnly_ = other.validateOnly_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateRemarketingActionsRequest Clone() {
      return new MutateRemarketingActionsRequest(this);
    }

    /// <summary>Field number for the "customer_id" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private string customerId_ = "";
    /// <summary>
    /// The ID of the customer whose remarketing actions are being modified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CustomerId {
      get { return customerId_; }
      set {
        customerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "operations" field.</summary>
    public const int OperationsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V0.Services.RemarketingActionOperation> _repeated_operations_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V0.Services.RemarketingActionOperation.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Services.RemarketingActionOperation> operations_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Services.RemarketingActionOperation>();
    /// <summary>
    /// The list of operations to perform on individual remarketing actions.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Services.RemarketingActionOperation> Operations {
      get { return operations_; }
    }

    /// <summary>Field number for the "partial_failure" field.</summary>
    public const int PartialFailureFieldNumber = 3;
    private bool partialFailure_;
    /// <summary>
    /// If true, successful operations will be carried out and invalid
    /// operations will return errors. If false, all operations will be carried
    /// out in one transaction if and only if they are all valid.
    /// Default is false.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool PartialFailure {
      get { return partialFailure_; }
      set {
        partialFailure_ = value;
      }
    }

    /// <summary>Field number for the "validate_only" field.</summary>
    public const int ValidateOnlyFieldNumber = 4;
    private bool validateOnly_;
    /// <summary>
    /// If true, the request is validated but not executed. Only errors are
    /// returned, not results.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ValidateOnly {
      get { return validateOnly_; }
      set {
        validateOnly_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MutateRemarketingActionsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateRemarketingActionsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomerId != other.CustomerId) return false;
      if(!operations_.Equals(other.operations_)) return false;
      if (PartialFailure != other.PartialFailure) return false;
      if (ValidateOnly != other.ValidateOnly) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomerId.Length != 0) hash ^= CustomerId.GetHashCode();
      hash ^= operations_.GetHashCode();
      if (PartialFailure != false) hash ^= PartialFailure.GetHashCode();
      if (ValidateOnly != false) hash ^= ValidateOnly.GetHashCode();
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
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      operations_.WriteTo(output, _repeated_operations_codec);
      if (PartialFailure != false) {
        output.WriteRawTag(24);
        output.WriteBool(PartialFailure);
      }
      if (ValidateOnly != false) {
        output.WriteRawTag(32);
        output.WriteBool(ValidateOnly);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CustomerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerId);
      }
      size += operations_.CalculateSize(_repeated_operations_codec);
      if (PartialFailure != false) {
        size += 1 + 1;
      }
      if (ValidateOnly != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MutateRemarketingActionsRequest other) {
      if (other == null) {
        return;
      }
      if (other.CustomerId.Length != 0) {
        CustomerId = other.CustomerId;
      }
      operations_.Add(other.operations_);
      if (other.PartialFailure != false) {
        PartialFailure = other.PartialFailure;
      }
      if (other.ValidateOnly != false) {
        ValidateOnly = other.ValidateOnly;
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
            CustomerId = input.ReadString();
            break;
          }
          case 18: {
            operations_.AddEntriesFrom(input, _repeated_operations_codec);
            break;
          }
          case 24: {
            PartialFailure = input.ReadBool();
            break;
          }
          case 32: {
            ValidateOnly = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A single operation (create, update) on a remarketing action.
  /// </summary>
  public sealed partial class RemarketingActionOperation : pb::IMessage<RemarketingActionOperation> {
    private static readonly pb::MessageParser<RemarketingActionOperation> _parser = new pb::MessageParser<RemarketingActionOperation>(() => new RemarketingActionOperation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RemarketingActionOperation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.RemarketingActionServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemarketingActionOperation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemarketingActionOperation(RemarketingActionOperation other) : this() {
      updateMask_ = other.updateMask_ != null ? other.updateMask_.Clone() : null;
      switch (other.OperationCase) {
        case OperationOneofCase.Create:
          Create = other.Create.Clone();
          break;
        case OperationOneofCase.Update:
          Update = other.Update.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemarketingActionOperation Clone() {
      return new RemarketingActionOperation(this);
    }

    /// <summary>Field number for the "update_mask" field.</summary>
    public const int UpdateMaskFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.FieldMask updateMask_;
    /// <summary>
    /// FieldMask that determines which resource fields are modified in an update.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.FieldMask UpdateMask {
      get { return updateMask_; }
      set {
        updateMask_ = value;
      }
    }

    /// <summary>Field number for the "create" field.</summary>
    public const int CreateFieldNumber = 1;
    /// <summary>
    /// Create operation: No resource name is expected for the new remarketing
    /// action.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Resources.RemarketingAction Create {
      get { return operationCase_ == OperationOneofCase.Create ? (global::Google.Ads.GoogleAds.V0.Resources.RemarketingAction) operation_ : null; }
      set {
        operation_ = value;
        operationCase_ = value == null ? OperationOneofCase.None : OperationOneofCase.Create;
      }
    }

    /// <summary>Field number for the "update" field.</summary>
    public const int UpdateFieldNumber = 2;
    /// <summary>
    /// Update operation: The remarketing action is expected to have a valid
    /// resource name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Resources.RemarketingAction Update {
      get { return operationCase_ == OperationOneofCase.Update ? (global::Google.Ads.GoogleAds.V0.Resources.RemarketingAction) operation_ : null; }
      set {
        operation_ = value;
        operationCase_ = value == null ? OperationOneofCase.None : OperationOneofCase.Update;
      }
    }

    private object operation_;
    /// <summary>Enum of possible cases for the "operation" oneof.</summary>
    public enum OperationOneofCase {
      None = 0,
      Create = 1,
      Update = 2,
    }
    private OperationOneofCase operationCase_ = OperationOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperationOneofCase OperationCase {
      get { return operationCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearOperation() {
      operationCase_ = OperationOneofCase.None;
      operation_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RemarketingActionOperation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RemarketingActionOperation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(UpdateMask, other.UpdateMask)) return false;
      if (!object.Equals(Create, other.Create)) return false;
      if (!object.Equals(Update, other.Update)) return false;
      if (OperationCase != other.OperationCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (updateMask_ != null) hash ^= UpdateMask.GetHashCode();
      if (operationCase_ == OperationOneofCase.Create) hash ^= Create.GetHashCode();
      if (operationCase_ == OperationOneofCase.Update) hash ^= Update.GetHashCode();
      hash ^= (int) operationCase_;
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
      if (operationCase_ == OperationOneofCase.Create) {
        output.WriteRawTag(10);
        output.WriteMessage(Create);
      }
      if (operationCase_ == OperationOneofCase.Update) {
        output.WriteRawTag(18);
        output.WriteMessage(Update);
      }
      if (updateMask_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(UpdateMask);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (updateMask_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateMask);
      }
      if (operationCase_ == OperationOneofCase.Create) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Create);
      }
      if (operationCase_ == OperationOneofCase.Update) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Update);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RemarketingActionOperation other) {
      if (other == null) {
        return;
      }
      if (other.updateMask_ != null) {
        if (updateMask_ == null) {
          updateMask_ = new global::Google.Protobuf.WellKnownTypes.FieldMask();
        }
        UpdateMask.MergeFrom(other.UpdateMask);
      }
      switch (other.OperationCase) {
        case OperationOneofCase.Create:
          if (Create == null) {
            Create = new global::Google.Ads.GoogleAds.V0.Resources.RemarketingAction();
          }
          Create.MergeFrom(other.Create);
          break;
        case OperationOneofCase.Update:
          if (Update == null) {
            Update = new global::Google.Ads.GoogleAds.V0.Resources.RemarketingAction();
          }
          Update.MergeFrom(other.Update);
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
            global::Google.Ads.GoogleAds.V0.Resources.RemarketingAction subBuilder = new global::Google.Ads.GoogleAds.V0.Resources.RemarketingAction();
            if (operationCase_ == OperationOneofCase.Create) {
              subBuilder.MergeFrom(Create);
            }
            input.ReadMessage(subBuilder);
            Create = subBuilder;
            break;
          }
          case 18: {
            global::Google.Ads.GoogleAds.V0.Resources.RemarketingAction subBuilder = new global::Google.Ads.GoogleAds.V0.Resources.RemarketingAction();
            if (operationCase_ == OperationOneofCase.Update) {
              subBuilder.MergeFrom(Update);
            }
            input.ReadMessage(subBuilder);
            Update = subBuilder;
            break;
          }
          case 34: {
            if (updateMask_ == null) {
              updateMask_ = new global::Google.Protobuf.WellKnownTypes.FieldMask();
            }
            input.ReadMessage(updateMask_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Response message for remarketing action mutate.
  /// </summary>
  public sealed partial class MutateRemarketingActionsResponse : pb::IMessage<MutateRemarketingActionsResponse> {
    private static readonly pb::MessageParser<MutateRemarketingActionsResponse> _parser = new pb::MessageParser<MutateRemarketingActionsResponse>(() => new MutateRemarketingActionsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateRemarketingActionsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.RemarketingActionServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateRemarketingActionsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateRemarketingActionsResponse(MutateRemarketingActionsResponse other) : this() {
      partialFailureError_ = other.partialFailureError_ != null ? other.partialFailureError_.Clone() : null;
      results_ = other.results_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateRemarketingActionsResponse Clone() {
      return new MutateRemarketingActionsResponse(this);
    }

    /// <summary>Field number for the "partial_failure_error" field.</summary>
    public const int PartialFailureErrorFieldNumber = 3;
    private global::Google.Rpc.Status partialFailureError_;
    /// <summary>
    /// Errors that pertain to operation failures in the partial failure mode.
    /// Returned only when partial_failure = true and all errors occur inside the
    /// operations. If any errors occur outside the operations (e.g. auth errors),
    /// we return an RPC level error.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Rpc.Status PartialFailureError {
      get { return partialFailureError_; }
      set {
        partialFailureError_ = value;
      }
    }

    /// <summary>Field number for the "results" field.</summary>
    public const int ResultsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V0.Services.MutateRemarketingActionResult> _repeated_results_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V0.Services.MutateRemarketingActionResult.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Services.MutateRemarketingActionResult> results_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Services.MutateRemarketingActionResult>();
    /// <summary>
    /// All results for the mutate.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Services.MutateRemarketingActionResult> Results {
      get { return results_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MutateRemarketingActionsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateRemarketingActionsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PartialFailureError, other.PartialFailureError)) return false;
      if(!results_.Equals(other.results_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (partialFailureError_ != null) hash ^= PartialFailureError.GetHashCode();
      hash ^= results_.GetHashCode();
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
      results_.WriteTo(output, _repeated_results_codec);
      if (partialFailureError_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PartialFailureError);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (partialFailureError_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PartialFailureError);
      }
      size += results_.CalculateSize(_repeated_results_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MutateRemarketingActionsResponse other) {
      if (other == null) {
        return;
      }
      if (other.partialFailureError_ != null) {
        if (partialFailureError_ == null) {
          partialFailureError_ = new global::Google.Rpc.Status();
        }
        PartialFailureError.MergeFrom(other.PartialFailureError);
      }
      results_.Add(other.results_);
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
          case 18: {
            results_.AddEntriesFrom(input, _repeated_results_codec);
            break;
          }
          case 26: {
            if (partialFailureError_ == null) {
              partialFailureError_ = new global::Google.Rpc.Status();
            }
            input.ReadMessage(partialFailureError_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The result for the remarketing action mutate.
  /// </summary>
  public sealed partial class MutateRemarketingActionResult : pb::IMessage<MutateRemarketingActionResult> {
    private static readonly pb::MessageParser<MutateRemarketingActionResult> _parser = new pb::MessageParser<MutateRemarketingActionResult>(() => new MutateRemarketingActionResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateRemarketingActionResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.RemarketingActionServiceReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateRemarketingActionResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateRemarketingActionResult(MutateRemarketingActionResult other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateRemarketingActionResult Clone() {
      return new MutateRemarketingActionResult(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Returned for successful operations.
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
      return Equals(other as MutateRemarketingActionResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateRemarketingActionResult other) {
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
    public void MergeFrom(MutateRemarketingActionResult other) {
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
