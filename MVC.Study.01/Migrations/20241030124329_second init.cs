using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC.Study._01.Migrations
{
    /// <inheritdoc />
    public partial class secondinit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Musteriler",
                columns: new[] { "MusteriId", "Ad", "Email", "Soyad" },
                values: new object[,]
                {
                    { 1, "Ali", "ali.yilmaz@example.com", "Yılmaz" },
                    { 2, "Ayşe", "ayse.kara@example.com", "Kara" },
                    { 3, "Mehmet", "mehmet.demir@example.com", "Demir" },
                    { 4, "Fatma", "fatma.ozturk@example.com", "Öztürk" },
                    { 5, "Hasan", "hasan.celik@example.com", "Çelik" },
                    { 6, "Zeynep", "zeynep.koc@example.com", "Koç" },
                    { 7, "Emre", "emre.aydin@example.com", "Aydın" },
                    { 8, "Seda", "seda.akman@example.com", "Akman" },
                    { 9, "Burak", "burak.sonmez@example.com", "Sönmez" },
                    { 10, "Elif", "elif.yavuz@example.com", "Yavuz" }
                });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "Fiyat", "UrunAdi" },
                values: new object[,]
                {
                    { 1, 2500m, "Laptop" },
                    { 2, 1500m, "Akıllı Telefon" },
                    { 3, 1200m, "Tablet" },
                    { 4, 300m, "Kulaklık" },
                    { 5, 2000m, "Masaüstü Bilgisayar" },
                    { 6, 800m, "Monitör" },
                    { 7, 400m, "Klavyeli" },
                    { 8, 600m, "Yazıcı" },
                    { 9, 250m, "Modem" },
                    { 10, 500m, "Harici Disk" }
                });

            migrationBuilder.InsertData(
                table: "Siparisler",
                columns: new[] { "SiparisId", "MusteriId", "SiparisTarihi", "UrunId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 30, 15, 43, 28, 424, DateTimeKind.Local).AddTicks(8406), 1 },
                    { 2, 1, new DateTime(2024, 10, 30, 15, 43, 28, 424, DateTimeKind.Local).AddTicks(8416), 2 },
                    { 3, 2, new DateTime(2024, 10, 30, 15, 43, 28, 424, DateTimeKind.Local).AddTicks(8418), 3 },
                    { 4, 2, new DateTime(2024, 10, 30, 15, 43, 28, 424, DateTimeKind.Local).AddTicks(8419), 4 },
                    { 5, 3, new DateTime(2024, 10, 30, 15, 43, 28, 424, DateTimeKind.Local).AddTicks(8420), 5 },
                    { 6, 3, new DateTime(2024, 10, 30, 15, 43, 28, 424, DateTimeKind.Local).AddTicks(8422), 6 },
                    { 7, 4, new DateTime(2024, 10, 30, 15, 43, 28, 424, DateTimeKind.Local).AddTicks(8423), 7 },
                    { 8, 5, new DateTime(2024, 10, 30, 15, 43, 28, 424, DateTimeKind.Local).AddTicks(8424), 8 },
                    { 9, 6, new DateTime(2024, 10, 30, 15, 43, 28, 424, DateTimeKind.Local).AddTicks(8425), 9 },
                    { 10, 7, new DateTime(2024, 10, 30, 15, 43, 28, 424, DateTimeKind.Local).AddTicks(8427), 10 },
                    { 11, 8, new DateTime(2024, 10, 30, 15, 43, 28, 424, DateTimeKind.Local).AddTicks(8428), 1 },
                    { 12, 9, new DateTime(2024, 10, 30, 15, 43, 28, 424, DateTimeKind.Local).AddTicks(8429), 2 },
                    { 13, 10, new DateTime(2024, 10, 30, 15, 43, 28, 424, DateTimeKind.Local).AddTicks(8430), 3 },
                    { 14, 4, new DateTime(2024, 10, 30, 15, 43, 28, 424, DateTimeKind.Local).AddTicks(8431), 5 },
                    { 15, 5, new DateTime(2024, 10, 30, 15, 43, 28, 424, DateTimeKind.Local).AddTicks(8432), 6 },
                    { 16, 6, new DateTime(2024, 10, 30, 15, 43, 28, 424, DateTimeKind.Local).AddTicks(8434), 7 },
                    { 17, 7, new DateTime(2024, 10, 30, 15, 43, 28, 424, DateTimeKind.Local).AddTicks(8435), 8 },
                    { 18, 8, new DateTime(2024, 10, 30, 15, 43, 28, 424, DateTimeKind.Local).AddTicks(8436), 9 },
                    { 19, 9, new DateTime(2024, 10, 30, 15, 43, 28, 424, DateTimeKind.Local).AddTicks(8437), 10 },
                    { 20, 10, new DateTime(2024, 10, 30, 15, 43, 28, 424, DateTimeKind.Local).AddTicks(8438), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "MusteriId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "MusteriId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "MusteriId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "MusteriId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "MusteriId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "MusteriId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "MusteriId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "MusteriId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "MusteriId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "MusteriId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 10);
        }
    }
}
