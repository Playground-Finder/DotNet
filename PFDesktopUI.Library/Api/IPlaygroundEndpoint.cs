using PFDesktopUI.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PFDesktopUI.Library.Api
{
    public interface IPlaygroundEndpoint
    {
        Task<List<PlaygroundModel>> GetAll();
    }
}