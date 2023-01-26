using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using BlazorBattles.Server.Data;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(app.Configuration.GetConnectionString("DefaultConnection")));

app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
