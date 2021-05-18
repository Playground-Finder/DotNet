using PFDesktopUI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PFDesktopUI.Helpers
{
    public class APIHelper : IAPIHelper
    {

        private HttpClient _apiClient;

        public APIHelper()
        {
            InitializeClient();
        }

        private void InitializeClient()
        {
            string api = ConfigurationManager.AppSettings.Get("api");

            _apiClient = new HttpClient();
            _apiClient.BaseAddress = new Uri(api);
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<AuthenticatedUser> Authenticate(string username, string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string,string>("grant_type","password"),
                new KeyValuePair<string, string>("username",username),
                new KeyValuePair<string, string>("password",password)
            });
            
            // The "/Token" endpoint is part of the OAuth protocol implemented by Owin. 
            using (HttpResponseMessage response = await _apiClient.PostAsync("/Token", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    // Uses JSON Deserialization behind the scene to convert HTTP response to AuthenticatedUser 
                    var result = await response.Content.ReadAsAsync<AuthenticatedUser>();
                    return result;
                }
                else
                {
                    throw new HttpRequestException(response.ReasonPhrase);
                }
            }
        }
    }
}
