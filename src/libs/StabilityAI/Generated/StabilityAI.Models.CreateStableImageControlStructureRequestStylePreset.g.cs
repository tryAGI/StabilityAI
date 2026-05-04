
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Guides the image model towards a particular style.
    /// </summary>
    public enum CreateStableImageControlStructureRequestStylePreset
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
    public static class CreateStableImageControlStructureRequestStylePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageControlStructureRequestStylePreset value)
        {
            return value switch
            {
                CreateStableImageControlStructureRequestStylePreset.x3dModel => "3d-model",
                CreateStableImageControlStructureRequestStylePreset.AnalogFilm => "analog-film",
                CreateStableImageControlStructureRequestStylePreset.Anime => "anime",
                CreateStableImageControlStructureRequestStylePreset.Cinematic => "cinematic",
                CreateStableImageControlStructureRequestStylePreset.ComicBook => "comic-book",
                CreateStableImageControlStructureRequestStylePreset.DigitalArt => "digital-art",
                CreateStableImageControlStructureRequestStylePreset.Enhance => "enhance",
                CreateStableImageControlStructureRequestStylePreset.FantasyArt => "fantasy-art",
                CreateStableImageControlStructureRequestStylePreset.Isometric => "isometric",
                CreateStableImageControlStructureRequestStylePreset.LineArt => "line-art",
                CreateStableImageControlStructureRequestStylePreset.LowPoly => "low-poly",
                CreateStableImageControlStructureRequestStylePreset.ModelingCompound => "modeling-compound",
                CreateStableImageControlStructureRequestStylePreset.NeonPunk => "neon-punk",
                CreateStableImageControlStructureRequestStylePreset.Origami => "origami",
                CreateStableImageControlStructureRequestStylePreset.Photographic => "photographic",
                CreateStableImageControlStructureRequestStylePreset.PixelArt => "pixel-art",
                CreateStableImageControlStructureRequestStylePreset.TileTexture => "tile-texture",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageControlStructureRequestStylePreset? ToEnum(string value)
        {
            return value switch
            {
                "3d-model" => CreateStableImageControlStructureRequestStylePreset.x3dModel,
                "analog-film" => CreateStableImageControlStructureRequestStylePreset.AnalogFilm,
                "anime" => CreateStableImageControlStructureRequestStylePreset.Anime,
                "cinematic" => CreateStableImageControlStructureRequestStylePreset.Cinematic,
                "comic-book" => CreateStableImageControlStructureRequestStylePreset.ComicBook,
                "digital-art" => CreateStableImageControlStructureRequestStylePreset.DigitalArt,
                "enhance" => CreateStableImageControlStructureRequestStylePreset.Enhance,
                "fantasy-art" => CreateStableImageControlStructureRequestStylePreset.FantasyArt,
                "isometric" => CreateStableImageControlStructureRequestStylePreset.Isometric,
                "line-art" => CreateStableImageControlStructureRequestStylePreset.LineArt,
                "low-poly" => CreateStableImageControlStructureRequestStylePreset.LowPoly,
                "modeling-compound" => CreateStableImageControlStructureRequestStylePreset.ModelingCompound,
                "neon-punk" => CreateStableImageControlStructureRequestStylePreset.NeonPunk,
                "origami" => CreateStableImageControlStructureRequestStylePreset.Origami,
                "photographic" => CreateStableImageControlStructureRequestStylePreset.Photographic,
                "pixel-art" => CreateStableImageControlStructureRequestStylePreset.PixelArt,
                "tile-texture" => CreateStableImageControlStructureRequestStylePreset.TileTexture,
                _ => null,
            };
        }
    }
}