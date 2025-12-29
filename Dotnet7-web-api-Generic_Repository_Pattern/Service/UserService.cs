using TechYatraAPI.Context;
using TechYatraAPI.Interface;
using TechYatraAPI.Model;

namespace TechYatraAPI.Service
{
    public class UserService : GenericRepository<User>, IUserService
    {
        private readonly ToDoContext _toDoContext;
        public UserService(ToDoContext toDoContext) : base(toDoContext)
        {
            _toDoContext = toDoContext;
        }

        public IEnumerable<User> GetAllUserFromNagpur()
        {
            return _toDoContext.Users.Where(w => w.Email.Contains("gmail.com")).ToList();
        }
    }
}
