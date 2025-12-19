using server.Models;
using System.Runtime.CompilerServices;

namespace server.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee?> CreateEmployeeAsync(Employee employee);
        Task<Employee?> GetEmployeeByIdAsync(int id);
        Task<List<Employee>> GetEmployeesAsync();
        Task UpdateEmployeeAsync(Employee employee);
        Task DeleteEmployeeAsync(int id);
    }
}
