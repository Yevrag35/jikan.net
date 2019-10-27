using Newtonsoft.Json;
using System.Collections.Generic;

namespace JikanDotNet
{
	/// <summary>
	/// Model class for anime review collection.
	/// </summary>
	public class AnimeReviews: BaseJikanRequest
	{
		/// <summary>
		/// Collection of anime reviews.
		/// </summary>
		[JsonProperty(PropertyName = "reviews")]
		public List<AnimeReview> Reviews { get; set; }
	}
}