using System;
using Lazy.Owin.WebApi2.Token.OAuth.Dal.Interfaces;

namespace Lazy.Owin.WebApi2.Token.OAuth.Dal.DefaultValues
{
	public class DefaultRefreshToken : IRefreshToken
	{
		public string Id { get; set; }

		public string ClientId { get; set; }

		public string Subject { get; set; }

		public DateTime IssuedUtc { get; set; }

		public DateTime ExpiresUtc { get; set; }

		public string ProtectedTicket { get; set; }
	}
}