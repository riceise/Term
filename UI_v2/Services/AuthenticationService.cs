using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Text.Json;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace UI_v2.Services
{
    public class AuthenticationService : AuthenticationStateProvider
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly NavigationManager _navigationManager;
        private readonly ProtectedLocalStorage _localStorage;

        public AuthenticationService(IHttpClientFactory httpClientFactory, NavigationManager navigationManager, ProtectedLocalStorage protectedLocalStorage)
        {
            _httpClientFactory = httpClientFactory;
            _navigationManager = navigationManager;
            _localStorage = protectedLocalStorage;
        }

        public async Task<bool> Login(string username, string password)
        {   
            var _httpClient = _httpClientFactory.CreateClient("BackendAPI");
            var response = await _httpClient.PostAsJsonAsync("api/Auth/login", new { UserName = username, Password = password });
            
            if (!response.IsSuccessStatusCode)
            {
                return false;
            }

            var result = await response.Content.ReadFromJsonAsync<LoginResult>();
            await _localStorage.SetAsync("authToken", result.Token);

            Console.WriteLine($"Получен токен: {result.Token}");

            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
            return true;
        }

        public async Task Logout()
        {
            await _localStorage.DeleteAsync("authToken");

            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
            _navigationManager.NavigateTo("/");
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                var token = await _localStorage.GetAsync<string>("authToken");
                
                if (!token.Success || string.IsNullOrEmpty(token.Value))
                {
                    var emptyUser = new ClaimsPrincipal(new ClaimsIdentity());
                    return new AuthenticationState(emptyUser);
                }

                var claims = ParseClaimsFromJwt(token.Value);
                var identity = new ClaimsIdentity(claims, "jwt");
                var user = new ClaimsPrincipal(identity);

                return new AuthenticationState(user);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("JS Interop недоступен, кидаем анонимуса"); 
                
                var anonymousUser = new ClaimsPrincipal(new ClaimsIdentity());
                return new AuthenticationState(anonymousUser);
            }
        }

        private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

            keyValuePairs.TryGetValue(ClaimTypes.Name, out object name);
            if (name != null)
            {
                claims.Add(new Claim(ClaimTypes.Name, name.ToString()));
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
        public async Task<string> GetCurrentToken()
        {
            try
            {
                var token = await _localStorage.GetAsync<string>("authToken");
                Console.WriteLine($"Возвращаемый токен: {token.Value}");
                
                return token.Value;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }
    }

    public class LoginResult
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}