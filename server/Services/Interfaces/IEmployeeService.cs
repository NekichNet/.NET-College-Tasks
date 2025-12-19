using server.Models;

namespace server.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<Employee?> AddEmployeeAsync(string fullName, string phoneNumber, string email);
        Task<Employee?> GetEmployeeAsync(int id);
        Task<List<Employee>> GetEmployeesAsync();
        Task<bool> IsEmployeeExists(int id);
        Task UpdateEmployeeAsync(Employee employee);
        Task DeleteEmployeeAsync(int id);
    }
}
