using PracticeWebApi.Models;

namespace PracticeWebApi.Data.Contract
{
    public interface IUserRepository
    {
        bool RegisterUser(User user);

        bool UserExists(string loginId, string email);

        User? ValidateUser(string username);
    }
}
