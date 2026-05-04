
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Guides the image model towards a particular style.
    /// </summary>
    public enum CreateStableImageUpscaleCreativeRequestStylePreset
    {
        /// <summary>
        /// 
        /// </summary>
        x3dModel,
        /// <summary>
        /// 
        /// </summary>
        AnalogFilm,
        /// <summary>
        /// 
        /// </summary>
        Anime,
        /// <summary>
        /// 
        /// </summary>
        Cinematic,
        /// <summary>
        /// 
        /// </summary>
        ComicBook,
        /// <summary>
        /// 
        /// </summary>
        DigitalArt,
        /// <summary>
        /// 
        /// </summary>
        Enhance,
        /// <summary>
        /// 
        /// </summary>
        FantasyArt,
        /// <summary>
        /// 
        /// </summary>
        Isometric,
        /// <summary>
        /// 
        /// </summary>
        LineArt,
        /// <summary>
        /// 
        /// </summary>
        LowPoly,
        /// <summary>
        /// 
        /// </summary>
        ModelingCompound,
        /// <summary>
        /// 
        /// </summary>
        NeonPunk,
        /// <summary>
        /// 
        /// </summary>
        Origami,
        /// <summary>
        /// 
        /// </summary>
        Photographic,
        /// <summary>
        /// 
        /// </summary>
        PixelArt,
        /// <summary>
        /// 
        /// </summary>
        TileTexture,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStableImageUpscaleCreativeRequestStylePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageUpscaleCreativeRequestStylePreset value)
        {
            return value switch
            {
                CreateStableImageUpscaleCreativeRequestStylePreset.x3dModel => "3d-model",
                CreateStableImageUpscaleCreativeRequestStylePreset.AnalogFilm => "analog-film",
                CreateStableImageUpscaleCreativeRequestStylePreset.Anime => "anime",
                CreateStableImageUpscaleCreativeRequestStylePreset.Cinematic => "cinematic",
                CreateStableImageUpscaleCreativeRequestStylePreset.ComicBook => "comic-book",
                CreateStableImageUpscaleCreativeRequestStylePreset.DigitalArt => "digital-art",
                CreateStableImageUpscaleCreativeRequestStylePreset.Enhance => "enhance",
                CreateStableImageUpscaleCreativeRequestStylePreset.FantasyArt => "fantasy-art",
                CreateStableImageUpscaleCreativeRequestStylePreset.Isometric => "isometric",
                CreateStableImageUpscaleCreativeRequestStylePreset.LineArt => "line-art",
                CreateStableImageUpscaleCreativeRequestStylePreset.LowPoly => "low-poly",
                CreateStableImageUpscaleCreativeRequestStylePreset.ModelingCompound => "modeling-compound",
                CreateStableImageUpscaleCreativeRequestStylePreset.NeonPunk => "neon-punk",
                CreateStableImageUpscaleCreativeRequestStylePreset.Origami => "origami",
                CreateStableImageUpscaleCreativeRequestStylePreset.Photographic => "photographic",
                CreateStableImageUpscaleCreativeRequestStylePreset.PixelArt => "pixel-art",
                CreateStableImageUpscaleCreativeRequestStylePreset.TileTexture => "tile-texture",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageUpscaleCreativeRequestStylePreset? ToEnum(string value)
        {
            return value switch
            {
                "3d-model" => CreateStableImageUpscaleCreativeRequestStylePreset.x3dModel,
                "analog-film" => CreateStableImageUpscaleCreativeRequestStylePreset.AnalogFilm,
                "anime" => CreateStableImageUpscaleCreativeRequestStylePreset.Anime,
                "cinematic" => CreateStableImageUpscaleCreativeRequestStylePreset.Cinematic,
                "comic-book" => CreateStableImageUpscaleCreativeRequestStylePreset.ComicBook,
                "digital-art" => CreateStableImageUpscaleCreativeRequestStylePreset.DigitalArt,
                "enhance" => CreateStableImageUpscaleCreativeRequestStylePreset.Enhance,
                "fantasy-art" => CreateStableImageUpscaleCreativeRequestStylePreset.FantasyArt,
                "isometric" => CreateStableImageUpscaleCreativeRequestStylePreset.Isometric,
                "line-art" => CreateStableImageUpscaleCreativeRequestStylePreset.LineArt,
                "low-poly" => CreateStableImageUpscaleCreativeRequestStylePreset.LowPoly,
                "modeling-compound" => CreateStableImageUpscaleCreativeRequestStylePreset.ModelingCompound,
                "neon-punk" => CreateStableImageUpscaleCreativeRequestStylePreset.NeonPunk,
                "origami" => CreateStableImageUpscaleCreativeRequestStylePreset.Origami,
                "photographic" => CreateStableImageUpscaleCreativeRequestStylePreset.Photographic,
                "pixel-art" => CreateStableImageUpscaleCreativeRequestStylePreset.PixelArt,
                "tile-texture" => CreateStableImageUpscaleCreativeRequestStylePreset.TileTexture,
                _ => null,
            };
        }
    }
}