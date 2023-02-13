using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foundation.Models;
[Table("Person")]
public class Person_model
{
    //[Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("person_id", Order = 0)]
    public int Person_modelId { get; set; }

    [Column("gender", Order = 1)]
    [StringLength(1)]
    public char Gender { get; set; }

    [Required]
    [Column("first_name", Order = 2)]
    [StringLength(30)]
    public string FirstName { get; set; }

    [Required]
    [Column("last_name", Order = 3)]
    [StringLength(20)]
    public string LastName { get; set; }

    [Required]
    [Column("age", Order = 4)]
    [StringLength(3)]
    public int Age { get; set; }

    [Required]
    [Column("localization", Order = 5)]
    [StringLength(30)]
    public string Localization { get; set; }

    [ForeignKey(nameof(Interest_first_model)), Column("interest_1_id", Order = 6)]
    [StringLength(3)]
    public int? InterestFirstId { get; set; }

    [ForeignKey(nameof(Interest_second_model)), Column("interest_2_id", Order = 7)]
    [StringLength(3)]
    public int? InterestSecondId { get; set; }

    [ForeignKey(nameof(Interest_third_model)), Column("interest_3_id", Order = 8)]
    [StringLength(3)]
    public int? InterestThirdId { get; set; }

    [Required]
    [ForeignKey("Relationship_status_model")]
    [Column("relationship_status_id")]
    [StringLength(3)]
    public int RelationshipStatusId { get; set; }

    [ForeignKey("Business_model")]
    [Column("business_id")]
    [StringLength(2)]
    public int? BusinessId { get; set; }

    [Required]
    [ForeignKey("Zodiac_sign_model")]
    [Column("zodiac_sign_id")]
    [StringLength(3)]
    public int ZodiacSignId { get; set; }

    [Required]
    [ForeignKey("Education_model")]
    [Column("education_id")]
    [StringLength(3)]
    public int EducationId { get; set; }

    [Column("pet_name")]
    [StringLength(30)]
    public string? PetName { get; set; }

    [Column("pet_type_id")]
    [ForeignKey("Pet_model")]
    [StringLength(2)]
    public int? PetTypeId { get; set; }

    [Required]
    [ForeignKey("Religion_model")]
    [Column("religion_id")]
    [StringLength(2)]
    public int ReligionId { get; set; }

    [Required]
    [ForeignKey("Alcohol_model")]
    [Column("alcohol_id")]
    [StringLength(2)]
    public int AlcoholId { get; set; }

    [Required]
    [ForeignKey("Smoking_model")]
    [Column("smoking_id")]
    [StringLength(2)]
    public int SmokingId { get; set; }

    public virtual Business_model Business_model { get; set; }
    public virtual Alcohol_model Alcohol_model { get; set; }
    public virtual Pet_model Pet_model { get; set; }
    public virtual Smoking_model Smoking_model { get; set; }
    public virtual Religion_model Religion_model { get; set; }
    public virtual Relationship_status_model Relationship_status_model { get; set; }
    public virtual Zodiac_sign_model Zodiac_sign_model { get; set; }
    public virtual Education_model Education_model { get; set; }
    public virtual Interest_model Interest_first_model { get; set; }
    public virtual Interest_model Interest_second_model { get; set; }
    public virtual Interest_model Interest_third_model { get; set; }

}