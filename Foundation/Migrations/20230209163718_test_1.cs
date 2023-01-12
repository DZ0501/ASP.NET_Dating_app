using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Foundation.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alcohol",
                columns: table => new
                {
                    alcoholid = table.Column<int>(name: "alcohol_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alcohol", x => x.alcoholid);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Business",
                columns: table => new
                {
                    businessid = table.Column<int>(name: "business_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    nip = table.Column<decimal>(type: "decimal(20,0)", maxLength: 10, nullable: false),
                    postcode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    localization = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    address = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business", x => x.businessid);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    educationid = table.Column<int>(name: "education_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.educationid);
                });

            migrationBuilder.CreateTable(
                name: "Interest",
                columns: table => new
                {
                    interestid = table.Column<int>(name: "interest_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interest", x => x.interestid);
                });

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    pettypeid = table.Column<int>(name: "pet_type_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.pettypeid);
                });

            migrationBuilder.CreateTable(
                name: "Relationship_status",
                columns: table => new
                {
                    relationshipstatusid = table.Column<int>(name: "relationship_status_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relationship_status", x => x.relationshipstatusid);
                });

            migrationBuilder.CreateTable(
                name: "Religion",
                columns: table => new
                {
                    religionid = table.Column<int>(name: "religion_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religion", x => x.religionid);
                });

            migrationBuilder.CreateTable(
                name: "Smoking",
                columns: table => new
                {
                    smokingid = table.Column<int>(name: "smoking_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smoking", x => x.smokingid);
                });

            migrationBuilder.CreateTable(
                name: "Zodiac_sign",
                columns: table => new
                {
                    zodiacsignid = table.Column<int>(name: "zodiac_sign_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zodiac_sign", x => x.zodiacsignid);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Men",
                columns: table => new
                {
                    menid = table.Column<int>(name: "men_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(name: "first_name", type: "nvarchar(30)", maxLength: 30, nullable: false),
                    lastname = table.Column<string>(name: "last_name", type: "nvarchar(20)", maxLength: 20, nullable: false),
                    age = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    localization = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    interest1id = table.Column<int>(name: "interest_1_id", type: "int", maxLength: 3, nullable: true),
                    interest2id = table.Column<int>(name: "interest_2_id", type: "int", maxLength: 3, nullable: true),
                    interest3id = table.Column<int>(name: "interest_3_id", type: "int", maxLength: 3, nullable: true),
                    relationshipstatusid = table.Column<int>(name: "relationship_status_id", type: "int", maxLength: 3, nullable: false),
                    businessid = table.Column<int>(name: "business_id", type: "int", maxLength: 2, nullable: true),
                    zodiacsignid = table.Column<int>(name: "zodiac_sign_id", type: "int", maxLength: 3, nullable: false),
                    educationid = table.Column<int>(name: "education_id", type: "int", maxLength: 3, nullable: false),
                    petname = table.Column<string>(name: "pet_name", type: "nvarchar(30)", maxLength: 30, nullable: true),
                    pettypeid = table.Column<int>(name: "pet_type_id", type: "int", maxLength: 2, nullable: true),
                    religionid = table.Column<int>(name: "religion_id", type: "int", maxLength: 2, nullable: false),
                    alcoholid = table.Column<int>(name: "alcohol_id", type: "int", maxLength: 2, nullable: false),
                    smokingid = table.Column<int>(name: "smoking_id", type: "int", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Men", x => x.menid);
                    table.ForeignKey(
                        name: "FK_Men_Alcohol_alcohol_id",
                        column: x => x.alcoholid,
                        principalTable: "Alcohol",
                        principalColumn: "alcohol_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Men_Business_business_id",
                        column: x => x.businessid,
                        principalTable: "Business",
                        principalColumn: "business_id");
                    table.ForeignKey(
                        name: "FK_Men_Education_education_id",
                        column: x => x.educationid,
                        principalTable: "Education",
                        principalColumn: "education_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Men_Interest_interest_1_id",
                        column: x => x.interest1id,
                        principalTable: "Interest",
                        principalColumn: "interest_id");
                    table.ForeignKey(
                        name: "FK_Men_Interest_interest_2_id",
                        column: x => x.interest2id,
                        principalTable: "Interest",
                        principalColumn: "interest_id");
                    table.ForeignKey(
                        name: "FK_Men_Interest_interest_3_id",
                        column: x => x.interest3id,
                        principalTable: "Interest",
                        principalColumn: "interest_id");
                    table.ForeignKey(
                        name: "FK_Men_Pet_pet_type_id",
                        column: x => x.pettypeid,
                        principalTable: "Pet",
                        principalColumn: "pet_type_id");
                    table.ForeignKey(
                        name: "FK_Men_Relationship_status_relationship_status_id",
                        column: x => x.relationshipstatusid,
                        principalTable: "Relationship_status",
                        principalColumn: "relationship_status_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Men_Religion_religion_id",
                        column: x => x.religionid,
                        principalTable: "Religion",
                        principalColumn: "religion_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Men_Smoking_smoking_id",
                        column: x => x.smokingid,
                        principalTable: "Smoking",
                        principalColumn: "smoking_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Men_Zodiac_sign_zodiac_sign_id",
                        column: x => x.zodiacsignid,
                        principalTable: "Zodiac_sign",
                        principalColumn: "zodiac_sign_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Women",
                columns: table => new
                {
                    menid = table.Column<int>(name: "men_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(name: "first_name", type: "nvarchar(30)", maxLength: 30, nullable: false),
                    lastname = table.Column<string>(name: "last_name", type: "nvarchar(20)", maxLength: 20, nullable: false),
                    age = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    localization = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    interest1id = table.Column<int>(name: "interest_1_id", type: "int", maxLength: 3, nullable: true),
                    interest2id = table.Column<int>(name: "interest_2_id", type: "int", maxLength: 3, nullable: true),
                    interest3id = table.Column<int>(name: "interest_3_id", type: "int", maxLength: 3, nullable: true),
                    relationshipstatusid = table.Column<int>(name: "relationship_status_id", type: "int", maxLength: 3, nullable: false),
                    businessid = table.Column<int>(name: "business_id", type: "int", maxLength: 2, nullable: true),
                    zodiacsignid = table.Column<int>(name: "zodiac_sign_id", type: "int", maxLength: 3, nullable: false),
                    educationid = table.Column<int>(name: "education_id", type: "int", maxLength: 3, nullable: false),
                    petname = table.Column<string>(name: "pet_name", type: "nvarchar(30)", maxLength: 30, nullable: true),
                    pettypeid = table.Column<int>(name: "pet_type_id", type: "int", maxLength: 2, nullable: true),
                    religionid = table.Column<int>(name: "religion_id", type: "int", maxLength: 2, nullable: false),
                    alcoholid = table.Column<int>(name: "alcohol_id", type: "int", maxLength: 2, nullable: false),
                    smokingid = table.Column<int>(name: "smoking_id", type: "int", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Women", x => x.menid);
                    table.ForeignKey(
                        name: "FK_Women_Alcohol_alcohol_id",
                        column: x => x.alcoholid,
                        principalTable: "Alcohol",
                        principalColumn: "alcohol_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Women_Business_business_id",
                        column: x => x.businessid,
                        principalTable: "Business",
                        principalColumn: "business_id");
                    table.ForeignKey(
                        name: "FK_Women_Education_education_id",
                        column: x => x.educationid,
                        principalTable: "Education",
                        principalColumn: "education_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Women_Interest_interest_1_id",
                        column: x => x.interest1id,
                        principalTable: "Interest",
                        principalColumn: "interest_id");
                    table.ForeignKey(
                        name: "FK_Women_Interest_interest_2_id",
                        column: x => x.interest2id,
                        principalTable: "Interest",
                        principalColumn: "interest_id");
                    table.ForeignKey(
                        name: "FK_Women_Interest_interest_3_id",
                        column: x => x.interest3id,
                        principalTable: "Interest",
                        principalColumn: "interest_id");
                    table.ForeignKey(
                        name: "FK_Women_Pet_pet_type_id",
                        column: x => x.pettypeid,
                        principalTable: "Pet",
                        principalColumn: "pet_type_id");
                    table.ForeignKey(
                        name: "FK_Women_Relationship_status_relationship_status_id",
                        column: x => x.relationshipstatusid,
                        principalTable: "Relationship_status",
                        principalColumn: "relationship_status_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Women_Religion_religion_id",
                        column: x => x.religionid,
                        principalTable: "Religion",
                        principalColumn: "religion_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Women_Smoking_smoking_id",
                        column: x => x.smokingid,
                        principalTable: "Smoking",
                        principalColumn: "smoking_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Women_Zodiac_sign_zodiac_sign_id",
                        column: x => x.zodiacsignid,
                        principalTable: "Zodiac_sign",
                        principalColumn: "zodiac_sign_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Alcohol",
                columns: new[] { "alcohol_id", "type" },
                values: new object[,]
                {
                    { 1, "Never" },
                    { 2, "Occasionally" },
                    { 3, "Often" },
                    { 4, "Daily" }
                });

            migrationBuilder.InsertData(
                table: "Business",
                columns: new[] { "business_id", "address", "localization", "nip", "name", "postcode" },
                values: new object[,]
                {
                    { 1, "ul. Na wzgórzu 42", "Rabka Zdrój", 9931742334m, "Blachotrapez Sp. z o.o", "30-215" },
                    { 2, "ul. Krakowska 12", "Nowy Sącz", 7233422312m, "Oknoplast Sp. z o.o.", "32-712" },
                    { 3, "ul. Krótka 32", "Warszawa", 9256345423m, "Evenea Sp. z o.o.", "02-250" },
                    { 4, "ul. Informatyków 1", "Kraków", 6722341245m, "Comarch S.A.", "30-230" },
                    { 5, "ul. Rakowicka 27", "Kraków", 9913451273m, "Uniwersytet Ekonomczny w Krakowie", "30-118" },
                    { 6, "ul. Lipowa 3", "Kraków", 6792933459m, "Neostrain Sp. z o.o.", "30-702" },
                    { 7, "ul. Poznańska 18", "Warszawa", 7452342345m, "Polkomtel S.A.", "00-212" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "education_id", "type" },
                values: new object[,]
                {
                    { 1, "Primary" },
                    { 2, "Secondary" },
                    { 3, "Higher" }
                });

            migrationBuilder.InsertData(
                table: "Interest",
                columns: new[] { "interest_id", "type" },
                values: new object[,]
                {
                    { 1, "Motorcycles" },
                    { 2, "Cars" },
                    { 3, "Music" },
                    { 4, "Food" },
                    { 5, "Computer games" },
                    { 6, "Animals" },
                    { 7, "Movies" },
                    { 8, "TV series" },
                    { 9, "Technology" },
                    { 10, "Traveling" },
                    { 11, "Cooking" },
                    { 12, "Reading" },
                    { 13, "Nature" }
                });

            migrationBuilder.InsertData(
                table: "Pet",
                columns: new[] { "pet_type_id", "type" },
                values: new object[,]
                {
                    { 1, "Dog" },
                    { 2, "Cat" },
                    { 3, "Guinea pig" }
                });

            migrationBuilder.InsertData(
                table: "Relationship_status",
                columns: new[] { "relationship_status_id", "type" },
                values: new object[,]
                {
                    { 1, "Free" },
                    { 2, "Taken" },
                    { 3, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Religion",
                columns: new[] { "religion_id", "type" },
                values: new object[,]
                {
                    { 1, "Christianity" },
                    { 2, "Islam" },
                    { 3, "Hinduism" },
                    { 4, "Buddhism" }
                });

            migrationBuilder.InsertData(
                table: "Smoking",
                columns: new[] { "smoking_id", "type" },
                values: new object[,]
                {
                    { 1, "Never" },
                    { 2, "Occasionally" },
                    { 3, "Often" },
                    { 4, "Daily" }
                });

            migrationBuilder.InsertData(
                table: "Zodiac_sign",
                columns: new[] { "zodiac_sign_id", "type" },
                values: new object[,]
                {
                    { 1, "Aquarius" },
                    { 2, "Pisces" },
                    { 3, "Aries" },
                    { 4, "Taurus" },
                    { 5, "Gemini" },
                    { 6, "Cancer" },
                    { 7, "Leo" },
                    { 8, "Virgo" },
                    { 9, "Libra" },
                    { 10, "Scorpio" },
                    { 11, "Capricorn" }
                });

            migrationBuilder.InsertData(
                table: "Men",
                columns: new[] { "men_id", "age", "alcohol_id", "business_id", "education_id", "first_name", "interest_1_id", "interest_2_id", "interest_3_id", "last_name", "localization", "pet_name", "pet_type_id", "relationship_status_id", "religion_id", "smoking_id", "zodiac_sign_id" },
                values: new object[,]
                {
                    { 1, 20, 1, 2, 2, "Paweł", 4, 2, 3, "Urbański", "Kraków", "Dyzio", 2, 1, 1, 1, 3 },
                    { 2, 25, 3, 4, 3, "Damian", 2, 1, 3, "Jawor", "Wadowice", "Piorun", 1, 1, 1, 4, 1 },
                    { 3, 21, 1, 2, 2, "Borys", 3, 1, 2, "Pawlak", "Toruń", null, null, 1, 1, 2, 2 },
                    { 4, 18, 3, null, 1, "Kajetan", 2, 3, 1, "Kowalski", "Nowy Sącz", "Saba", 1, 3, 1, 2, 1 },
                    { 5, 30, 1, 5, 3, "Marcel", 9, 10, 5, "Bąk", "Warszawa", "Ares", 2, 2, 3, 2, 7 }
                });

            migrationBuilder.InsertData(
                table: "Women",
                columns: new[] { "men_id", "age", "alcohol_id", "business_id", "education_id", "first_name", "interest_1_id", "interest_2_id", "interest_3_id", "last_name", "localization", "pet_name", "pet_type_id", "relationship_status_id", "religion_id", "smoking_id", "zodiac_sign_id" },
                values: new object[,]
                {
                    { 1, 20, 1, 2, 2, "Jagoda", 11, 12, 13, "Lis", "Wadowice", "Eliza", 3, 1, 1, 2, 3 },
                    { 2, 27, 3, 4, 3, "Lara", 2, 1, 3, "Czerwik", "Kraków", "Beza", 2, 1, 1, 4, 1 },
                    { 3, 23, 1, 2, 2, "Wiktoria", 3, 1, 2, "Zakrzewska", "Warszawa", null, null, 1, 1, 3, 2 },
                    { 4, 20, 3, null, 1, "Helena", 2, 3, 1, "Pikol", "Nowy Sącz", "Agrest", 1, 3, 2, 2, 1 },
                    { 5, 32, 3, 1, 1, "Natalia", 2, 3, 1, "Sobczak", "Sandomierz", "Fafik", 1, 3, 2, 2, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Men_alcohol_id",
                table: "Men",
                column: "alcohol_id");

            migrationBuilder.CreateIndex(
                name: "IX_Men_business_id",
                table: "Men",
                column: "business_id");

            migrationBuilder.CreateIndex(
                name: "IX_Men_education_id",
                table: "Men",
                column: "education_id");

            migrationBuilder.CreateIndex(
                name: "IX_Men_interest_1_id",
                table: "Men",
                column: "interest_1_id");

            migrationBuilder.CreateIndex(
                name: "IX_Men_interest_2_id",
                table: "Men",
                column: "interest_2_id");

            migrationBuilder.CreateIndex(
                name: "IX_Men_interest_3_id",
                table: "Men",
                column: "interest_3_id");

            migrationBuilder.CreateIndex(
                name: "IX_Men_pet_type_id",
                table: "Men",
                column: "pet_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_Men_relationship_status_id",
                table: "Men",
                column: "relationship_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_Men_religion_id",
                table: "Men",
                column: "religion_id");

            migrationBuilder.CreateIndex(
                name: "IX_Men_smoking_id",
                table: "Men",
                column: "smoking_id");

            migrationBuilder.CreateIndex(
                name: "IX_Men_zodiac_sign_id",
                table: "Men",
                column: "zodiac_sign_id");

            migrationBuilder.CreateIndex(
                name: "IX_Women_alcohol_id",
                table: "Women",
                column: "alcohol_id");

            migrationBuilder.CreateIndex(
                name: "IX_Women_business_id",
                table: "Women",
                column: "business_id");

            migrationBuilder.CreateIndex(
                name: "IX_Women_education_id",
                table: "Women",
                column: "education_id");

            migrationBuilder.CreateIndex(
                name: "IX_Women_interest_1_id",
                table: "Women",
                column: "interest_1_id");

            migrationBuilder.CreateIndex(
                name: "IX_Women_interest_2_id",
                table: "Women",
                column: "interest_2_id");

            migrationBuilder.CreateIndex(
                name: "IX_Women_interest_3_id",
                table: "Women",
                column: "interest_3_id");

            migrationBuilder.CreateIndex(
                name: "IX_Women_pet_type_id",
                table: "Women",
                column: "pet_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_Women_relationship_status_id",
                table: "Women",
                column: "relationship_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_Women_religion_id",
                table: "Women",
                column: "religion_id");

            migrationBuilder.CreateIndex(
                name: "IX_Women_smoking_id",
                table: "Women",
                column: "smoking_id");

            migrationBuilder.CreateIndex(
                name: "IX_Women_zodiac_sign_id",
                table: "Women",
                column: "zodiac_sign_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Men");

            migrationBuilder.DropTable(
                name: "Women");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Alcohol");

            migrationBuilder.DropTable(
                name: "Business");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Interest");

            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "Relationship_status");

            migrationBuilder.DropTable(
                name: "Religion");

            migrationBuilder.DropTable(
                name: "Smoking");

            migrationBuilder.DropTable(
                name: "Zodiac_sign");
        }
    }
}
