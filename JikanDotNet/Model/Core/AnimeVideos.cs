using Newtonsoft.Json;
using System.Collections.Generic;

namespace JikanDotNet
{
	/// <summary>
	/// Anime related videos list model class.
	/// </summary>
	public class AnimeVideos: BaseJikanRequest
	{
		/// <summary>
		/// Anime's related promo videos URLs.
		/// </summary>
		[JsonProperty(PropertyName = "promo")]
		public List<PromoVideo> PromoVideos { get; set; }

		/// <summary>
		/// Anime's related episode videos URLs.
		/// </summary>
		[JsonProperty(PropertyName = "episodes")]
		public List<EpisodeVideo> EpisodeVideos { get; set; }
	}
}