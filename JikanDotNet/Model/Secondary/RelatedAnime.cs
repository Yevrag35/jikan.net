using Newtonsoft.Json;
using System.Collections.Generic;

namespace JikanDotNet
{
	/// <summary>
	/// Model class representing collection of related anime entries.
	/// </summary>
	public class RelatedAnime
	{
		/// <summary>
		/// Collection of alternative versions.
		/// </summary>
		[JsonProperty(PropertyName = "Alternative Version")]
		public MALList<MALSubItem> AlternativeVersions { get; set; }

		/// <summary>
		/// Collection of alternative settings.
		/// </summary>
		[JsonProperty(PropertyName = "Alternative Setting")]
		public MALList<MALSubItem> AlternativeSettings { get; set; }

		/// <summary>
		/// Collection of adaptations.
		/// </summary>
		[JsonProperty(PropertyName = "Adaptation")]
		public MALList<MALSubItem> Adaptations { get; set; }

		/// <summary>
		/// Collection of character related entries.
		/// </summary>
		[JsonProperty(PropertyName = "Character")]
		public MALList<MALSubItem> Characters { get; set; }

		/// <summary>
		/// Collection of full stories.
		/// </summary>
		[JsonProperty(PropertyName = "Full story")]
		public MALList<MALSubItem> FullStories { get; set; }

		/// <summary>
		/// Collection of parent stories.
		/// </summary>
		[JsonProperty(PropertyName = "Parent story")]
		public MALList<MALSubItem> ParentStories { get; set; }

		/// <summary>
		/// Collection of prequels.
		/// </summary>
		[JsonProperty(PropertyName = "Prequel")]
		public MALList<MALSubItem> Prequels { get; set; }

		/// <summary>
		/// Collection of other entries.
		/// </summary>
		[JsonProperty(PropertyName = "Other")]
		public MALList<MALSubItem> Others { get; set; }

		/// <summary>
		/// Collection of sequels.
		/// </summary>
		[JsonProperty(PropertyName = "Sequel")]
		public MALList<MALSubItem> Sequels { get; set; }

		/// <summary>
		/// Collection of side stories.
		/// </summary>
		[JsonProperty(PropertyName = "Side Story")]
		public MALList<MALSubItem> SideStories { get; set; }

		/// <summary>
		/// Collection of spin-off.
		/// </summary>
		[JsonProperty(PropertyName = "Spin-off")]
		public MALList<MALSubItem> SpinOffs { get; set; }

		/// <summary>
		/// Collection of summaries.
		/// </summary>
		[JsonProperty(PropertyName = "Summary")]
		public MALList<MALSubItem> Summaries { get; set; }
	}
}