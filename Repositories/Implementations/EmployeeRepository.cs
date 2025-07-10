using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Context;
using Repositories.Interfaces;

namespace Repositories.Implementations;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly HmrsDbContext _context;

    public EmployeeRepository(HmrsDbContext context)
    {
        _context = context;
    }

    public async Task<Employee?> GetEmployeeById(Guid id)
    {
        return await _context.Employees.FindAsync(id);
    }

    public async Task<IEnumerable<Employee>?> GetAllEmployees()
    {
        return await _context.Employees.ToListAsync();
    }

    public async Task<bool> CreateAsync(Employee employee)
    {
        await _context.Employees.AddAsync(employee);
        var result = await _context.SaveChangesAsync();
        return result > 0;    }

    public async Task<bool> UpdateAsync(Employee employee)
    {
        _context.Employees.Update(employee);
        var result = await _context.SaveChangesAsync();
        return result > 0;    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        _context.Employees.Remove(await _context.Employees.FindAsync(id));
        var result = await _context.SaveChangesAsync();
        return result > 0;    }
}