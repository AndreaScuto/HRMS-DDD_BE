using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Context;
using Repositories.Interfaces;

namespace Repositories.Implementations;

public class AssignmentRepository : IAssignmentRepository
{
    private readonly HmrsDbContext _context;

    public AssignmentRepository(HmrsDbContext context)
    {
        _context = context;
    }

    public async Task<Assignment?> GetAssignmentById(Guid id)
    {
        return await _context.Assignments.FindAsync(id);
    }

    public async Task<IEnumerable<Assignment>?> GetAllAssignment()
    {
        return await _context.Assignments.ToListAsync();
    }

    public async Task<bool> CreateAsync(Assignment assignment)
    {
        _context.Assignments.Add(assignment);
        var result = await _context.SaveChangesAsync();
        return result > 0;
    }


    public async Task<bool> UpdateAsync(Assignment assignment)
    {
        _context.Update(assignment);
        var result = await _context.SaveChangesAsync();
        return result > 0;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        _context.Assignments.Remove(await _context.Assignments.FindAsync(id));
        var result = await _context.SaveChangesAsync();
        return result > 0;
    }
}