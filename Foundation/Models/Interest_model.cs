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

    [InverseProperty(nameof(Men_model.Interest_first_model))]
    public virtual ICollection<Men_model> Men_first_models { get; set; }


    [InverseProperty(nameof(Men_model.Interest_second_model))]
    public virtual ICollection<Men_model> Men_second_models { get; set; }


    [InverseProperty(nameof(Men_model.Interest_third_model))]
    public virtual ICollection<Men_model> Men_third_models { get; set; }


    [InverseProperty(nameof(Women_model.Interest_first_model))]
    public virtual ICollection<Women_model> Women_first_models { get; set; }


    [InverseProperty(nameof(Women_model.Interest_second_model))]
    public virtual ICollection<Women_model> Women_second_models { get; set; }


    [InverseProperty(nameof(Women_model.Interest_third_model))]
    public virtual ICollection<Women_model> Women_third_models { get; set; }


}