
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Guides the image model towards a particular style.
    /// </summary>
    public enum CreateStableImageGenerateCoreRequestStylePreset
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
    public static class CreateStableImageGenerateCoreRequestStylePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageGenerateCoreRequestStylePreset value)
        {
            return value switch
            {
                CreateStableImageGenerateCoreRequestStylePreset.x3dModel => "3d-model",
                CreateStableImageGenerateCoreRequestStylePreset.AnalogFilm => "analog-film",
                CreateStableImageGenerateCoreRequestStylePreset.Anime => "anime",
                CreateStableImageGenerateCoreRequestStylePreset.Cinematic => "cinematic",
                CreateStableImageGenerateCoreRequestStylePreset.ComicBook => "comic-book",
                CreateStableImageGenerateCoreRequestStylePreset.DigitalArt => "digital-art",
                CreateStableImageGenerateCoreRequestStylePreset.Enhance => "enhance",
                CreateStableImageGenerateCoreRequestStylePreset.FantasyArt => "fantasy-art",
                CreateStableImageGenerateCoreRequestStylePreset.Isometric => "isometric",
                CreateStableImageGenerateCoreRequestStylePreset.LineArt => "line-art",
                CreateStableImageGenerateCoreRequestStylePreset.LowPoly => "low-poly",
                CreateStableImageGenerateCoreRequestStylePreset.ModelingCompound => "modeling-compound",
                CreateStableImageGenerateCoreRequestStylePreset.NeonPunk => "neon-punk",
                CreateStableImageGenerateCoreRequestStylePreset.Origami => "origami",
                CreateStableImageGenerateCoreRequestStylePreset.Photographic => "photographic",
                CreateStableImageGenerateCoreRequestStylePreset.PixelArt => "pixel-art",
                CreateStableImageGenerateCoreRequestStylePreset.TileTexture => "tile-texture",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageGenerateCoreRequestStylePreset? ToEnum(string value)
        {
            return value switch
            {
                "3d-model" => CreateStableImageGenerateCoreRequestStylePreset.x3dModel,
                "analog-film" => CreateStableImageGenerateCoreRequestStylePreset.AnalogFilm,
                "anime" => CreateStableImageGenerateCoreRequestStylePreset.Anime,
                "cinematic" => CreateStableImageGenerateCoreRequestStylePreset.Cinematic,
                "comic-book" => CreateStableImageGenerateCoreRequestStylePreset.ComicBook,
                "digital-art" => CreateStableImageGenerateCoreRequestStylePreset.DigitalArt,
                "enhance" => CreateStableImageGenerateCoreRequestStylePreset.Enhance,
                "fantasy-art" => CreateStableImageGenerateCoreRequestStylePreset.FantasyArt,
                "isometric" => CreateStableImageGenerateCoreRequestStylePreset.Isometric,
                "line-art" => CreateStableImageGenerateCoreRequestStylePreset.LineArt,
                "low-poly" => CreateStableImageGenerateCoreRequestStylePreset.LowPoly,
                "modeling-compound" => CreateStableImageGenerateCoreRequestStylePreset.ModelingCompound,
                "neon-punk" => CreateStableImageGenerateCoreRequestStylePreset.NeonPunk,
                "origami" => CreateStableImageGenerateCoreRequestStylePreset.Origami,
                "photographic" => CreateStableImageGenerateCoreRequestStylePreset.Photographic,
                "pixel-art" => CreateStableImageGenerateCoreRequestStylePreset.PixelArt,
                "tile-texture" => CreateStableImageGenerateCoreRequestStylePreset.TileTexture,
                _ => null,
            };
        }
    }
}