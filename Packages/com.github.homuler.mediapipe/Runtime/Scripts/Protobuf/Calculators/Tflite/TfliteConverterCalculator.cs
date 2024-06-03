// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mediapipe/calculators/tflite/tflite_converter_calculator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mediapipe {

  /// <summary>Holder for reflection information generated from mediapipe/calculators/tflite/tflite_converter_calculator.proto</summary>
  public static partial class TfliteConverterCalculatorReflection {

    #region Descriptor
    /// <summary>File descriptor for mediapipe/calculators/tflite/tflite_converter_calculator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TfliteConverterCalculatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5tZWRpYXBpcGUvY2FsY3VsYXRvcnMvdGZsaXRlL3RmbGl0ZV9jb252ZXJ0",
            "ZXJfY2FsY3VsYXRvci5wcm90bxIJbWVkaWFwaXBlGiRtZWRpYXBpcGUvZnJh",
            "bWV3b3JrL2NhbGN1bGF0b3IucHJvdG8ihAQKIFRmTGl0ZUNvbnZlcnRlckNh",
            "bGN1bGF0b3JPcHRpb25zEhkKC3plcm9fY2VudGVyGAEgASgIOgR0cnVlEicK",
            "GHVzZV9jdXN0b21fbm9ybWFsaXphdGlvbhgGIAEoCDoFZmFsc2USFgoKY3Vz",
            "dG9tX2RpdhgHIAEoAjoCLTESFgoKY3VzdG9tX3N1YhgIIAEoAjoCLTESHgoP",
            "ZmxpcF92ZXJ0aWNhbGx5GAIgASgIOgVmYWxzZRIbChBtYXhfbnVtX2NoYW5u",
            "ZWxzGAMgASgFOgEzEh8KEHJvd19tYWpvcl9tYXRyaXgYBCABKAg6BWZhbHNl",
            "EiQKFXVzZV9xdWFudGl6ZWRfdGVuc29ycxgFIAEoCDoFZmFsc2USXwoZb3V0",
            "cHV0X3RlbnNvcl9mbG9hdF9yYW5nZRgJIAEoCzI8Lm1lZGlhcGlwZS5UZkxp",
            "dGVDb252ZXJ0ZXJDYWxjdWxhdG9yT3B0aW9ucy5UZW5zb3JGbG9hdFJhbmdl",
            "GiwKEFRlbnNvckZsb2F0UmFuZ2USCwoDbWluGAEgASgCEgsKA21heBgCIAEo",
            "AjJZCgNleHQSHC5tZWRpYXBpcGUuQ2FsY3VsYXRvck9wdGlvbnMYxcObdSAB",
            "KAsyKy5tZWRpYXBpcGUuVGZMaXRlQ29udmVydGVyQ2FsY3VsYXRvck9wdGlv",
            "bnM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Mediapipe.CalculatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mediapipe.TfLiteConverterCalculatorOptions), global::Mediapipe.TfLiteConverterCalculatorOptions.Parser, new[]{ "ZeroCenter", "UseCustomNormalization", "CustomDiv", "CustomSub", "FlipVertically", "MaxNumChannels", "RowMajorMatrix", "UseQuantizedTensors", "OutputTensorFloatRange" }, null, null, new pb::Extension[] { global::Mediapipe.TfLiteConverterCalculatorOptions.Extensions.Ext }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Mediapipe.TfLiteConverterCalculatorOptions.Types.TensorFloatRange), global::Mediapipe.TfLiteConverterCalculatorOptions.Types.TensorFloatRange.Parser, new[]{ "Min", "Max" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Full Example:
  ///
  /// node {
  ///   calculator: "TfLiteConverterCalculator"
  ///   input_stream: "IMAGE_IN:input_image"
  ///   output_stream: "TENSOR_OUT:image_tensor"
  ///   options {
  ///     [mediapipe.TfLiteConverterCalculatorOptions.ext] {
  ///       zero_center: true
  ///     }
  ///   }
  /// }
  /// </summary>
  public sealed partial class TfLiteConverterCalculatorOptions : pb::IMessage<TfLiteConverterCalculatorOptions>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TfLiteConverterCalculatorOptions> _parser = new pb::MessageParser<TfLiteConverterCalculatorOptions>(() => new TfLiteConverterCalculatorOptions());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TfLiteConverterCalculatorOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mediapipe.TfliteConverterCalculatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TfLiteConverterCalculatorOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TfLiteConverterCalculatorOptions(TfLiteConverterCalculatorOptions other) : this() {
      _hasBits0 = other._hasBits0;
      zeroCenter_ = other.zeroCenter_;
      useCustomNormalization_ = other.useCustomNormalization_;
      customDiv_ = other.customDiv_;
      customSub_ = other.customSub_;
      flipVertically_ = other.flipVertically_;
      maxNumChannels_ = other.maxNumChannels_;
      rowMajorMatrix_ = other.rowMajorMatrix_;
      useQuantizedTensors_ = other.useQuantizedTensors_;
      outputTensorFloatRange_ = other.outputTensorFloatRange_ != null ? other.outputTensorFloatRange_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TfLiteConverterCalculatorOptions Clone() {
      return new TfLiteConverterCalculatorOptions(this);
    }

    /// <summary>Field number for the "zero_center" field.</summary>
    public const int ZeroCenterFieldNumber = 1;
    private readonly static bool ZeroCenterDefaultValue = true;

    private bool zeroCenter_;
    /// <summary>
    /// Choose normalization mode for output (not applied for Matrix inputs).
    /// true = [-1,1]
    /// false = [0,1]
    /// Ignored if using quantization.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ZeroCenter {
      get { if ((_hasBits0 & 1) != 0) { return zeroCenter_; } else { return ZeroCenterDefaultValue; } }
      set {
        _hasBits0 |= 1;
        zeroCenter_ = value;
      }
    }
    /// <summary>Gets whether the "zero_center" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasZeroCenter {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "zero_center" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearZeroCenter() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "use_custom_normalization" field.</summary>
    public const int UseCustomNormalizationFieldNumber = 6;
    private readonly static bool UseCustomNormalizationDefaultValue = false;

    private bool useCustomNormalization_;
    /// <summary>
    /// Custom settings to override the internal scaling factors `div` and `sub`.
    /// Both values must be set to non-negative values. Will only take effect on
    /// CPU AND when |use_custom_normalization| is set to true. When these custom
    /// values take effect, the |zero_center| setting above will be overridden, and
    /// the normalized_value will be calculated as:
    /// normalized_value = input / custom_div - custom_sub.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool UseCustomNormalization {
      get { if ((_hasBits0 & 32) != 0) { return useCustomNormalization_; } else { return UseCustomNormalizationDefaultValue; } }
      set {
        _hasBits0 |= 32;
        useCustomNormalization_ = value;
      }
    }
    /// <summary>Gets whether the "use_custom_normalization" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasUseCustomNormalization {
      get { return (_hasBits0 & 32) != 0; }
    }
    /// <summary>Clears the value of the "use_custom_normalization" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearUseCustomNormalization() {
      _hasBits0 &= ~32;
    }

    /// <summary>Field number for the "custom_div" field.</summary>
    public const int CustomDivFieldNumber = 7;
    private readonly static float CustomDivDefaultValue = -1F;

    private float customDiv_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float CustomDiv {
      get { if ((_hasBits0 & 64) != 0) { return customDiv_; } else { return CustomDivDefaultValue; } }
      set {
        _hasBits0 |= 64;
        customDiv_ = value;
      }
    }
    /// <summary>Gets whether the "custom_div" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCustomDiv {
      get { return (_hasBits0 & 64) != 0; }
    }
    /// <summary>Clears the value of the "custom_div" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCustomDiv() {
      _hasBits0 &= ~64;
    }

    /// <summary>Field number for the "custom_sub" field.</summary>
    public const int CustomSubFieldNumber = 8;
    private readonly static float CustomSubDefaultValue = -1F;

    private float customSub_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float CustomSub {
      get { if ((_hasBits0 & 128) != 0) { return customSub_; } else { return CustomSubDefaultValue; } }
      set {
        _hasBits0 |= 128;
        customSub_ = value;
      }
    }
    /// <summary>Gets whether the "custom_sub" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCustomSub {
      get { return (_hasBits0 & 128) != 0; }
    }
    /// <summary>Clears the value of the "custom_sub" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCustomSub() {
      _hasBits0 &= ~128;
    }

    /// <summary>Field number for the "flip_vertically" field.</summary>
    public const int FlipVerticallyFieldNumber = 2;
    private readonly static bool FlipVerticallyDefaultValue = false;

    private bool flipVertically_;
    /// <summary>
    /// Whether the input image should be flipped vertically (along the
    /// y-direction). This is useful, for example, when the input image is defined
    /// with a coordinate system where the origin is at the bottom-left corner
    /// (e.g., in OpenGL) whereas the ML model expects an image with a top-left
    /// origin.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool FlipVertically {
      get { if ((_hasBits0 & 2) != 0) { return flipVertically_; } else { return FlipVerticallyDefaultValue; } }
      set {
        _hasBits0 |= 2;
        flipVertically_ = value;
      }
    }
    /// <summary>Gets whether the "flip_vertically" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasFlipVertically {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "flip_vertically" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearFlipVertically() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "max_num_channels" field.</summary>
    public const int MaxNumChannelsFieldNumber = 3;
    private readonly static int MaxNumChannelsDefaultValue = 3;

    private int maxNumChannels_;
    /// <summary>
    /// Controls how many channels of the input image get passed through to the
    /// tensor. Valid values are 1,3,4 only. Ignored for iOS GPU.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MaxNumChannels {
      get { if ((_hasBits0 & 4) != 0) { return maxNumChannels_; } else { return MaxNumChannelsDefaultValue; } }
      set {
        _hasBits0 |= 4;
        maxNumChannels_ = value;
      }
    }
    /// <summary>Gets whether the "max_num_channels" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasMaxNumChannels {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "max_num_channels" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearMaxNumChannels() {
      _hasBits0 &= ~4;
    }

    /// <summary>Field number for the "row_major_matrix" field.</summary>
    public const int RowMajorMatrixFieldNumber = 4;
    private readonly static bool RowMajorMatrixDefaultValue = false;

    private bool rowMajorMatrix_;
    /// <summary>
    /// The calculator expects Matrix inputs to be in column-major order. Set
    /// row_major_matrix to true if the inputs are in row-major order.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool RowMajorMatrix {
      get { if ((_hasBits0 & 8) != 0) { return rowMajorMatrix_; } else { return RowMajorMatrixDefaultValue; } }
      set {
        _hasBits0 |= 8;
        rowMajorMatrix_ = value;
      }
    }
    /// <summary>Gets whether the "row_major_matrix" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasRowMajorMatrix {
      get { return (_hasBits0 & 8) != 0; }
    }
    /// <summary>Clears the value of the "row_major_matrix" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearRowMajorMatrix() {
      _hasBits0 &= ~8;
    }

    /// <summary>Field number for the "use_quantized_tensors" field.</summary>
    public const int UseQuantizedTensorsFieldNumber = 5;
    private readonly static bool UseQuantizedTensorsDefaultValue = false;

    private bool useQuantizedTensors_;
    /// <summary>
    /// Quantization option (CPU only).
    /// When true, output kTfLiteUInt8 tensor instead of kTfLiteFloat32.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool UseQuantizedTensors {
      get { if ((_hasBits0 & 16) != 0) { return useQuantizedTensors_; } else { return UseQuantizedTensorsDefaultValue; } }
      set {
        _hasBits0 |= 16;
        useQuantizedTensors_ = value;
      }
    }
    /// <summary>Gets whether the "use_quantized_tensors" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasUseQuantizedTensors {
      get { return (_hasBits0 & 16) != 0; }
    }
    /// <summary>Clears the value of the "use_quantized_tensors" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearUseQuantizedTensors() {
      _hasBits0 &= ~16;
    }

    /// <summary>Field number for the "output_tensor_float_range" field.</summary>
    public const int OutputTensorFloatRangeFieldNumber = 9;
    private global::Mediapipe.TfLiteConverterCalculatorOptions.Types.TensorFloatRange outputTensorFloatRange_;
    /// <summary>
    /// Normalization option.
    /// Setting normalization_range results in the values normalized to
    /// the range [output_tensor_float_range.min, output_tensor_float_range.max].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Mediapipe.TfLiteConverterCalculatorOptions.Types.TensorFloatRange OutputTensorFloatRange {
      get { return outputTensorFloatRange_; }
      set {
        outputTensorFloatRange_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TfLiteConverterCalculatorOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TfLiteConverterCalculatorOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ZeroCenter != other.ZeroCenter) return false;
      if (UseCustomNormalization != other.UseCustomNormalization) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CustomDiv, other.CustomDiv)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CustomSub, other.CustomSub)) return false;
      if (FlipVertically != other.FlipVertically) return false;
      if (MaxNumChannels != other.MaxNumChannels) return false;
      if (RowMajorMatrix != other.RowMajorMatrix) return false;
      if (UseQuantizedTensors != other.UseQuantizedTensors) return false;
      if (!object.Equals(OutputTensorFloatRange, other.OutputTensorFloatRange)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasZeroCenter) hash ^= ZeroCenter.GetHashCode();
      if (HasUseCustomNormalization) hash ^= UseCustomNormalization.GetHashCode();
      if (HasCustomDiv) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CustomDiv);
      if (HasCustomSub) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CustomSub);
      if (HasFlipVertically) hash ^= FlipVertically.GetHashCode();
      if (HasMaxNumChannels) hash ^= MaxNumChannels.GetHashCode();
      if (HasRowMajorMatrix) hash ^= RowMajorMatrix.GetHashCode();
      if (HasUseQuantizedTensors) hash ^= UseQuantizedTensors.GetHashCode();
      if (outputTensorFloatRange_ != null) hash ^= OutputTensorFloatRange.GetHashCode();
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
      if (HasZeroCenter) {
        output.WriteRawTag(8);
        output.WriteBool(ZeroCenter);
      }
      if (HasFlipVertically) {
        output.WriteRawTag(16);
        output.WriteBool(FlipVertically);
      }
      if (HasMaxNumChannels) {
        output.WriteRawTag(24);
        output.WriteInt32(MaxNumChannels);
      }
      if (HasRowMajorMatrix) {
        output.WriteRawTag(32);
        output.WriteBool(RowMajorMatrix);
      }
      if (HasUseQuantizedTensors) {
        output.WriteRawTag(40);
        output.WriteBool(UseQuantizedTensors);
      }
      if (HasUseCustomNormalization) {
        output.WriteRawTag(48);
        output.WriteBool(UseCustomNormalization);
      }
      if (HasCustomDiv) {
        output.WriteRawTag(61);
        output.WriteFloat(CustomDiv);
      }
      if (HasCustomSub) {
        output.WriteRawTag(69);
        output.WriteFloat(CustomSub);
      }
      if (outputTensorFloatRange_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(OutputTensorFloatRange);
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
      if (HasZeroCenter) {
        output.WriteRawTag(8);
        output.WriteBool(ZeroCenter);
      }
      if (HasFlipVertically) {
        output.WriteRawTag(16);
        output.WriteBool(FlipVertically);
      }
      if (HasMaxNumChannels) {
        output.WriteRawTag(24);
        output.WriteInt32(MaxNumChannels);
      }
      if (HasRowMajorMatrix) {
        output.WriteRawTag(32);
        output.WriteBool(RowMajorMatrix);
      }
      if (HasUseQuantizedTensors) {
        output.WriteRawTag(40);
        output.WriteBool(UseQuantizedTensors);
      }
      if (HasUseCustomNormalization) {
        output.WriteRawTag(48);
        output.WriteBool(UseCustomNormalization);
      }
      if (HasCustomDiv) {
        output.WriteRawTag(61);
        output.WriteFloat(CustomDiv);
      }
      if (HasCustomSub) {
        output.WriteRawTag(69);
        output.WriteFloat(CustomSub);
      }
      if (outputTensorFloatRange_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(OutputTensorFloatRange);
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
      if (HasZeroCenter) {
        size += 1 + 1;
      }
      if (HasUseCustomNormalization) {
        size += 1 + 1;
      }
      if (HasCustomDiv) {
        size += 1 + 4;
      }
      if (HasCustomSub) {
        size += 1 + 4;
      }
      if (HasFlipVertically) {
        size += 1 + 1;
      }
      if (HasMaxNumChannels) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxNumChannels);
      }
      if (HasRowMajorMatrix) {
        size += 1 + 1;
      }
      if (HasUseQuantizedTensors) {
        size += 1 + 1;
      }
      if (outputTensorFloatRange_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OutputTensorFloatRange);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TfLiteConverterCalculatorOptions other) {
      if (other == null) {
        return;
      }
      if (other.HasZeroCenter) {
        ZeroCenter = other.ZeroCenter;
      }
      if (other.HasUseCustomNormalization) {
        UseCustomNormalization = other.UseCustomNormalization;
      }
      if (other.HasCustomDiv) {
        CustomDiv = other.CustomDiv;
      }
      if (other.HasCustomSub) {
        CustomSub = other.CustomSub;
      }
      if (other.HasFlipVertically) {
        FlipVertically = other.FlipVertically;
      }
      if (other.HasMaxNumChannels) {
        MaxNumChannels = other.MaxNumChannels;
      }
      if (other.HasRowMajorMatrix) {
        RowMajorMatrix = other.RowMajorMatrix;
      }
      if (other.HasUseQuantizedTensors) {
        UseQuantizedTensors = other.UseQuantizedTensors;
      }
      if (other.outputTensorFloatRange_ != null) {
        if (outputTensorFloatRange_ == null) {
          OutputTensorFloatRange = new global::Mediapipe.TfLiteConverterCalculatorOptions.Types.TensorFloatRange();
        }
        OutputTensorFloatRange.MergeFrom(other.OutputTensorFloatRange);
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
            ZeroCenter = input.ReadBool();
            break;
          }
          case 16: {
            FlipVertically = input.ReadBool();
            break;
          }
          case 24: {
            MaxNumChannels = input.ReadInt32();
            break;
          }
          case 32: {
            RowMajorMatrix = input.ReadBool();
            break;
          }
          case 40: {
            UseQuantizedTensors = input.ReadBool();
            break;
          }
          case 48: {
            UseCustomNormalization = input.ReadBool();
            break;
          }
          case 61: {
            CustomDiv = input.ReadFloat();
            break;
          }
          case 69: {
            CustomSub = input.ReadFloat();
            break;
          }
          case 74: {
            if (outputTensorFloatRange_ == null) {
              OutputTensorFloatRange = new global::Mediapipe.TfLiteConverterCalculatorOptions.Types.TensorFloatRange();
            }
            input.ReadMessage(OutputTensorFloatRange);
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
            ZeroCenter = input.ReadBool();
            break;
          }
          case 16: {
            FlipVertically = input.ReadBool();
            break;
          }
          case 24: {
            MaxNumChannels = input.ReadInt32();
            break;
          }
          case 32: {
            RowMajorMatrix = input.ReadBool();
            break;
          }
          case 40: {
            UseQuantizedTensors = input.ReadBool();
            break;
          }
          case 48: {
            UseCustomNormalization = input.ReadBool();
            break;
          }
          case 61: {
            CustomDiv = input.ReadFloat();
            break;
          }
          case 69: {
            CustomSub = input.ReadFloat();
            break;
          }
          case 74: {
            if (outputTensorFloatRange_ == null) {
              OutputTensorFloatRange = new global::Mediapipe.TfLiteConverterCalculatorOptions.Types.TensorFloatRange();
            }
            input.ReadMessage(OutputTensorFloatRange);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the TfLiteConverterCalculatorOptions message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public sealed partial class TensorFloatRange : pb::IMessage<TensorFloatRange>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<TensorFloatRange> _parser = new pb::MessageParser<TensorFloatRange>(() => new TensorFloatRange());
        private pb::UnknownFieldSet _unknownFields;
        private int _hasBits0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<TensorFloatRange> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Mediapipe.TfLiteConverterCalculatorOptions.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public TensorFloatRange() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public TensorFloatRange(TensorFloatRange other) : this() {
          _hasBits0 = other._hasBits0;
          min_ = other.min_;
          max_ = other.max_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public TensorFloatRange Clone() {
          return new TensorFloatRange(this);
        }

        /// <summary>Field number for the "min" field.</summary>
        public const int MinFieldNumber = 1;
        private readonly static float MinDefaultValue = 0F;

        private float min_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public float Min {
          get { if ((_hasBits0 & 1) != 0) { return min_; } else { return MinDefaultValue; } }
          set {
            _hasBits0 |= 1;
            min_ = value;
          }
        }
        /// <summary>Gets whether the "min" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasMin {
          get { return (_hasBits0 & 1) != 0; }
        }
        /// <summary>Clears the value of the "min" field</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearMin() {
          _hasBits0 &= ~1;
        }

        /// <summary>Field number for the "max" field.</summary>
        public const int MaxFieldNumber = 2;
        private readonly static float MaxDefaultValue = 0F;

        private float max_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public float Max {
          get { if ((_hasBits0 & 2) != 0) { return max_; } else { return MaxDefaultValue; } }
          set {
            _hasBits0 |= 2;
            max_ = value;
          }
        }
        /// <summary>Gets whether the "max" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasMax {
          get { return (_hasBits0 & 2) != 0; }
        }
        /// <summary>Clears the value of the "max" field</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearMax() {
          _hasBits0 &= ~2;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as TensorFloatRange);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(TensorFloatRange other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Min, other.Min)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Max, other.Max)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (HasMin) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Min);
          if (HasMax) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Max);
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
          if (HasMin) {
            output.WriteRawTag(13);
            output.WriteFloat(Min);
          }
          if (HasMax) {
            output.WriteRawTag(21);
            output.WriteFloat(Max);
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
          if (HasMin) {
            output.WriteRawTag(13);
            output.WriteFloat(Min);
          }
          if (HasMax) {
            output.WriteRawTag(21);
            output.WriteFloat(Max);
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
          if (HasMin) {
            size += 1 + 4;
          }
          if (HasMax) {
            size += 1 + 4;
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(TensorFloatRange other) {
          if (other == null) {
            return;
          }
          if (other.HasMin) {
            Min = other.Min;
          }
          if (other.HasMax) {
            Max = other.Max;
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
              case 13: {
                Min = input.ReadFloat();
                break;
              }
              case 21: {
                Max = input.ReadFloat();
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
              case 13: {
                Min = input.ReadFloat();
                break;
              }
              case 21: {
                Max = input.ReadFloat();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

    #region Extensions
    /// <summary>Container for extensions for other messages declared in the TfLiteConverterCalculatorOptions message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Extensions {
      public static readonly pb::Extension<global::Mediapipe.CalculatorOptions, global::Mediapipe.TfLiteConverterCalculatorOptions> Ext =
        new pb::Extension<global::Mediapipe.CalculatorOptions, global::Mediapipe.TfLiteConverterCalculatorOptions>(245817797, pb::FieldCodec.ForMessage(1966542378, global::Mediapipe.TfLiteConverterCalculatorOptions.Parser));
    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
