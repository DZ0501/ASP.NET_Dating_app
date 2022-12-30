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
                    alcoholid = table.Column<byte>(name: "alcohol_id", type: "tinyint", nullable: false),
                    type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alcohol", x => x.alcoholid);
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
                    educationid = table.Column<byte>(name: "education_id", type: "tinyint", nullable: false),
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
                    interestid = table.Column<byte>(name: "interest_id", type: "tinyint", nullable: false),
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
                    pettypeid = table.Column<byte>(name: "pet_type_id", type: "tinyint", nullable: false),
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
                    relationshipstatusid = table.Column<byte>(name: "relationship_status_id", type: "tinyint", nullable: false),
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
                    religionid = table.Column<byte>(name: "religion_id", type: "tinyint", nullable: false),
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
                    smokingid = table.Column<byte>(name: "smoking_id", type: "tinyint", nullable: false),
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
                    zodiacsignid = table.Column<byte>(name: "zodiac_sign_id", type: "tinyint", nullable: false),
                    type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zodiac_sign", x => x.zodiacsignid);
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
                    interest1id = table.Column<byte>(name: "interest_1_id", type: "tinyint", maxLength: 3, nullable: true),
                    interest2id = table.Column<byte>(name: "interest_2_id", type: "tinyint", maxLength: 3, nullable: true),
                    interest3id = table.Column<byte>(name: "interest_3_id", type: "tinyint", maxLength: 3, nullable: true),
                    relationshipstatusid = table.Column<byte>(name: "relationship_status_id", type: "tinyint", maxLength: 3, nullable: false),
                    businessid = table.Column<int>(name: "business_id", type: "int", maxLength: 2, nullable: true),
                    zodiacsignid = table.Column<byte>(name: "zodiac_sign_id", type: "tinyint", maxLength: 3, nullable: false),
                    educationid = table.Column<byte>(name: "education_id", type: "tinyint", maxLength: 3, nullable: false),
                    petname = table.Column<string>(name: "pet_name", type: "nvarchar(30)", maxLength: 30, nullable: true),
                    pettypeid = table.Column<byte>(name: "pet_type_id", type: "tinyint", maxLength: 2, nullable: true),
                    religionid = table.Column<byte>(name: "religion_id", type: "tinyint", maxLength: 2, nullable: false),
                    alcoholid = table.Column<byte>(name: "alcohol_id", type: "tinyint", maxLength: 2, nullable: false),
                    smokingid = table.Column<byte>(name: "smoking_id", type: "tinyint", maxLength: 2, nullable: false)
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
                    interest1id = table.Column<byte>(name: "interest_1_id", type: "tinyint", maxLength: 3, nullable: true),
                    interest2id = table.Column<byte>(name: "interest_2_id", type: "tinyint", maxLength: 3, nullable: true),
                    interest3id = table.Column<byte>(name: "interest_3_id", type: "tinyint", maxLength: 3, nullable: true),
                    relationshipstatusid = table.Column<byte>(name: "relationship_status_id", type: "tinyint", maxLength: 3, nullable: false),
                    businessid = table.Column<int>(name: "business_id", type: "int", maxLength: 2, nullable: true),
                    zodiacsignid = table.Column<byte>(name: "zodiac_sign_id", type: "tinyint", maxLength: 3, nullable: false),
                    educationid = table.Column<byte>(name: "education_id", type: "tinyint", maxLength: 3, nullable: false),
                    petname = table.Column<string>(name: "pet_name", type: "nvarchar(30)", maxLength: 30, nullable: true),
                    pettypeid = table.Column<byte>(name: "pet_type_id", type: "tinyint", maxLength: 2, nullable: true),
                    religionid = table.Column<byte>(name: "religion_id", type: "tinyint", maxLength: 2, nullable: false),
                    alcoholid = table.Column<byte>(name: "alcohol_id", type: "tinyint", maxLength: 2, nullable: false),
                    smokingid = table.Column<byte>(name: "smoking_id", type: "tinyint", maxLength: 2, nullable: false)
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
                    { (byte)1, "Never" },
                    { (byte)2, "Occasionally" },
                    { (byte)3, "Often" },
                    { (byte)4, "Daily" }
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
                    { (byte)1, "Primary" },
                    { (byte)2, "Secondary" },
                    { (byte)3, "Higher" }
                });

            migrationBuilder.InsertData(
                table: "Interest",
                columns: new[] { "interest_id", "type" },
                values: new object[,]
                {
                    { (byte)1, "Motorcycles" },
                    { (byte)2, "Cars" },
                    { (byte)3, "Music" },
                    { (byte)4, "Food" },
                    { (byte)5, "Computer games" },
                    { (byte)6, "Animals" },
                    { (byte)7, "Movies" },
                    { (byte)8, "TV series" },
                    { (byte)9, "Technology" },
                    { (byte)10, "Traveling" },
                    { (byte)11, "Cooking" },
                    { (byte)12, "Reading" },
                    { (byte)13, "Nature" }
                });

            migrationBuilder.InsertData(
                table: "Pet",
                columns: new[] { "pet_type_id", "type" },
                values: new object[,]
                {
                    { (byte)1, "Dog" },
                    { (byte)2, "Cat" },
                    { (byte)3, "Guinea pig" }
                });

            migrationBuilder.InsertData(
                table: "Relationship_status",
                columns: new[] { "relationship_status_id", "type" },
                values: new object[,]
                {
                    { (byte)1, "Free" },
                    { (byte)2, "Taken" },
                    { (byte)3, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Religion",
                columns: new[] { "religion_id", "type" },
                values: new object[,]
                {
                    { (byte)1, "Christianity" },
                    { (byte)2, "Islam" },
                    { (byte)3, "Hinduism" },
                    { (byte)4, "Buddhism" }
                });

            migrationBuilder.InsertData(
                table: "Smoking",
                columns: new[] { "smoking_id", "type" },
                values: new object[,]
                {
                    { (byte)1, "Never" },
                    { (byte)2, "Occasionally" },
                    { (byte)3, "Often" },
                    { (byte)4, "Daily" }
                });

            migrationBuilder.InsertData(
                table: "Zodiac_sign",
                columns: new[] { "zodiac_sign_id", "type" },
                values: new object[,]
                {
                    { (byte)1, "Aquarius" },
                    { (byte)2, "Pisces" },
                    { (byte)3, "Aries" },
                    { (byte)4, "Taurus" },
                    { (byte)5, "Gemini" },
                    { (byte)6, "Cancer" },
                    { (byte)7, "Leo" },
                    { (byte)8, "Virgo" },
                    { (byte)9, "Libra" },
                    { (byte)10, "Scorpio" },
                    { (byte)11, "Capricorn" }
                });

            migrationBuilder.InsertData(
                table: "Men",
                columns: new[] { "men_id", "age", "alcohol_id", "business_id", "education_id", "first_name", "interest_1_id", "interest_2_id", "interest_3_id", "last_name", "localization", "pet_name", "pet_type_id", "relationship_status_id", "religion_id", "smoking_id", "zodiac_sign_id" },
                values: new object[,]
                {
                    { 1, 20, (byte)1, 2, (byte)2, "Paweł", (byte)4, (byte)2, (byte)3, "Urbański", "Kraków", "Dyzio", (byte)2, (byte)1, (byte)1, (byte)1, (byte)3 },
                    { 2, 25, (byte)3, 4, (byte)3, "Damian", (byte)2, (byte)1, (byte)3, "Jawor", "Wadowice", "Piorun", (byte)1, (byte)1, (byte)1, (byte)4, (byte)1 },
                    { 3, 21, (byte)1, 2, (byte)2, "Borys", (byte)3, (byte)1, (byte)2, "Pawlak", "Toruń", null, null, (byte)1, (byte)1, (byte)2, (byte)2 },
                    { 4, 18, (byte)3, null, (byte)1, "Kajetan", (byte)2, (byte)3, (byte)1, "Kowalski", "Nowy Sącz", "Saba", (byte)1, (byte)3, (byte)1, (byte)2, (byte)1 },
                    { 5, 30, (byte)1, 5, (byte)3, "Marcel", (byte)9, (byte)10, (byte)5, "Bąk", "Warszawa", "Ares", (byte)2, (byte)2, (byte)3, (byte)2, (byte)7 }
                });

            migrationBuilder.InsertData(
                table: "Women",
                columns: new[] { "men_id", "age", "alcohol_id", "business_id", "education_id", "first_name", "interest_1_id", "interest_2_id", "interest_3_id", "last_name", "localization", "pet_name", "pet_type_id", "relationship_status_id", "religion_id", "smoking_id", "zodiac_sign_id" },
                values: new object[,]
                {
                    { 1, 20, (byte)1, 2, (byte)2, "Jagoda", (byte)11, (byte)12, (byte)13, "Lis", "Wadowice", "Eliza", (byte)3, (byte)1, (byte)1, (byte)2, (byte)3 },
                    { 2, 27, (byte)3, 4, (byte)3, "Lara", (byte)2, (byte)1, (byte)3, "Czerwik", "Kraków", "Beza", (byte)2, (byte)1, (byte)1, (byte)4, (byte)1 },
                    { 3, 23, (byte)1, 2, (byte)2, "Wiktoria", (byte)3, (byte)1, (byte)2, "Zakrzewska", "Warszawa", null, null, (byte)1, (byte)1, (byte)3, (byte)2 },
                    { 4, 20, (byte)3, null, (byte)1, "Helena", (byte)2, (byte)3, (byte)1, "Pikol", "Nowy Sącz", "Agrest", (byte)1, (byte)3, (byte)2, (byte)2, (byte)1 },
                    { 5, 32, (byte)3, 1, (byte)1, "Natalia", (byte)2, (byte)3, (byte)1, "Sobczak", "Sandomierz", "Fafik", (byte)1, (byte)3, (byte)2, (byte)2, (byte)1 }
                });

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
                name: "Men");

            migrationBuilder.DropTable(
                name: "Women");

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
