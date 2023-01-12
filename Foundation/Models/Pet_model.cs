using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foundation.Models;
[Table("Pet")]
public class Pet_model
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("pet_type_id")]
    public int Pet_modelId { get; set; }

    [Column("type")]
    [MaxLength(20)]
    public string Type { get; set; }


    public virtual ICollection<Men_model> Men_model { get; set; }
    public virtual ICollection<Women_model> Women_model { get; set; }

}