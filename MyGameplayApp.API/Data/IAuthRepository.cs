using System.Threading.Tasks;
using MyGameplayApp.API.Models;

namespace MyGameplayApp.API.Data
{
    public interface IAuthRepository 
    {
        Task<User> Login(string username, string password);
        Task<User> Register(User user, string password);
        Task<bool> UserExists(string username);
    }
}