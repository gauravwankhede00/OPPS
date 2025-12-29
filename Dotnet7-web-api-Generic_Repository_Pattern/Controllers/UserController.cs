using Microsoft.AspNetCore.Mvc;
using TechYatraAPI.Interface;
using TechYatraAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechYatraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IUserService _userService;
        public UserController(IUnitOfWork unitOfWork
            )
        {
            _unitOfWork = unitOfWork;
          
        }
        // GET: api/<UserController>
        [HttpGet]
        public List<User> Get()
        {
            var list = _unitOfWork.TodoService.GetAllTasksBYGAURAV();
            var users = _unitOfWork.UserService.GetAll();
            return users;
        }
        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            var result = _unitOfWork.UserService.GetById(id);
            return result;
        }

        // POST api/<UserController>
        [HttpPost]
        public User Post([FromBody] User obj)
        {
            var user = _unitOfWork.UserService.Add(obj);
            return user;
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public User Put(int id, [FromBody] User value)
        {
            if (id != value.Id)
            {
                throw new Exception("Please enter the valid details");
            }
            var result = _unitOfWork.UserService.Update(value, id);
            return result;


        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            bool result = _unitOfWork.UserService.Delete(id);
            return result;
        }
    }
}
