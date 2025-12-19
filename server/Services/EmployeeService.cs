using server.Models;
using server.Repositories.Interfaces;
using server.Services.Interfaces;

namespace server.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<Employee?> AddEmployeeAsync(string fullName, string phoneNumber, string email)
        {
            return await _repository.CreateEmployeeAsync(new Employee(fullName, phoneNumber, email));
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            _repository.DeleteEmployeeAsync(id);
        }

        public async Task<Employee?> GetEmployeeAsync(int id)
        {
            return await _repository.GetEmployeeByIdAsync(id);
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await _repository.GetEmployeesAsync();
        }

        public async Task<bool> IsEmployeeExists(int id)
        {
            return await _repository.GetEmployeeByIdAsync(id) is Employee;
        }

        public async Task UpdateEmployeeAsync(Employee employee)
        {
            _repository.UpdateEmployeeAsync(employee);
        }
    }
}
