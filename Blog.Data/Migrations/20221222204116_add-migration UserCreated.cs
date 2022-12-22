using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class addmigrationUserCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b3168182-eb8f-40b3-adc3-c20e8e3d9d2a"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("fa360cf1-c2a7-40a3-bc78-f1dd9e9f7f00"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("86ebdce2-9367-4bea-8922-c8cbdb31ed7f"), new Guid("50c2eed1-c93d-4a9d-8d52-b197eb48d509"), "Visual Studio Code hızlı, hafif olmanın yanında Microsoft, Linux ve Mac işletim sistemlerinde çalışabilen bir araçtır.Visual Studio Code Nedir?Visual Studio Code hızlı, hafif olmanın yanında Microsoft, Linux ve Mac işletim sistemlerinde çalışabilen bir araçtır.01 Ağustos 2019Günümüzde programlama dilleri bağımsız bir alana taşınmaya başlanmıştır. Bir programlama dili ile geliştirme yapmak için her türlü işletim sistemi kullanılabilir olmalıdır. Son bir kaç yılda Microsoft bu değişime ayak uydurarak açık kaynak ürünler ve platform bağımsız teknolojiler üretmeye başlamıştır. Microsoft .net ile artık Mac OS ve Linux platformlarında geliştirme yapmak mümkün hale gelmiştir. Visual Studio Code hızlı, hafif olmanın yanında Microsoft, Linux ve Mac işletim sistemlerinde çalışabilen bir araçtır. Kurulum yapıldığında  basit bir metin editörü görüntüsü ile karşımıza çıkan ürün, eklentiler sayesinde Node JS, Ruby, Python, C/C++, C#, Javascript gibi bir çok programlama dilini desteklemektedir. Yani klasik Visual Studio ürünleri gibi her şeyi bünyesinde barındırmak yerine çekirdek bir yapı ile başlatılıp lazım olan parçaların eklentiler halinde ürüne eklenmesi sağlanarak mantıklı bir hareket yapılmıştır. Eklentilerin indirilebildiği bir market ortamı oluşturulmuştur.", "Admin Test", new DateTime(2022, 12, 22, 23, 41, 16, 619, DateTimeKind.Local).AddTicks(2735), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("038f524a-4480-4b81-a013-b68c1a5fed8e"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Studio Deneme Makalesi 1", 33 },
                    { new Guid("a4b26310-f4b7-4450-8473-35a679701e27"), new Guid("0dd270c3-836b-45b9-aa86-897ae30630dd"), "Asp.Net Mvc ile yeni bir projeye başlarken genelde aşağı yukarı aynı mimari yapıyı oluşturuyoruz. Domain nesnelerini ve iş mantığını barındıran bir sınıf kütüphanesi, domain nesneleri ile veritabanı arasındaki köprü olan veri katmanı sınıf kütüphanesi (Repository sınıfları vb.), web içeriklerini bulunduran Asp.Net Mvc uygulaması, Controller sınıfları için ayrı bir sınıf kütüphanesi projesi gibi. Tüm bu projeler arasında bağımlılığı ortadan kaldırmak için Dependency Injection, kodların tutarlılığını kontrol altında tutabilmek için de birim testi projeleri de çözüme eklediğimiz projeler arasında. Gereksinimlere göre proje sayısı daha da artabilir :) Konumuz proje sayısı değil tabi ki, bahsettiğim mimari yapıyı hazır olarak sunan ve birkaç projede bize hız kazandıran başarılı bir framework konumuz.", "Admin Test", new DateTime(2022, 12, 22, 23, 41, 16, 619, DateTimeKind.Local).AddTicks(2728), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a8812bfc-f85c-44b4-8d36-9b474f23b02c"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.net Core Deneme Makalesi 1", 15 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("10baeb44-0bad-477e-8d5f-0437aef0ebdb"), "58e3325a-3b4b-424a-8d2a-0ca723cd31ed", "Admin", "ADMIN" },
                    { new Guid("620938a5-ef18-421c-8f72-65291f44c678"), "1486ef3c-ec2e-4d6f-a360-c393a73231cc", "Superadmin", "SUPERADMIN" },
                    { new Guid("6b32f648-fd66-4e3b-833c-436ce41dc97b"), "f165bb13-d8e6-4024-802f-0429cee3c301", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("48e58468-8a50-46ad-ac18-04ec33fa1818"), 0, "0d482a7c-3c97-483c-bcb1-99bd5e163985", "superadmin@gmail.com", true, "Atakan", "Arslan", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEOutEYBnd/e5Yhjwah/D/Op4zPRh4HSF7CHixWfV2P5QXkvKD91YR6P1raUSSLS9hA==", "+905061590807", true, "cbce4321-5e6e-4e18-98f8-a6489cada219", false, "superadmin@gmail.com" },
                    { new Guid("5c4c8997-e65f-46c2-b823-6b882cf151a3"), 0, "0c88477c-ae93-4585-beef-c3459f2f1e20", "admin@gmail.com", false, "Göksu", "Arslan", false, null, "SUPERADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEKFt4ojielMZKc5BrhoxMkYCT6TtNmLZmlLj8YykOMXeMUBNpjOV1CcOOibKtwSxig==", "+905061590809", false, "2ac6fb3a-4128-46de-bde6-dd3488df9dc6", false, "admin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0dd270c3-836b-45b9-aa86-897ae30630dd"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 23, 41, 16, 619, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("50c2eed1-c93d-4a9d-8d52-b197eb48d509"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 23, 41, 16, 619, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("038f524a-4480-4b81-a013-b68c1a5fed8e"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 23, 41, 16, 619, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a8812bfc-f85c-44b4-8d36-9b474f23b02c"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 23, 41, 16, 619, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("620938a5-ef18-421c-8f72-65291f44c678"), new Guid("48e58468-8a50-46ad-ac18-04ec33fa1818") },
                    { new Guid("10baeb44-0bad-477e-8d5f-0437aef0ebdb"), new Guid("5c4c8997-e65f-46c2-b823-6b882cf151a3") }
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("86ebdce2-9367-4bea-8922-c8cbdb31ed7f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a4b26310-f4b7-4450-8473-35a679701e27"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("b3168182-eb8f-40b3-adc3-c20e8e3d9d2a"), new Guid("50c2eed1-c93d-4a9d-8d52-b197eb48d509"), "Visual Studio Code hızlı, hafif olmanın yanında Microsoft, Linux ve Mac işletim sistemlerinde çalışabilen bir araçtır.Visual Studio Code Nedir?Visual Studio Code hızlı, hafif olmanın yanında Microsoft, Linux ve Mac işletim sistemlerinde çalışabilen bir araçtır.01 Ağustos 2019Günümüzde programlama dilleri bağımsız bir alana taşınmaya başlanmıştır. Bir programlama dili ile geliştirme yapmak için her türlü işletim sistemi kullanılabilir olmalıdır. Son bir kaç yılda Microsoft bu değişime ayak uydurarak açık kaynak ürünler ve platform bağımsız teknolojiler üretmeye başlamıştır. Microsoft .net ile artık Mac OS ve Linux platformlarında geliştirme yapmak mümkün hale gelmiştir. Visual Studio Code hızlı, hafif olmanın yanında Microsoft, Linux ve Mac işletim sistemlerinde çalışabilen bir araçtır. Kurulum yapıldığında  basit bir metin editörü görüntüsü ile karşımıza çıkan ürün, eklentiler sayesinde Node JS, Ruby, Python, C/C++, C#, Javascript gibi bir çok programlama dilini desteklemektedir. Yani klasik Visual Studio ürünleri gibi her şeyi bünyesinde barındırmak yerine çekirdek bir yapı ile başlatılıp lazım olan parçaların eklentiler halinde ürüne eklenmesi sağlanarak mantıklı bir hareket yapılmıştır. Eklentilerin indirilebildiği bir market ortamı oluşturulmuştur.", "Admin Test", new DateTime(2022, 12, 19, 19, 54, 37, 500, DateTimeKind.Local).AddTicks(4928), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("038f524a-4480-4b81-a013-b68c1a5fed8e"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Studio Deneme Makalesi 1", 33 },
                    { new Guid("fa360cf1-c2a7-40a3-bc78-f1dd9e9f7f00"), new Guid("0dd270c3-836b-45b9-aa86-897ae30630dd"), "Asp.Net Mvc ile yeni bir projeye başlarken genelde aşağı yukarı aynı mimari yapıyı oluşturuyoruz. Domain nesnelerini ve iş mantığını barındıran bir sınıf kütüphanesi, domain nesneleri ile veritabanı arasındaki köprü olan veri katmanı sınıf kütüphanesi (Repository sınıfları vb.), web içeriklerini bulunduran Asp.Net Mvc uygulaması, Controller sınıfları için ayrı bir sınıf kütüphanesi projesi gibi. Tüm bu projeler arasında bağımlılığı ortadan kaldırmak için Dependency Injection, kodların tutarlılığını kontrol altında tutabilmek için de birim testi projeleri de çözüme eklediğimiz projeler arasında. Gereksinimlere göre proje sayısı daha da artabilir :) Konumuz proje sayısı değil tabi ki, bahsettiğim mimari yapıyı hazır olarak sunan ve birkaç projede bize hız kazandıran başarılı bir framework konumuz.", "Admin Test", new DateTime(2022, 12, 19, 19, 54, 37, 500, DateTimeKind.Local).AddTicks(4901), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a8812bfc-f85c-44b4-8d36-9b474f23b02c"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.net Core Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0dd270c3-836b-45b9-aa86-897ae30630dd"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 19, 54, 37, 500, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("50c2eed1-c93d-4a9d-8d52-b197eb48d509"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 19, 54, 37, 500, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("038f524a-4480-4b81-a013-b68c1a5fed8e"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 19, 54, 37, 500, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a8812bfc-f85c-44b4-8d36-9b474f23b02c"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 19, 54, 37, 500, DateTimeKind.Local).AddTicks(5335));
        }
    }
}
