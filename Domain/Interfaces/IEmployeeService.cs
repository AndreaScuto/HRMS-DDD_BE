using Domain.Entities;

namespace Domain.Interfaces;

public interface IEmployeeService
{
    Task<Employee> GetEmployeeByIdAsync(Guid id);
    Task<IEnumerable<Employee>> GetAllAsync();
    Task<Employee> CreateEmployeeAsync(Employee employee);
    Task UpdateEmployeeAsync(Employee employee);
    Task DeleteEmployeeAsync(Guid id);
}