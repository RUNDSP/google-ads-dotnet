// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/services/customer_negative_criterion_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/services/customer_negative_criterion_service.proto</summary>
  public static partial class CustomerNegativeCriterionServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/services/customer_negative_criterion_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerNegativeCriterionServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckpnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9zZXJ2aWNlcy9jdXN0b21lcl9u",
            "ZWdhdGl2ZV9jcml0ZXJpb25fc2VydmljZS5wcm90bxIgZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjEuc2VydmljZXMaQ2dvb2dsZS9hZHMvZ29vZ2xlYWRzL3Yx",
            "L3Jlc291cmNlcy9jdXN0b21lcl9uZWdhdGl2ZV9jcml0ZXJpb24ucHJvdG8a",
            "HGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8aHmdvb2dsZS9wcm90b2J1",
            "Zi93cmFwcGVycy5wcm90bxoXZ29vZ2xlL3JwYy9zdGF0dXMucHJvdG8iPAoj",
            "R2V0Q3VzdG9tZXJOZWdhdGl2ZUNyaXRlcmlvblJlcXVlc3QSFQoNcmVzb3Vy",
            "Y2VfbmFtZRgBIAEoCSLGAQolTXV0YXRlQ3VzdG9tZXJOZWdhdGl2ZUNyaXRl",
            "cmlhUmVxdWVzdBITCgtjdXN0b21lcl9pZBgBIAEoCRJYCgpvcGVyYXRpb25z",
            "GAIgAygLMkQuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEuc2VydmljZXMuQ3Vz",
            "dG9tZXJOZWdhdGl2ZUNyaXRlcmlvbk9wZXJhdGlvbhIXCg9wYXJ0aWFsX2Zh",
            "aWx1cmUYAyABKAgSFQoNdmFsaWRhdGVfb25seRgEIAEoCCKTAQoiQ3VzdG9t",
            "ZXJOZWdhdGl2ZUNyaXRlcmlvbk9wZXJhdGlvbhJOCgZjcmVhdGUYASABKAsy",
            "PC5nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5yZXNvdXJjZXMuQ3VzdG9tZXJO",
            "ZWdhdGl2ZUNyaXRlcmlvbkgAEhAKBnJlbW92ZRgCIAEoCUgAQgsKCW9wZXJh",
            "dGlvbiK0AQomTXV0YXRlQ3VzdG9tZXJOZWdhdGl2ZUNyaXRlcmlhUmVzcG9u",
            "c2USMQoVcGFydGlhbF9mYWlsdXJlX2Vycm9yGAMgASgLMhIuZ29vZ2xlLnJw",
            "Yy5TdGF0dXMSVwoHcmVzdWx0cxgCIAMoCzJGLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxLnNlcnZpY2VzLk11dGF0ZUN1c3RvbWVyTmVnYXRpdmVDcml0ZXJp",
            "YVJlc3VsdCI9CiRNdXRhdGVDdXN0b21lck5lZ2F0aXZlQ3JpdGVyaWFSZXN1",
            "bHQSFQoNcmVzb3VyY2VfbmFtZRgBIAEoCTKMBAogQ3VzdG9tZXJOZWdhdGl2",
            "ZUNyaXRlcmlvblNlcnZpY2US5wEKHEdldEN1c3RvbWVyTmVnYXRpdmVDcml0",
            "ZXJpb24SRS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5zZXJ2aWNlcy5HZXRD",
            "dXN0b21lck5lZ2F0aXZlQ3JpdGVyaW9uUmVxdWVzdBo8Lmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnYxLnJlc291cmNlcy5DdXN0b21lck5lZ2F0aXZlQ3JpdGVy",
            "aW9uIkKC0+STAjwSOi92MS97cmVzb3VyY2VfbmFtZT1jdXN0b21lcnMvKi9j",
            "dXN0b21lck5lZ2F0aXZlQ3JpdGVyaWEvKn0S/QEKHk11dGF0ZUN1c3RvbWVy",
            "TmVnYXRpdmVDcml0ZXJpYRJHLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLnNl",
            "cnZpY2VzLk11dGF0ZUN1c3RvbWVyTmVnYXRpdmVDcml0ZXJpYVJlcXVlc3Qa",
            "SC5nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5zZXJ2aWNlcy5NdXRhdGVDdXN0",
            "b21lck5lZ2F0aXZlQ3JpdGVyaWFSZXNwb25zZSJIgtPkkwJCIj0vdjEvY3Vz",
            "dG9tZXJzL3tjdXN0b21lcl9pZD0qfS9jdXN0b21lck5lZ2F0aXZlQ3JpdGVy",
            "aWE6bXV0YXRlOgEqQowCCiRjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEu",
            "c2VydmljZXNCJUN1c3RvbWVyTmVnYXRpdmVDcml0ZXJpb25TZXJ2aWNlUHJv",
            "dG9QAVpIZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9h",
            "ZHMvZ29vZ2xlYWRzL3YxL3NlcnZpY2VzO3NlcnZpY2VzogIDR0FBqgIgR29v",
            "Z2xlLkFkcy5Hb29nbGVBZHMuVjEuU2VydmljZXPKAiBHb29nbGVcQWRzXEdv",
            "b2dsZUFkc1xWMVxTZXJ2aWNlc+oCJEdvb2dsZTo6QWRzOjpHb29nbGVBZHM6",
            "OlYxOjpTZXJ2aWNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V1.Resources.CustomerNegativeCriterionReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Rpc.StatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Services.GetCustomerNegativeCriterionRequest), global::Google.Ads.GoogleAds.V1.Services.GetCustomerNegativeCriterionRequest.Parser, new[]{ "ResourceName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Services.MutateCustomerNegativeCriteriaRequest), global::Google.Ads.GoogleAds.V1.Services.MutateCustomerNegativeCriteriaRequest.Parser, new[]{ "CustomerId", "Operations", "PartialFailure", "ValidateOnly" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Services.CustomerNegativeCriterionOperation), global::Google.Ads.GoogleAds.V1.Services.CustomerNegativeCriterionOperation.Parser, new[]{ "Create", "Remove" }, new[]{ "Operation" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Services.MutateCustomerNegativeCriteriaResponse), global::Google.Ads.GoogleAds.V1.Services.MutateCustomerNegativeCriteriaResponse.Parser, new[]{ "PartialFailureError", "Results" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Services.MutateCustomerNegativeCriteriaResult), global::Google.Ads.GoogleAds.V1.Services.MutateCustomerNegativeCriteriaResult.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for
  /// [CustomerNegativeCriterionService.GetCustomerNegativeCriterion][google.ads.googleads.v1.services.CustomerNegativeCriterionService.GetCustomerNegativeCriterion].
  /// </summary>
  public sealed partial class GetCustomerNegativeCriterionRequest : pb::IMessage<GetCustomerNegativeCriterionRequest> {
    private static readonly pb::MessageParser<GetCustomerNegativeCriterionRequest> _parser = new pb::MessageParser<GetCustomerNegativeCriterionRequest>(() => new GetCustomerNegativeCriterionRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetCustomerNegativeCriterionRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Services.CustomerNegativeCriterionServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCustomerNegativeCriterionRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCustomerNegativeCriterionRequest(GetCustomerNegativeCriterionRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCustomerNegativeCriterionRequest Clone() {
      return new GetCustomerNegativeCriterionRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the criterion to fetch.
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
      return Equals(other as GetCustomerNegativeCriterionRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetCustomerNegativeCriterionRequest other) {
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
    public void MergeFrom(GetCustomerNegativeCriterionRequest other) {
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
  /// Request message for
  /// [CustomerNegativeCriterionService.MutateCustomerNegativeCriteria][google.ads.googleads.v1.services.CustomerNegativeCriterionService.MutateCustomerNegativeCriteria].
  /// </summary>
  public sealed partial class MutateCustomerNegativeCriteriaRequest : pb::IMessage<MutateCustomerNegativeCriteriaRequest> {
    private static readonly pb::MessageParser<MutateCustomerNegativeCriteriaRequest> _parser = new pb::MessageParser<MutateCustomerNegativeCriteriaRequest>(() => new MutateCustomerNegativeCriteriaRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateCustomerNegativeCriteriaRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Services.CustomerNegativeCriterionServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCustomerNegativeCriteriaRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCustomerNegativeCriteriaRequest(MutateCustomerNegativeCriteriaRequest other) : this() {
      customerId_ = other.customerId_;
      operations_ = other.operations_.Clone();
      partialFailure_ = other.partialFailure_;
      validateOnly_ = other.validateOnly_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCustomerNegativeCriteriaRequest Clone() {
      return new MutateCustomerNegativeCriteriaRequest(this);
    }

    /// <summary>Field number for the "customer_id" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private string customerId_ = "";
    /// <summary>
    /// The ID of the customer whose criteria are being modified.
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
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V1.Services.CustomerNegativeCriterionOperation> _repeated_operations_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V1.Services.CustomerNegativeCriterionOperation.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V1.Services.CustomerNegativeCriterionOperation> operations_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V1.Services.CustomerNegativeCriterionOperation>();
    /// <summary>
    /// The list of operations to perform on individual criteria.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V1.Services.CustomerNegativeCriterionOperation> Operations {
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
      return Equals(other as MutateCustomerNegativeCriteriaRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateCustomerNegativeCriteriaRequest other) {
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
    public void MergeFrom(MutateCustomerNegativeCriteriaRequest other) {
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
  /// A single operation (create or remove) on a customer level negative criterion.
  /// </summary>
  public sealed partial class CustomerNegativeCriterionOperation : pb::IMessage<CustomerNegativeCriterionOperation> {
    private static readonly pb::MessageParser<CustomerNegativeCriterionOperation> _parser = new pb::MessageParser<CustomerNegativeCriterionOperation>(() => new CustomerNegativeCriterionOperation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomerNegativeCriterionOperation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Services.CustomerNegativeCriterionServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerNegativeCriterionOperation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerNegativeCriterionOperation(CustomerNegativeCriterionOperation other) : this() {
      switch (other.OperationCase) {
        case OperationOneofCase.Create:
          Create = other.Create.Clone();
          break;
        case OperationOneofCase.Remove:
          Remove = other.Remove;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerNegativeCriterionOperation Clone() {
      return new CustomerNegativeCriterionOperation(this);
    }

    /// <summary>Field number for the "create" field.</summary>
    public const int CreateFieldNumber = 1;
    /// <summary>
    /// Create operation: No resource name is expected for the new criterion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Resources.CustomerNegativeCriterion Create {
      get { return operationCase_ == OperationOneofCase.Create ? (global::Google.Ads.GoogleAds.V1.Resources.CustomerNegativeCriterion) operation_ : null; }
      set {
        operation_ = value;
        operationCase_ = value == null ? OperationOneofCase.None : OperationOneofCase.Create;
      }
    }

    /// <summary>Field number for the "remove" field.</summary>
    public const int RemoveFieldNumber = 2;
    /// <summary>
    /// Remove operation: A resource name for the removed criterion is expected,
    /// in this format:
    ///
    /// `customers/{customer_id}/customerNegativeCriteria/{criterion_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Remove {
      get { return operationCase_ == OperationOneofCase.Remove ? (string) operation_ : ""; }
      set {
        operation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        operationCase_ = OperationOneofCase.Remove;
      }
    }

    private object operation_;
    /// <summary>Enum of possible cases for the "operation" oneof.</summary>
    public enum OperationOneofCase {
      None = 0,
      Create = 1,
      Remove = 2,
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
      return Equals(other as CustomerNegativeCriterionOperation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomerNegativeCriterionOperation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Create, other.Create)) return false;
      if (Remove != other.Remove) return false;
      if (OperationCase != other.OperationCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (operationCase_ == OperationOneofCase.Create) hash ^= Create.GetHashCode();
      if (operationCase_ == OperationOneofCase.Remove) hash ^= Remove.GetHashCode();
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
      if (operationCase_ == OperationOneofCase.Remove) {
        output.WriteRawTag(18);
        output.WriteString(Remove);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (operationCase_ == OperationOneofCase.Create) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Create);
      }
      if (operationCase_ == OperationOneofCase.Remove) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Remove);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CustomerNegativeCriterionOperation other) {
      if (other == null) {
        return;
      }
      switch (other.OperationCase) {
        case OperationOneofCase.Create:
          if (Create == null) {
            Create = new global::Google.Ads.GoogleAds.V1.Resources.CustomerNegativeCriterion();
          }
          Create.MergeFrom(other.Create);
          break;
        case OperationOneofCase.Remove:
          Remove = other.Remove;
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
            global::Google.Ads.GoogleAds.V1.Resources.CustomerNegativeCriterion subBuilder = new global::Google.Ads.GoogleAds.V1.Resources.CustomerNegativeCriterion();
            if (operationCase_ == OperationOneofCase.Create) {
              subBuilder.MergeFrom(Create);
            }
            input.ReadMessage(subBuilder);
            Create = subBuilder;
            break;
          }
          case 18: {
            Remove = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Response message for customer negative criterion mutate.
  /// </summary>
  public sealed partial class MutateCustomerNegativeCriteriaResponse : pb::IMessage<MutateCustomerNegativeCriteriaResponse> {
    private static readonly pb::MessageParser<MutateCustomerNegativeCriteriaResponse> _parser = new pb::MessageParser<MutateCustomerNegativeCriteriaResponse>(() => new MutateCustomerNegativeCriteriaResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateCustomerNegativeCriteriaResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Services.CustomerNegativeCriterionServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCustomerNegativeCriteriaResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCustomerNegativeCriteriaResponse(MutateCustomerNegativeCriteriaResponse other) : this() {
      partialFailureError_ = other.partialFailureError_ != null ? other.partialFailureError_.Clone() : null;
      results_ = other.results_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCustomerNegativeCriteriaResponse Clone() {
      return new MutateCustomerNegativeCriteriaResponse(this);
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
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V1.Services.MutateCustomerNegativeCriteriaResult> _repeated_results_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V1.Services.MutateCustomerNegativeCriteriaResult.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V1.Services.MutateCustomerNegativeCriteriaResult> results_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V1.Services.MutateCustomerNegativeCriteriaResult>();
    /// <summary>
    /// All results for the mutate.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V1.Services.MutateCustomerNegativeCriteriaResult> Results {
      get { return results_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MutateCustomerNegativeCriteriaResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateCustomerNegativeCriteriaResponse other) {
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
    public void MergeFrom(MutateCustomerNegativeCriteriaResponse other) {
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
  /// The result for the criterion mutate.
  /// </summary>
  public sealed partial class MutateCustomerNegativeCriteriaResult : pb::IMessage<MutateCustomerNegativeCriteriaResult> {
    private static readonly pb::MessageParser<MutateCustomerNegativeCriteriaResult> _parser = new pb::MessageParser<MutateCustomerNegativeCriteriaResult>(() => new MutateCustomerNegativeCriteriaResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateCustomerNegativeCriteriaResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Services.CustomerNegativeCriterionServiceReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCustomerNegativeCriteriaResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCustomerNegativeCriteriaResult(MutateCustomerNegativeCriteriaResult other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCustomerNegativeCriteriaResult Clone() {
      return new MutateCustomerNegativeCriteriaResult(this);
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
      return Equals(other as MutateCustomerNegativeCriteriaResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateCustomerNegativeCriteriaResult other) {
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
    public void MergeFrom(MutateCustomerNegativeCriteriaResult other) {
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