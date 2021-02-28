using System;
using System.ComponentModel.DataAnnotations;

namespace Park.Core
{
  public class Models
  {
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string State { get; set; }
    public DateTime Created { get; set; }
    public DateTime Established { get; set; }
  }
}
