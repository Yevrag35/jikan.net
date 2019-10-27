﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace JikanDotNet
{
	/// <summary>
	/// Model class for anime top.
	/// </summary>
    public class AnimeTop: BaseJikanRequest
	{
		/// <summary>
		/// Collection of anime entries on top list.
		/// </summary>
		[JsonProperty(PropertyName = "top")]
		public MALList<AnimeTopEntry> Top { get; set; }
    }
}
