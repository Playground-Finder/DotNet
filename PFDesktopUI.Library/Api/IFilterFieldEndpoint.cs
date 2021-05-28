using System.Collections.Generic;
using System.Threading.Tasks;

namespace PFDesktopUI.Library.Api
{
    public interface IFilterFieldEndpoint
    {
        Task<List<string>> GetFilter(string FilterName);

        Task<List<string>> GetAgeFilter();
    }
}