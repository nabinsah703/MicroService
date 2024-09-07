using System;
using System.ComponentModel.DataAnnotations;

namespace PlateformService.Model;

public class Platform
{
    [Key]
    [Required]
    public int ID { get; set; }

    [Required]
    public int Name { get; set; }

    [Required]
    public int Publisher { get; set; }

    [Required]
    public int Cost { get; set; }
}
