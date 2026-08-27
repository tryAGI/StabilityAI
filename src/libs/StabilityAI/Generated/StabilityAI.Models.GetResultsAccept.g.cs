
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Specify `*/*` to receive the bytes of the result directly. Otherwise specify `application/json` to receive the result as base64 encoded JSON.<br/>
    /// Default Value: */*
    /// </summary>
    public enum GetResultsAccept
    {
        /// <summary>
        ///
        /// </summary>
        AnyAny,
        /// <summary>
        ///
        /// </summary>
        ApplicationJson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetResultsAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResultsAccept value)
        {
            return value switch
            {
                GetResultsAccept.AnyAny => "*/*",
                GetResultsAccept.ApplicationJson => "application/json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResultsAccept? ToEnum(string value)
        {
            return value switch
            {
                "*/*" => GetResultsAccept.AnyAny,
                "application/json" => GetResultsAccept.ApplicationJson,
                _ => null,
            };
        }
    }
}