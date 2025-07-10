using Domain.Entities;

namespace Repositories.Interfaces;

public interface IEmployeeRepository
{
    Task<Employee?> GetEmployeeById(Guid id);
    Task<IEnumerable<Employee>?> GetAllEmployees();
    Task<bool> CreateAsync(Employee employee);
    Task<bool> UpdateAsync(Employee employee);
    Task<bool> DeleteAsync(Guid id);
}