using GenericRepository_JWT.JWT.Model;

namespace GenericRepository_JWT.JWT.Interface
{
    public interface IEmployeeService
    {
        Employee Add(Employee obj);
        List<Employee> GetAll();
        Employee GetById(int id);
        Employee Update(Employee obj, int id);
        Employee Delete(int id);
    }
}
