using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPasswordFieldToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4532), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4536), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4540), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4542), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4543) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4545), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4548), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4551), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4552) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4554), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4556), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4560), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4564), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4567), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4569), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4600), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4603), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4604) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4606), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4608), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4611), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4614), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4618), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4621), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4624), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4626), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4629), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4632), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4635), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4638), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4640), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4644), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4647), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4649), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4652), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4655), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4658), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4661), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4663), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4666), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4670), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4673), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4675), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4678), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4681), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4684), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4686), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4689), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4692), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4697), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4700), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4702), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4705), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4708), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4709) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4711), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(3191), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(3227), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(3230), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(3232), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(3235), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(3238), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4148), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4153), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4156), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4158), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4161), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4163), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4166), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4168), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4171), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4173), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4175), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4178), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4180), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4183), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4185), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4188), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4218), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4221), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4224), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4226), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4229), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4231), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4234), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4236), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4238), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4239) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4241), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4243), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4246), new DateTime(2023, 3, 26, 15, 6, 22, 803, DateTimeKind.Local).AddTicks(4247) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(298), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(302), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(305), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(309), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(311), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(314), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(318), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(321), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(324), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(326), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(329), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(332), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(335), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(337), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(340), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(344), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(347), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(350), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(352), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(353) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(355), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(358), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(361), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(363), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(366), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(370), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(373), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(375), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(378), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(381), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(384), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(386), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(389), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(392), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(395), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(398), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(401), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(404), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(406), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(409), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(412), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(414), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(417), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(421), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(424), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(426), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(429), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(432), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(435), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(460), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(463), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(466), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(468), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9008), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9040), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9043), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9045), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9047), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9050), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9931), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9936), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9939), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9942), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9944), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9947), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9949), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9952), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9954), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9956), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9959), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9961), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9964), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9967), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9969), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9972), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9974), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9976), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9979), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9981), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9984), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9986), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9989), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9991), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9993), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9996), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9998), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(1), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(2) });
        }
    }
}
