using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foundation.Models;
[Table("Education")]
public class Education_model
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("education_id")]
    public int Education_modelId { get; set; }

    [Column("type")]
    [MaxLength(20)]
    public string Type { get; set; }


    public virtual ICollection<Person_model> Person_model { get; set; }

}