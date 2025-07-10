using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Assignment // N-N Relation
{
    [Key] public Guid EmployeeId { get; set; }
    [Required] public required Employee Employee { get; set; }
    [Key] public Guid ProjectId { get; set; }
    [Required] public required Project Project { get; set; } = null!;
    [Required] public decimal PercentageOfWork { get; set; }
    [Required] public decimal HoursOfWork { get; set; }

    public Assignment()
    {
    }
}