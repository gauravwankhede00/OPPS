using TechYatraAPI.Model;

namespace TechYatraAPI.Interface
{
    public interface IToDoService : IGenericRepository<ToDo>
    {
        //ToDo AddTaskBYGAURAV (ToDo todo);
        Task<List<ToDo>> GetAllTasksBYGAURAV();
        //ToDo ToDoGetTaskById(int id);
        //ToDo UpdateTask(ToDo todo);
        //bool DeleteTaskById(int id);
    }
}
