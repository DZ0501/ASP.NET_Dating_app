using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foundation.Models;
[Table("Interest")]
public class Interest_model
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("interest_id")]
    public int Interest_modelId { get; set; }

    [Column("type")]
    [MaxLength(20)]
    public string Type { get; set; }

    [InverseProperty(nameof(Person_model.Interest_first_model))]
    public virtual ICollection<Person_model> Person_first_models { get; set; }


    [InverseProperty(nameof(Person_model.Interest_second_model))]
    public virtual ICollection<Person_model> Person_second_models { get; set; }


    [InverseProperty(nameof(Person_model.Interest_third_model))]
    public virtual ICollection<Person_model> Person_third_models { get; set; }



}