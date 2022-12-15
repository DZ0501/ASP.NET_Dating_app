﻿using Microsoft.EntityFrameworkCore;

namespace Foundation.Models;

public class AppDbContext: DbContext
{
    public DbSet<Business_model> Business { get; set; }
    public DbSet<Men_model> Men { get; set; }
    public DbSet<Women_model> Women { get; set; }
    public DbSet<Alcohol_model> Alcohol { get; set; }
    public DbSet<Pet_model> Pet { get; set; }

    //public int Counter { get; set; }

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Business_model>().HasData(
            new Business_model() { Business_modelId = 1, Name = "Blachotrapez Sp. z o.o", NIP = 9931742334, Postcode = "30-215", Localization = "Rabka Zdrój", Address = "ul. Na wzgórzu 42" },
            new Business_model() { Business_modelId = 2, Name = "Oknoplast Sp. z o.o.", NIP = 7233422312, Postcode = "32-712", Localization = "Nowy Sącz", Address = "ul. Krakowska 12" },
            new Business_model() { Business_modelId = 3, Name = "Evenea Sp. z o.o.", NIP = 9256345423, Postcode = "02-250", Localization = "Warszawa", Address = "ul. Krótka 32" },
            new Business_model() { Business_modelId = 4, Name = "Comarch S.A.", NIP = 6722341245, Postcode = "30-230", Localization = "Kraków", Address = "ul. Informatyków 1" },
            new Business_model() { Business_modelId = 5, Name = "Uniwersytet Ekonomczny w Krakowie", NIP = 9913451273, Postcode = "30-118", Localization = "Kraków", Address = "ul. Rakowicka 27" },
            new Business_model() { Business_modelId = 6, Name = "Neostrain Sp. z o.o.", NIP = 6792933459, Postcode = "30-702", Localization = "Kraków", Address = "ul. Lipowa 3" },
            new Business_model() { Business_modelId = 7, Name = "Polkomtel S.A.", NIP = 7452342345, Postcode = "00-212", Localization = "Warszawa", Address = "ul. Poznańska 18" }
        );
        modelBuilder.Entity<Men_model>().HasData
        (
            new Men_model(){Men_modelId = 1, FirstName = "Paweł", LastName = "Urbański", Age = 20, Localization="Kraków", InterestFirstId=4, InterestSecondId=2, InterestThirdId=3, RelationshipStatusId=1, BusinessId=2, ZodiacSignId=3, EducationId=2, PetName="Dyzio", PetTypeId=2, ReligionId=1, AlcoholId=1, SmokingId=1},
            new Men_model(){Men_modelId = 2, FirstName = "Damian", LastName = "Jawor", Age = 25, Localization="Wadowice", InterestFirstId=2, InterestSecondId=1, InterestThirdId=3, RelationshipStatusId=1, BusinessId=4, ZodiacSignId=1, EducationId=3, PetName="Piorun", PetTypeId=1, ReligionId=1, AlcoholId=3, SmokingId=4},
            new Men_model(){Men_modelId = 3, FirstName = "Borys", LastName = "Pawlak", Age = 21, Localization="Toruń", InterestFirstId=3, InterestSecondId=1, InterestThirdId=2, RelationshipStatusId=1, BusinessId=2, ZodiacSignId=2, EducationId=2, ReligionId=1, AlcoholId=1, SmokingId=2},
            new Men_model(){Men_modelId = 4, FirstName = "Kajetan", LastName = "Kowalski", Age = 18, Localization="Nowy Sącz", InterestFirstId=2, InterestSecondId=3, InterestThirdId=1, RelationshipStatusId=3, ZodiacSignId=1, EducationId=1, PetName="Saba", PetTypeId=1, ReligionId=1, AlcoholId=3, SmokingId=2},
            new Men_model(){Men_modelId = 5, FirstName = "Marcel", LastName = "Bąk", Age = 30, Localization="Warszawa", InterestFirstId=9, InterestSecondId=10, InterestThirdId=5, RelationshipStatusId=2, BusinessId=5, ZodiacSignId=7, EducationId=3, PetName="Ares", PetTypeId=2, ReligionId=3, AlcoholId=1, SmokingId=2}
        );

        modelBuilder.Entity<Women_model>().HasData
       (
            new Women_model() {Women_modelId = 1, FirstName = "Jagoda", LastName = "Lis", Age = 20, Localization = "Wadowice", InterestFirstId = 11, InterestSecondId = 12, InterestThirdId = 13, RelationshipStatusId = 1, BusinessId = 2, ZodiacSignId = 3, EducationId = 2, PetName = "Eliza", PetTypeId = 3, ReligionId = 1, AlcoholId = 1, SmokingId = 2 },
            new Women_model() {Women_modelId = 2, FirstName = "Lara", LastName = "Czerwik", Age = 27, Localization = "Kraków", InterestFirstId = 2, InterestSecondId = 1, InterestThirdId = 3, RelationshipStatusId = 1, BusinessId = 4, ZodiacSignId = 1, EducationId = 3, PetName = "Beza", PetTypeId = 2, ReligionId = 1, AlcoholId = 3, SmokingId = 4 },
            new Women_model() {Women_modelId = 3, FirstName = "Wiktoria", LastName = "Zakrzewska", Age = 23, Localization = "Warszawa", InterestFirstId = 3, InterestSecondId = 1, InterestThirdId = 2, RelationshipStatusId = 1, BusinessId = 2, ZodiacSignId = 2, EducationId = 2, ReligionId = 1, AlcoholId = 1, SmokingId = 3 },
            new Women_model() {Women_modelId = 4, FirstName = "Helena", LastName = "Pikol", Age = 20, Localization = "Nowy Sącz", InterestFirstId = 2, InterestSecondId = 3, InterestThirdId = 1, RelationshipStatusId = 3, ZodiacSignId = 1, EducationId = 1, PetName = "Agrest", PetTypeId = 1, ReligionId = 2, AlcoholId = 3, SmokingId = 2 },
            new Women_model() {Women_modelId = 5, FirstName = "Natalia", LastName = "Sobczak", Age = 32, Localization = "Sandomierz", InterestFirstId = 2, InterestSecondId = 3, InterestThirdId = 1, RelationshipStatusId = 3, BusinessId = 1, ZodiacSignId = 1, EducationId = 1, PetName = "Fafik", PetTypeId = 1, ReligionId = 2, AlcoholId = 3, SmokingId = 2 }
            
       );

        modelBuilder.Entity<Alcohol_model>().HasData
       (
            new Alcohol_model() { Alcohol_modelId = 1, Type = "Never" },
            new Alcohol_model() { Alcohol_modelId = 2, Type = "Occasionally" },
            new Alcohol_model() { Alcohol_modelId = 3, Type = "Often" },
            new Alcohol_model() { Alcohol_modelId = 4, Type = "Daily" }
       );

        modelBuilder.Entity<Pet_model>().HasData
       (
            new Pet_model() { Pet_modelId = 1, Type = "Dog" },
            new Pet_model() { Pet_modelId = 2, Type = "Cat" },
            new Pet_model() { Pet_modelId = 3, Type = "Guinea pig" }
       );



    }
    
    
}