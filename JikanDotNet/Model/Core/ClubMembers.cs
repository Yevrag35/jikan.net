﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace JikanDotNet
{
	/// <summary>
	/// Model class for club members collection.
	/// </summary>
	public class ClubMembers: BaseJikanRequest
	{
		/// <summary>
		/// Collection of club members.
		/// </summary>
		[JsonProperty(PropertyName = "members")]
		public List<ClubMember> Members { get; set; }
	}
}