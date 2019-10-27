using System;
using System.Net;
using System.Net.Http;

namespace JikanDotNet.Exceptions
{
	/// <summary>
	/// Exception class thrown when request is not handled properly/
	/// </summary>
	public class JikanRequestException : Exception
	{
		/// <summary>
		/// Response code received from <see cref="HttpResponseMessage"/>.
		/// </summary>
		public HttpStatusCode ResponseCode { get; private set; }

		/// <summary>
		/// Parameterless constructor.
		/// </summary>
		public JikanRequestException()
		{
		}

		/// <summary>
		/// Constructor with exception message.
		/// </summary>
		public JikanRequestException(string message) : base(message)
		{
		}

		/// <summary>
		/// Constructor with exception message and code.
		/// </summary>
		public JikanRequestException(string message, HttpStatusCode responseCode) : base(message)
		{
			this.ResponseCode = responseCode;
		}

		/// <summary>
		/// Constructor with exception message and inner exception.
		/// </summary>
		public JikanRequestException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}