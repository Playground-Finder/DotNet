using PFDesktopUI.Library.Models;
using System.Threading.Tasks;

namespace PFDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);

        Task GetLoggedInUserInfo(string token);
    }
}