using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionFieldToBookModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9245), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9249), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9252), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9255), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9258), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9261), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9264), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9289), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9291), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9294), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9297), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9298) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9300), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9302), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9305), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9308), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9311), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9314), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9316), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9317) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9319), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9323), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9326), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9329), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9331), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9334), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9337), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9340), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9342), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9345), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9349), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9352), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9354), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9357), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9360), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9363), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9365), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9368), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9371), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9375), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9377), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9380), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9383), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9385), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9388), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9391), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9394), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9396), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9400), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9403), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9405), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9406) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9408), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9411), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9414), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8204), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8229), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8231), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8234), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8236), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8237) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8238), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8892), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8897), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8902), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8906), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8945), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8949), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8952), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8954), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8957), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8959), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8961), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8964), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8966), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8969), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8971), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8974), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8976), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8978), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8981), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8983), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8986), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8988), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8993), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8995), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8998), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9001) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(606), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(611), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(613), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(616), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(619), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(622), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(624), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(627), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(629), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(632), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(635), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(638), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(640), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(643), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(644) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(645), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(648), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(649) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(651), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(654), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(657), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(659), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(662), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(665), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(668), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(671), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(674), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(675) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(677), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(679), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(682), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(685), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(688), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(691), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(694), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(696), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(699), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(701), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(702) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(704), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(706), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(710), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(711) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(712), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(715), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(718), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(719) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(750), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(753), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(755), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(756) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(758), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(760), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(763), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(765), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(769), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(772), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(774), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(777), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9447), new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9483), new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9485), new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9487), new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9490), new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9492), new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(194), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(202), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(205), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(207), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(210), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(212), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(215), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(217), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(219), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(222), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(224), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(226), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(229), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(231), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(233), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(236), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(238), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(240), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(243), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(245), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(247), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(250), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(252), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(254), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(256), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(259), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(261), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(263), new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(264) });
        }
    }
}
