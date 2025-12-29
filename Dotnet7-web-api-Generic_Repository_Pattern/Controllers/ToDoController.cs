using Microsoft.AspNetCore.Mvc;
using TechYatraAPI.Interface;
using TechYatraAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechYatraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoService _service;
        public ToDoController(IToDoService service,

            IGenericRepository<ToDo> toDoService
            )
        {
            _service = service;
            // _toDoService = toDoService;
        }
        // GET: api/<ToDoController>
        [HttpGet]
        public async Task<List<ToDo>> Get()
        {
            var list =  await _service.GetAllTasksBYGAURAV();
            //var tasks = _service.GetAll();
            return list;
        }

        // GET api/<ToDoController>/5
        [HttpGet("{id}")]
        public ToDo Get(int id)
        {
            var result = _service.GetById(id);
            return result;
        }

        // POST api/<ToDoController>
        [HttpPost]
        public ToDo Post([FromBody] ToDo todo)
        {
            var task = _service.Add(todo);
            return task;
        }

        // PUT api/<ToDoController>/5
        [HttpPut("{id}")]
        public ToDo Put(int id, [FromBody] ToDo value)
        {
            if (id != value.Id)
            {
                throw new Exception("Please enter the valid details");
            }
            var result = _service.Update(value, id);
            return result;


        }

        // DELETE api/<ToDoController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            bool result = _service.Delete(id);
            return result;
        }
    }
}
