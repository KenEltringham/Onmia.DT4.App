namespace Onmia.DT4.App.Services
{
    using Microsoft.Extensions.Options;
    public class UrlService
    {
        private readonly string _apiBaseUrl;

        public UrlService(IOptions<ApiSettings> apiSettings)
        {
            _apiBaseUrl = apiSettings.Value.BaseURL;
        }
    }
}
