using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SanaCommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProductDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0065ddf5-cb40-4070-888c-b0f2338444dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06095f7c-e5fc-4566-a255-7559615035ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08b756e2-baad-4422-9b68-e10b130d3cb4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0aedcea3-6a5e-4478-9f0e-702abc832d58"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e2e63af-ac0a-498b-bbf3-22baec83476f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2194f53f-05b8-45bd-898d-4f4fa8ffccd4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28ec847a-5d8c-431f-8220-e0756a0f589f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a9ab043-0c6a-4442-8253-414129a691e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3fac869d-1c01-4857-9a29-15910784d699"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("46a32d62-0f91-49f8-9092-a4a9a533309b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("46d0e1f9-a68c-4ad0-9ef4-630fda64cf19"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ff296b1-8c90-4765-aec8-5c7b17bcc4f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5015dbcb-4b52-45c3-8635-b7eec97dd652"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54b3d25c-6d3b-42cc-87b4-8cd276f7c877"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71cefd95-2a74-4781-b4eb-82123be4a99e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76319fa0-eb12-4cc1-a4cd-f878c87e77ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("781827ea-142a-4fb5-8b4c-fe6e36d8982a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86a1bd9b-abe8-4f89-8b63-645bc1a2b3e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a9eb7b6-12b5-4e83-9b2b-6ee407a72aa2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96d68020-640b-4afe-8b8c-c93513dc40d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ab3802d-97dd-45e1-a16d-784bf0f2aef2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fa08ac5-5177-4ea8-ab02-dac1a481aabd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca7cd202-09ec-415f-ab69-623da4b2e54b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc7c82e0-4f5d-4f48-a8a3-3656645657cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df0602e7-49df-4343-9546-e6e84f328256"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0ebbdda-ccd3-4226-b9c2-974c1d53ed7c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee59ba13-ea67-4ef1-8878-495de9a5ee6a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5ede965-02e3-4522-bee8-f93e21c3f590"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fceccf79-32bf-47fb-83a4-1b3a309672f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe8a6297-7ccd-4224-96f2-7cbfa72fab3c"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Price", "ProductCode", "Stock", "Title" },
                values: new object[,]
                {
                    { new Guid("0065ddf5-cb40-4070-888c-b0f2338444dc"), "High-speed document scanner", 99.99m, "SCN345", 10, "Scanner" },
                    { new Guid("06095f7c-e5fc-4566-a255-7559615035ba"), "4K Ultra HD television", 799.99m, "TVN901", 14, "Television" },
                    { new Guid("08b756e2-baad-4422-9b68-e10b130d3cb4"), "Latest model smartphone", 899.99m, "SMP456", 25, "Smartphone" },
                    { new Guid("0aedcea3-6a5e-4478-9f0e-702abc832d58"), "Rechargeable electric toothbrush", 69.99m, "ETB234", 23, "Electric Toothbrush" },
                    { new Guid("0e2e63af-ac0a-498b-bbf3-22baec83476f"), "High-speed blender", 59.99m, "BLD123", 35, "Blender" },
                    { new Guid("2194f53f-05b8-45bd-898d-4f4fa8ffccd4"), "Energy efficient air conditioner", 499.99m, "ACD345", 9, "Air Conditioner" },
                    { new Guid("28ec847a-5d8c-431f-8220-e0756a0f589f"), "Professional hair dryer", 59.99m, "HDR567", 20, "Hair Dryer" },
                    { new Guid("2a9ab043-0c6a-4442-8253-414129a691e6"), "Digital SLR camera", 799.99m, "CAM901", 8, "Camera" },
                    { new Guid("3fac869d-1c01-4857-9a29-15910784d699"), "Smartwatch with health tracking", 299.99m, "SMW012", 15, "Smartwatch" },
                    { new Guid("46a32d62-0f91-49f8-9092-a4a9a533309b"), "24-inch full HD monitor", 149.99m, "MNT123", 16, "Monitor" },
                    { new Guid("46d0e1f9-a68c-4ad0-9ef4-630fda64cf19"), "Wireless mouse", 29.99m, "MSE789", 40, "Mouse" },
                    { new Guid("4ff296b1-8c90-4765-aec8-5c7b17bcc4f5"), "High-speed WiFi router", 99.99m, "RTR567", 45, "Router" },
                    { new Guid("5015dbcb-4b52-45c3-8635-b7eec97dd652"), "High performance laptop", 1200.99m, "LAP123", 10, "Laptop" },
                    { new Guid("54b3d25c-6d3b-42cc-87b4-8cd276f7c877"), "High resolution tablet", 499.99m, "TAB345", 20, "Tablet" },
                    { new Guid("71cefd95-2a74-4781-b4eb-82123be4a99e"), "Double door refrigerator", 1099.99m, "RFR789", 5, "Refrigerator" },
                    { new Guid("76319fa0-eb12-4cc1-a4cd-f878c87e77ca"), "Noise cancelling headphones", 199.99m, "HDP789", 50, "Headphones" },
                    { new Guid("781827ea-142a-4fb5-8b4c-fe6e36d8982a"), "Cordless vacuum cleaner", 149.99m, "VAC678", 30, "Vacuum Cleaner" },
                    { new Guid("86a1bd9b-abe8-4f89-8b63-645bc1a2b3e1"), "1TB external hard drive", 59.99m, "EHD890", 28, "External Hard Drive" },
                    { new Guid("8a9eb7b6-12b5-4e83-9b2b-6ee407a72aa2"), "Compact microwave oven", 129.99m, "MWO890", 22, "Microwave Oven" },
                    { new Guid("96d68020-640b-4afe-8b8c-c93513dc40d5"), "Next-gen gaming console", 499.99m, "GMC234", 12, "Gaming Console" },
                    { new Guid("9ab3802d-97dd-45e1-a16d-784bf0f2aef2"), "Dolby Atmos soundbar", 299.99m, "SBR234", 21, "Soundbar" },
                    { new Guid("9fa08ac5-5177-4ea8-ab02-dac1a481aabd"), "Activity and sleep tracker", 99.99m, "FTR901", 32, "Fitness Tracker" },
                    { new Guid("ca7cd202-09ec-415f-ab69-623da4b2e54b"), "Portable Bluetooth speaker", 89.99m, "BSP678", 40, "Bluetooth Speaker" },
                    { new Guid("dc7c82e0-4f5d-4f48-a8a3-3656645657cb"), "Front load washing machine", 699.99m, "WSM012", 7, "Washing Machine" },
                    { new Guid("df0602e7-49df-4343-9546-e6e84f328256"), "HD webcam", 49.99m, "WBC678", 27, "Webcam" },
                    { new Guid("e0ebbdda-ccd3-4226-b9c2-974c1d53ed7c"), "All-in-one printer", 199.99m, "PRT012", 13, "Printer" },
                    { new Guid("ee59ba13-ea67-4ef1-8878-495de9a5ee6a"), "Fast boiling electric kettle", 39.99m, "EKT567", 60, "Electric Kettle" },
                    { new Guid("f5ede965-02e3-4522-bee8-f93e21c3f590"), "Automatic coffee maker", 79.99m, "CFM456", 18, "Coffee Maker" },
                    { new Guid("fceccf79-32bf-47fb-83a4-1b3a309672f4"), "Automatic espresso machine", 399.99m, "ESM890", 11, "Espresso Machine" },
                    { new Guid("fe8a6297-7ccd-4224-96f2-7cbfa72fab3c"), "Mechanical keyboard", 79.99m, "KYB456", 25, "Keyboard" }
                });
        }
    }
}
