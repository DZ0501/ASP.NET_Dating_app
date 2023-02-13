using Foundation.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using Foundation.Models;


public class FoundationContext : IdentityDbContext<FoundationUser>
{


    public DbSet<Business_model> Business { get; set; }
    public DbSet<Person_model> Person { get; set; }
    public DbSet<Alcohol_model> Alcohol { get; set; }
    public DbSet<Pet_model> Pet { get; set; }
    public DbSet<Religion_model> Religion { get; set; }
    public DbSet<Relationship_status_model> Relationship_status { get; set; }
    public DbSet<Zodiac_sign_model> Zodiac_sign { get; set; }
    public DbSet<Interest_model> Interest { get; set; }
    public DbSet<Education_model> Education { get; set; }

    public FoundationContext(DbContextOptions<FoundationContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.Entity<Business_model>().HasData(
            new Business_model() { Business_modelId = 1, Name = "Blachotrapez Sp. z o.o", NIP = 9931742334, Postcode = "30-215", Localization = "Rabka Zdrój", Address = "ul. Na wzgórzu 42" },
            new Business_model() { Business_modelId = 2, Name = "Oknoplast Sp. z o.o.", NIP = 7233422312, Postcode = "32-712", Localization = "Nowy Sącz", Address = "ul. Krakowska 12" },
            new Business_model() { Business_modelId = 3, Name = "Evenea Sp. z o.o.", NIP = 9256345423, Postcode = "02-250", Localization = "Warszawa", Address = "ul. Krótka 32" },
            new Business_model() { Business_modelId = 4, Name = "Comarch S.A.", NIP = 6722341245, Postcode = "30-230", Localization = "Kraków", Address = "ul. Informatyków 1" },
            new Business_model() { Business_modelId = 5, Name = "Uniwersytet Ekonomczny w Krakowie", NIP = 9913451273, Postcode = "30-118", Localization = "Kraków", Address = "ul. Rakowicka 27" },
            new Business_model() { Business_modelId = 6, Name = "Neostrain Sp. z o.o.", NIP = 6792933459, Postcode = "30-702", Localization = "Kraków", Address = "ul. Lipowa 3" },
            new Business_model() { Business_modelId = 7, Name = "Polkomtel S.A.", NIP = 7452342345, Postcode = "00-212", Localization = "Warszawa", Address = "ul. Poznańska 18" }
        );
        builder.Entity<Person_model>().HasData
        (
            new Person_model() { Person_modelId = 1, Gender = 'm', FirstName = "Paweł", LastName = "Urbański", Age = 20, Localization = "Kraków", InterestFirstId = 4, InterestSecondId = 2, InterestThirdId = 3, RelationshipStatusId = 1, BusinessId = 2, ZodiacSignId = 3, EducationId = 2, PetName = "Dyzio", PetTypeId = 2, ReligionId = 1, AlcoholId = 1, SmokingId = 1 },
            new Person_model() { Person_modelId = 2, Gender = 'm', FirstName = "Damian", LastName = "Jawor", Age = 25, Localization = "Wadowice", InterestFirstId = 2, InterestSecondId = 1, InterestThirdId = 3, RelationshipStatusId = 1, BusinessId = 4, ZodiacSignId = 1, EducationId = 3, PetName = "Piorun", PetTypeId = 1, ReligionId = 1, AlcoholId = 3, SmokingId = 4 },
            new Person_model() { Person_modelId = 3, Gender = 'm', FirstName = "Borys", LastName = "Pawlak", Age = 21, Localization = "Toruń", InterestFirstId = 3, InterestSecondId = 1, InterestThirdId = 2, RelationshipStatusId = 1, BusinessId = 2, ZodiacSignId = 2, EducationId = 2, ReligionId = 1, AlcoholId = 1, SmokingId = 2 },
            new Person_model() { Person_modelId = 4, Gender = 'm', FirstName = "Kajetan", LastName = "Kowalski", Age = 18, Localization = "Nowy Sącz", InterestFirstId = 2, InterestSecondId = 3, InterestThirdId = 1, RelationshipStatusId = 3, ZodiacSignId = 1, EducationId = 1, PetName = "Saba", PetTypeId = 1, ReligionId = 1, AlcoholId = 3, SmokingId = 2 },
            new Person_model() { Person_modelId = 5, Gender = 'm', FirstName = "Marcel", LastName = "Bąk", Age = 30, Localization = "Warszawa", InterestFirstId = 9, InterestSecondId = 10, InterestThirdId = 5, RelationshipStatusId = 2, BusinessId = 5, ZodiacSignId = 7, EducationId = 3, PetName = "Ares", PetTypeId = 2, ReligionId = 3, AlcoholId = 1, SmokingId = 2 },
            new Person_model() { Person_modelId = 6, Gender = 'w', FirstName = "Jagoda", LastName = "Lis", Age = 20, Localization = "Wadowice", InterestFirstId = 11, InterestSecondId = 12, InterestThirdId = 13, RelationshipStatusId = 1, BusinessId = 2, ZodiacSignId = 3, EducationId = 2, PetName = "Eliza", PetTypeId = 3, ReligionId = 1, AlcoholId = 1, SmokingId = 2 },
            new Person_model() { Person_modelId = 7, Gender = 'w', FirstName = "Lara", LastName = "Czerwik", Age = 27, Localization = "Kraków", InterestFirstId = 2, InterestSecondId = 1, InterestThirdId = 3, RelationshipStatusId = 1, BusinessId = 4, ZodiacSignId = 1, EducationId = 3, PetName = "Beza", PetTypeId = 2, ReligionId = 1, AlcoholId = 3, SmokingId = 4 },
            new Person_model() { Person_modelId = 8, Gender = 'w', FirstName = "Wiktoria", LastName = "Zakrzewska", Age = 23, Localization = "Warszawa", InterestFirstId = 3, InterestSecondId = 1, InterestThirdId = 2, RelationshipStatusId = 1, BusinessId = 2, ZodiacSignId = 2, EducationId = 2, ReligionId = 1, AlcoholId = 1, SmokingId = 3 },
            new Person_model() { Person_modelId = 9, Gender = 'w', FirstName = "Helena", LastName = "Pikol", Age = 20, Localization = "Nowy Sącz", InterestFirstId = 2, InterestSecondId = 3, InterestThirdId = 1, RelationshipStatusId = 3, ZodiacSignId = 1, EducationId = 1, PetName = "Agrest", PetTypeId = 1, ReligionId = 2, AlcoholId = 3, SmokingId = 2 },
            new Person_model() { Person_modelId = 10, Gender = 'w', FirstName = "Natalia", LastName = "Sobczak", Age = 32, Localization = "Sandomierz", InterestFirstId = 2, InterestSecondId = 3, InterestThirdId = 1, RelationshipStatusId = 3, BusinessId = 1, ZodiacSignId = 1, EducationId = 1, PetName = "Fafik", PetTypeId = 1, ReligionId = 2, AlcoholId = 3, SmokingId = 2 }
        );

        builder.Entity<Alcohol_model>().HasData
       (
            new Alcohol_model() { Alcohol_modelId = 1, Type = "Never" },
            new Alcohol_model() { Alcohol_modelId = 2, Type = "Occasionally" },
            new Alcohol_model() { Alcohol_modelId = 3, Type = "Often" },
            new Alcohol_model() { Alcohol_modelId = 4, Type = "Daily" }
       );

        builder.Entity<Pet_model>().HasData
       (
            new Pet_model() { Pet_modelId = 1, Type = "Dog" },
            new Pet_model() { Pet_modelId = 2, Type = "Cat" },
            new Pet_model() { Pet_modelId = 3, Type = "Guinea pig" }
       );

        builder.Entity<Smoking_model>().HasData
       (
            new Smoking_model() { Smoking_modelId = 1, Type = "Never" },
            new Smoking_model() { Smoking_modelId = 2, Type = "Occasionally" },
            new Smoking_model() { Smoking_modelId = 3, Type = "Often" },
            new Smoking_model() { Smoking_modelId = 4, Type = "Daily" }
       );

        builder.Entity<Religion_model>().HasData
       (
            new Religion_model() { Religion_modelId = 1, Type = "Christianity" },
            new Religion_model() { Religion_modelId = 2, Type = "Islam" },
            new Religion_model() { Religion_modelId = 3, Type = "Hinduism" },
            new Religion_model() { Religion_modelId = 4, Type = "Buddhism" }
       );

        builder.Entity<Relationship_status_model>().HasData
       (
            new Relationship_status_model() { Relationship_status_modelId = 1, Type = "Free" },
            new Relationship_status_model() { Relationship_status_modelId = 2, Type = "Taken" },
            new Relationship_status_model() { Relationship_status_modelId = 3, Type = "Other" }
       );

        builder.Entity<Zodiac_sign_model>().HasData
       (
            new Zodiac_sign_model() { Zodiac_sign_modelId = 1, Type = "Aquarius" },
            new Zodiac_sign_model() { Zodiac_sign_modelId = 2, Type = "Pisces" },
            new Zodiac_sign_model() { Zodiac_sign_modelId = 3, Type = "Aries" },
            new Zodiac_sign_model() { Zodiac_sign_modelId = 4, Type = "Taurus" },
            new Zodiac_sign_model() { Zodiac_sign_modelId = 5, Type = "Gemini" },
            new Zodiac_sign_model() { Zodiac_sign_modelId = 6, Type = "Cancer" },
            new Zodiac_sign_model() { Zodiac_sign_modelId = 7, Type = "Leo" },
            new Zodiac_sign_model() { Zodiac_sign_modelId = 8, Type = "Virgo" },
            new Zodiac_sign_model() { Zodiac_sign_modelId = 9, Type = "Libra" },
            new Zodiac_sign_model() { Zodiac_sign_modelId = 10, Type = "Scorpio" },
            new Zodiac_sign_model() { Zodiac_sign_modelId = 11, Type = "Capricorn" }
       );

        builder.Entity<Interest_model>().HasData
       (
            new Interest_model() { Interest_modelId = 1, Type = "Motorcycles" },
            new Interest_model() { Interest_modelId = 2, Type = "Cars" },
            new Interest_model() { Interest_modelId = 3, Type = "Music" },
            new Interest_model() { Interest_modelId = 4, Type = "Food" },
            new Interest_model() { Interest_modelId = 5, Type = "Computer games" },
            new Interest_model() { Interest_modelId = 6, Type = "Animals" },
            new Interest_model() { Interest_modelId = 7, Type = "Movies" },
            new Interest_model() { Interest_modelId = 8, Type = "TV series" },
            new Interest_model() { Interest_modelId = 9, Type = "Technology" },
            new Interest_model() { Interest_modelId = 10, Type = "Traveling" },
            new Interest_model() { Interest_modelId = 11, Type = "Cooking" },
            new Interest_model() { Interest_modelId = 12, Type = "Reading" },
            new Interest_model() { Interest_modelId = 13, Type = "Nature" }
       );

        builder.Entity<Education_model>().HasData
       (
            new Education_model() { Education_modelId = 1, Type = "Primary" },
            new Education_model() { Education_modelId = 2, Type = "Secondary" },
            new Education_model() { Education_modelId = 3, Type = "Higher" }
       );

       
    }
}
