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
                name: "Men",
                columns: table => new
                {
                    menid = table.Column<int>(name: "men_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(name: "first_name", type: "nvarchar(30)", maxLength: 30, nullable: false),
                    lastname = table.Column<string>(name: "last_name", type: "nvarchar(20)", maxLength: 20, nullable: false),
                    age = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    localization = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    interest1id = table.Column<byte>(name: "interest_1_id", type: "tinyint", maxLength: 3, nullable: false),
                    interest2id = table.Column<byte>(name: "interest_2_id", type: "tinyint", maxLength: 3, nullable: false),
                    interest3id = table.Column<byte>(name: "interest_3_id", type: "tinyint", maxLength: 3, nullable: false),
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
                        name: "FK_Men_Pet_pet_type_id",
                        column: x => x.pettypeid,
                        principalTable: "Pet",
                        principalColumn: "pet_type_id");
                });

            migrationBuilder.CreateTable(
                name: "Women",
                columns: table => new
                {
                    womenid = table.Column<int>(name: "women_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(name: "first_name", type: "nvarchar(30)", maxLength: 30, nullable: false),
                    lastname = table.Column<string>(name: "last_name", type: "nvarchar(20)", maxLength: 20, nullable: false),
                    age = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    localization = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    interest1id = table.Column<byte>(name: "interest_1_id", type: "tinyint", maxLength: 3, nullable: false),
                    interest2id = table.Column<byte>(name: "interest_2_id", type: "tinyint", maxLength: 3, nullable: false),
                    interest3id = table.Column<byte>(name: "interest_3_id", type: "tinyint", maxLength: 3, nullable: false),
                    relationshipstatusid = table.Column<byte>(name: "relationship_status_id", type: "tinyint", maxLength: 3, nullable: false),
                    businessid = table.Column<int>(name: "business_id", type: "int", maxLength: 2, nullable: true),
                    zodiacsignid = table.Column<byte>(name: "zodiac_sign_id", type: "tinyint", maxLength: 3, nullable: false),
                    educationid = table.Column<byte>(name: "education_id", type: "tinyint", maxLength: 3, nullable: false),
                    petname = table.Column<string>(name: "pet_name", type: "nvarchar(30)", maxLength: 30, nullable: true),
                    pettypeid = table.Column<byte>(name: "pet_type_id", type: "tinyint", maxLength: 2, nullable: true),
                    religionid = table.Column<byte>(name: "religion_id", type: "tinyint", maxLength: 2, nullable: false),
                    alcoholid = table.Column<byte>(name: "alcohol_id", type: "tinyint", maxLength: 2, nullable: false),
                    smokingid = table.Column<byte>(name: "smoking_id", type: "tinyint", maxLength: 2, nullable: false),
                    PetmodelId = table.Column<byte>(name: "Pet_modelId", type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Women", x => x.womenid);
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
                        name: "FK_Women_Pet_Pet_modelId",
                        column: x => x.PetmodelId,
                        principalTable: "Pet",
                        principalColumn: "pet_type_id");
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
                table: "Pet",
                columns: new[] { "pet_type_id", "type" },
                values: new object[,]
                {
                    { (byte)1, "Dog" },
                    { (byte)2, "Cat" },
                    { (byte)3, "Guinea pig" }
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
                columns: new[] { "women_id", "age", "alcohol_id", "business_id", "education_id", "first_name", "interest_1_id", "interest_2_id", "interest_3_id", "last_name", "localization", "pet_name", "pet_type_id", "Pet_modelId", "relationship_status_id", "religion_id", "smoking_id", "zodiac_sign_id" },
                values: new object[,]
                {
                    { 1, 20, (byte)1, 2, (byte)2, "Jagoda", (byte)11, (byte)12, (byte)13, "Lis", "Wadowice", "Eliza", (byte)3, null, (byte)1, (byte)1, (byte)2, (byte)3 },
                    { 2, 27, (byte)3, 4, (byte)3, "Lara", (byte)2, (byte)1, (byte)3, "Czerwik", "Kraków", "Beza", (byte)2, null, (byte)1, (byte)1, (byte)4, (byte)1 },
                    { 3, 23, (byte)1, 2, (byte)2, "Wiktoria", (byte)3, (byte)1, (byte)2, "Zakrzewska", "Warszawa", null, null, null, (byte)1, (byte)1, (byte)3, (byte)2 },
                    { 4, 20, (byte)3, null, (byte)1, "Helena", (byte)2, (byte)3, (byte)1, "Pikol", "Nowy Sącz", "Agrest", (byte)1, null, (byte)3, (byte)2, (byte)2, (byte)1 },
                    { 5, 32, (byte)3, 1, (byte)1, "Natalia", (byte)2, (byte)3, (byte)1, "Sobczak", "Sandomierz", "Fafik", (byte)1, null, (byte)3, (byte)2, (byte)2, (byte)1 }
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
                name: "IX_Men_pet_type_id",
                table: "Men",
                column: "pet_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_Women_alcohol_id",
                table: "Women",
                column: "alcohol_id");

            migrationBuilder.CreateIndex(
                name: "IX_Women_business_id",
                table: "Women",
                column: "business_id");

            migrationBuilder.CreateIndex(
                name: "IX_Women_Pet_modelId",
                table: "Women",
                column: "Pet_modelId");
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
                name: "Pet");
        }
    }
}
