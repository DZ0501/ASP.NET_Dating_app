using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foundation.Models;
[Table("Alcohol")]
public class Alcohol_model
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("alcohol_id")]
    public int Alcohol_modelId { get; set; }

    [Column("type")]
    [MaxLength(20)]
    public string Type { get; set; }


    public virtual ICollection<Person_model> Person_model { get; set; }

}