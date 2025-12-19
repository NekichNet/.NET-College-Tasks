using Microsoft.EntityFrameworkCore;
using server.Models;
using server.Repositories.Interfaces;
using server.Repositories.Persistence;

namespace server.Repositories
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private readonly AppDbContext _context;

		public EmployeeRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task<Employee?> CreateEmployeeAsync(Employee employee)
		{
			Employee? resultEmployee = _context.Employee.AddAsync(employee).Result.Entity;
			await _context.SaveChangesAsync();
			return resultEmployee;
		}

		public async Task DeleteEmployeeAsync(int id)
		{
			Employee? employee = await _context.Employee.FindAsync(id);
			if (employee != null)
			{
				_context.Employee.Remove(employee);
				await _context.SaveChangesAsync();
			}
		}

		public async Task<Employee?> GetEmployeeByIdAsync(int id)
		{
			return await _context.Employee.FindAsync(id);
		}

        public async Task<List<Employee>> GetEmployeesAsync()
		{
			return await _context.Employee.ToListAsync();
		}

		public async Task UpdateEmployeeAsync(Employee employee)
		{
			_context.Employee.Update(employee);
			await _context.SaveChangesAsync();
		}
	}
}
