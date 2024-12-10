using System.Net.Http.Headers;

namespace Ui.Components.Services
{
    public class AuthorizationMessageHandler : DelegatingHandler
    {
        private readonly AuthenticationService _authService;

        public AuthorizationMessageHandler(AuthenticationService authenticationService)
        {
            _authService = authenticationService;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var token = _authService.GetCurrentToken(); // Из сервиса тырим токен

            if (!string.IsNullOrEmpty(token))
            {
                // request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                Console.WriteLine($"Добавлен заголовок Authorization: Bearer {token}");
            }
            else
            {
                Console.WriteLine("Токен отсутствует, заголовок Authorization не добавлен.");
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }
}