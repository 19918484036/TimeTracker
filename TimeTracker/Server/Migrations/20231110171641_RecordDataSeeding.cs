using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TimeTracker.Server.Migrations
{
    /// <inheritdoc />
    public partial class RecordDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RecordDatas",
                columns: new[] { "Id", "Date", "WorkEndTimeAfternoon", "WorkEndTimeMorning", "WorkStartTimeAfternoon", "WorkStartTimeMorning" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 8, 30, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecordDatas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RecordDatas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RecordDatas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RecordDatas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RecordDatas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RecordDatas",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
