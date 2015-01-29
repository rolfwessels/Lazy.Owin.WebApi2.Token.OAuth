using System;

namespace Lazy.Owin.WebApi2.Token.OAuth
{
	public class AuthorizationSettings
	{
		public AuthorizationSettings()
		{
			EndpointPath = "/token";
			RefresherTokenEnabled = false;
			MaxRefresherTokenLifetimeInMinutes = TimeSpan.FromDays(1).TotalMinutes;
		}

		public double MaxRefresherTokenLifetimeInMinutes { get; set; }

		public bool RefresherTokenEnabled { get; set; }

		public string EndpointPath { get; set; }
	}
}