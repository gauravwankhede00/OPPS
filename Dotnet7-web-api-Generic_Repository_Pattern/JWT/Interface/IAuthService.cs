using GenericRepository_JWT.JWT.Model;
using GenericRepository_JWT.JWT.Model.RequestModel;

namespace GenericRepository_JWT.JWT.Interface
{
    public interface IAuthService
    {
        JwtUser AddUser(JwtUser user);
        string Login(LoginRequest loginRequest);
    }
}
