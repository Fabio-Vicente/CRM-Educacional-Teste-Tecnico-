using System.ComponentModel.DataAnnotations;

namespace CRMEducacional.models;

public class Course
{
  public int Id { get; set; }
  [MaxLength(50)]
  public string Name { get; set; } = default!;
  public DateTime StartDate { get; set; }
  public int CreditHours { get; set; }
  public int MaxParticipants { get; set; } = default!;
  [MaxLength(20)]
  public string Local { get; set; } = default!;
  public DateTime CreatedAt { get; set; } = DateTime.Now;
  public DateTime UpdatedAt { get; set; } = DateTime.Now;
  public ICollection<Registration>? Registrations { get; set; }
}