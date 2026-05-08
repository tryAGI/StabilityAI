#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MaskingUsingInitImageAlphaRequestBody : global::System.IEquatable<MaskingUsingInitImageAlphaRequestBody>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1? MaskingUsingInitImageAlphaRequestBodyVariant1 { get; init; }
#else
        public global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1? MaskingUsingInitImageAlphaRequestBodyVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MaskingUsingInitImageAlphaRequestBodyVariant1))]
#endif
        public bool IsMaskingUsingInitImageAlphaRequestBodyVariant1 => MaskingUsingInitImageAlphaRequestBodyVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMaskingUsingInitImageAlphaRequestBodyVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1? value)
        {
            value = MaskingUsingInitImageAlphaRequestBodyVariant1;
            return IsMaskingUsingInitImageAlphaRequestBodyVariant1;
        }

        /// <summary>
        /// Represents the optional parameters that can be passed to any generation request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::StabilityAI.GenerationRequestOptionalParams? GenerationOptionalParams { get; init; }
#else
        public global::StabilityAI.GenerationRequestOptionalParams? GenerationOptionalParams { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerationOptionalParams))]
#endif
        public bool IsGenerationOptionalParams => GenerationOptionalParams != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGenerationOptionalParams(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::StabilityAI.GenerationRequestOptionalParams? value)
        {
            value = GenerationOptionalParams;
            return IsGenerationOptionalParams;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MaskingUsingInitImageAlphaRequestBody(global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1 value) => new MaskingUsingInitImageAlphaRequestBody((global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1?(MaskingUsingInitImageAlphaRequestBody @this) => @this.MaskingUsingInitImageAlphaRequestBodyVariant1;

        /// <summary>
        /// 
        /// </summary>
        public MaskingUsingInitImageAlphaRequestBody(global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1? value)
        {
            MaskingUsingInitImageAlphaRequestBodyVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MaskingUsingInitImageAlphaRequestBody(global::StabilityAI.GenerationRequestOptionalParams value) => new MaskingUsingInitImageAlphaRequestBody((global::StabilityAI.GenerationRequestOptionalParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::StabilityAI.GenerationRequestOptionalParams?(MaskingUsingInitImageAlphaRequestBody @this) => @this.GenerationOptionalParams;

        /// <summary>
        /// 
        /// </summary>
        public MaskingUsingInitImageAlphaRequestBody(global::StabilityAI.GenerationRequestOptionalParams? value)
        {
            GenerationOptionalParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MaskingUsingInitImageAlphaRequestBody(
            global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1? maskingUsingInitImageAlphaRequestBodyVariant1,
            global::StabilityAI.GenerationRequestOptionalParams? generationOptionalParams
            )
        {
            MaskingUsingInitImageAlphaRequestBodyVariant1 = maskingUsingInitImageAlphaRequestBodyVariant1;
            GenerationOptionalParams = generationOptionalParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GenerationOptionalParams as object ??
            MaskingUsingInitImageAlphaRequestBodyVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MaskingUsingInitImageAlphaRequestBodyVariant1?.ToString() ??
            GenerationOptionalParams?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMaskingUsingInitImageAlphaRequestBodyVariant1 && IsGenerationOptionalParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1, TResult>? maskingUsingInitImageAlphaRequestBodyVariant1 = null,
            global::System.Func<global::StabilityAI.GenerationRequestOptionalParams, TResult>? generationOptionalParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMaskingUsingInitImageAlphaRequestBodyVariant1 && maskingUsingInitImageAlphaRequestBodyVariant1 != null)
            {
                return maskingUsingInitImageAlphaRequestBodyVariant1(MaskingUsingInitImageAlphaRequestBodyVariant1!);
            }
            else if (IsGenerationOptionalParams && generationOptionalParams != null)
            {
                return generationOptionalParams(GenerationOptionalParams!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1>? maskingUsingInitImageAlphaRequestBodyVariant1 = null,

            global::System.Action<global::StabilityAI.GenerationRequestOptionalParams>? generationOptionalParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMaskingUsingInitImageAlphaRequestBodyVariant1)
            {
                maskingUsingInitImageAlphaRequestBodyVariant1?.Invoke(MaskingUsingInitImageAlphaRequestBodyVariant1!);
            }
            else if (IsGenerationOptionalParams)
            {
                generationOptionalParams?.Invoke(GenerationOptionalParams!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1>? maskingUsingInitImageAlphaRequestBodyVariant1 = null,
            global::System.Action<global::StabilityAI.GenerationRequestOptionalParams>? generationOptionalParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMaskingUsingInitImageAlphaRequestBodyVariant1)
            {
                maskingUsingInitImageAlphaRequestBodyVariant1?.Invoke(MaskingUsingInitImageAlphaRequestBodyVariant1!);
            }
            else if (IsGenerationOptionalParams)
            {
                generationOptionalParams?.Invoke(GenerationOptionalParams!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MaskingUsingInitImageAlphaRequestBodyVariant1,
                typeof(global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1),
                GenerationOptionalParams,
                typeof(global::StabilityAI.GenerationRequestOptionalParams),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(MaskingUsingInitImageAlphaRequestBody other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1?>.Default.Equals(MaskingUsingInitImageAlphaRequestBodyVariant1, other.MaskingUsingInitImageAlphaRequestBodyVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::StabilityAI.GenerationRequestOptionalParams?>.Default.Equals(GenerationOptionalParams, other.GenerationOptionalParams) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MaskingUsingInitImageAlphaRequestBody obj1, MaskingUsingInitImageAlphaRequestBody obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MaskingUsingInitImageAlphaRequestBody>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MaskingUsingInitImageAlphaRequestBody obj1, MaskingUsingInitImageAlphaRequestBody obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MaskingUsingInitImageAlphaRequestBody o && Equals(o);
        }
    }
}
