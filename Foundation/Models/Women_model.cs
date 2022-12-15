using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foundation.Models;
[Table("Women")]
public class Women_model
{
    //[Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("women_id")]
    public int Women_modelId { get; set; }

    [Required]
    [Column("first_name")]
    [StringLength(30)]
    public string FirstName { get; set; }

    [Required]
    [Column("last_name")]
    [StringLength(20)]
    public string LastName { get; set; }

    [Required]
    [Column("age")]
    [StringLength(3)]
    public int Age { get; set; }

    [Required]
    [Column("localization")]
    [StringLength(30)]
    public string Localization { get; set; }

    [Required]
    [Column("interest_1_id")]
    [StringLength(3)]
    public byte InterestFirstId { get; set; }

    [Required]
    [Column("interest_2_id")]
    [StringLength(3)]
    public byte InterestSecondId { get; set; }

    [Required]
    [Column("interest_3_id")]
    [StringLength(3)]
    public byte InterestThirdId { get; set; }

    [Required]
    [Column("relationship_status_id")]
    [StringLength(3)]
    public byte RelationshipStatusId { get; set; }

    [ForeignKey("Business_model")]
    [Column("business_id")]
    [StringLength(2)]
    public int? BusinessId { get; set; }

    [Required]
    [Column("zodiac_sign_id")]
    [StringLength(3)]
    public byte ZodiacSignId { get; set; }

    [Required]
    [Column("education_id")]
    [StringLength(3)]
    public byte EducationId { get; set; }

    
    [Column("pet_name")]
    [StringLength(30)]
    public string? PetName { get; set; }

    [Column("pet_type_id")]
    [ForeignKey("Pet_model")]
    [StringLength(2)]
    public byte? PetTypeId { get; set; }

    [Required]
    [Column("religion_id")]
    [StringLength(2)]
    public byte ReligionId { get; set; }

    [Required]
    [ForeignKey("Alcohol_model")]
    [Column("alcohol_id")]
    [StringLength(2)]
    public byte AlcoholId { get; set; }

    [Required]
    [Column("smoking_id")]
    [StringLength(2)]
    public byte SmokingId { get; set; }

    public virtual Business_model Business_model { get; set; }
    public virtual Alcohol_model Alcohol_model { get; set; }
    public virtual Pet_model Pet_Model { get; set; }



}