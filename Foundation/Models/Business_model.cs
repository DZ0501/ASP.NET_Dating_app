using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foundation.Models;
[Table("Business")]
public class Business_model
{
    //[Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("business_id")]
    public int Business_modelId { get; set; }

    [Required]
    [Column("name")]
    [StringLength(70)]
    public string Name { get; set; }

    [Required]
    [Column("nip")]
    [MaxLength(10)]
    public ulong NIP { get; set; }

    [Required]
    [Column("postcode")]
    [StringLength(6)]
    public string Postcode { get; set; }

    [Required]
    [Column("localization")]
    [StringLength(30)]
    public string Localization { get; set; }

    [Required]
    [Column("address")]
    [StringLength(70)]
    public string Address { get; set; }

    public virtual ICollection<Men_model> Men_model { get; set; }
    public virtual ICollection<Women_model> Women_model { get; set; }


}