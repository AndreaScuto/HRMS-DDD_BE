using Domain.Entities;
using Domain.Interfaces;

namespace Services.Implementations;

public class EmployeeService : IEmployeeService
{
    public Task<Employee> GetEmployeeByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Employee>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Employee> CreateEmployeeAsync(Employee employee)
    {
        throw new NotImplementedException();
    }

    public Task UpdateEmployeeAsync(Employee employee)
    {
        throw new NotImplementedException();
    }

    public Task DeleteEmployeeAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}