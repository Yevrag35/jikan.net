using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace JikanDotNet.Helpers
{
	/// <summary>
	/// Provider class for static <see cref="HttpClient"/> construction.
	/// </summary>
	public static class HttpProvider
	{
		/// <summary>
		/// Endpoint for non-SSL encrypted requests.
		/// </summary>
		public const string httpEndpoint = "http://api.jikan.moe/v3/";

		/// <summary>
		/// Endpoint for SSL encrypted requests.
		/// </summary>
		public const string httpsEndpoint = "https://api.jikan.moe/v3/";
		
		/// <summary>
		/// Constructor.
		/// </summary>
		static HttpProvider()
		{
		}

        /// <summary>
        /// Gets a static <see cref="HttpClient"/> using the default Jikan REST endpoint.
        /// </summary>
        /// <param name="useHttps">Define if request should be send to SSL encrypted endpoint.</param>
        /// <returns>Static HttpClient.</returns>
        public static HttpClient GetHttpClient(bool useHttps)
		{
            return GetHttpClient(useHttps, new HttpClientHandler(), false);
		}

        /// <summary>
        /// Gets a static <see cref="HttpClient"/> using the default Jikan REST endpoint with the specified <see cref="HttpMessageHandler"/>.
        /// </summary>
        /// <param name="useHttps"></param>
        /// <param name="handler">The <see cref="HttpMessageHandler"/> responsible for processing the HTTP response messages.</param>
        /// <param name="disposeHandler"><see langword="true"/> if the inner handler should be disposed of by <see cref="HttpClient.Dispose(bool)"/>;
        /// <see langword="false"/> if you intend to reuse the inner handler.</param>
        /// <returns>Static <see cref="HttpClient"/></returns>
        public static HttpClient GetHttpClient(bool useHttps, HttpMessageHandler handler, bool disposeHandler)
        {
            string endpoint = useHttps ? httpsEndpoint : httpEndpoint;
            HttpClient Client = new HttpClient(handler, disposeHandler)
            {
                BaseAddress = new Uri(endpoint)
            };
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            return Client;
        }

		/// <summary>
		/// Gets a static <see cref="HttpClient"/> using a custom, user defined Jikan REST endpoint.
		/// </summary>
		/// <param name="endpoint">Endpoint of the REST API.</param>
		/// <returns>Static HttpClient.</returns>
		public static HttpClient GetHttpClient(Uri endpoint)
		{
            return GetHttpClient(endpoint, new HttpClientHandler(), false);
		}

        /// <summary>
        /// Gets a static <see cref="HttpClient"/> using a custom, user defined Jikan REST endpoint.
        /// </summary>
        /// <param name="endpoint">Endpoint of the REST API.</param>
        /// <param name="handler">The <see cref="HttpMessageHandler"/> responsible for processing the HTTP response messages.</param>
        /// <param name="disposeHandler"><see langword="true"/> if the inner handler should be disposed of by <see cref="HttpClient.Dispose(bool)"/>;
        /// <see langword="false"/> if you intend to reuse the inner handler.</param>
        /// <returns>Static HttpClient.</returns>
        public static HttpClient GetHttpClient(Uri endpoint, HttpMessageHandler handler, bool disposeHandler)
        {
            HttpClient Client = new HttpClient(handler, disposeHandler)
            {
                BaseAddress = endpoint
            };
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            return Client;
        }
	}
}