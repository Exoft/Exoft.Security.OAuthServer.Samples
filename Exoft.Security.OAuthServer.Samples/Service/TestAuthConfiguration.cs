using Exoft.Security.OAuthServer.Providers;

namespace Exoft.Security.OAuthServer.Samples.Service
{
    public class TestAuthConfiguration:IAuthenticationConfiguration
    {
        public int AccessTokenLifetimeMinutes { get; set; }
        public int RefreshTokenLifetimeMinutes { get; set; }
        public string RequestScope { get; set; }

        public TestAuthConfiguration()
        {
            RequestScope = "openid offline_access";
            AccessTokenLifetimeMinutes = 120;
            RefreshTokenLifetimeMinutes = 30;
        }
    }
}
