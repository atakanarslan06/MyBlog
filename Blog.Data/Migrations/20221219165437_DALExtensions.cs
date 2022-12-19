﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class DALExtensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2918243a-7735-4453-a992-a5fa759aec9a"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d122e323-1d00-4fd5-a768-9bbd73e7a32c"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b3168182-eb8f-40b3-adc3-c20e8e3d9d2a"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("fa360cf1-c2a7-40a3-bc78-f1dd9e9f7f00"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("2918243a-7735-4453-a992-a5fa759aec9a"), new Guid("50c2eed1-c93d-4a9d-8d52-b197eb48d509"), "Visual Studio Code hızlı, hafif olmanın yanında Microsoft, Linux ve Mac işletim sistemlerinde çalışabilen bir araçtır.Visual Studio Code Nedir?Visual Studio Code hızlı, hafif olmanın yanında Microsoft, Linux ve Mac işletim sistemlerinde çalışabilen bir araçtır.01 Ağustos 2019Günümüzde programlama dilleri bağımsız bir alana taşınmaya başlanmıştır. Bir programlama dili ile geliştirme yapmak için her türlü işletim sistemi kullanılabilir olmalıdır. Son bir kaç yılda Microsoft bu değişime ayak uydurarak açık kaynak ürünler ve platform bağımsız teknolojiler üretmeye başlamıştır. Microsoft .net ile artık Mac OS ve Linux platformlarında geliştirme yapmak mümkün hale gelmiştir. Visual Studio Code hızlı, hafif olmanın yanında Microsoft, Linux ve Mac işletim sistemlerinde çalışabilen bir araçtır. Kurulum yapıldığında  basit bir metin editörü görüntüsü ile karşımıza çıkan ürün, eklentiler sayesinde Node JS, Ruby, Python, C/C++, C#, Javascript gibi bir çok programlama dilini desteklemektedir. Yani klasik Visual Studio ürünleri gibi her şeyi bünyesinde barındırmak yerine çekirdek bir yapı ile başlatılıp lazım olan parçaların eklentiler halinde ürüne eklenmesi sağlanarak mantıklı bir hareket yapılmıştır. Eklentilerin indirilebildiği bir market ortamı oluşturulmuştur.", "Admin Test", new DateTime(2022, 12, 19, 10, 22, 49, 293, DateTimeKind.Local).AddTicks(9430), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("038f524a-4480-4b81-a013-b68c1a5fed8e"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Studio Deneme Makalesi 1", 15 },
                    { new Guid("d122e323-1d00-4fd5-a768-9bbd73e7a32c"), new Guid("0dd270c3-836b-45b9-aa86-897ae30630dd"), "Asp.Net Mvc ile yeni bir projeye başlarken genelde aşağı yukarı aynı mimari yapıyı oluşturuyoruz. Domain nesnelerini ve iş mantığını barındıran bir sınıf kütüphanesi, domain nesneleri ile veritabanı arasındaki köprü olan veri katmanı sınıf kütüphanesi (Repository sınıfları vb.), web içeriklerini bulunduran Asp.Net Mvc uygulaması, Controller sınıfları için ayrı bir sınıf kütüphanesi projesi gibi. Tüm bu projeler arasında bağımlılığı ortadan kaldırmak için Dependency Injection, kodların tutarlılığını kontrol altında tutabilmek için de birim testi projeleri de çözüme eklediğimiz projeler arasında. Gereksinimlere göre proje sayısı daha da artabilir :) Konumuz proje sayısı değil tabi ki, bahsettiğim mimari yapıyı hazır olarak sunan ve birkaç projede bize hız kazandıran başarılı bir framework konumuz.", "Admin Test", new DateTime(2022, 12, 19, 10, 22, 49, 293, DateTimeKind.Local).AddTicks(9425), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a8812bfc-f85c-44b4-8d36-9b474f23b02c"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.net Core Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0dd270c3-836b-45b9-aa86-897ae30630dd"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 10, 22, 49, 293, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("50c2eed1-c93d-4a9d-8d52-b197eb48d509"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 10, 22, 49, 293, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("038f524a-4480-4b81-a013-b68c1a5fed8e"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 10, 22, 49, 293, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a8812bfc-f85c-44b4-8d36-9b474f23b02c"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 10, 22, 49, 293, DateTimeKind.Local).AddTicks(9756));
        }
    }
}
