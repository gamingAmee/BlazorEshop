using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Grafikkort" },
                    { 2, "Bærbar" },
                    { 3, "Mobil" },
                    { 4, "TV" },
                    { 5, "Tastatur" },
                    { 6, "Mus" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { 9, "LG" },
                    { 8, "Samsung" },
                    { 7, "MSI" },
                    { 6, "HP" },
                    { 3, "Apple" },
                    { 4, "Lenovo" },
                    { 10, "Razer" },
                    { 2, "Acer" },
                    { 1, "ASUS" },
                    { 5, "DELL" },
                    { 11, "Steelseries" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ManufacturerId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, 1, "ASUS GeForce RTX 2080 SUPER ROG Strix Advanced", 7319m },
                    { 27, 6, 10, "Razer Basilisk Ultimate Trådløs Gaming Mus", 1349m },
                    { 24, 5, 10, "Razer BlackWidow Elite Gaming Tastatur", 1399m },
                    { 15, 2, 10, "Razer Blade Pro 17,3 UHD / 4K touch 120 Hz", 33495m },
                    { 23, 4, 9, "LG 48 OLED TV OLED48CX6", 11999m },
                    { 22, 4, 9, "LG 55 UHD OLED Smart TV OLED55C9", 9990m },
                    { 21, 4, 8, "Samsung 75 QLED Smart TV QE75Q90R", 39990m },
                    { 20, 4, 8, "Samsung 75 QLED Smart TV QE75Q60R", 16990m },
                    { 17, 3, 8, "Samsung Galaxy A51 128GB Sort", 2789m },
                    { 16, 3, 8, "Samsung Galaxy S20 Ultra 5G 128GB Grå", 10499m },
                    { 7, 2, 7, "MSI Prestige 15 15,6 Full HD", 11995m },
                    { 5, 2, 7, "MSI GE75 Raider 17,3 FHD 240 Hz", 19990m },
                    { 2, 1, 7, "MSI GeForce RTX 2080 SUPER SEA HAWK EK X", 6999m },
                    { 26, 5, 11, "SteelSeries Apex Pro Gaming Tastatur", 1599m },
                    { 14, 2, 6, "HP Spectre x360 15-df1012no 15,6 UHD OLED touch", 17495m },
                    { 12, 2, 5, "Dell Vostro 3590 15,6 Full HD", 5290m },
                    { 11, 2, 4, "Lenovo ThinkPad P53 15,6 Workstation Pro Full HD", 27990m },
                    { 19, 3, 3, "Apple iPhone SE 64GB Sort", 3699m },
                    { 18, 3, 3, "iPhone 11 Pro Max 64 GB Grå", 9649m },
                    { 10, 2, 3, "Apple MacBook Pro laptop 16 1TB MVV med touch bar", 21999m },
                    { 9, 2, 2, "Acer Chromebook R13 CB5-312T 13.3 FHD", 2495m },
                    { 6, 2, 2, "Acer Nitro 5 15,6 FHD 120 Hz", 5290m },
                    { 28, 6, 1, "ASUS ROG Chakram Trådløs Gaming Mus", 1079m },
                    { 25, 5, 1, "ASUS ROG Strix Scope Gaming Tastatur", 1099m },
                    { 8, 2, 1, "ASUS ZenBook Pro Duo 15,6 UHD / 4K OLED Touch", 21490m },
                    { 4, 1, 1, "ASUS GeForce GTX 1660 SUPER ROG Strix OC", 2229m },
                    { 3, 1, 1, "ASUS Radeon RX 5500 XT ROG Strix OC 8GB", 1999m },
                    { 13, 2, 5, "Dell XPS 13 7390 13,3 UHD / 4K Touch", 13690m },
                    { 29, 6, 11, "Steelseries Rival 710 Gaming Mus", 799m }
                });

            migrationBuilder.InsertData(
                table: "ProductImage",
                columns: new[] { "ProductImageId", "Image", "ProductId" },
                values: new object[,]
                {
                    { 4, "https://www.komplett.dk/img/p/1200/1135677.jpg", 1 },
                    { 30, "https://www.komplett.dk/img/p/1200/1146944.jpg", 27 },
                    { 27, "https://www.elgiganten.dk/image/dv_web_D18000100296972/12851/razer-blackwidow-elite-gaming-tastatur.jpg?$fullsize$", 24 },
                    { 18, "https://www.komplett.dk/img/p/1200/1153777.jpg", 15 },
                    { 26, "https://www.elgiganten.dk/image/dv_web_D180001002410624/153758/lg-48-cx-4k-oled-tv-oled48cx.jpg?$fullsize$", 23 },
                    { 3, "https://www.elgiganten.dk/image/dv_web_D180001002410669/153758/lg-48-cx-4k-oled-tv-oled48cx.jpg?$prod_all4one$", 23 },
                    { 2, "https://www.elgiganten.dk/image/dv_web_D180001002410670/153758/lg-48-cx-4k-oled-tv-oled48cx.jpg?$fullsize$", 23 },
                    { 1, "https://www.elgiganten.dk/image/dv_web_D180001002410624/153758/lg-48-cx-4k-oled-tv-oled48cx.jpg?$fullsize$", 23 },
                    { 25, "https://www.komplett.dk/img/p/1200/1130516.jpg", 22 },
                    { 24, "https://www.komplett.dk/img/p/1080/1124646.jpg", 21 },
                    { 23, "https://www.komplett.dk/img/p/1080/1124639.jpg", 20 },
                    { 20, "https://www.komplett.dk/img/p/1200/1149587.jpg", 17 },
                    { 19, "https://www.komplett.dk/img/p/1200/1151019.jpg", 16 },
                    { 10, "https://www.komplett.dk/img/p/1200/1135667.jpg", 7 },
                    { 8, "https://www.komplett.dk/img/p/1200/1153467.jpg", 5 },
                    { 5, "https://www.komplett.dk/img/p/1200/1139034.jpg", 2 },
                    { 17, "https://www.komplett.dk/img/p/1200/1132707.jpg", 14 },
                    { 16, "https://www.komplett.dk/img/p/1200/1146637.jpg", 13 },
                    { 15, "https://www.komplett.dk/img/p/1200/1150472.jpg", 12 },
                    { 14, "https://www.komplett.dk/img/p/1000/1137677.jpg", 11 },
                    { 22, "https://www.komplett.dk/img/p/1200/1157749.jpg", 19 },
                    { 21, "https://www.komplett.dk/img/p/1200/1138869.jpg", 18 },
                    { 13, "https://sg-next.imgix.net/medias/sys_master/root/hbd/h3a/13735092912158/MacBook-Pro-16-in-Pure-Front-Space-Gray-SCREEN-result.jpg?w=350&h=350&auto=format&fm=jpg", 10 },
                    { 12, "https://www.komplett.dk/img/p/1200/898464.jpg", 9 },
                    { 9, "https://www.komplett.dk/img/p/1200/1156443.jpg", 6 },
                    { 31, "https://www.komplett.dk/img/p/1200/1150475.jpg", 28 },
                    { 28, "https://www.komplett.dk/img/p/1200/1144808.jpg", 25 },
                    { 11, "https://www.komplett.dk/img/p/1200/1132405.jpg", 8 },
                    { 7, "https://www.komplett.dk/img/p/1200/1148757.jpg", 4 },
                    { 6, "https://www.komplett.dk/img/p/1200/1149212.jpg", 3 },
                    { 29, "https://www.komplett.dk/img/p/1200/1127733.jpg", 26 },
                    { 32, "https://www.komplett.dk/img/p/1200/1041072.jpg", 29 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 11);
        }
    }
}
