using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SanaCommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("353e1d6f-d7be-40a1-bc73-256e54abc630"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1291e60e-dde0-4c8b-b622-2b394cfc44e5"), "Home" },
                    { new Guid("1f31e90d-faa1-4eae-b54d-3c33aafc2896"), "Books" },
                    { new Guid("5a0f889b-5e91-4d83-bb0e-0d6823d3d292"), "Clothing" },
                    { new Guid("bdb2d6e1-8c5e-4b28-8ed8-53c8b57a17f3"), "Electronics" },
                    { new Guid("d75e74ff-77ee-4486-9916-1c842e36a6c7"), "Toys" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Price", "ProductCode", "Stock", "Title" },
                values: new object[,]
                {
                    { new Guid("0112ad75-29d6-4b13-a16c-7a15eeef63b1"), "Noise cancelling headphones", 199.99m, "HDP789", 50, "Headphones" },
                    { new Guid("03d9e34d-e4cf-41f3-9a23-dbaadb0f471a"), "Front load washing machine", 699.99m, "WSM012", 7, "Washing Machine" },
                    { new Guid("046ead53-ce3e-47f7-873c-1b9f51b7941d"), "Professional hair dryer", 59.99m, "HDR567", 20, "Hair Dryer" },
                    { new Guid("19ade003-cae5-4eaa-82ef-330cf4b94e72"), "Portable Bluetooth speaker", 89.99m, "BSP678", 40, "Bluetooth Speaker" },
                    { new Guid("20c4cab1-4fcf-4051-ad7c-cafab29382af"), "HD webcam", 49.99m, "WBC678", 27, "Webcam" },
                    { new Guid("230ad032-4a1d-437f-93e3-102e14260184"), "High-speed WiFi router", 99.99m, "RTR567", 45, "Router" },
                    { new Guid("287f7ef8-4e1b-4457-ba52-d05753133da0"), "High resolution tablet", 499.99m, "TAB345", 20, "Tablet" },
                    { new Guid("2a650ec4-27ca-43e2-8a28-321a9f0adf72"), "Rechargeable electric toothbrush", 69.99m, "ETB234", 23, "Electric Toothbrush" },
                    { new Guid("39e9b344-9c86-40f1-870c-5a6a089e2371"), "High-speed document scanner", 99.99m, "SCN345", 10, "Scanner" },
                    { new Guid("3de93926-facb-4302-930b-1419a8ba2425"), "Next-gen gaming console", 499.99m, "GMC234", 12, "Gaming Console" },
                    { new Guid("472f4f78-2c60-4343-b770-02baf524b92c"), "Activity and sleep tracker", 99.99m, "FTR901", 32, "Fitness Tracker" },
                    { new Guid("5bdfec9a-7d7d-4512-8cd4-1afdd89f24f9"), "Fast boiling electric kettle", 39.99m, "EKT567", 60, "Electric Kettle" },
                    { new Guid("5dc08406-5768-4395-967d-7a2c8bfb49b3"), "Double door refrigerator", 1099.99m, "RFR789", 5, "Refrigerator" },
                    { new Guid("62f7fbcd-7df4-473c-a57b-df4290f3a2e6"), "Compact microwave oven", 129.99m, "MWO890", 22, "Microwave Oven" },
                    { new Guid("6ed181c6-bc62-44cc-a2b9-150e804a0e39"), "Automatic coffee maker", 79.99m, "CFM456", 18, "Coffee Maker" },
                    { new Guid("7c2d76ca-c84f-48d1-bedc-f1cbc3fe8e05"), "Digital SLR camera", 799.99m, "CAM901", 8, "Camera" },
                    { new Guid("87cd360a-601d-4c5a-a7d3-9c4d5e689876"), "Latest model smartphone", 899.99m, "SMP456", 25, "Smartphone" },
                    { new Guid("88b0942b-1caa-49a3-9a61-3191f4e4b08d"), "24-inch full HD monitor", 149.99m, "MNT123", 16, "Monitor" },
                    { new Guid("8c7836a4-5ef1-40b0-9a9f-3431ab261661"), "Automatic espresso machine", 399.99m, "ESM890", 11, "Espresso Machine" },
                    { new Guid("8e1dbab3-7fad-4d4c-9bf3-e15bd5059440"), "All-in-one printer", 199.99m, "PRT012", 13, "Printer" },
                    { new Guid("8e33cb1f-fc84-4493-857d-09b6b5eb59aa"), "High performance laptop", 1200.99m, "LAP123", 10, "Laptop" },
                    { new Guid("8f16abdc-b411-4db2-9f44-1fd979338521"), "Smartwatch with health tracking", 299.99m, "SMW012", 15, "Smartwatch" },
                    { new Guid("9a4da6a9-8c83-4cc8-8db2-758a3008b5f5"), "4K Ultra HD television", 799.99m, "TVN901", 14, "Television" },
                    { new Guid("9f1d03ae-a1b6-4834-aeec-bc5912fef449"), "1TB external hard drive", 59.99m, "EHD890", 28, "External Hard Drive" },
                    { new Guid("b749794b-15b0-4417-9cf1-7ba467b4af6a"), "Energy efficient air conditioner", 499.99m, "ACD345", 9, "Air Conditioner" },
                    { new Guid("b9760403-d5e1-4f64-adf4-09820299b6ae"), "Cordless vacuum cleaner", 149.99m, "VAC678", 30, "Vacuum Cleaner" },
                    { new Guid("c635f558-ebf3-47b2-9a83-bd9b71ce284b"), "Wireless mouse", 29.99m, "MSE789", 40, "Mouse" },
                    { new Guid("c6f1e7b9-3029-46d4-af69-b21112f17c51"), "Dolby Atmos soundbar", 299.99m, "SBR234", 21, "Soundbar" },
                    { new Guid("d19b7f60-3326-4bc5-9add-826871024a2a"), "High-speed blender", 59.99m, "BLD123", 35, "Blender" },
                    { new Guid("d4481a19-3cda-4003-8090-f6ce067b6409"), "Mechanical keyboard", 79.99m, "KYB456", 25, "Keyboard" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1291e60e-dde0-4c8b-b622-2b394cfc44e5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1f31e90d-faa1-4eae-b54d-3c33aafc2896"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5a0f889b-5e91-4d83-bb0e-0d6823d3d292"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bdb2d6e1-8c5e-4b28-8ed8-53c8b57a17f3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d75e74ff-77ee-4486-9916-1c842e36a6c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0112ad75-29d6-4b13-a16c-7a15eeef63b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03d9e34d-e4cf-41f3-9a23-dbaadb0f471a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("046ead53-ce3e-47f7-873c-1b9f51b7941d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19ade003-cae5-4eaa-82ef-330cf4b94e72"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20c4cab1-4fcf-4051-ad7c-cafab29382af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("230ad032-4a1d-437f-93e3-102e14260184"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("287f7ef8-4e1b-4457-ba52-d05753133da0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a650ec4-27ca-43e2-8a28-321a9f0adf72"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39e9b344-9c86-40f1-870c-5a6a089e2371"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3de93926-facb-4302-930b-1419a8ba2425"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("472f4f78-2c60-4343-b770-02baf524b92c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5bdfec9a-7d7d-4512-8cd4-1afdd89f24f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5dc08406-5768-4395-967d-7a2c8bfb49b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62f7fbcd-7df4-473c-a57b-df4290f3a2e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ed181c6-bc62-44cc-a2b9-150e804a0e39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7c2d76ca-c84f-48d1-bedc-f1cbc3fe8e05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("87cd360a-601d-4c5a-a7d3-9c4d5e689876"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88b0942b-1caa-49a3-9a61-3191f4e4b08d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8c7836a4-5ef1-40b0-9a9f-3431ab261661"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e1dbab3-7fad-4d4c-9bf3-e15bd5059440"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e33cb1f-fc84-4493-857d-09b6b5eb59aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8f16abdc-b411-4db2-9f44-1fd979338521"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a4da6a9-8c83-4cc8-8db2-758a3008b5f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f1d03ae-a1b6-4834-aeec-bc5912fef449"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b749794b-15b0-4417-9cf1-7ba467b4af6a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9760403-d5e1-4f64-adf4-09820299b6ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c635f558-ebf3-47b2-9a83-bd9b71ce284b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6f1e7b9-3029-46d4-af69-b21112f17c51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d19b7f60-3326-4bc5-9add-826871024a2a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4481a19-3cda-4003-8090-f6ce067b6409"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("353e1d6f-d7be-40a1-bc73-256e54abc630"), "Categoria 1" });
        }
    }
}
