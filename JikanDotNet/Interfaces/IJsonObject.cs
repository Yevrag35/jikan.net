using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;

namespace JikanDotNet
{
    /// <summary>
    /// An interface providing methods for converting the implementing class into JSON strings.
    /// </summary>
    public interface IJsonObject
    {
        /// <summary>
        /// Converts the inheriting class into its JSON-indented equivalent string.
        /// </summary>
        /// <returns></returns>
        string ToJson();

        /// <summary>
        /// Converts the inheriting class into a JSON string using the specified <see cref="JsonSerializerSettings"/>.
        /// </summary>
        /// <param name="serializerSettings">The <see cref="JsonSerializerSettings"/> used when serializing the object.</param>
        string ToJson(JsonSerializerSettings serializerSettings);
    }
}
