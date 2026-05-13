using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CourseWork.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Balance", "Email", "FullName", "Phone" },
                values: new object[,]
                {
                    { 1, 250.00m, "shevchenko.o@gmail.com", "Шевченко Олександр Петрович", "+380501234567" },
                    { 2, 180.50m, "kovalenko.m@ukr.net", "Коваленко Марія Іванівна", "+380672345678" },
                    { 3, 320.00m, "bondarenko.a@gmail.com", "Бондаренко Андрій Сергійович", "+380933456789" },
                    { 4, 95.75m, "tkachenko.o@ukr.net", "Ткаченко Ольга Вікторівна", "+380504567890" },
                    { 5, 410.00m, "melnyk.d@gmail.com", "Мельник Дмитро Олегович", "+380675678901" },
                    { 6, 150.25m, "kravchenko.n@ukr.net", "Кравченко Наталія Юріївна", "+380936789012" },
                    { 7, 200.00m, "oliinyk.i@gmail.com", "Олійник Ігор Васильович", "+380507890123" },
                    { 8, 75.00m, "polishchuk.k@ukr.net", "Поліщук Катерина Андріївна", "+380678901234" },
                    { 9, 560.00m, "savchenko.v@gmail.com", "Савченко Віталій Миколайович", "+380939012345" },
                    { 10, 300.00m, "rudenko.a@ukr.net", "Руденко Анна Олександрівна", "+380500123456" },
                    { 11, 125.50m, "lytvynenko.s@gmail.com", "Литвиненко Сергій Ігорович", "+380671234509" },
                    { 12, 440.00m, "moroz.y@ukr.net", "Мороз Юлія Дмитрівна", "+380932345610" },
                    { 13, 88.00m, "pavlenko.r@gmail.com", "Павленко Роман Тарасович", "+380503456711" },
                    { 14, 670.00m, "khomenko.i@ukr.net", "Хоменко Ірина Степанівна", "+380674567812" },
                    { 15, 215.00m, "honcharenko.m@gmail.com", "Гончаренко Максим Павлович", "+380935678913" }
                });

            migrationBuilder.InsertData(
                table: "GeoZones",
                columns: new[] { "Id", "Boundary", "Description", "Name", "SpeedLimit", "ZoneType" },
                values: new object[,]
                {
                    { 1, (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.05 49.44, 32.07 49.44, 32.07 49.45, 32.05 49.45, 32.05 49.44))"), "Центральна зона міста Черкаси", "Центр Черкас", 25.0, "Allowed" },
                    { 2, (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.045 49.448, 32.055 49.448, 32.055 49.456, 32.045 49.456, 32.045 49.448))"), "Зона пішохідної набережної", "Набережна зона", 10.0, "SpeedLimited" },
                    { 3, (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.048 49.434, 32.058 49.434, 32.058 49.442, 32.048 49.442, 32.048 49.434))"), "Паркова зона зі зниженою швидкістю", "Парк 30-річчя Перемоги", 15.0, "SpeedLimited" },
                    { 4, (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.005 49.42, 32.025 49.42, 32.025 49.432, 32.005 49.432, 32.005 49.42))"), "Житловий район Митниця", "Митниця", null, "Allowed" },
                    { 5, (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.08 49.425, 32.1 49.425, 32.1 49.44, 32.08 49.44, 32.08 49.425))"), "Промислова зона — рух заборонено", "Промзона Черкаси", null, "Restricted" },
                    { 6, (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.025 49.412, 32.045 49.412, 32.045 49.424, 32.025 49.424, 32.025 49.412))"), "Район Соснівка", "Соснівка", null, "Allowed" },
                    { 7, (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.07 49.424, 32.09 49.424, 32.09 49.436, 32.07 49.436, 32.07 49.424))"), "Район Дахнівка", "Дахнівка", null, "Allowed" },
                    { 8, (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.056 49.438, 32.06 49.438, 32.06 49.442, 32.056 49.442, 32.056 49.438))"), "Зона паркування біля ТРЦ", "Паркінг ТРЦ Любава", 5.0, "Parking" },
                    { 9, (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.064 49.432, 32.072 49.432, 32.072 49.438, 32.064 49.438, 32.064 49.432))"), "Зона біля залізничного вокзалу", "Вокзальна площа", 10.0, "SpeedLimited" },
                    { 10, (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.052 49.444, 32.06 49.444, 32.06 49.45, 32.052 49.45, 32.052 49.444))"), "Вулиця Хрещатик та прилеглі квартали", "Хрещатик Черкаси", 20.0, "Allowed" },
                    { 11, (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((31.455 49.748, 31.47 49.748, 31.47 49.758, 31.455 49.758, 31.455 49.748))"), "Центральна частина міста Канів", "Канів Центр", 25.0, "Allowed" },
                    { 12, (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((31.465 49.752, 31.478 49.752, 31.478 49.76, 31.465 49.76, 31.465 49.752))"), "Заповідна зона Тарасової гори", "Тарасова гора", 10.0, "SpeedLimited" },
                    { 13, (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((31.45 49.744, 31.462 49.744, 31.462 49.752, 31.45 49.752, 31.45 49.744))"), "Набережна зона Канева", "Набережна Канева", 15.0, "SpeedLimited" },
                    { 14, (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((31.454 49.747, 31.462 49.747, 31.462 49.753, 31.454 49.753, 31.454 49.747))"), "Зона паркування в парку Канева", "Парк відпочинку Канів", 5.0, "Parking" },
                    { 15, (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((31.475 49.74, 31.49 49.74, 31.49 49.75, 31.475 49.75, 31.475 49.74))"), "Промислова зона Канева — рух заборонено", "Промзона Канів", null, "Restricted" }
                });

            migrationBuilder.InsertData(
                table: "RentalPoints",
                columns: new[] { "Id", "Address", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "м. Черкаси, бул. Шевченка, 205", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0621 49.4445)"), "Центр Черкаси" },
                    { 2, "м. Черкаси, вул. Благовісна, 170", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.053 49.438)"), "Парк ім. 30-річчя Перемоги" },
                    { 3, "м. Черкаси, вул. Набережна, 1", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.049 49.452)"), "Набережна Дніпра" },
                    { 4, "м. Черкаси, вул. Героїв Дніпра, 45", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.015 49.426)"), "Район Митниця" },
                    { 5, "м. Черкаси, вул. Смілянська, 36", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.058 49.44)"), "ТРЦ Любава" },
                    { 6, "м. Черкаси, вул. Вокзальна, 1", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.068 49.435)"), "Вокзал Черкаси" },
                    { 7, "м. Черкаси, вул. Хрещатик, 190", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.055 49.447)"), "Парк Перемоги" },
                    { 8, "м. Черкаси, вул. Дахнівська, 12", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.08 49.43)"), "Дахнівка" },
                    { 9, "м. Черкаси, вул. Сумгаїтська, 28", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.034 49.418)"), "Район Соснівка" },
                    { 10, "м. Черкаси, пл. Б. Хмельницького, 1", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.06 49.446)"), "Площа Богдана Хмельницького" },
                    { 11, "м. Канів, вул. Шевченка, 89", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (31.461 49.752)"), "Канів Центр" },
                    { 12, "м. Канів, Тарасова гора, 1", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (31.47 49.755)"), "Тарасова гора" },
                    { 13, "м. Канів, вул. Набережна, 5", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (31.456 49.748)"), "Набережна Канева" },
                    { 14, "м. Канів, вул. Героїв, 34", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (31.458 49.75)"), "Парк Канів" },
                    { 15, "м. Канів, вул. Київська, 70", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (31.463 49.754)"), "Автостанція Канів" }
                });

            migrationBuilder.InsertData(
                table: "VehicleTypes",
                columns: new[] { "Id", "Name", "PerMinuteRate", "UnlockFee" },
                values: new object[,]
                {
                    { 1, "Xiaomi Mi Pro 2", 4.50m, 15.00m },
                    { 2, "Xiaomi Mi Essential", 3.50m, 10.00m },
                    { 3, "Ninebot Max G30", 5.00m, 20.00m },
                    { 4, "Kugoo S3 Pro", 3.80m, 12.00m },
                    { 5, "Segway Ninebot E2", 3.00m, 10.00m },
                    { 6, "Велосипед міський Classic", 2.00m, 5.00m },
                    { 7, "Велосипед гірський Trail", 2.50m, 8.00m },
                    { 8, "Електровелосипед City-E", 4.00m, 15.00m },
                    { 9, "Xiaomi Mi 1S", 4.00m, 12.00m },
                    { 10, "Kugoo Kirin M4", 5.50m, 18.00m },
                    { 11, "Велосипед складний Fold", 2.20m, 6.00m },
                    { 12, "Ninebot F40", 4.80m, 16.00m },
                    { 13, "Електровелосипед Cargo", 5.00m, 20.00m },
                    { 14, "Segway P65", 6.00m, 25.00m },
                    { 15, "Kugoo G-Booster", 5.80m, 22.00m }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BatteryLevel", "CurrentLocation", "IsAvailable", "RentalPointId", "SerialNumber", "VehicleTypeId" },
                values: new object[,]
                {
                    { 1, 95, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0621 49.4445)"), true, 1, "XM-PRO2-0001", 1 },
                    { 2, 80, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0623 49.4446)"), true, 1, "XM-ESS-0002", 2 },
                    { 3, 60, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.05 49.44)"), false, null, "NB-MAX-0003", 3 },
                    { 4, 100, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.053 49.438)"), true, 2, "KG-S3P-0004", 4 },
                    { 5, 45, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.049 49.452)"), true, 3, "SG-E2-0005", 5 },
                    { 6, 100, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.015 49.426)"), true, 4, "VL-CLS-0006", 6 },
                    { 7, 100, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.056 49.4475)"), false, null, "VL-TRL-0007", 7 },
                    { 8, 70, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.058 49.44)"), true, 5, "EV-CTE-0008", 8 },
                    { 9, 88, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.068 49.435)"), true, 6, "XM-1S-0009", 9 },
                    { 10, 55, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.055 49.447)"), true, 7, "KG-M4-0010", 10 },
                    { 11, 100, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (31.461 49.752)"), true, 11, "VL-FLD-0011", 11 },
                    { 12, 30, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (31.465 49.751)"), false, null, "NB-F40-0012", 12 },
                    { 13, 90, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (31.47 49.755)"), true, 12, "EV-CRG-0013", 13 },
                    { 14, 75, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (31.456 49.748)"), true, 13, "SG-P65-0014", 14 },
                    { 15, 20, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (31.458 49.75)"), true, 14, "KG-GBS-0015", 15 }
                });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "Id", "ClientId", "EndRentalPointId", "EndTime", "StartRentalPointId", "StartTime", "TotalCost", "VehicleId" },
                values: new object[,]
                {
                    { 1, 1, 2, new DateTime(2026, 5, 1, 9, 25, 0, 0, DateTimeKind.Utc), 1, new DateTime(2026, 5, 1, 9, 0, 0, 0, DateTimeKind.Utc), 127.50m, 1 },
                    { 2, 2, 5, new DateTime(2026, 5, 1, 11, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2026, 5, 1, 10, 30, 0, 0, DateTimeKind.Utc), 170.00m, 3 },
                    { 3, 3, 1, new DateTime(2026, 5, 2, 14, 40, 0, 0, DateTimeKind.Utc), 3, new DateTime(2026, 5, 2, 14, 0, 0, 0, DateTimeKind.Utc), 130.00m, 5 },
                    { 4, 4, 4, new DateTime(2026, 5, 2, 17, 0, 0, 0, DateTimeKind.Utc), 7, new DateTime(2026, 5, 2, 16, 0, 0, 0, DateTimeKind.Utc), 158.00m, 7 },
                    { 5, 5, 3, new DateTime(2026, 5, 3, 8, 35, 0, 0, DateTimeKind.Utc), 1, new DateTime(2026, 5, 3, 8, 15, 0, 0, DateTimeKind.Utc), 80.00m, 2 },
                    { 6, 6, 6, new DateTime(2026, 5, 3, 11, 45, 0, 0, DateTimeKind.Utc), 2, new DateTime(2026, 5, 3, 11, 0, 0, 0, DateTimeKind.Utc), 183.00m, 4 },
                    { 7, 7, 9, new DateTime(2026, 5, 4, 8, 30, 0, 0, DateTimeKind.Utc), 4, new DateTime(2026, 5, 4, 7, 30, 0, 0, DateTimeKind.Utc), 125.00m, 6 },
                    { 8, 8, 7, new DateTime(2026, 5, 4, 13, 20, 0, 0, DateTimeKind.Utc), 5, new DateTime(2026, 5, 4, 13, 0, 0, 0, DateTimeKind.Utc), 95.00m, 8 },
                    { 9, 9, 10, new DateTime(2026, 5, 5, 9, 50, 0, 0, DateTimeKind.Utc), 7, new DateTime(2026, 5, 5, 9, 0, 0, 0, DateTimeKind.Utc), 293.00m, 10 },
                    { 10, 10, 8, new DateTime(2026, 5, 5, 15, 30, 0, 0, DateTimeKind.Utc), 6, new DateTime(2026, 5, 5, 15, 0, 0, 0, DateTimeKind.Utc), 132.00m, 9 },
                    { 11, 11, 13, new DateTime(2026, 5, 6, 10, 55, 0, 0, DateTimeKind.Utc), 11, new DateTime(2026, 5, 6, 10, 0, 0, 0, DateTimeKind.Utc), 127.00m, 11 },
                    { 12, 12, 12, new DateTime(2026, 5, 6, 12, 15, 0, 0, DateTimeKind.Utc), 11, new DateTime(2026, 5, 6, 12, 0, 0, 0, DateTimeKind.Utc), 88.00m, 12 },
                    { 13, 13, 14, new DateTime(2026, 5, 7, 17, 35, 0, 0, DateTimeKind.Utc), 13, new DateTime(2026, 5, 7, 17, 0, 0, 0, DateTimeKind.Utc), 235.00m, 14 },
                    { 14, 14, null, null, 12, new DateTime(2026, 5, 8, 8, 0, 0, 0, DateTimeKind.Utc), null, 13 },
                    { 15, 15, null, null, 14, new DateTime(2026, 5, 8, 9, 30, 0, 0, DateTimeKind.Utc), null, 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RentalPoints",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RentalPoints",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RentalPoints",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RentalPoints",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RentalPoints",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RentalPoints",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RentalPoints",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RentalPoints",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RentalPoints",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RentalPoints",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RentalPoints",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RentalPoints",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RentalPoints",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "RentalPoints",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RentalPoints",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
