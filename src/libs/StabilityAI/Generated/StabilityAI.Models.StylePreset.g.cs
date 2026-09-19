
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Guides the image model towards a particular style.
    /// </summary>
    public enum StylePreset
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
    public static class StylePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StylePreset value)
        {
            return value switch
            {
                StylePreset.x3dModel => "3d-model",
                StylePreset.AnalogFilm => "analog-film",
                StylePreset.Anime => "anime",
                StylePreset.Cinematic => "cinematic",
                StylePreset.ComicBook => "comic-book",
                StylePreset.DigitalArt => "digital-art",
                StylePreset.Enhance => "enhance",
                StylePreset.FantasyArt => "fantasy-art",
                StylePreset.Isometric => "isometric",
                StylePreset.LineArt => "line-art",
                StylePreset.LowPoly => "low-poly",
                StylePreset.ModelingCompound => "modeling-compound",
                StylePreset.NeonPunk => "neon-punk",
                StylePreset.Origami => "origami",
                StylePreset.Photographic => "photographic",
                StylePreset.PixelArt => "pixel-art",
                StylePreset.TileTexture => "tile-texture",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StylePreset? ToEnum(string value)
        {
            return value switch
            {
                "3d-model" => StylePreset.x3dModel,
                "analog-film" => StylePreset.AnalogFilm,
                "anime" => StylePreset.Anime,
                "cinematic" => StylePreset.Cinematic,
                "comic-book" => StylePreset.ComicBook,
                "digital-art" => StylePreset.DigitalArt,
                "enhance" => StylePreset.Enhance,
                "fantasy-art" => StylePreset.FantasyArt,
                "isometric" => StylePreset.Isometric,
                "line-art" => StylePreset.LineArt,
                "low-poly" => StylePreset.LowPoly,
                "modeling-compound" => StylePreset.ModelingCompound,
                "neon-punk" => StylePreset.NeonPunk,
                "origami" => StylePreset.Origami,
                "photographic" => StylePreset.Photographic,
                "pixel-art" => StylePreset.PixelArt,
                "tile-texture" => StylePreset.TileTexture,
                _ => null,
            };
        }
    }
}