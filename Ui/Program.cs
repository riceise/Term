using Ui.Components;
using Data;
using Data.Model.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using Ui.Components.Services;

var builder = WebApplication.CreateBuilder(args);

// DbContext для работы с Identity
builder.Services.AddDbContext<TFOMSContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

// Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<TFOMSContext>()
    .AddDefaultTokenProviders();

// Настраиваем куки
// builder.Services.ConfigureApplicationCookie(options =>
// {
//     options.LoginPath = "/login";
//     options.AccessDeniedPath = "/access-denied";
// });

// Регистрация AuthenticationService
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddScoped<AuthorizationMessageHandler>();
builder.Services.AddScoped<AuthenticationStateProvider>(provider => provider.GetRequiredService<AuthenticationService>());

// Регистрация Http клиента с хэндлером для автоматического добавления токенов к телу
builder.Services.AddHttpClient("BackendAPI", client =>
{
    client.BaseAddress = new Uri("http://localhost:5277/");
}).AddHttpMessageHandler(sp => sp.GetRequiredService<AuthorizationMessageHandler>());

builder.Services.AddAuthorization();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();
app.UseAntiforgery();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
