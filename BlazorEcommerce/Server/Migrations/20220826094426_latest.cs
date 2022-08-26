using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class latest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "ProductVariants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "ProductVariants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("29556bf0-ecee-4c97-af94-4b67acbd7efc"),
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bab82ab7-2a1c-469c-92b6-4d0b606444ee"),
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e72b0914-9057-4bcf-ab27-dca606bc3796"),
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("10c34a0c-34d2-4701-9747-6fd1bc8453a1"), new Guid("a02f43d7-1cbe-4e52-b7a5-f70edc0dbc67") },
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("2655e4a5-6017-49e2-a4f2-e7e19477cd21"), new Guid("d6b9cc8c-803f-4ba0-8ffb-a3171baaf618") },
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("277adaa9-3d24-4814-b655-943f3cca2f9a"), new Guid("9c453430-13ec-4af0-be34-0466ad416573") },
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("277adaa9-3d24-4814-b655-943f3cca2f9a"), new Guid("c1a0a0a5-abaa-4051-b3dc-ff4acc37f678") },
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("277adaa9-3d24-4814-b655-943f3cca2f9a"), new Guid("d6b9cc8c-803f-4ba0-8ffb-a3171baaf618") },
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("30352fe2-306a-401f-bc1a-80175a6f6339"), new Guid("41a4ba21-4a69-48eb-9670-4a332ee0d471") },
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("52c7bca4-530f-4bd2-aa10-614764287ea4"), new Guid("41a4ba21-4a69-48eb-9670-4a332ee0d471") },
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("81b77744-e198-40fe-b102-8c48ef41b283"), new Guid("c95c9386-0231-48f5-8e8b-bb47950646bc") },
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("b784d506-98ec-4a86-900d-48d63700b1ce"), new Guid("29ba1ff3-454e-4752-a774-9f889e978a57") },
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("b784d506-98ec-4a86-900d-48d63700b1ce"), new Guid("c95c9386-0231-48f5-8e8b-bb47950646bc") },
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("b784d506-98ec-4a86-900d-48d63700b1ce"), new Guid("d0aa1426-45b6-4ecc-83e2-7eb03f94f307") },
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("bfb850c2-3c74-4d06-b39b-ff94a7f89f74"), new Guid("8fa1a293-9176-425d-8ef5-d22e49f66dd5") },
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("bfb850c2-3c74-4d06-b39b-ff94a7f89f74"), new Guid("9a5e15c5-45c5-460c-97f6-5ecd3ada998e") },
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("bfb850c2-3c74-4d06-b39b-ff94a7f89f74"), new Guid("a02f43d7-1cbe-4e52-b7a5-f70edc0dbc67") },
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("d67b758a-5447-41c2-8ae6-108d4f92ad4c"), new Guid("c95c9386-0231-48f5-8e8b-bb47950646bc") },
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("ec68bfcc-282b-48f4-966b-94a5a438c808"), new Guid("a02f43d7-1cbe-4e52-b7a5-f70edc0dbc67") },
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("fb9c047c-b557-4148-8103-0df3d8c4d17f"), new Guid("d6b9cc8c-803f-4ba0-8ffb-a3171baaf618") },
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10c34a0c-34d2-4701-9747-6fd1bc8453a1"),
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2655e4a5-6017-49e2-a4f2-e7e19477cd21"),
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("277adaa9-3d24-4814-b655-943f3cca2f9a"),
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30352fe2-306a-401f-bc1a-80175a6f6339"),
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52c7bca4-530f-4bd2-aa10-614764287ea4"),
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81b77744-e198-40fe-b102-8c48ef41b283"),
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b784d506-98ec-4a86-900d-48d63700b1ce"),
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfb850c2-3c74-4d06-b39b-ff94a7f89f74"),
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d67b758a-5447-41c2-8ae6-108d4f92ad4c"),
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ec68bfcc-282b-48f4-966b-94a5a438c808"),
                column: "Visible",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb9c047c-b557-4148-8103-0df3d8c4d17f"),
                column: "Visible",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Categories");
        }
    }
}
