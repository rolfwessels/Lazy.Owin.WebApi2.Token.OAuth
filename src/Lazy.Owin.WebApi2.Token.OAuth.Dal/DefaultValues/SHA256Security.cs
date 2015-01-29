using System;
using System.Security.Cryptography;
using Lazy.Owin.WebApi2.Token.OAuth.Dal.Interfaces;

namespace Lazy.Owin.WebApi2.Token.OAuth.Dal.DefaultValues
{
	public class SHA256Security : IOAuthSecurity
	{
		#region Implementation of IOAuthSecurity

		public string GetHash(string input)
		{
			HashAlgorithm hashAlgorithm = new SHA256CryptoServiceProvider();
			byte[] byteValue = System.Text.Encoding.UTF8.GetBytes(input);
			byte[] byteHash = hashAlgorithm.ComputeHash(byteValue);
			return Convert.ToBase64String(byteHash);
		}

		#endregion
	}
}