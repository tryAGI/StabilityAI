
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Guides the image model towards a particular style.
    /// </summary>
    public enum CreateStableImageEditOutpaintRequestStylePreset
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
    public static class CreateStableImageEditOutpaintRequestStylePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageEditOutpaintRequestStylePreset value)
        {
            return value switch
            {
                CreateStableImageEditOutpaintRequestStylePreset.x3dModel => "3d-model",
                CreateStableImageEditOutpaintRequestStylePreset.AnalogFilm => "analog-film",
                CreateStableImageEditOutpaintRequestStylePreset.Anime => "anime",
                CreateStableImageEditOutpaintRequestStylePreset.Cinematic => "cinematic",
                CreateStableImageEditOutpaintRequestStylePreset.ComicBook => "comic-book",
                CreateStableImageEditOutpaintRequestStylePreset.DigitalArt => "digital-art",
                CreateStableImageEditOutpaintRequestStylePreset.Enhance => "enhance",
                CreateStableImageEditOutpaintRequestStylePreset.FantasyArt => "fantasy-art",
                CreateStableImageEditOutpaintRequestStylePreset.Isometric => "isometric",
                CreateStableImageEditOutpaintRequestStylePreset.LineArt => "line-art",
                CreateStableImageEditOutpaintRequestStylePreset.LowPoly => "low-poly",
                CreateStableImageEditOutpaintRequestStylePreset.ModelingCompound => "modeling-compound",
                CreateStableImageEditOutpaintRequestStylePreset.NeonPunk => "neon-punk",
                CreateStableImageEditOutpaintRequestStylePreset.Origami => "origami",
                CreateStableImageEditOutpaintRequestStylePreset.Photographic => "photographic",
                CreateStableImageEditOutpaintRequestStylePreset.PixelArt => "pixel-art",
                CreateStableImageEditOutpaintRequestStylePreset.TileTexture => "tile-texture",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageEditOutpaintRequestStylePreset? ToEnum(string value)
        {
            return value switch
            {
                "3d-model" => CreateStableImageEditOutpaintRequestStylePreset.x3dModel,
                "analog-film" => CreateStableImageEditOutpaintRequestStylePreset.AnalogFilm,
                "anime" => CreateStableImageEditOutpaintRequestStylePreset.Anime,
                "cinematic" => CreateStableImageEditOutpaintRequestStylePreset.Cinematic,
                "comic-book" => CreateStableImageEditOutpaintRequestStylePreset.ComicBook,
                "digital-art" => CreateStableImageEditOutpaintRequestStylePreset.DigitalArt,
                "enhance" => CreateStableImageEditOutpaintRequestStylePreset.Enhance,
                "fantasy-art" => CreateStableImageEditOutpaintRequestStylePreset.FantasyArt,
                "isometric" => CreateStableImageEditOutpaintRequestStylePreset.Isometric,
                "line-art" => CreateStableImageEditOutpaintRequestStylePreset.LineArt,
                "low-poly" => CreateStableImageEditOutpaintRequestStylePreset.LowPoly,
                "modeling-compound" => CreateStableImageEditOutpaintRequestStylePreset.ModelingCompound,
                "neon-punk" => CreateStableImageEditOutpaintRequestStylePreset.NeonPunk,
                "origami" => CreateStableImageEditOutpaintRequestStylePreset.Origami,
                "photographic" => CreateStableImageEditOutpaintRequestStylePreset.Photographic,
                "pixel-art" => CreateStableImageEditOutpaintRequestStylePreset.PixelArt,
                "tile-texture" => CreateStableImageEditOutpaintRequestStylePreset.TileTexture,
                _ => null,
            };
        }
    }
}