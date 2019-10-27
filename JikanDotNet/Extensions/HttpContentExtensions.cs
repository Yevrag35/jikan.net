using JikanDotNet.Consts;
using JikanDotNet.Exceptions;
using JikanDotNet.Extensions;
using JikanDotNet.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace JikanDotNet.Extensions
{
    internal static class HttpContentExtensions
    {
        internal async static Task<T> ReadAsJsonAsync<T>(this HttpContent content, bool suppressExceptions)
        {
            string rawJson = await content.ReadAsStringAsync();
            if (string.IsNullOrWhiteSpace(rawJson) && !suppressExceptions)
            {
                throw new JikanRequestException(string.Format(Resources.Errors.FailedRequest, "Response content was blank or null."));
            }
            else
            {
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    NullValueHandling = NullValueHandling.Include,
                    DateFormatHandling = DateFormatHandling.IsoDateFormat,
                    DateParseHandling = DateParseHandling.DateTime,
                    FloatParseHandling = FloatParseHandling.Decimal
                };
                settings.Converters.Add(new StringEnumConverter(new CamelCaseNamingStrategy()));
                return JsonConvert.DeserializeObject<T>(rawJson, settings);
            }
        }
    }
}
