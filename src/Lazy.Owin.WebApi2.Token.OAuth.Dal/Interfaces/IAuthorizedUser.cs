namespace Lazy.Owin.WebApi2.Token.OAuth.Dal.Interfaces
{
	public interface IAuthorizedUser
	{
		string UserId { get; set; }
		string DisplayName { get; set; }
	}
}