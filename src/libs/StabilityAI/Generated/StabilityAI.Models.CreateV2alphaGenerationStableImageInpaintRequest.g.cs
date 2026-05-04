#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateV2alphaGenerationStableImageInpaintRequest : global::System.IEquatable<CreateV2alphaGenerationStableImageInpaintRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode? Mode { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::StabilityAI.InpaintingSearchModeRequestBody? Search { get; init; }
#else
        public global::StabilityAI.InpaintingSearchModeRequestBody? Search { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Search))]
#endif
        public bool IsSearch => Search != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::StabilityAI.InpaintingMaskingModeRequestBody? Mask { get; init; }
#else
        public global::StabilityAI.InpaintingMaskingModeRequestBody? Mask { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mask))]
#endif
        public bool IsMask => Mask != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateV2alphaGenerationStableImageInpaintRequest(global::StabilityAI.InpaintingSearchModeRequestBody value) => new CreateV2alphaGenerationStableImageInpaintRequest((global::StabilityAI.InpaintingSearchModeRequestBody?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::StabilityAI.InpaintingSearchModeRequestBody?(CreateV2alphaGenerationStableImageInpaintRequest @this) => @this.Search;

        /// <summary>
        /// 
        /// </summary>
        public CreateV2alphaGenerationStableImageInpaintRequest(global::StabilityAI.InpaintingSearchModeRequestBody? value)
        {
            Search = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateV2alphaGenerationStableImageInpaintRequest(global::StabilityAI.InpaintingMaskingModeRequestBody value) => new CreateV2alphaGenerationStableImageInpaintRequest((global::StabilityAI.InpaintingMaskingModeRequestBody?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::StabilityAI.InpaintingMaskingModeRequestBody?(CreateV2alphaGenerationStableImageInpaintRequest @this) => @this.Mask;

        /// <summary>
        /// 
        /// </summary>
        public CreateV2alphaGenerationStableImageInpaintRequest(global::StabilityAI.InpaintingMaskingModeRequestBody? value)
        {
            Mask = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateV2alphaGenerationStableImageInpaintRequest(
            global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode? mode,
            global::StabilityAI.InpaintingSearchModeRequestBody? search,
            global::StabilityAI.InpaintingMaskingModeRequestBody? mask
            )
        {
            Mode = mode;

            Search = search;
            Mask = mask;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Mask as object ??
            Search as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Search?.ToString() ??
            Mask?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSearch && !IsMask || !IsSearch && IsMask;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::StabilityAI.InpaintingSearchModeRequestBody?, TResult>? search = null,
            global::System.Func<global::StabilityAI.InpaintingMaskingModeRequestBody?, TResult>? mask = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearch && search != null)
            {
                return search(Search!);
            }
            else if (IsMask && mask != null)
            {
                return mask(Mask!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::StabilityAI.InpaintingSearchModeRequestBody?>? search = null,
            global::System.Action<global::StabilityAI.InpaintingMaskingModeRequestBody?>? mask = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearch)
            {
                search?.Invoke(Search!);
            }
            else if (IsMask)
            {
                mask?.Invoke(Mask!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Search,
                typeof(global::StabilityAI.InpaintingSearchModeRequestBody),
                Mask,
                typeof(global::StabilityAI.InpaintingMaskingModeRequestBody),
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
        public bool Equals(CreateV2alphaGenerationStableImageInpaintRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::StabilityAI.InpaintingSearchModeRequestBody?>.Default.Equals(Search, other.Search) &&
                global::System.Collections.Generic.EqualityComparer<global::StabilityAI.InpaintingMaskingModeRequestBody?>.Default.Equals(Mask, other.Mask) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateV2alphaGenerationStableImageInpaintRequest obj1, CreateV2alphaGenerationStableImageInpaintRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateV2alphaGenerationStableImageInpaintRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateV2alphaGenerationStableImageInpaintRequest obj1, CreateV2alphaGenerationStableImageInpaintRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateV2alphaGenerationStableImageInpaintRequest o && Equals(o);
        }
    }
}
