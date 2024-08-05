using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SanaCommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProductDateOffSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b9cdcb9-a2cf-4676-b069-e386549f9386"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16c65138-db8d-457b-b64c-ec0f90aa44c8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("256d30f6-76da-49c0-93ef-a394c5142799"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b19fc1f-7e5c-4072-93ae-2154ed8a0264"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31fc9572-1abd-447b-bf8a-24283bc3ac6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("389c1a63-7249-49b7-8d71-d086c30a6bb8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e9d6c5d-eb58-493b-b71e-a18cd873fb01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4cd3198d-2f63-4f79-ae78-3dab0c2f1145"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4fd36778-c189-4b3b-a214-0e759a36c0ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("542fbc65-792d-467e-af93-a22c5771b720"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d206f53-cc92-4fb4-ac40-ec5eb6208870"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("740aec81-e358-4d61-9cc3-39743f126fdd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7db72d78-187d-48ca-b4cd-77d455065e7f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84a38b7e-01e6-4253-8a5f-c769b86e17a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("853dde7f-6f88-4c21-8fe2-0f0fb3b5d0ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86249afd-3c34-410e-8a8d-07f7b9319f3f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("998cc45a-7bc0-4c19-ad3b-f45eaa35faee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99b29f56-c34b-4ee8-871a-670655708338"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("adc99544-f06b-4c3a-ab9f-684735e57d38"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b817b853-00a2-4661-bb39-0d58bc56b934"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5249b52-b01d-442b-9797-0c7349b52e18"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c98975ad-db22-448a-a91f-9ece217cc836"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb0cb708-932d-4d74-874f-f0aa72ca002a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2d2a4f9-f74b-4a4d-8aea-20493c2991d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1830ee0-e4d1-4d07-bcf6-ef9cb8a85f4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f36b4c36-846d-4061-966f-13964784b432"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4ebe020-f618-4ef3-b30c-244a0e8e7f4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f55a7c21-aba7-4e07-bbcb-a6d613a614dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f88fa99e-cbbf-41f0-80b5-93789547770d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9bc788a-24eb-4082-9866-8f0fb08ad970"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "Price", "ProductCode", "Stock", "Title" },
                values: new object[,]
                {
                    { new Guid("03c85f68-84eb-4342-b5d1-514b853be3ce"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1160), new TimeSpan(0, 0, 0, 0, 0)), "All-in-one printer", 199.99m, "PRT012", 13, "Printer" },
                    { new Guid("09ebc12a-dcfa-4847-94f5-f4ff69d4d37a"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1010), new TimeSpan(0, 0, 0, 0, 0)), "High performance laptop", 1200.99m, "LAP123", 10, "Laptop" },
                    { new Guid("0c23e156-b0bd-447b-9bea-c98a064d3ef5"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1140), new TimeSpan(0, 0, 0, 0, 0)), "High-speed WiFi router", 99.99m, "RTR567", 45, "Router" },
                    { new Guid("0da731d3-1802-4a4f-8158-be973e147ce0"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1110), new TimeSpan(0, 0, 0, 0, 0)), "Automatic coffee maker", 79.99m, "CFM456", 18, "Coffee Maker" },
                    { new Guid("167ec7b2-927d-421f-b935-22af153b5c55"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1170), new TimeSpan(0, 0, 0, 0, 0)), "HD webcam", 49.99m, "WBC678", 27, "Webcam" },
                    { new Guid("1690f4a0-b729-4a01-873a-d27c585cde4c"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1180), new TimeSpan(0, 0, 0, 0, 0)), "Professional hair dryer", 59.99m, "HDR567", 20, "Hair Dryer" },
                    { new Guid("1d4f3159-2af7-4631-ab0a-a7f20edb2d66"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1160), new TimeSpan(0, 0, 0, 0, 0)), "High-speed document scanner", 99.99m, "SCN345", 10, "Scanner" },
                    { new Guid("218519d2-cd32-4e63-8c5d-5b19c2e2e9ba"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, 0, 0, 0, 0)), "Latest model smartphone", 899.99m, "SMP456", 25, "Smartphone" },
                    { new Guid("2868c7ca-f9df-480b-8552-af80a4f91b89"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1150), new TimeSpan(0, 0, 0, 0, 0)), "Mechanical keyboard", 79.99m, "KYB456", 25, "Keyboard" },
                    { new Guid("357f9a0b-346a-4c01-8ed2-9f5005a8cb5f"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1080), new TimeSpan(0, 0, 0, 0, 0)), "Smartwatch with health tracking", 299.99m, "SMW012", 15, "Smartwatch" },
                    { new Guid("35dcdc75-a20c-4886-833f-37120182470d"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1130), new TimeSpan(0, 0, 0, 0, 0)), "4K Ultra HD television", 799.99m, "TVN901", 14, "Television" },
                    { new Guid("3aa5bc03-a313-4b5c-8657-7cf85ab82e51"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1140), new TimeSpan(0, 0, 0, 0, 0)), "Dolby Atmos soundbar", 299.99m, "SBR234", 21, "Soundbar" },
                    { new Guid("401ed72f-6eab-4f55-9325-37e74dc9c327"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1120), new TimeSpan(0, 0, 0, 0, 0)), "Front load washing machine", 699.99m, "WSM012", 7, "Washing Machine" },
                    { new Guid("4a7deb44-4cec-4ac2-9498-dd0aa2fd558e"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1110), new TimeSpan(0, 0, 0, 0, 0)), "High-speed blender", 59.99m, "BLD123", 35, "Blender" },
                    { new Guid("6537dd9f-84be-4ec9-a089-6a12affb0737"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1160), new TimeSpan(0, 0, 0, 0, 0)), "Wireless mouse", 29.99m, "MSE789", 40, "Mouse" },
                    { new Guid("686d597e-bc64-479c-aab9-9a766ed63a82"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1080), new TimeSpan(0, 0, 0, 0, 0)), "High resolution tablet", 499.99m, "TAB345", 20, "Tablet" },
                    { new Guid("6c0bb29e-45d3-40d6-9aa8-e86449e8e29d"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1090), new TimeSpan(0, 0, 0, 0, 0)), "Digital SLR camera", 799.99m, "CAM901", 8, "Camera" },
                    { new Guid("72242d86-f9b3-4c32-a826-84892174c7af"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1190), new TimeSpan(0, 0, 0, 0, 0)), "Automatic espresso machine", 399.99m, "ESM890", 11, "Espresso Machine" },
                    { new Guid("79722887-2e83-4457-8dac-8ba24f79188e"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1120), new TimeSpan(0, 0, 0, 0, 0)), "Double door refrigerator", 1099.99m, "RFR789", 5, "Refrigerator" },
                    { new Guid("8168f564-0b41-48fd-ac7d-ce087077a754"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1170), new TimeSpan(0, 0, 0, 0, 0)), "Activity and sleep tracker", 99.99m, "FTR901", 32, "Fitness Tracker" },
                    { new Guid("8ba89df0-6e67-4bed-88d7-b62f1722dafd"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1140), new TimeSpan(0, 0, 0, 0, 0)), "1TB external hard drive", 59.99m, "EHD890", 28, "External Hard Drive" },
                    { new Guid("8d9d6b1d-0dfb-4c6c-9f0e-d4db8898173f"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, 0, 0, 0, 0)), "Noise cancelling headphones", 199.99m, "HDP789", 50, "Headphones" },
                    { new Guid("9ab75f70-738c-40a6-b44f-5a40dcefc04c"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1120), new TimeSpan(0, 0, 0, 0, 0)), "Energy efficient air conditioner", 499.99m, "ACD345", 9, "Air Conditioner" },
                    { new Guid("9e050546-c17e-4681-8348-64106e5a2443"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1100), new TimeSpan(0, 0, 0, 0, 0)), "Compact microwave oven", 129.99m, "MWO890", 22, "Microwave Oven" },
                    { new Guid("b579cf92-efd5-4960-9405-e45957a56f0c"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1100), new TimeSpan(0, 0, 0, 0, 0)), "Fast boiling electric kettle", 39.99m, "EKT567", 60, "Electric Kettle" },
                    { new Guid("c34527c1-8790-44f3-8f6a-171b8f1929d0"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1180), new TimeSpan(0, 0, 0, 0, 0)), "Rechargeable electric toothbrush", 69.99m, "ETB234", 23, "Electric Toothbrush" },
                    { new Guid("e81b4b99-fb86-4af5-8209-8b0f15763557"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1130), new TimeSpan(0, 0, 0, 0, 0)), "Cordless vacuum cleaner", 149.99m, "VAC678", 30, "Vacuum Cleaner" },
                    { new Guid("f69ba2f2-9568-4e27-8c02-1fe81fe52d47"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1090), new TimeSpan(0, 0, 0, 0, 0)), "Next-gen gaming console", 499.99m, "GMC234", 12, "Gaming Console" },
                    { new Guid("fe14ff54-1c6c-45a8-bf62-9c5990da8573"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1090), new TimeSpan(0, 0, 0, 0, 0)), "Portable Bluetooth speaker", 89.99m, "BSP678", 40, "Bluetooth Speaker" },
                    { new Guid("fe4a39be-40db-4762-82af-6b031ab0cd16"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 51, 39, 215, DateTimeKind.Unspecified).AddTicks(1150), new TimeSpan(0, 0, 0, 0, 0)), "24-inch full HD monitor", 149.99m, "MNT123", 16, "Monitor" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03c85f68-84eb-4342-b5d1-514b853be3ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09ebc12a-dcfa-4847-94f5-f4ff69d4d37a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c23e156-b0bd-447b-9bea-c98a064d3ef5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0da731d3-1802-4a4f-8158-be973e147ce0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("167ec7b2-927d-421f-b935-22af153b5c55"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1690f4a0-b729-4a01-873a-d27c585cde4c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d4f3159-2af7-4631-ab0a-a7f20edb2d66"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("218519d2-cd32-4e63-8c5d-5b19c2e2e9ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2868c7ca-f9df-480b-8552-af80a4f91b89"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("357f9a0b-346a-4c01-8ed2-9f5005a8cb5f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35dcdc75-a20c-4886-833f-37120182470d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3aa5bc03-a313-4b5c-8657-7cf85ab82e51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("401ed72f-6eab-4f55-9325-37e74dc9c327"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a7deb44-4cec-4ac2-9498-dd0aa2fd558e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6537dd9f-84be-4ec9-a089-6a12affb0737"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("686d597e-bc64-479c-aab9-9a766ed63a82"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c0bb29e-45d3-40d6-9aa8-e86449e8e29d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72242d86-f9b3-4c32-a826-84892174c7af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("79722887-2e83-4457-8dac-8ba24f79188e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8168f564-0b41-48fd-ac7d-ce087077a754"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ba89df0-6e67-4bed-88d7-b62f1722dafd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d9d6b1d-0dfb-4c6c-9f0e-d4db8898173f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ab75f70-738c-40a6-b44f-5a40dcefc04c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e050546-c17e-4681-8348-64106e5a2443"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b579cf92-efd5-4960-9405-e45957a56f0c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c34527c1-8790-44f3-8f6a-171b8f1929d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e81b4b99-fb86-4af5-8209-8b0f15763557"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f69ba2f2-9568-4e27-8c02-1fe81fe52d47"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe14ff54-1c6c-45a8-bf62-9c5990da8573"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe4a39be-40db-4762-82af-6b031ab0cd16"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "Price", "ProductCode", "Stock", "Title" },
                values: new object[,]
                {
                    { new Guid("0b9cdcb9-a2cf-4676-b069-e386549f9386"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3680), new TimeSpan(0, -5, 0, 0, 0)), "Latest model smartphone", 899.99m, "SMP456", 25, "Smartphone" },
                    { new Guid("16c65138-db8d-457b-b64c-ec0f90aa44c8"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3760), new TimeSpan(0, -5, 0, 0, 0)), "4K Ultra HD television", 799.99m, "TVN901", 14, "Television" },
                    { new Guid("256d30f6-76da-49c0-93ef-a394c5142799"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3360), new TimeSpan(0, -5, 0, 0, 0)), "High performance laptop", 1200.99m, "LAP123", 10, "Laptop" },
                    { new Guid("2b19fc1f-7e5c-4072-93ae-2154ed8a0264"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3780), new TimeSpan(0, -5, 0, 0, 0)), "Wireless mouse", 29.99m, "MSE789", 40, "Mouse" },
                    { new Guid("31fc9572-1abd-447b-bf8a-24283bc3ac6e"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3710), new TimeSpan(0, -5, 0, 0, 0)), "Next-gen gaming console", 499.99m, "GMC234", 12, "Gaming Console" },
                    { new Guid("389c1a63-7249-49b7-8d71-d086c30a6bb8"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3780), new TimeSpan(0, -5, 0, 0, 0)), "Mechanical keyboard", 79.99m, "KYB456", 25, "Keyboard" },
                    { new Guid("3e9d6c5d-eb58-493b-b71e-a18cd873fb01"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3740), new TimeSpan(0, -5, 0, 0, 0)), "Front load washing machine", 699.99m, "WSM012", 7, "Washing Machine" },
                    { new Guid("4cd3198d-2f63-4f79-ae78-3dab0c2f1145"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3770), new TimeSpan(0, -5, 0, 0, 0)), "High-speed WiFi router", 99.99m, "RTR567", 45, "Router" },
                    { new Guid("4fd36778-c189-4b3b-a214-0e759a36c0ab"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3750), new TimeSpan(0, -5, 0, 0, 0)), "Energy efficient air conditioner", 499.99m, "ACD345", 9, "Air Conditioner" },
                    { new Guid("542fbc65-792d-467e-af93-a22c5771b720"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3710), new TimeSpan(0, -5, 0, 0, 0)), "Digital SLR camera", 799.99m, "CAM901", 8, "Camera" },
                    { new Guid("6d206f53-cc92-4fb4-ac40-ec5eb6208870"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3800), new TimeSpan(0, -5, 0, 0, 0)), "Activity and sleep tracker", 99.99m, "FTR901", 32, "Fitness Tracker" },
                    { new Guid("740aec81-e358-4d61-9cc3-39743f126fdd"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3740), new TimeSpan(0, -5, 0, 0, 0)), "Double door refrigerator", 1099.99m, "RFR789", 5, "Refrigerator" },
                    { new Guid("7db72d78-187d-48ca-b4cd-77d455065e7f"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3790), new TimeSpan(0, -5, 0, 0, 0)), "High-speed document scanner", 99.99m, "SCN345", 10, "Scanner" },
                    { new Guid("84a38b7e-01e6-4253-8a5f-c769b86e17a6"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3720), new TimeSpan(0, -5, 0, 0, 0)), "Compact microwave oven", 129.99m, "MWO890", 22, "Microwave Oven" },
                    { new Guid("853dde7f-6f88-4c21-8fe2-0f0fb3b5d0ef"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3770), new TimeSpan(0, -5, 0, 0, 0)), "1TB external hard drive", 59.99m, "EHD890", 28, "External Hard Drive" },
                    { new Guid("86249afd-3c34-410e-8a8d-07f7b9319f3f"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3700), new TimeSpan(0, -5, 0, 0, 0)), "Portable Bluetooth speaker", 89.99m, "BSP678", 40, "Bluetooth Speaker" },
                    { new Guid("998cc45a-7bc0-4c19-ad3b-f45eaa35faee"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3810), new TimeSpan(0, -5, 0, 0, 0)), "Rechargeable electric toothbrush", 69.99m, "ETB234", 23, "Electric Toothbrush" },
                    { new Guid("99b29f56-c34b-4ee8-871a-670655708338"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3690), new TimeSpan(0, -5, 0, 0, 0)), "Noise cancelling headphones", 199.99m, "HDP789", 50, "Headphones" },
                    { new Guid("adc99544-f06b-4c3a-ab9f-684735e57d38"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3730), new TimeSpan(0, -5, 0, 0, 0)), "High-speed blender", 59.99m, "BLD123", 35, "Blender" },
                    { new Guid("b817b853-00a2-4661-bb39-0d58bc56b934"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3760), new TimeSpan(0, -5, 0, 0, 0)), "Dolby Atmos soundbar", 299.99m, "SBR234", 21, "Soundbar" },
                    { new Guid("c5249b52-b01d-442b-9797-0c7349b52e18"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3800), new TimeSpan(0, -5, 0, 0, 0)), "HD webcam", 49.99m, "WBC678", 27, "Webcam" },
                    { new Guid("c98975ad-db22-448a-a91f-9ece217cc836"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3690), new TimeSpan(0, -5, 0, 0, 0)), "Smartwatch with health tracking", 299.99m, "SMW012", 15, "Smartwatch" },
                    { new Guid("cb0cb708-932d-4d74-874f-f0aa72ca002a"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3820), new TimeSpan(0, -5, 0, 0, 0)), "Automatic espresso machine", 399.99m, "ESM890", 11, "Espresso Machine" },
                    { new Guid("d2d2a4f9-f74b-4a4d-8aea-20493c2991d5"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3750), new TimeSpan(0, -5, 0, 0, 0)), "Cordless vacuum cleaner", 149.99m, "VAC678", 30, "Vacuum Cleaner" },
                    { new Guid("e1830ee0-e4d1-4d07-bcf6-ef9cb8a85f4a"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3720), new TimeSpan(0, -5, 0, 0, 0)), "Fast boiling electric kettle", 39.99m, "EKT567", 60, "Electric Kettle" },
                    { new Guid("f36b4c36-846d-4061-966f-13964784b432"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3700), new TimeSpan(0, -5, 0, 0, 0)), "High resolution tablet", 499.99m, "TAB345", 20, "Tablet" },
                    { new Guid("f4ebe020-f618-4ef3-b30c-244a0e8e7f4a"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3810), new TimeSpan(0, -5, 0, 0, 0)), "Professional hair dryer", 59.99m, "HDR567", 20, "Hair Dryer" },
                    { new Guid("f55a7c21-aba7-4e07-bbcb-a6d613a614dd"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3780), new TimeSpan(0, -5, 0, 0, 0)), "24-inch full HD monitor", 149.99m, "MNT123", 16, "Monitor" },
                    { new Guid("f88fa99e-cbbf-41f0-80b5-93789547770d"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3790), new TimeSpan(0, -5, 0, 0, 0)), "All-in-one printer", 199.99m, "PRT012", 13, "Printer" },
                    { new Guid("f9bc788a-24eb-4082-9866-8f0fb08ad970"), new DateTimeOffset(new DateTime(2024, 8, 4, 10, 48, 48, 818, DateTimeKind.Unspecified).AddTicks(3730), new TimeSpan(0, -5, 0, 0, 0)), "Automatic coffee maker", 79.99m, "CFM456", 18, "Coffee Maker" }
                });
        }
    }
}
