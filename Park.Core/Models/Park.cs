using System;
using System.ComponentModel.DataAnnotations;

namespace Parks.Core
{
  public class Park
  {
    [Key]
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string State { get; set; }
    public DateTime Created { get; set; }
    public DateTime Established { get; set; }
  }
}
