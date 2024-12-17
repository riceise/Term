using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Text.Json;

namespace UI_v2.Services
{
    public class AuthenticationService : AuthenticationStateProvider
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly NavigationManager _navigationManager;

        public AuthenticationService(IHttpClientFactory httpClientFactory, NavigationManager navigationManager)
        {
            _httpClientFactory = httpClientFactory;
            _navigationManager = navigationManager;
        }

        public async Task<bool> Login
    }
}