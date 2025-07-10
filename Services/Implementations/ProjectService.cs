using Domain.Entities;
using Domain.Interfaces;

namespace Services.Implementations;

public class ProjectService : IProjectService
{
    public Task<Project> GetProjectByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Project>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Project> CreateProjectAsync(Project project)
    {
        throw new NotImplementedException();
    }

    public Task UpdateProjectAsync(Project project)
    {
        throw new NotImplementedException();
    }

    public Task DeleteProjectAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}