using GenericRepository_JWT.JWT.Interface;
using GenericRepository_JWT.JWT.Model;
using GenericRepository_JWT.JWT.Model.RequestModel;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TechYatraAPI.Context;

namespace GenericRepository_JWT.JWT.Service
{
    public class AuthService : IAuthService
    {
        private readonly ToDoContext _toDoContext;
        private readonly IConfiguration _configuration;

        Func<JwtUser, bool> CheckUserExists;

        public AuthService(ToDoContext toDoContext, IConfiguration configuration)
        {
            this._toDoContext = toDoContext;
            CheckUserExists = UserExists;
            _configuration = configuration;
        }
        public JwtUser AddUser(JwtUser user)
        {
            var userAdded = _toDoContext.JwtUser.Add(user);
            _toDoContext.SaveChanges();
            return userAdded.Entity;
        }

        public string Login(LoginRequest loginRequest)
        {

            var user = _toDoContext.JwtUser.SingleOrDefault(u => u.Email == loginRequest.Username && u.Password == loginRequest.Password);
            if (user != null)
            {
                string role;
                if (user.Name.ToLower().Contains("gaurav"))
                {
                    role = "Owner";
                }
                else if (user.Name.ToLower().Contains("komal"))
                {
                    role = "Co-Owner";
                }
                else
                {
                    role = "Other";
                }

                var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                new Claim("Id", user.Id.ToString()),
                new Claim("UserName", user.Name),
                new Claim("Email", user.Email),
                new Claim("Role",  role)
            };
                //ClaimTypes.Role

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    _configuration["Jwt:Issuer"],
                    _configuration["Jwt:Audience"],
                    claims,
                    expires: DateTime.UtcNow.AddMinutes(10),
                    signingCredentials: signIn
                );

                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            else
            {
                throw new Exception("Login credentials not match");
            }
        }
        private bool UserExists(JwtUser user)
        {
            return _toDoContext.JwtUser.Any(u => u.Email == user.Email && u.Password == user.Password);
        }
    }
}
