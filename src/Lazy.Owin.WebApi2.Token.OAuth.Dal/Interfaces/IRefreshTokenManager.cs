using System.Threading.Tasks;

namespace Lazy.Owin.WebApi2.Token.OAuth.Dal.Interfaces
{
	public interface IRefreshTokenManager
	{
		IRefreshToken CreateRefresherToken();
		Task SaveRefreshToken(IRefreshToken token);
		Task<IRefreshToken> GetRefreshToken(string hashedTokenId);
		Task DeleteRefreshToken(string hashedTokenId);
	}
}