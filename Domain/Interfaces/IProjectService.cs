using Domain.Entities;

namespace Domain.Interfaces;

public interface IProjectService
{
    Task<Project> GetProjectByIdAsync(Guid id);
    Task<IEnumerable<Project>> GetAllAsync();
    Task<Project> CreateProjectAsync(Project project);
    Task UpdateProjectAsync(Project project);
    Task DeleteProjectAsync(Guid id);
}