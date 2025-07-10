using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;
using Repositories.Implementations;

namespace Services.Implementations;

public class EmployeeService(EmployeeRepository employeeRepository) : IEmployeeService
{
    public async Task<Employee> GetEmployeeByIdAsync(Guid id)
    {
        var employee = await employeeRepository.GetEmployeeById(id);
        if (employee == null)
        {
            throw new NotFoundException("Employee with id:" + id + " not found.");
        }

        return employee;
    }

    public async Task<IEnumerable<Employee>> GetAllAsync()
    {
        var employees = await employeeRepository.GetAllEmployees();
        return employees ?? [];
    }

    public async Task CreateEmployeeAsync(Employee employee)
    {
        if (!await employeeRepository.CreateAsync(employee))
        {
            throw new CrudException("Employee creation failed.");
        }
    }

    public async Task UpdateEmployeeAsync(Employee employee)
    {
        if (!await employeeRepository.UpdateAsync(employee))
        {
            throw new CrudException("Employee update failed.");
        }
    }

    public async Task DeleteEmployeeAsync(Guid id)
    {
        if (!await employeeRepository.DeleteAsync(id))
        {
            throw new CrudException("Employee deletion failed.");
        }
    }
}