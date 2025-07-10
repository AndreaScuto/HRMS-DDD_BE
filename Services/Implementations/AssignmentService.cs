using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;
using Repositories.Implementations;

namespace Services.Implementations;

public class AssignmentService(AssignmentRepository assignmentRepository) : IAssignmentService
{
    public async Task<Assignment> GetAssignmentByIdAsync(Guid id)
    {
        var assignment = await assignmentRepository.GetAssignmentById(id);
        if (assignment == null)
        {
            throw new CrudException("Assignment with id:" + id + " not found.");
        }

        return assignment;
    }

    public async Task<IEnumerable<Assignment>> GetAllAsync()
    {
        var assignments = await assignmentRepository.GetAllAssignment();
        return assignments ?? [];
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