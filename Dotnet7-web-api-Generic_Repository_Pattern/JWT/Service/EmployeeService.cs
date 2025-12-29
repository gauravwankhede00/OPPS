using GenericRepository_JWT.JWT.Interface;
using GenericRepository_JWT.JWT.Model;
using TechYatraAPI.Context;

namespace GenericRepository_JWT.JWT.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ToDoContext _toDoContext;
        public EmployeeService(ToDoContext toDoContext)
        {
            this._toDoContext = toDoContext;
        }
        public Employee Add(Employee obj)
        {
            _toDoContext.Employees.Add(obj);
            _toDoContext.SaveChanges();
            return obj;
        }

        public Employee Delete(int id)
        {
            var obj = _toDoContext.Employees.Find(id);
            if (obj == null)
            {
                throw new ArgumentException("No Employee Exists");
            }
            _toDoContext.Employees.Remove(obj);
            _toDoContext.SaveChanges();
            return obj;
        }

        public List<Employee> GetAll()
        {
            return _toDoContext.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return _toDoContext.Employees.Find(id);
        }

        public Employee Update(Employee obj, int id)
        {
            var updated = _toDoContext.Employees.Update(obj);

            _toDoContext.SaveChanges();
            return updated.Entity;

        }
    }
}
