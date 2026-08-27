
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Guides the image model towards a particular style.
    /// </summary>
    public enum CreateStableImageEditSearchAndReplaceRequestStylePreset
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
    public static class CreateStableImageEditSearchAndReplaceRequestStylePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageEditSearchAndReplaceRequestStylePreset value)
        {
            return value switch
            {
                CreateStableImageEditSearchAndReplaceRequestStylePreset.x3dModel => "3d-model",
                CreateStableImageEditSearchAndReplaceRequestStylePreset.AnalogFilm => "analog-film",
                CreateStableImageEditSearchAndReplaceRequestStylePreset.Anime => "anime",
                CreateStableImageEditSearchAndReplaceRequestStylePreset.Cinematic => "cinematic",
                CreateStableImageEditSearchAndReplaceRequestStylePreset.ComicBook => "comic-book",
                CreateStableImageEditSearchAndReplaceRequestStylePreset.DigitalArt => "digital-art",
                CreateStableImageEditSearchAndReplaceRequestStylePreset.Enhance => "enhance",
                CreateStableImageEditSearchAndReplaceRequestStylePreset.FantasyArt => "fantasy-art",
                CreateStableImageEditSearchAndReplaceRequestStylePreset.Isometric => "isometric",
                CreateStableImageEditSearchAndReplaceRequestStylePreset.LineArt => "line-art",
                CreateStableImageEditSearchAndReplaceRequestStylePreset.LowPoly => "low-poly",
                CreateStableImageEditSearchAndReplaceRequestStylePreset.ModelingCompound => "modeling-compound",
                CreateStableImageEditSearchAndReplaceRequestStylePreset.NeonPunk => "neon-punk",
                CreateStableImageEditSearchAndReplaceRequestStylePreset.Origami => "origami",
                CreateStableImageEditSearchAndReplaceRequestStylePreset.Photographic => "photographic",
                CreateStableImageEditSearchAndReplaceRequestStylePreset.PixelArt => "pixel-art",
                CreateStableImageEditSearchAndReplaceRequestStylePreset.TileTexture => "tile-texture",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageEditSearchAndReplaceRequestStylePreset? ToEnum(string value)
        {
            return value switch
            {
                "3d-model" => CreateStableImageEditSearchAndReplaceRequestStylePreset.x3dModel,
                "analog-film" => CreateStableImageEditSearchAndReplaceRequestStylePreset.AnalogFilm,
                "anime" => CreateStableImageEditSearchAndReplaceRequestStylePreset.Anime,
                "cinematic" => CreateStableImageEditSearchAndReplaceRequestStylePreset.Cinematic,
                "comic-book" => CreateStableImageEditSearchAndReplaceRequestStylePreset.ComicBook,
                "digital-art" => CreateStableImageEditSearchAndReplaceRequestStylePreset.DigitalArt,
                "enhance" => CreateStableImageEditSearchAndReplaceRequestStylePreset.Enhance,
                "fantasy-art" => CreateStableImageEditSearchAndReplaceRequestStylePreset.FantasyArt,
                "isometric" => CreateStableImageEditSearchAndReplaceRequestStylePreset.Isometric,
                "line-art" => CreateStableImageEditSearchAndReplaceRequestStylePreset.LineArt,
                "low-poly" => CreateStableImageEditSearchAndReplaceRequestStylePreset.LowPoly,
                "modeling-compound" => CreateStableImageEditSearchAndReplaceRequestStylePreset.ModelingCompound,
                "neon-punk" => CreateStableImageEditSearchAndReplaceRequestStylePreset.NeonPunk,
                "origami" => CreateStableImageEditSearchAndReplaceRequestStylePreset.Origami,
                "photographic" => CreateStableImageEditSearchAndReplaceRequestStylePreset.Photographic,
                "pixel-art" => CreateStableImageEditSearchAndReplaceRequestStylePreset.PixelArt,
                "tile-texture" => CreateStableImageEditSearchAndReplaceRequestStylePreset.TileTexture,
                _ => null,
            };
        }
    }
}