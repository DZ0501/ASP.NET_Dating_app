using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foundation.Models;
[Table("Zodiac_sign")]
public class Zodiac_sign_model
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("zodiac_sign_id")]
    public int Zodiac_sign_modelId { get; set; }

    [Column("type")]
    [MaxLength(20)]
    public string Type { get; set; }


    public virtual ICollection<Person_model> Person_model { get; set; }

}