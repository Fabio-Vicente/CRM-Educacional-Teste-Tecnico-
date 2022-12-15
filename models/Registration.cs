using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CRMEducacional.models;

public class Registration
{
  [Key]
  [Column(Order = 1)]
  public int LeadId { get; set; }
  public Lead? Lead { get; set; }
  [Key]
  [Column(Order = 2)]
  public int CourseId { get; set; }
  public Course? Course { get; set; }
  public DateTime RegistrationDate { get; set; }
}