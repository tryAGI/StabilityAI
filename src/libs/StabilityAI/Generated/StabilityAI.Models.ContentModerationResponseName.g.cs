
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Our content moderation system has flagged some part of your request and subsequently denied it.  You were not charged for this request.  While this may at times be frustrating, it is necessary to maintain the integrity of our platform and ensure a safe experience for all users.<br/>
    /// If you would like to provide feedback, please use the [Support Form](https://kb.stability.ai/knowledge-base/kb-tickets/new).
    /// </summary>
    public enum ContentModerationResponseName
    {
        /// <summary>
        /// 
        /// </summary>
        ContentModeration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentModerationResponseNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentModerationResponseName value)
        {
            return value switch
            {
                ContentModerationResponseName.ContentModeration => "content_moderation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentModerationResponseName? ToEnum(string value)
        {
            return value switch
            {
                "content_moderation" => ContentModerationResponseName.ContentModeration,
                _ => null,
            };
        }
    }
}