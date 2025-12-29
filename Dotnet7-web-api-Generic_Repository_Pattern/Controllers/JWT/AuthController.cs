using GenericRepository_JWT.JWT.Interface;
using GenericRepository_JWT.JWT.Model;
using GenericRepository_JWT.JWT.Model.RequestModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GenericRepository_JWT.Controllers.JWT
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService _authService)
        {
            this._authService = _authService;
        }

        // POST api/<AuthController>
        [HttpPost("Login")]
        public string Login([FromBody] LoginRequest value)
        {
            return _authService.Login(value);

        }

        [HttpPost("AddUser")]
        public JwtUser AddUser([FromBody] JwtUser value)
        {
            return _authService.AddUser(value);

        }


    }
}
