using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace JikanDotNet
{
	/// <summary>
	/// Base model class for each Jikan request model, containing information about cache.
	/// </summary>
	public abstract class BaseJikanRequest : ICloneable, IJsonObject
	{
		/// <summary>
		/// Hash of the request.
		/// </summary>
		[JsonProperty(PropertyName = "request_hash")]
		public string RequestHash { get; set; }

		/// <summary>
		/// Is request cached.
		/// </summary>
		[JsonProperty(PropertyName = "request_cached")]
		public bool RequestCached { get; set; }

		/// <summary>
		/// Time till cache expiration (in seconds).
		/// </summary>
		[JsonProperty(PropertyName = "request_cache_expiry")]
		public int RequestCacheExpiry { get; set; }

        /// <summary>
        /// Clones the JSON properties from the current object to a new instance.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            Type thisType = this.GetType();
            object newObj = Activator.CreateInstance(thisType);

            IEnumerable<PropertyInfo> allProps = thisType
                .GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo pi in allProps
                        .Where(prop => prop.CanWrite))
            {
                object originalValue = pi.GetValue(this);

                if (originalValue != null)
                {
                    pi.SetValue(newObj, originalValue);
                }
            }

            return newObj;
        }

        /// <summary>
        /// Converts this instance into its JSON-indented equivalent string.
        /// </summary>
        public string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);

        /// <summary>
        /// Converts the inheriting class into a JSON string using the specified <see cref="JsonSerializerSettings"/>.
        /// </summary>
        /// <param name="serializerSettings">The <see cref="JsonSerializerSettings"/> used when serializing the object.</param>
        public string ToJson(JsonSerializerSettings serializerSettings) => JsonConvert.SerializeObject(this, serializerSettings);
	}
}