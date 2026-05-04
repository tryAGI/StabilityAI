
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Guides the image model towards a particular style.
    /// </summary>
    public enum CreateStableImageEditInpaintRequestStylePreset
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
    public static class CreateStableImageEditInpaintRequestStylePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageEditInpaintRequestStylePreset value)
        {
            return value switch
            {
                CreateStableImageEditInpaintRequestStylePreset.x3dModel => "3d-model",
                CreateStableImageEditInpaintRequestStylePreset.AnalogFilm => "analog-film",
                CreateStableImageEditInpaintRequestStylePreset.Anime => "anime",
                CreateStableImageEditInpaintRequestStylePreset.Cinematic => "cinematic",
                CreateStableImageEditInpaintRequestStylePreset.ComicBook => "comic-book",
                CreateStableImageEditInpaintRequestStylePreset.DigitalArt => "digital-art",
                CreateStableImageEditInpaintRequestStylePreset.Enhance => "enhance",
                CreateStableImageEditInpaintRequestStylePreset.FantasyArt => "fantasy-art",
                CreateStableImageEditInpaintRequestStylePreset.Isometric => "isometric",
                CreateStableImageEditInpaintRequestStylePreset.LineArt => "line-art",
                CreateStableImageEditInpaintRequestStylePreset.LowPoly => "low-poly",
                CreateStableImageEditInpaintRequestStylePreset.ModelingCompound => "modeling-compound",
                CreateStableImageEditInpaintRequestStylePreset.NeonPunk => "neon-punk",
                CreateStableImageEditInpaintRequestStylePreset.Origami => "origami",
                CreateStableImageEditInpaintRequestStylePreset.Photographic => "photographic",
                CreateStableImageEditInpaintRequestStylePreset.PixelArt => "pixel-art",
                CreateStableImageEditInpaintRequestStylePreset.TileTexture => "tile-texture",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageEditInpaintRequestStylePreset? ToEnum(string value)
        {
            return value switch
            {
                "3d-model" => CreateStableImageEditInpaintRequestStylePreset.x3dModel,
                "analog-film" => CreateStableImageEditInpaintRequestStylePreset.AnalogFilm,
                "anime" => CreateStableImageEditInpaintRequestStylePreset.Anime,
                "cinematic" => CreateStableImageEditInpaintRequestStylePreset.Cinematic,
                "comic-book" => CreateStableImageEditInpaintRequestStylePreset.ComicBook,
                "digital-art" => CreateStableImageEditInpaintRequestStylePreset.DigitalArt,
                "enhance" => CreateStableImageEditInpaintRequestStylePreset.Enhance,
                "fantasy-art" => CreateStableImageEditInpaintRequestStylePreset.FantasyArt,
                "isometric" => CreateStableImageEditInpaintRequestStylePreset.Isometric,
                "line-art" => CreateStableImageEditInpaintRequestStylePreset.LineArt,
                "low-poly" => CreateStableImageEditInpaintRequestStylePreset.LowPoly,
                "modeling-compound" => CreateStableImageEditInpaintRequestStylePreset.ModelingCompound,
                "neon-punk" => CreateStableImageEditInpaintRequestStylePreset.NeonPunk,
                "origami" => CreateStableImageEditInpaintRequestStylePreset.Origami,
                "photographic" => CreateStableImageEditInpaintRequestStylePreset.Photographic,
                "pixel-art" => CreateStableImageEditInpaintRequestStylePreset.PixelArt,
                "tile-texture" => CreateStableImageEditInpaintRequestStylePreset.TileTexture,
                _ => null,
            };
        }
    }
}