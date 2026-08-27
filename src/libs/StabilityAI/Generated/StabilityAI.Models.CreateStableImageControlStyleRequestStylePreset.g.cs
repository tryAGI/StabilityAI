
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Guides the image model towards a particular style.
    /// </summary>
    public enum CreateStableImageControlStyleRequestStylePreset
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
    public static class CreateStableImageControlStyleRequestStylePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageControlStyleRequestStylePreset value)
        {
            return value switch
            {
                CreateStableImageControlStyleRequestStylePreset.x3dModel => "3d-model",
                CreateStableImageControlStyleRequestStylePreset.AnalogFilm => "analog-film",
                CreateStableImageControlStyleRequestStylePreset.Anime => "anime",
                CreateStableImageControlStyleRequestStylePreset.Cinematic => "cinematic",
                CreateStableImageControlStyleRequestStylePreset.ComicBook => "comic-book",
                CreateStableImageControlStyleRequestStylePreset.DigitalArt => "digital-art",
                CreateStableImageControlStyleRequestStylePreset.Enhance => "enhance",
                CreateStableImageControlStyleRequestStylePreset.FantasyArt => "fantasy-art",
                CreateStableImageControlStyleRequestStylePreset.Isometric => "isometric",
                CreateStableImageControlStyleRequestStylePreset.LineArt => "line-art",
                CreateStableImageControlStyleRequestStylePreset.LowPoly => "low-poly",
                CreateStableImageControlStyleRequestStylePreset.ModelingCompound => "modeling-compound",
                CreateStableImageControlStyleRequestStylePreset.NeonPunk => "neon-punk",
                CreateStableImageControlStyleRequestStylePreset.Origami => "origami",
                CreateStableImageControlStyleRequestStylePreset.Photographic => "photographic",
                CreateStableImageControlStyleRequestStylePreset.PixelArt => "pixel-art",
                CreateStableImageControlStyleRequestStylePreset.TileTexture => "tile-texture",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageControlStyleRequestStylePreset? ToEnum(string value)
        {
            return value switch
            {
                "3d-model" => CreateStableImageControlStyleRequestStylePreset.x3dModel,
                "analog-film" => CreateStableImageControlStyleRequestStylePreset.AnalogFilm,
                "anime" => CreateStableImageControlStyleRequestStylePreset.Anime,
                "cinematic" => CreateStableImageControlStyleRequestStylePreset.Cinematic,
                "comic-book" => CreateStableImageControlStyleRequestStylePreset.ComicBook,
                "digital-art" => CreateStableImageControlStyleRequestStylePreset.DigitalArt,
                "enhance" => CreateStableImageControlStyleRequestStylePreset.Enhance,
                "fantasy-art" => CreateStableImageControlStyleRequestStylePreset.FantasyArt,
                "isometric" => CreateStableImageControlStyleRequestStylePreset.Isometric,
                "line-art" => CreateStableImageControlStyleRequestStylePreset.LineArt,
                "low-poly" => CreateStableImageControlStyleRequestStylePreset.LowPoly,
                "modeling-compound" => CreateStableImageControlStyleRequestStylePreset.ModelingCompound,
                "neon-punk" => CreateStableImageControlStyleRequestStylePreset.NeonPunk,
                "origami" => CreateStableImageControlStyleRequestStylePreset.Origami,
                "photographic" => CreateStableImageControlStyleRequestStylePreset.Photographic,
                "pixel-art" => CreateStableImageControlStyleRequestStylePreset.PixelArt,
                "tile-texture" => CreateStableImageControlStyleRequestStylePreset.TileTexture,
                _ => null,
            };
        }
    }
}