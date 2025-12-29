using TechYatraAPI.Model;

namespace TechYatraAPI.Interface
{
    public interface IUserService : IGenericRepository<User>
    {
        IEnumerable<User> GetAllUserFromNagpur();
    }
}
