using BlazorBattles.Client;
using BlazorBattles.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.Toast;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

////Nuget package services
//builder.Services.AddBlazoredToast();
//builder.Services.AddBlazoredLocalStorage();

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

////Custom Services
//builder.Services.AddOptions();
//builder.Services.AddAuthorizationCore();
//builder.Services.AddScoped<IBananaService, BananaService>();
//builder.Services.AddScoped<IUnitService, UnitService>();
//builder.Services.AddScoped<CustomAuthStateProvider>();
////builder.Services.AddScoped<AuthenticationStateProvider>(provider => provider.GetRequiredService<CustomAuthStateProvider>());
//builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

builder.Services.AddBlazoredToast();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IBananaService, BananaService>();
builder.Services.AddScoped<IUnitService, UnitService>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
//builder.Services.AddScoped<CustomAuthStateProvider>();
//builder.Services.AddScoped<AuthenticationStateProvider>(provider => provider.GetRequiredService<CustomAuthStateProvider>());

//builder.Services.AddScoped<IAuthService, AuthService>();
//builder.Services.AddScoped<ILeaderboardService, LeaderboardService>();
//builder.Services.AddScoped<IBattleService, BattleService>();

await builder.Build().RunAsync();
