﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace JikanDotNet
{
	/// <summary>
	/// Model class for result from searching person.
	/// </summary>
	public class PersonSearchResult : BaseJikanRequest
	{
		/// <summary>
		/// List of search results.
		/// </summary>
		[JsonProperty(PropertyName = "results")]
		public MALList<PersonSearchEntry> Results { get; set; }

		/// <summary>
		/// Index of the last page.
		/// </summary>
		[JsonProperty(PropertyName = "last_page")]
		public int? ResultLastPage { get; set; }
	}
}