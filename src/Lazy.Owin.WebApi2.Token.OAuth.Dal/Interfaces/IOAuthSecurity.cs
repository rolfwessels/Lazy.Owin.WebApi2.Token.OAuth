namespace Lazy.Owin.WebApi2.Token.OAuth.Dal.Interfaces
{
	public interface IOAuthSecurity
	{
		string GetHash(string clientSecret);
	}
}