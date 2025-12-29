using GenericRepository_JWT.JWT.Model;
using Microsoft.EntityFrameworkCore;
using TechYatraAPI.Model;

namespace TechYatraAPI.Context
{
    public class ToDoContext: DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options): base(options)
        {

        }
        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<TechYatraAPI.Model.User> Users { get; set; }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<GenericRepository_JWT.JWT.Model.JwtUser> JwtUser { get; set; }
    }
}
