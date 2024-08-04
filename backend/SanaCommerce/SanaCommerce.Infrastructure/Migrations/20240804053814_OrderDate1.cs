using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SanaCommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class OrderDate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("086a4e70-243c-4cc8-a73f-31305f4749b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("101376dd-c649-44bc-acb6-7f6ffa5d1c14"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("154cc3c2-6a5c-4d97-9145-0eee939b2a27"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("232d8063-ebb4-4224-910e-02d9443af52b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3432d06a-8f82-4504-aec5-d34b048561a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c7b184e-6af5-4ea4-bc15-f2c429497e0b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d101d87-b8df-428b-8e05-9c503829246a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e869fe9-74ad-48f8-b8a5-16baafe6489c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5dc14b47-fb5e-41b8-8a42-4daaca8a4f02"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("693fe7e4-7b4d-412c-923b-0e8527f43f7b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("701e3d14-bf73-4cb5-a9cf-476c623fab29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7229b9a7-7cf1-45da-afc7-7d8869546bd3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7603529a-1cfe-49ba-b593-861e873c3deb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bd685e2-79e8-47a9-b123-0aa4cfa3b997"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89b4037c-e72c-4de3-b33f-68e9fdc917e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93efdde4-08dc-4cf8-b925-8f30cbadda09"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96213f4c-6fd8-45e9-9ec9-bbb55eadaf9c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99dccdda-8010-4263-9a03-3c17aa4a3f10"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9debed6b-1106-4ab6-9a9b-37a0a86cb149"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a70ade4a-bf8b-43de-ac53-476f717040f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae01055f-cca8-444d-9dd5-bd91f6a61337"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb63d616-31e2-4d4b-8d8c-94d16f76f717"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5fe0492-7be2-44c7-9591-83d3861ebab0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3872b1c-d7f7-4f19-8c0e-4076e519480f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6efe142-f780-42c6-8226-0a5aac388b3e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1b96f7b-a5cb-4d24-baec-e2875bc5423b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e96b6e4a-b189-4e9e-b23d-98e868cfbee6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f50a90e0-cd38-4035-9ef1-aff7cbcc7417"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7b321b0-0688-490c-8abd-45a0d994b04c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7e5e109-6007-4a4c-8806-9ee903a273a3"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Price", "ProductCode", "Stock", "Title" },
                values: new object[,]
                {
                    { new Guid("086a4e70-243c-4cc8-a73f-31305f4749b4"), "All-in-one printer", 199.99m, "PRT012", 13, "Printer" },
                    { new Guid("101376dd-c649-44bc-acb6-7f6ffa5d1c14"), "Fast boiling electric kettle", 39.99m, "EKT567", 60, "Electric Kettle" },
                    { new Guid("154cc3c2-6a5c-4d97-9145-0eee939b2a27"), "Next-gen gaming console", 499.99m, "GMC234", 12, "Gaming Console" },
                    { new Guid("232d8063-ebb4-4224-910e-02d9443af52b"), "High resolution tablet", 499.99m, "TAB345", 20, "Tablet" },
                    { new Guid("3432d06a-8f82-4504-aec5-d34b048561a6"), "Automatic coffee maker", 79.99m, "CFM456", 18, "Coffee Maker" },
                    { new Guid("4c7b184e-6af5-4ea4-bc15-f2c429497e0b"), "Smartwatch with health tracking", 299.99m, "SMW012", 15, "Smartwatch" },
                    { new Guid("4d101d87-b8df-428b-8e05-9c503829246a"), "Portable Bluetooth speaker", 89.99m, "BSP678", 40, "Bluetooth Speaker" },
                    { new Guid("4e869fe9-74ad-48f8-b8a5-16baafe6489c"), "Cordless vacuum cleaner", 149.99m, "VAC678", 30, "Vacuum Cleaner" },
                    { new Guid("5dc14b47-fb5e-41b8-8a42-4daaca8a4f02"), "Rechargeable electric toothbrush", 69.99m, "ETB234", 23, "Electric Toothbrush" },
                    { new Guid("693fe7e4-7b4d-412c-923b-0e8527f43f7b"), "Automatic espresso machine", 399.99m, "ESM890", 11, "Espresso Machine" },
                    { new Guid("701e3d14-bf73-4cb5-a9cf-476c623fab29"), "Compact microwave oven", 129.99m, "MWO890", 22, "Microwave Oven" },
                    { new Guid("7229b9a7-7cf1-45da-afc7-7d8869546bd3"), "Wireless mouse", 29.99m, "MSE789", 40, "Mouse" },
                    { new Guid("7603529a-1cfe-49ba-b593-861e873c3deb"), "Noise cancelling headphones", 199.99m, "HDP789", 50, "Headphones" },
                    { new Guid("7bd685e2-79e8-47a9-b123-0aa4cfa3b997"), "High performance laptop", 1200.99m, "LAP123", 10, "Laptop" },
                    { new Guid("89b4037c-e72c-4de3-b33f-68e9fdc917e7"), "Mechanical keyboard", 79.99m, "KYB456", 25, "Keyboard" },
                    { new Guid("93efdde4-08dc-4cf8-b925-8f30cbadda09"), "Digital SLR camera", 799.99m, "CAM901", 8, "Camera" },
                    { new Guid("96213f4c-6fd8-45e9-9ec9-bbb55eadaf9c"), "24-inch full HD monitor", 149.99m, "MNT123", 16, "Monitor" },
                    { new Guid("99dccdda-8010-4263-9a03-3c17aa4a3f10"), "1TB external hard drive", 59.99m, "EHD890", 28, "External Hard Drive" },
                    { new Guid("9debed6b-1106-4ab6-9a9b-37a0a86cb149"), "4K Ultra HD television", 799.99m, "TVN901", 14, "Television" },
                    { new Guid("a70ade4a-bf8b-43de-ac53-476f717040f0"), "Double door refrigerator", 1099.99m, "RFR789", 5, "Refrigerator" },
                    { new Guid("ae01055f-cca8-444d-9dd5-bd91f6a61337"), "High-speed blender", 59.99m, "BLD123", 35, "Blender" },
                    { new Guid("bb63d616-31e2-4d4b-8d8c-94d16f76f717"), "High-speed document scanner", 99.99m, "SCN345", 10, "Scanner" },
                    { new Guid("c5fe0492-7be2-44c7-9591-83d3861ebab0"), "Latest model smartphone", 899.99m, "SMP456", 25, "Smartphone" },
                    { new Guid("d3872b1c-d7f7-4f19-8c0e-4076e519480f"), "Front load washing machine", 699.99m, "WSM012", 7, "Washing Machine" },
                    { new Guid("d6efe142-f780-42c6-8226-0a5aac388b3e"), "HD webcam", 49.99m, "WBC678", 27, "Webcam" },
                    { new Guid("e1b96f7b-a5cb-4d24-baec-e2875bc5423b"), "Energy efficient air conditioner", 499.99m, "ACD345", 9, "Air Conditioner" },
                    { new Guid("e96b6e4a-b189-4e9e-b23d-98e868cfbee6"), "Dolby Atmos soundbar", 299.99m, "SBR234", 21, "Soundbar" },
                    { new Guid("f50a90e0-cd38-4035-9ef1-aff7cbcc7417"), "High-speed WiFi router", 99.99m, "RTR567", 45, "Router" },
                    { new Guid("f7b321b0-0688-490c-8abd-45a0d994b04c"), "Activity and sleep tracker", 99.99m, "FTR901", 32, "Fitness Tracker" },
                    { new Guid("f7e5e109-6007-4a4c-8806-9ee903a273a3"), "Professional hair dryer", 59.99m, "HDR567", 20, "Hair Dryer" }
                });
        }
    }
}
