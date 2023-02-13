using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foundation.Models;
[Table("Smoking")]
public class Smoking_model
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("smoking_id")]
    public int Smoking_modelId { get; set; }

    [Column("type")]
    [MaxLength(20)]
    public string Type { get; set; }


    public virtual ICollection<Person_model> Person_model { get; set; }

}