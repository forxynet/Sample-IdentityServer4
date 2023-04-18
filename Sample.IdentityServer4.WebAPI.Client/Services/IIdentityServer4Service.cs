using IdentityModel.Client;

namespace Sample.IdentityServer4.WebAPI.Client.Services
{
    public interface IIdentityServer4Service
    {
        Task<TokenResponse> GetToken(string apiScope);
    }
}
