using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace CourseWork.Migrations
{
    /// <inheritdoc />
    public partial class UpdateClientAndVehicleType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Clients");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "VehicleTypes",
                type: "character varying(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Clients",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Clients",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Patronymic",
                table: "Clients",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "Patronymic" },
                values: new object[] { "Олександр", "Шевченко", "Петрович" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "Patronymic" },
                values: new object[] { "Марія", "Коваленко", "Іванівна" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "Patronymic" },
                values: new object[] { "Андрій", "Бондаренко", "Сергійович" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName", "Patronymic" },
                values: new object[] { "Ольга", "Ткаченко", "Вікторівна" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "Patronymic" },
                values: new object[] { "Дмитро", "Мельник", "Олегович" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName", "Patronymic" },
                values: new object[] { "Наталія", "Кравченко", "Юріївна" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName", "Patronymic" },
                values: new object[] { "Ігор", "Олійник", "Васильович" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FirstName", "LastName", "Patronymic" },
                values: new object[] { "Катерина", "Поліщук", "Андріївна" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FirstName", "LastName", "Patronymic" },
                values: new object[] { "Віталій", "Савченко", "Миколайович" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FirstName", "LastName", "Patronymic" },
                values: new object[] { "Анна", "Руденко", "Олександрівна" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FirstName", "LastName", "Patronymic" },
                values: new object[] { "Сергій", "Литвиненко", "Ігорович" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FirstName", "LastName", "Patronymic" },
                values: new object[] { "Юлія", "Мороз", "Дмитрівна" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FirstName", "LastName", "Patronymic" },
                values: new object[] { "Роман", "Павленко", "Тарасович" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FirstName", "LastName", "Patronymic" },
                values: new object[] { "Ірина", "Хоменко", "Степанівна" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FirstName", "LastName", "Patronymic" },
                values: new object[] { "Максим", "Гончаренко", "Павлович" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Boundary", "Description" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.052 49.44, 32.07 49.44, 32.07 49.45, 32.052 49.45, 32.052 49.44))"), "Центральна зона: бул. Шевченка — Хрещатик" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Boundary", "Description", "Name" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.042 49.448, 32.056 49.448, 32.056 49.456, 32.042 49.456, 32.042 49.448))"), "Набережна від мосту до річпорту", "Набережна Дніпра" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Boundary", "Description" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.048 49.434, 32.06 49.434, 32.06 49.442, 32.048 49.442, 32.048 49.434))"), "Паркова зона між вул. Благовісна та Смілянська" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Boundary", "Description", "Name" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.005 49.42, 32.03 49.42, 32.03 49.434, 32.005 49.434, 32.005 49.42))"), "Житловий масив Митниця", "Район Митниця" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Boundary", "Name" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.085 49.425, 32.105 49.425, 32.105 49.44, 32.085 49.44, 32.085 49.425))"), "Промзона Придніпровська" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Boundary", "Description", "Name" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.025 49.41, 32.045 49.41, 32.045 49.425, 32.025 49.425, 32.025 49.41))"), "Мікрорайон Соснівка", "Район Соснівка" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Мікрорайон Дахнівка", "Район Дахнівка" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Boundary", "Description" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.0565 49.439, 32.06 49.439, 32.06 49.4415, 32.0565 49.4415, 32.0565 49.439))"), "Зона паркування біля ТРЦ Любава" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Привокзальна зона");

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Boundary", "Description", "Name" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.05 49.444, 32.062 49.444, 32.062 49.451, 32.05 49.451, 32.05 49.444))"), "Вул. Хрещатик та прилеглі квартали", "Хрещатик" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Boundary", "Description" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((31.453 49.746, 31.47 49.746, 31.47 49.758, 31.453 49.758, 31.453 49.746))"), "Центральна частина Канева" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Заповідна зона навколо могили Т. Шевченка");

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Boundary", "Description" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((31.448 49.744, 31.462 49.744, 31.462 49.752, 31.448 49.752, 31.448 49.744))"), "Набережна вздовж Дніпра" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Boundary", "Description" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((31.454 49.747, 31.463 49.747, 31.463 49.753, 31.454 49.753, 31.454 49.747))"), "Зона паркування у міському парку" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 15,
                column: "Boundary",
                value: (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((31.475 49.738, 31.495 49.738, 31.495 49.75, 31.475 49.75, 31.475 49.738))"));

            migrationBuilder.UpdateData(
                table: "RentalPoints",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Площа Б. Хмельницького");

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Category",
                value: "Самокат");

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Category",
                value: "Самокат");

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Category",
                value: "Самокат");

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Category",
                value: "Самокат");

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Category",
                value: "Самокат");

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Велосипед", "City Classic 28" });

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Велосипед", "Mountain Trail 29" });

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Електровелосипед", "E-Bike City Pro" });

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Category",
                value: "Самокат");

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Category",
                value: "Самокат");

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Велосипед", "Fold Compact 20" });

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Category",
                value: "Самокат");

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Електровелосипед", "E-Bike Cargo Max" });

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Category",
                value: "Самокат");

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Category",
                value: "Самокат");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "VehicleTypes");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Patronymic",
                table: "Clients");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Clients",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "FullName",
                value: "Шевченко Олександр Петрович");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "FullName",
                value: "Коваленко Марія Іванівна");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "FullName",
                value: "Бондаренко Андрій Сергійович");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "FullName",
                value: "Ткаченко Ольга Вікторівна");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "FullName",
                value: "Мельник Дмитро Олегович");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                column: "FullName",
                value: "Кравченко Наталія Юріївна");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                column: "FullName",
                value: "Олійник Ігор Васильович");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                column: "FullName",
                value: "Поліщук Катерина Андріївна");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                column: "FullName",
                value: "Савченко Віталій Миколайович");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                column: "FullName",
                value: "Руденко Анна Олександрівна");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 11,
                column: "FullName",
                value: "Литвиненко Сергій Ігорович");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 12,
                column: "FullName",
                value: "Мороз Юлія Дмитрівна");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 13,
                column: "FullName",
                value: "Павленко Роман Тарасович");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 14,
                column: "FullName",
                value: "Хоменко Ірина Степанівна");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 15,
                column: "FullName",
                value: "Гончаренко Максим Павлович");

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Boundary", "Description" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.05 49.44, 32.07 49.44, 32.07 49.45, 32.05 49.45, 32.05 49.44))"), "Центральна зона міста Черкаси" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Boundary", "Description", "Name" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.045 49.448, 32.055 49.448, 32.055 49.456, 32.045 49.456, 32.045 49.448))"), "Зона пішохідної набережної", "Набережна зона" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Boundary", "Description" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.048 49.434, 32.058 49.434, 32.058 49.442, 32.048 49.442, 32.048 49.434))"), "Паркова зона зі зниженою швидкістю" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Boundary", "Description", "Name" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.005 49.42, 32.025 49.42, 32.025 49.432, 32.005 49.432, 32.005 49.42))"), "Житловий район Митниця", "Митниця" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Boundary", "Name" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.08 49.425, 32.1 49.425, 32.1 49.44, 32.08 49.44, 32.08 49.425))"), "Промзона Черкаси" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Boundary", "Description", "Name" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.025 49.412, 32.045 49.412, 32.045 49.424, 32.025 49.424, 32.025 49.412))"), "Район Соснівка", "Соснівка" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Район Дахнівка", "Дахнівка" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Boundary", "Description" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.056 49.438, 32.06 49.438, 32.06 49.442, 32.056 49.442, 32.056 49.438))"), "Зона паркування біля ТРЦ" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Зона біля залізничного вокзалу");

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Boundary", "Description", "Name" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((32.052 49.444, 32.06 49.444, 32.06 49.45, 32.052 49.45, 32.052 49.444))"), "Вулиця Хрещатик та прилеглі квартали", "Хрещатик Черкаси" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Boundary", "Description" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((31.455 49.748, 31.47 49.748, 31.47 49.758, 31.455 49.758, 31.455 49.748))"), "Центральна частина міста Канів" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Заповідна зона Тарасової гори");

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Boundary", "Description" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((31.45 49.744, 31.462 49.744, 31.462 49.752, 31.45 49.752, 31.45 49.744))"), "Набережна зона Канева" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Boundary", "Description" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((31.454 49.747, 31.462 49.747, 31.462 49.753, 31.454 49.753, 31.454 49.747))"), "Зона паркування в парку Канева" });

            migrationBuilder.UpdateData(
                table: "GeoZones",
                keyColumn: "Id",
                keyValue: 15,
                column: "Boundary",
                value: (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((31.475 49.74, 31.49 49.74, 31.49 49.75, 31.475 49.75, 31.475 49.74))"));

            migrationBuilder.UpdateData(
                table: "RentalPoints",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Площа Богдана Хмельницького");

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Велосипед міський Classic");

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Велосипед гірський Trail");

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Електровелосипед City-E");

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Велосипед складний Fold");

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Електровелосипед Cargo");
        }
    }
}
