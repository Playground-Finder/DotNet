using PFDesktopUI.Models;
using System.Threading.Tasks;

namespace PFDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}