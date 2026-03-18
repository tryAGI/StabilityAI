#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Example: {"cfg_scale":7,"clip_guidance_preset":"FAST_BLUE","height":512,"sampler":"K_DPM_2_ANCESTRAL","samples":1,"seed":0,"steps":75,"text_prompts":[{"text":"A lighthouse on a cliff","weight":1}],"width":512}
    /// </summary>
    public readonly partial struct TextToImageRequestBody : global::System.IEquatable<TextToImageRequestBody>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::StabilityAI.TextToImageRequestBodyVariant1? Value1 { get; init; }
#else
        public global::StabilityAI.TextToImageRequestBodyVariant1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// Represents the optional parameters that can be passed to any generation request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::StabilityAI.GenerationRequestOptionalParams? Value2 { get; init; }
#else
        public global::StabilityAI.GenerationRequestOptionalParams? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToImageRequestBody(global::StabilityAI.TextToImageRequestBodyVariant1 value) => new TextToImageRequestBody((global::StabilityAI.TextToImageRequestBodyVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::StabilityAI.TextToImageRequestBodyVariant1?(TextToImageRequestBody @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public TextToImageRequestBody(global::StabilityAI.TextToImageRequestBodyVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToImageRequestBody(global::StabilityAI.GenerationRequestOptionalParams value) => new TextToImageRequestBody((global::StabilityAI.GenerationRequestOptionalParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::StabilityAI.GenerationRequestOptionalParams?(TextToImageRequestBody @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public TextToImageRequestBody(global::StabilityAI.GenerationRequestOptionalParams? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TextToImageRequestBody(
            global::StabilityAI.TextToImageRequestBodyVariant1? value1,
            global::StabilityAI.GenerationRequestOptionalParams? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::StabilityAI.TextToImageRequestBodyVariant1?, TResult>? value1 = null,
            global::System.Func<global::StabilityAI.GenerationRequestOptionalParams?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::StabilityAI.TextToImageRequestBodyVariant1?>? value1 = null,
            global::System.Action<global::StabilityAI.GenerationRequestOptionalParams?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::StabilityAI.TextToImageRequestBodyVariant1),
                Value2,
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
        public bool Equals(TextToImageRequestBody other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::StabilityAI.TextToImageRequestBodyVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::StabilityAI.GenerationRequestOptionalParams?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TextToImageRequestBody obj1, TextToImageRequestBody obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextToImageRequestBody>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TextToImageRequestBody obj1, TextToImageRequestBody obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextToImageRequestBody o && Equals(o);
        }
    }
}
