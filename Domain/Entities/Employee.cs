using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace Domain.Entities;

public class Employee
{
    [Key] public Guid Id { get; set; } = Guid.NewGuid();
    [Required] public required string FirstName { get; set; } = null!;
    [Required] public required string LastName { get; set; } = null!;
    [Required] public DateOnly HireDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    [Required] public required string Department { get; set; }
    [Required] public required Role Role { get; set; }
    [Required] public decimal Salary { get; set; } = 0;
    public Assignment[]? Assignments { get; set; }

    public Employee()
    {
    }
}