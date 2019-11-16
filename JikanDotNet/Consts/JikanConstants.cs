﻿namespace JikanDotNet.Consts
{
	/// <summary>
	/// Endpoints in Jikan REST API.
	/// </summary>
	internal static class JikanConstants
	{
        internal const string FailedRequest = "GET request failed.  Inner Message: {0}";
        internal const string NotEnum = "EnumerationValue must be of Enum type.";
        internal const string SerializationFailed = "Serialization failed.";

		/// <summary>
		/// Anime endpoint.
		/// </summary>
		public const string Anime = "anime";

		/// <summary>
		/// Manga endpoint.
		/// </summary>
		public const string Manga = "manga";

		/// <summary>
		/// Character endpoint.
		/// </summary>
		public const string Character = "character";

		/// <summary>
		/// Characters endpoint.
		/// </summary>
		public const string Characters = "characters";

		/// <summary>
		/// People endpoint.
		/// </summary>
		public const string Person = "person";

		/// <summary>
		/// Alternative people endpoint.
		/// </summary>
		public const string People = "people";

		/// <summary>
		/// Season endpoint.
		/// </summary>
		public const string Season = "season";

		/// <summary>
		/// Schedule endpoint.
		/// </summary>
		public const string Schedule = "schedule";

		/// <summary>
		/// Top list endpoint.
		/// </summary>
		public const string TopList = "top";

		/// <summary>
		/// Genre endpoint.
		/// </summary>
		public const string Genre = "genre";

		/// <summary>
		/// Producer endpoint.
		/// </summary>
		public const string Producer = "producer";

		/// <summary>
		/// Magazine endpoint.
		/// </summary>
		public const string Magazine = "magazine";

		/// <summary>
		/// User endpoint.
		/// </summary>
		public const string User = "user";

		/// <summary>
		/// Club endpoint.
		/// </summary>
		public const string Club = "club";

		/// <summary>
		/// Search endpoint.
		/// </summary>
		public const string Search = "search";

		/// <summary>
		/// Metadata endpoint.
		/// </summary>
		public const string Meta = "meta";
	}
}