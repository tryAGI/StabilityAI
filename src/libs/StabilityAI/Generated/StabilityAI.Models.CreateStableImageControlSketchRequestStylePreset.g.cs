
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Guides the image model towards a particular style.
    /// </summary>
    public enum CreateStableImageControlSketchRequestStylePreset
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
    public static class CreateStableImageControlSketchRequestStylePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageControlSketchRequestStylePreset value)
        {
            return value switch
            {
                CreateStableImageControlSketchRequestStylePreset.x3dModel => "3d-model",
                CreateStableImageControlSketchRequestStylePreset.AnalogFilm => "analog-film",
                CreateStableImageControlSketchRequestStylePreset.Anime => "anime",
                CreateStableImageControlSketchRequestStylePreset.Cinematic => "cinematic",
                CreateStableImageControlSketchRequestStylePreset.ComicBook => "comic-book",
                CreateStableImageControlSketchRequestStylePreset.DigitalArt => "digital-art",
                CreateStableImageControlSketchRequestStylePreset.Enhance => "enhance",
                CreateStableImageControlSketchRequestStylePreset.FantasyArt => "fantasy-art",
                CreateStableImageControlSketchRequestStylePreset.Isometric => "isometric",
                CreateStableImageControlSketchRequestStylePreset.LineArt => "line-art",
                CreateStableImageControlSketchRequestStylePreset.LowPoly => "low-poly",
                CreateStableImageControlSketchRequestStylePreset.ModelingCompound => "modeling-compound",
                CreateStableImageControlSketchRequestStylePreset.NeonPunk => "neon-punk",
                CreateStableImageControlSketchRequestStylePreset.Origami => "origami",
                CreateStableImageControlSketchRequestStylePreset.Photographic => "photographic",
                CreateStableImageControlSketchRequestStylePreset.PixelArt => "pixel-art",
                CreateStableImageControlSketchRequestStylePreset.TileTexture => "tile-texture",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageControlSketchRequestStylePreset? ToEnum(string value)
        {
            return value switch
            {
                "3d-model" => CreateStableImageControlSketchRequestStylePreset.x3dModel,
                "analog-film" => CreateStableImageControlSketchRequestStylePreset.AnalogFilm,
                "anime" => CreateStableImageControlSketchRequestStylePreset.Anime,
                "cinematic" => CreateStableImageControlSketchRequestStylePreset.Cinematic,
                "comic-book" => CreateStableImageControlSketchRequestStylePreset.ComicBook,
                "digital-art" => CreateStableImageControlSketchRequestStylePreset.DigitalArt,
                "enhance" => CreateStableImageControlSketchRequestStylePreset.Enhance,
                "fantasy-art" => CreateStableImageControlSketchRequestStylePreset.FantasyArt,
                "isometric" => CreateStableImageControlSketchRequestStylePreset.Isometric,
                "line-art" => CreateStableImageControlSketchRequestStylePreset.LineArt,
                "low-poly" => CreateStableImageControlSketchRequestStylePreset.LowPoly,
                "modeling-compound" => CreateStableImageControlSketchRequestStylePreset.ModelingCompound,
                "neon-punk" => CreateStableImageControlSketchRequestStylePreset.NeonPunk,
                "origami" => CreateStableImageControlSketchRequestStylePreset.Origami,
                "photographic" => CreateStableImageControlSketchRequestStylePreset.Photographic,
                "pixel-art" => CreateStableImageControlSketchRequestStylePreset.PixelArt,
                "tile-texture" => CreateStableImageControlSketchRequestStylePreset.TileTexture,
                _ => null,
            };
        }
    }
}