using Newtonsoft.Json;
using System.Collections.Generic;

namespace JikanDotNet
{
	/// <summary>
	/// Anime news list model class.
	/// </summary>
	public class AnimeNews: BaseJikanRequest
	{
		/// <summary>
		/// News related to anime.
		/// </summary>
		[JsonProperty(PropertyName = "articles")]
		public List<News> News { get; set; }
	}
}