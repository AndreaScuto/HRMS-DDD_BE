using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Context;

namespace Repositories.Implementations;

public class ProjectRepository : IProjectRepository
{
    private readonly HmrsDbContext _context;

    public ProjectRepository(HmrsDbContext context)
    {
        _context = context;
    }

    public async Task<Project?> GetProjectById(Guid id)
    {
        return await _context.Projects.FindAsync(id);
    }

    public async Task<IEnumerable<Project>?> GetAllProject()
    {
        return await _context.Projects.ToListAsync();
    }

    public async Task<bool> CreateAsync(Employee employee)
    {
        await _context.AddAsync(employee);
        var result = await _context.SaveChangesAsync();
        return result > 0;
    }

    public async Task<bool> UpdateAsync(Employee employee)
    {
        _context.Update(employee);
        var result = await _context.SaveChangesAsync();
        return result > 0;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        _context.Remove(await _context.Projects.FindAsync(id));
        var result = await _context.SaveChangesAsync();
        return result > 0;
    }
}