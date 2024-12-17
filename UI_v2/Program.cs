using Data;
using Data.Model.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using UI_v2.Services;

var builder = WebApplication.CreateBuilder(args);

#region Всё, что связано с Identity

builder.Services.AddDbContext<TFOMSContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<TFOMSContext>()
    .AddDefaultTokenProviders();    

builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddScoped<AuthorizationMessageHandler>();
builder.Services.AddScoped<AuthenticationStateProvider>(provider => provider.GetRequiredService<AuthenticationService>());

// Регистрация Http клиента с хэндлером для автоматического добавления токенов к телу
builder.Services.AddHttpClient("BackendAPI", client =>
{
    client.BaseAddress = new Uri("http://localhost:5277/");
}).AddHttpMessageHandler(sp => sp.GetRequiredService<AuthorizationMessageHandler>());

#endregion

builder.Services.AddAuthorization();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapBlazorHub();
app.MapControllers();
app.MapFallbackToPage("/_Host");
app.MapRazorPages();

app.Run();
