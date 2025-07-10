using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace Domain.Entities;

public class Project
{
    [Key] public Guid Id { get; set; } = Guid.NewGuid();
    [Required] public string Name { get; set; } = null!;
    [Required] public string Description { get; set; } = "";
    [Required] public DateOnly StartDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    public DateOnly EndDate { get; set; }
    [Required] public required Status Status { get; set; }
    public EmployeesProjects? EmployeesProjects { get; set; }

    public Project()
    {
    }
}