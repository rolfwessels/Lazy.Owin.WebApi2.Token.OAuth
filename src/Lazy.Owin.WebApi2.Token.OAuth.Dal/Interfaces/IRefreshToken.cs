using System;

namespace Lazy.Owin.WebApi2.Token.OAuth.Dal.Interfaces
{
	public interface IRefreshToken
	{
		string Id { get; set; }

		string ClientId { get; set; }

		string Subject { get; set; }

		DateTime IssuedUtc { get; set; }

		DateTime ExpiresUtc { get; set; }

		string ProtectedTicket { get; set; }
	}
}