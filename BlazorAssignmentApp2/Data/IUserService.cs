using System.Threading.Tasks;
using BlazorAssignmentApp2.Models;

namespace BlazorAssignmentApp2.Data
{
    public interface IUserService
    {
         Task<User> ValidateUser(string username, string password);
    }
}