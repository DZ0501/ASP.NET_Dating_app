using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foundation.Models;

public class CreateRole_model
{
    [Required]
    [Display(Name = "Role")]
    public string RoleName { get; set; }
}