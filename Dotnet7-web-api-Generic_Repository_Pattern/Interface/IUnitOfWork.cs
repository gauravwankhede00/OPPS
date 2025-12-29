namespace TechYatraAPI.Interface
{
    public interface IUnitOfWork : IDisposable
    {
         IToDoService TodoService { get; }
         IUserService UserService { get; }
        void Save();
    }
}
