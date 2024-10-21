using Microsoft.AspNetCore.Identity;

namespace auth_jwt_token_asp_net_core_web_api_with_sameer.Repositories
{
    public interface ITokenRepostory
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
