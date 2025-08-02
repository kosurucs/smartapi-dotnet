using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace AmoSave.Broking.UI.Auth
{
    public class AuthMessageHandler : DelegatingHandler
    {
        private readonly CustomAuthStateProvider _authProvider;

        public AuthMessageHandler(CustomAuthStateProvider authProvider)
        {
            _authProvider = authProvider;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var token = _authProvider.GetToken();
            if (!string.IsNullOrEmpty(token))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            return base.SendAsync(request, cancellationToken);
        }
    }
}