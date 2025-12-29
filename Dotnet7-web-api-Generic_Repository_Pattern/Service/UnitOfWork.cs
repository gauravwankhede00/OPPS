using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using TechYatraAPI.Context;
using TechYatraAPI.Service;

namespace TechYatraAPI.Interface
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ToDoContext _dbContext;

        public IToDoService TodoService { get; private set; }

        public IUserService UserService { get; private set; }
        public UnitOfWork(ToDoContext dbContext, IMemoryCache cache)
        {
           
            _dbContext = dbContext;
            TodoService = new ToDoService(dbContext, cache);
            UserService = new UserService(dbContext);
        }

        public void Save()
        {
          
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public Task Testing()
        {
            return Task.CompletedTask;
        }
    }
}
