using Newtonsoft.Json;
using System.Collections.Generic;

namespace JikanDotNet
{
	/// <summary>
	/// Model class for most popular characters.
	/// </summary>
	public class CharactersTop: BaseJikanRequest
	{
		/// <summary>
		/// Collection of characters entries on top list.
		/// </summary>
		[JsonProperty(PropertyName = "top")]
		public MALList<CharacterTopEntry> Top { get; set; }
	}
}