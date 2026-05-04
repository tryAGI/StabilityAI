
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Guides the image model towards a particular style.
    /// </summary>
    public enum CreateStableImageEditSearchAndRecolorRequestStylePreset
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
    public static class CreateStableImageEditSearchAndRecolorRequestStylePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageEditSearchAndRecolorRequestStylePreset value)
        {
            return value switch
            {
                CreateStableImageEditSearchAndRecolorRequestStylePreset.x3dModel => "3d-model",
                CreateStableImageEditSearchAndRecolorRequestStylePreset.AnalogFilm => "analog-film",
                CreateStableImageEditSearchAndRecolorRequestStylePreset.Anime => "anime",
                CreateStableImageEditSearchAndRecolorRequestStylePreset.Cinematic => "cinematic",
                CreateStableImageEditSearchAndRecolorRequestStylePreset.ComicBook => "comic-book",
                CreateStableImageEditSearchAndRecolorRequestStylePreset.DigitalArt => "digital-art",
                CreateStableImageEditSearchAndRecolorRequestStylePreset.Enhance => "enhance",
                CreateStableImageEditSearchAndRecolorRequestStylePreset.FantasyArt => "fantasy-art",
                CreateStableImageEditSearchAndRecolorRequestStylePreset.Isometric => "isometric",
                CreateStableImageEditSearchAndRecolorRequestStylePreset.LineArt => "line-art",
                CreateStableImageEditSearchAndRecolorRequestStylePreset.LowPoly => "low-poly",
                CreateStableImageEditSearchAndRecolorRequestStylePreset.ModelingCompound => "modeling-compound",
                CreateStableImageEditSearchAndRecolorRequestStylePreset.NeonPunk => "neon-punk",
                CreateStableImageEditSearchAndRecolorRequestStylePreset.Origami => "origami",
                CreateStableImageEditSearchAndRecolorRequestStylePreset.Photographic => "photographic",
                CreateStableImageEditSearchAndRecolorRequestStylePreset.PixelArt => "pixel-art",
                CreateStableImageEditSearchAndRecolorRequestStylePreset.TileTexture => "tile-texture",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageEditSearchAndRecolorRequestStylePreset? ToEnum(string value)
        {
            return value switch
            {
                "3d-model" => CreateStableImageEditSearchAndRecolorRequestStylePreset.x3dModel,
                "analog-film" => CreateStableImageEditSearchAndRecolorRequestStylePreset.AnalogFilm,
                "anime" => CreateStableImageEditSearchAndRecolorRequestStylePreset.Anime,
                "cinematic" => CreateStableImageEditSearchAndRecolorRequestStylePreset.Cinematic,
                "comic-book" => CreateStableImageEditSearchAndRecolorRequestStylePreset.ComicBook,
                "digital-art" => CreateStableImageEditSearchAndRecolorRequestStylePreset.DigitalArt,
                "enhance" => CreateStableImageEditSearchAndRecolorRequestStylePreset.Enhance,
                "fantasy-art" => CreateStableImageEditSearchAndRecolorRequestStylePreset.FantasyArt,
                "isometric" => CreateStableImageEditSearchAndRecolorRequestStylePreset.Isometric,
                "line-art" => CreateStableImageEditSearchAndRecolorRequestStylePreset.LineArt,
                "low-poly" => CreateStableImageEditSearchAndRecolorRequestStylePreset.LowPoly,
                "modeling-compound" => CreateStableImageEditSearchAndRecolorRequestStylePreset.ModelingCompound,
                "neon-punk" => CreateStableImageEditSearchAndRecolorRequestStylePreset.NeonPunk,
                "origami" => CreateStableImageEditSearchAndRecolorRequestStylePreset.Origami,
                "photographic" => CreateStableImageEditSearchAndRecolorRequestStylePreset.Photographic,
                "pixel-art" => CreateStableImageEditSearchAndRecolorRequestStylePreset.PixelArt,
                "tile-texture" => CreateStableImageEditSearchAndRecolorRequestStylePreset.TileTexture,
                _ => null,
            };
        }
    }
}