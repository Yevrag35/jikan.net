using Newtonsoft.Json;
using System.Collections.Generic;

namespace JikanDotNet
{
	/// <summary>
	/// Model class for schedule of current season.
	/// </summary>
	public class Schedule: BaseJikanRequest
	{
		/// <summary>
		/// All current season entries scheduled for Monday.
		/// </summary>
		[JsonProperty(PropertyName = "monday")]
		public MALList<AnimeSubEntry> Monday;

		/// <summary>
		/// All current season entries scheduled for Tuesday.
		/// </summary>
		[JsonProperty(PropertyName = "tuesday")]
		public MALList<AnimeSubEntry> Tuesday;

		/// <summary>
		/// All current season entries scheduled for Wednesday.
		/// </summary>
		[JsonProperty(PropertyName = "wednesday")]
		public MALList<AnimeSubEntry> Wednesday;

		/// <summary>
		/// All current season entries scheduled for Thursday.
		/// </summary>
		[JsonProperty(PropertyName = "thursday")]
		public MALList<AnimeSubEntry> Thursday;

		/// <summary>
		/// All current season entries scheduled for Friday.
		/// </summary>
		[JsonProperty(PropertyName = "friday")]
		public MALList<AnimeSubEntry> Friday;

		/// <summary>
		/// All current season entries scheduled for Saturday.
		/// </summary>
		[JsonProperty(PropertyName = "saturday")]
		public MALList<AnimeSubEntry> Saturday;

		/// <summary>
		/// All current season entries scheduled for Sunday.
		/// </summary>Sunday
		[JsonProperty(PropertyName = "sunday")]
		public MALList<AnimeSubEntry> Sunday;

		/// <summary>
		/// All current season entries scheduled for other days (irregular airing).
		/// </summary>Sunday
		[JsonProperty(PropertyName = "other")]
		public MALList<AnimeSubEntry> Other;

		/// <summary>
		/// All current season entries scheduled for unknown airing.
		/// </summary>Sunday
		[JsonProperty(PropertyName = "unknown")]
		public MALList<AnimeSubEntry> Unknown;
	}
}