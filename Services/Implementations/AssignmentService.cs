using Domain.Entities;
using Domain.Interfaces;

namespace Services.Implementations;

public class AssignmentService : IAssignmentService
{
    public Task<Assignment> GetAssignmentByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Assignment>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Assignment> CreateAssignmentAsync(Assignment assignment)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAssignmentAsync(Assignment assignment)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAssignmentAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}