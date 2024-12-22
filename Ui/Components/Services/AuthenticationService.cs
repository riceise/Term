using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Text.Json;
using Microsoft.AspNetCore.Identity;
using Data.Model.Entities.Users;

namespace Ui.Components.Services
{
    public class AuthenticationService : AuthenticationStateProvider
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly NavigationManager _navigationManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private static string _token = string.Empty;

        public AuthenticationService(
            IHttpClientFactory httpClientFactory, 
            NavigationManager navigationManager,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _httpClientFactory = httpClientFactory;
            _navigationManager = navigationManager;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> Login(string username, string password)
        {   
            var _httpClient = _httpClientFactory.CreateClient("BackendAPI");
            var response = await _httpClient.PostAsJsonAsync("api/Auth/login", new { UserName = username, Password = password });
            
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<LoginResult>();
                _token = result.Token;

                // Временное логирование
                Console.WriteLine($"Получен токен: {_token}");

                NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
                return true;
            }
            
            return false;
        }

        public void Logout()
        {
            _token = null;
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
            _navigationManager.NavigateTo("/");
        }

        // public override Task<AuthenticationState> GetAuthenticationStateAsync()
        // {
        //     if (string.IsNullOrEmpty(_token))
        //     {
        //         return Task.FromResult(new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())));
        //     }

        //     var claims = ParseClaimsFromJwt(_token);
        //     var identity = new ClaimsIdentity(claims, "jwt");
        //     var user = new ClaimsPrincipal(identity);
        //     return Task.FromResult(new AuthenticationState(user));
        // }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            if (string.IsNullOrEmpty(_token))
            {
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }

            var user = await _userManager.GetUserAsync(_signInManager.Context.User);
            if (user != null)
            {
                var claims = await _userManager.GetClaimsAsync(user);
                var identity = new ClaimsIdentity(claims, "jwt");
                return new AuthenticationState(new ClaimsPrincipal(identity));
            }

            var jwtClaims = ParseClaimsFromJwt(_token);
            var jwtIdentity = new ClaimsIdentity(jwtClaims, "jwt");
            return new AuthenticationState(new ClaimsPrincipal(jwtIdentity));
        }

        // private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        // {
        //     var claims = new List<Claim>();
        //     var payload = jwt.Split('.')[1];
        //     var jsonBytes = ParseBase64WithoutPadding(payload);
        //     var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

        //     keyValuePairs.TryGetValue(ClaimTypes.Name, out object name);
        //     if (name != null)
        //     {
        //         claims.Add(new Claim(ClaimTypes.Name, name.ToString()));
        //     }

        //     return claims;
        // }

        private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

            keyValuePairs.TryGetValue(ClaimTypes.Role, out object role);
            if (role != null)
            {
                claims.Add(new Claim(ClaimTypes.Role, role.ToString()));
            }

            keyValuePairs.TryGetValue(ClaimTypes.Name, out object name);
            if (name != null)
            {
                claims.Add(new Claim(ClaimTypes.Name, name.ToString()));
            }

            keyValuePairs.TryGetValue(ClaimTypes.NameIdentifier, out object nameIdentifier);
            if (nameIdentifier != null)
            {
                claims.Add(new Claim(ClaimTypes.NameIdentifier, nameIdentifier.ToString()));
            }

            return claims;
        }

        private byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }

        // Метод вернёт токен для генерации заголовка в запросах
        public string GetCurrentToken()
        {
            Console.WriteLine($"Возвращаемый токен: {_token}");
            return _token;
        }
    }

    public class LoginResult
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}