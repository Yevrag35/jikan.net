using Newtonsoft.Json;
using System.Collections.Generic;

namespace JikanDotNet
{
	/// <summary>
	/// User's history model class.
	/// </summary>
	public class UserHistory: BaseJikanRequest
	{
		/// <summary>
		/// Collection of user's history updates.
		/// </summary>
		[JsonProperty(PropertyName = "history")]
		public List<HistoryEntry> History { get; set; }
	}
}