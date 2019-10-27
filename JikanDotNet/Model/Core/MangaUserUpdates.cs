﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace JikanDotNet
{
	/// <summary>
	/// Model class for manga user updates collection.
	/// </summary>
	public class MangaUserUpdates: BaseJikanRequest
	{
		/// <summary>
		/// Collection of manga user updates.
		/// </summary>
		[JsonProperty(PropertyName = "users")]
		public List<MangaUserUpdate> Updates { get; set; }
	}
}