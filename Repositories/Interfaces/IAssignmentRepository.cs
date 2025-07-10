using Domain.Entities;

namespace Repositories.Interfaces;

public interface IAssignmentRepository
{
    Task<Assignment?> GetAssignmentById(Guid id);
    Task<IEnumerable<Assignment>?> GetAllAssignment();
    Task<bool> CreateAsync(Assignment assignment);
    Task<bool> UpdateAsync(Assignment assignment);
    Task<bool> DeleteAsync(Guid id);
}