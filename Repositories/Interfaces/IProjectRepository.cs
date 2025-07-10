using Domain.Entities;

namespace Repositories.Implementations;

public interface IProjectRepository
{
    Task<Project?> GetProjectById(Guid id);
    Task<IEnumerable<Project>?> GetAllProject();
    Task<bool> CreateAsync(Employee employee);
    Task<bool> UpdateAsync(Employee employee);
    Task<bool> DeleteAsync(Guid id);
}