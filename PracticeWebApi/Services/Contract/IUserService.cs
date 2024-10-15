using PracticeWebApi.Dtos;

namespace PracticeWebApi.Services.Contract
{
    public interface IUserService
    {
        ServiceResponse<string> RegisterUserService(RegisterDto register);

        ServiceResponse<string> LoginUserService(LoginDto login);
    }
}
