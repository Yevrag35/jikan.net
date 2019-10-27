﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace JikanDotNet
{
	/// <summary>
	/// Model class for anime top.
	/// </summary>
	public class MangaTop: BaseJikanRequest
	{
		/// <summary>
		/// Collection of anime entries on top list.
		/// </summary>
		[JsonProperty(PropertyName = "top")]
		public MALList<MangaTopEntry> Top { get; set; }
	}
}