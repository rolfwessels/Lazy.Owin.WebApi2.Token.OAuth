using System.Threading.Tasks;

namespace Lazy.Owin.WebApi2.Token.OAuth.Dal.Interfaces
{
	public interface IOAuthDataManager : IRefreshTokenManager
	{
		Task<IOAuthClient> GetApplication(string clientId);
		Task<IAuthorizedUser> GetUserByUserIdAndPassword(string userName, string password);
		Task<string[]> GetRolesForUser(IAuthorizedUser user);
		Task UpdateUserLastActivityDate(IAuthorizedUser user);
	}
}