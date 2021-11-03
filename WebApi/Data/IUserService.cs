using WebApi.Models;

namespace WebApi.Data
{
    public interface IUserService
    {
        User ValidateUser(string username, string password);
    }
}