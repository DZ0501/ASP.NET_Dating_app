using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foundation.Models;
[Table("Relationship_status")]
public class Relationship_status_model
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("relationship_status_id")]
    public int Relationship_status_modelId { get; set; }

    [Column("type")]
    [MaxLength(20)]
    public string Type { get; set; }

    public virtual ICollection<Person_model> Person_model { get; set; }

}