using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PFDesktopUI.Library.Api
{
    public class FilterFieldEndpoint : IFilterFieldEndpoint
    {
        private IAPIHelper _apiHelper;

        public FilterFieldEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task<List<string>> GetFilter(string FilterName)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync($"api/UI/GetFilter?FilterName={FilterName}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<string>>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }
        }
        public async Task<List<string>> GetAgeFilter()
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("api/UI/GetAgeFilter"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<string>>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }
        }

    }
}
