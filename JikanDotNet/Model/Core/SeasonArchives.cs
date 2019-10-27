using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace JikanDotNet
{
	/// <summary>
	/// Seasons archive collection model class
	/// </summary>
	public class SeasonArchives: BaseJikanRequest
	{
		/// <summary>
		/// Season entry for season.
		/// </summary>
		[JsonProperty(PropertyName = "archive")]
		public List<SeasonArchive> Archives { get; set; }
	}
}