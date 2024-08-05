using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SanaCommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProductDate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("05ee5e3e-c8bc-4db5-b685-f4e977efd75f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1057a5da-96b5-4941-a0fc-ecfabecb93cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d02ff3f-53b0-4dbb-931c-2554ef5c5dca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("200b324b-d71a-4d6a-87ba-9bfff56d609c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ee23024-52c7-4c4a-b057-3a76ac1cd6cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a46592e-7108-4d80-a15a-d3419033ccbd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b8a3a62-4a03-42bb-88c9-fe2d6ea73c86"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4fd96447-47fa-456e-afea-7c2284d747b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52e8e952-ae6d-4031-a49d-3c3dfd85e1d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53b5a077-bf89-4510-b6a1-196380076a13"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53c9409c-2e26-4312-ba82-dbf1965ecbb7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("608d25d5-b4ac-415d-b483-c0b97a2b8bf8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f920daa-b650-4471-b801-749ac9d38d6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7393c81f-19ae-4fd6-a7ea-d2a1832e5ab7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("75a7e3f2-b009-4a57-9e5d-d343eac0cf9a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("766fa99f-8628-49f7-ae08-844735816573"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76e1598a-697e-456d-9411-00142293a24a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7898d1c9-824b-469d-9859-1a3c4e54d8ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7cf1726a-8656-4e0a-8051-061b2736ec47"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89ccdb88-42c3-495d-96df-c11aa264ca76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1b08569-ed89-4235-bc65-bee8abd5dd68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b117cfbc-b5dc-4798-894e-4159c56ca8d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca63d43b-fce4-4682-9abc-3ea7dc1c13e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d577e474-1ef5-4d40-b1eb-0d7bb406e835"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5c4841f-c5d7-42dd-b3d9-fff8548787bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7f3c81b-2834-4a2a-b963-156f9ee4bbae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef367271-6271-4a7b-bd7d-e5c505fecdfb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f72af54d-a07a-4d2b-b476-924455f93474"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe3a7d93-b1c3-4f8c-94ee-301b144b203f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff095ddd-9a9d-4269-80e9-7f0b3ee7ad6f"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("05ee5e3e-c8bc-4db5-b685-f4e977efd75f"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9000), new TimeSpan(0, 0, 0, 0, 0)), "Noise cancelling headphones", 199.99m, "HDP789", 50, "Headphones" },
                    { new Guid("1057a5da-96b5-4941-a0fc-ecfabecb93cb"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9020), new TimeSpan(0, 0, 0, 0, 0)), "Portable Bluetooth speaker", 89.99m, "BSP678", 40, "Bluetooth Speaker" },
                    { new Guid("1d02ff3f-53b0-4dbb-931c-2554ef5c5dca"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9070), new TimeSpan(0, 0, 0, 0, 0)), "Dolby Atmos soundbar", 299.99m, "SBR234", 21, "Soundbar" },
                    { new Guid("200b324b-d71a-4d6a-87ba-9bfff56d609c"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9020), new TimeSpan(0, 0, 0, 0, 0)), "Digital SLR camera", 799.99m, "CAM901", 8, "Camera" },
                    { new Guid("2ee23024-52c7-4c4a-b057-3a76ac1cd6cf"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9030), new TimeSpan(0, 0, 0, 0, 0)), "Next-gen gaming console", 499.99m, "GMC234", 12, "Gaming Console" },
                    { new Guid("3a46592e-7108-4d80-a15a-d3419033ccbd"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9080), new TimeSpan(0, 0, 0, 0, 0)), "Mechanical keyboard", 79.99m, "KYB456", 25, "Keyboard" },
                    { new Guid("4b8a3a62-4a03-42bb-88c9-fe2d6ea73c86"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9030), new TimeSpan(0, 0, 0, 0, 0)), "Fast boiling electric kettle", 39.99m, "EKT567", 60, "Electric Kettle" },
                    { new Guid("4fd96447-47fa-456e-afea-7c2284d747b7"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9040), new TimeSpan(0, 0, 0, 0, 0)), "Automatic coffee maker", 79.99m, "CFM456", 18, "Coffee Maker" },
                    { new Guid("52e8e952-ae6d-4031-a49d-3c3dfd85e1d9"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), "HD webcam", 49.99m, "WBC678", 27, "Webcam" },
                    { new Guid("53b5a077-bf89-4510-b6a1-196380076a13"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9110), new TimeSpan(0, 0, 0, 0, 0)), "Automatic espresso machine", 399.99m, "ESM890", 11, "Espresso Machine" },
                    { new Guid("53c9409c-2e26-4312-ba82-dbf1965ecbb7"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9080), new TimeSpan(0, 0, 0, 0, 0)), "24-inch full HD monitor", 149.99m, "MNT123", 16, "Monitor" },
                    { new Guid("608d25d5-b4ac-415d-b483-c0b97a2b8bf8"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9060), new TimeSpan(0, 0, 0, 0, 0)), "Cordless vacuum cleaner", 149.99m, "VAC678", 30, "Vacuum Cleaner" },
                    { new Guid("6f920daa-b650-4471-b801-749ac9d38d6e"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9090), new TimeSpan(0, 0, 0, 0, 0)), "All-in-one printer", 199.99m, "PRT012", 13, "Printer" },
                    { new Guid("7393c81f-19ae-4fd6-a7ea-d2a1832e5ab7"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9030), new TimeSpan(0, 0, 0, 0, 0)), "Compact microwave oven", 129.99m, "MWO890", 22, "Microwave Oven" },
                    { new Guid("75a7e3f2-b009-4a57-9e5d-d343eac0cf9a"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9050), new TimeSpan(0, 0, 0, 0, 0)), "Front load washing machine", 699.99m, "WSM012", 7, "Washing Machine" },
                    { new Guid("766fa99f-8628-49f7-ae08-844735816573"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9110), new TimeSpan(0, 0, 0, 0, 0)), "Professional hair dryer", 59.99m, "HDR567", 20, "Hair Dryer" },
                    { new Guid("76e1598a-697e-456d-9411-00142293a24a"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9090), new TimeSpan(0, 0, 0, 0, 0)), "High-speed document scanner", 99.99m, "SCN345", 10, "Scanner" },
                    { new Guid("7898d1c9-824b-469d-9859-1a3c4e54d8ba"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9070), new TimeSpan(0, 0, 0, 0, 0)), "High-speed WiFi router", 99.99m, "RTR567", 45, "Router" },
                    { new Guid("7cf1726a-8656-4e0a-8051-061b2736ec47"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9060), new TimeSpan(0, 0, 0, 0, 0)), "4K Ultra HD television", 799.99m, "TVN901", 14, "Television" },
                    { new Guid("89ccdb88-42c3-495d-96df-c11aa264ca76"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9040), new TimeSpan(0, 0, 0, 0, 0)), "High-speed blender", 59.99m, "BLD123", 35, "Blender" },
                    { new Guid("a1b08569-ed89-4235-bc65-bee8abd5dd68"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9070), new TimeSpan(0, 0, 0, 0, 0)), "1TB external hard drive", 59.99m, "EHD890", 28, "External Hard Drive" },
                    { new Guid("b117cfbc-b5dc-4798-894e-4159c56ca8d6"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9090), new TimeSpan(0, 0, 0, 0, 0)), "Wireless mouse", 29.99m, "MSE789", 40, "Mouse" },
                    { new Guid("ca63d43b-fce4-4682-9abc-3ea7dc1c13e6"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(8980), new TimeSpan(0, 0, 0, 0, 0)), "High performance laptop", 1200.99m, "LAP123", 10, "Laptop" },
                    { new Guid("d577e474-1ef5-4d40-b1eb-0d7bb406e835"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), "Activity and sleep tracker", 99.99m, "FTR901", 32, "Fitness Tracker" },
                    { new Guid("d5c4841f-c5d7-42dd-b3d9-fff8548787bf"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9010), new TimeSpan(0, 0, 0, 0, 0)), "High resolution tablet", 499.99m, "TAB345", 20, "Tablet" },
                    { new Guid("e7f3c81b-2834-4a2a-b963-156f9ee4bbae"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), "Rechargeable electric toothbrush", 69.99m, "ETB234", 23, "Electric Toothbrush" },
                    { new Guid("ef367271-6271-4a7b-bd7d-e5c505fecdfb"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9050), new TimeSpan(0, 0, 0, 0, 0)), "Double door refrigerator", 1099.99m, "RFR789", 5, "Refrigerator" },
                    { new Guid("f72af54d-a07a-4d2b-b476-924455f93474"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9050), new TimeSpan(0, 0, 0, 0, 0)), "Energy efficient air conditioner", 499.99m, "ACD345", 9, "Air Conditioner" },
                    { new Guid("fe3a7d93-b1c3-4f8c-94ee-301b144b203f"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9000), new TimeSpan(0, 0, 0, 0, 0)), "Latest model smartphone", 899.99m, "SMP456", 25, "Smartphone" },
                    { new Guid("ff095ddd-9a9d-4269-80e9-7f0b3ee7ad6f"), new DateTimeOffset(new DateTime(2024, 8, 4, 15, 43, 44, 461, DateTimeKind.Unspecified).AddTicks(9010), new TimeSpan(0, 0, 0, 0, 0)), "Smartwatch with health tracking", 299.99m, "SMW012", 15, "Smartwatch" }
                });
        }
    }
}
