using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using Blazored.LocalStorage;

namespace BlazorBattles.Client
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorageService;
        public CustomAuthStateProvider(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            AuthenticationState state = new AuthenticationState(new ClaimsPrincipal());

            if (await _localStorageService.GetItemAsync<bool>("isAuthenticated"))
            {
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(new[]{
                new Claim(ClaimTypes.Name, "Bob")
                }, "Test Authentication");

                ClaimsPrincipal user = new ClaimsPrincipal(claimsIdentity);
                state = new AuthenticationState(user);
            }

            //Tell all the components that the Auth state has changed
            NotifyAuthenticationStateChanged(Task.FromResult(state));
            return (state);
        }
    }
}
