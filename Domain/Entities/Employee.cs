using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Employee
{
    [Key] public Guid Id { get; set; } = Guid.NewGuid();
    [Required] public required string FirstName { get; set; } = null!;
    [Required] public required string LastName { get; set; } = null!;
    [Required] public DateOnly HireDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    [Required] public required string Department { get; set; }
    [Required] public required string Role { get; set; } = null!;
    [Required] public decimal Salary { get; set; } = 0;
    public EmployeesProjects? EmployeesProjects { get; set; }

    public Employee()
    {
    }
}