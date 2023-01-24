using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace BlazorBattles.Client
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //This will result in an unauthorised user because it does not have a claims identity
            //return Task.FromResult(new AuthenticationState(new ClaimsPrincipal()));

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, "Thomas")
            }, "Test Authentication");

            ClaimsPrincipal user = new ClaimsPrincipal(claimsIdentity);

            return Task.FromResult(new AuthenticationState(user));
        }
    }
}
