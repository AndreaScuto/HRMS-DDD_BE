using Domain.Entities;

namespace Domain.Interfaces;

public interface IAssignmentService
{
    Task<Assignment> GetAssignmentByIdAsync(Guid id);
    Task<IEnumerable<Assignment>> GetAllAsync();
    Task<Assignment> CreateAssignmentAsync(Assignment assignment);
    Task UpdateAssignmentAsync(Assignment assignment);
    Task DeleteAssignmentAsync(Guid id);
}