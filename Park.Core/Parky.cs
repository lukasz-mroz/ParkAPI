using System;
using System.ComponentModel.DataAnnotations;

namespace Parks.Cores
{
  public class Parky
  {
    [Key]
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string State { get; set; }
    public DateTime Created { get; set; }
    public DateTime Established { get; set; }
    public bool IsDeleted { get; set; }
  }
}
