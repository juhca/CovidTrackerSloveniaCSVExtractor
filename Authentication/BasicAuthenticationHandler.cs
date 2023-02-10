using System;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Text;
using System.Security.Claims;
using IndigoLabs2.Models;

namespace IndigoLabs2.Authentication
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> option, ILoggerFactory logger,
        UrlEncoder encoder, ISystemClock clock) : base(option, logger, encoder, clock)
        {

        }

        private List<User> _users = new List<User>
        {
            new User
            {
                Id= 1, Username = "admin", Password= "000000"
            },
            new User
            {
                Id= 2, Username = "user", Password= "000000"
            },
            new User
            {
                Id= 3, Username = "tomas", Password= "000000"
            }
        };

        protected async override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("No header found.");

            var headerValue = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
            var bytes = Convert.FromBase64String(headerValue.Parameter);
            string credentials = Encoding.UTF8.GetString(bytes);

            if (string.IsNullOrEmpty(credentials))
                return AuthenticateResult.Fail("No credentials found.");

            string[] array = credentials.Split(':');
            string username = array[0];
            string password = array[1];

            if (await Task.FromResult(_users.SingleOrDefault(x => x.Username == username && x.Password == password)) != null)
            {
                var claim = new[] { new Claim(ClaimTypes.Name, username) };
                var identity = new ClaimsIdentity(claim, Scheme.Name);
                var principal = new ClaimsPrincipal(identity);
                var ticket = new AuthenticationTicket(principal, Scheme.Name);

                return AuthenticateResult.Success(ticket);
            }
            return AuthenticateResult.Fail("Username/password combo not find.");
        }
    }
}
