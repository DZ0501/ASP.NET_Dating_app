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


    public virtual ICollection<Men_model> Men_model { get; set; }
    public virtual ICollection<Women_model> Women_model { get; set; }

}