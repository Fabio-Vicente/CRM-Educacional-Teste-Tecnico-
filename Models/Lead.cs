using System.ComponentModel.DataAnnotations;

namespace CRMEducacional.Models;

public class Lead
{
  public int Id { get; set; }
  [MaxLength(50)]
  public string Name { get; set; } = default!;
  public int CPF { get; set; }
  [MaxLength(30)]
  public string Email { get; set; } = default!;
  [MaxLength(20)]

  public string Password { get; set; } = default!;
  public DateTime CreatedAt { get; set; } = DateTime.Now;
  public DateTime UpdatedAt { get; set; } = DateTime.Now;
  public ICollection<Registration>? Registrations { get; set; }
}