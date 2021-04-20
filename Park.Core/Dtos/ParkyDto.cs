using System;
using System.ComponentModel.DataAnnotations;

namespace Parks.Cores.Dtos
{
  public class ParkyDto
  {
    [Key]
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string State { get; set; }
    }
}