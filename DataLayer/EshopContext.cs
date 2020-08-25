using System;
using DataLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace DataLayer
{
    public class EshopContext : IdentityDbContext<Customer>
    {
        public EshopContext(DbContextOptions<EshopContext> options)
            : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //ManyToMany
            modelBuilder.Entity<OrderProduct>()
            .HasKey(b => new { b.OrderId, b.ProductId });

            modelBuilder.Entity<Manufacturer>().HasData(
                 new Manufacturer { Name = "ASUS", ManufacturerId = 1 },
                 new Manufacturer { Name = "Acer", ManufacturerId = 2 },
                 new Manufacturer { Name = "Apple", ManufacturerId = 3 },
                 new Manufacturer { Name = "Lenovo", ManufacturerId = 4 },
                 new Manufacturer { Name = "DELL", ManufacturerId = 5 },
                 new Manufacturer { Name = "HP", ManufacturerId = 6 },
                 new Manufacturer { Name = "MSI", ManufacturerId = 7 },
                 new Manufacturer { Name = "Samsung", ManufacturerId = 8 },
                 new Manufacturer { Name = "LG", ManufacturerId = 9 },
                 new Manufacturer { Name = "Razer", ManufacturerId = 10 },
                 new Manufacturer { Name = "Steelseries", ManufacturerId = 11 }
                 );

            modelBuilder.Entity<Category>().HasData(
                new Category { Name = "Grafikkort", CategoryId = 1 },
                new Category { Name = "Bærbar", CategoryId = 2 },
                new Category { Name = "Mobil", CategoryId = 3 },
                new Category { Name = "TV", CategoryId = 4 },
                new Category { Name = "Tastatur", CategoryId = 5 },
                new Category { Name = "Mus", CategoryId = 6 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Name = "ASUS GeForce RTX 2080 SUPER ROG Strix Advanced", CategoryId = 1, ManufacturerId = 1, Price = 7319, ProductId = 1 },
                new Product { Name = "MSI GeForce RTX 2080 SUPER SEA HAWK EK X", CategoryId = 1, ManufacturerId = 7, Price = 6999, ProductId = 2 },
                new Product { Name = "ASUS Radeon RX 5500 XT ROG Strix OC 8GB", CategoryId = 1, ManufacturerId = 1, Price = 1999, ProductId = 3 },
                new Product { Name = "ASUS GeForce GTX 1660 SUPER ROG Strix OC", CategoryId = 1, ManufacturerId = 1, Price = 2229, ProductId = 4 },
                new Product { Name = "MSI GE75 Raider 17,3 FHD 240 Hz", CategoryId = 2, ManufacturerId = 7, Price = 19990, ProductId = 5 },
                new Product { Name = "Acer Nitro 5 15,6 FHD 120 Hz", CategoryId = 2, ManufacturerId = 2, Price = 5290, ProductId = 6 },
                new Product { Name = "MSI Prestige 15 15,6 Full HD", CategoryId = 2, ManufacturerId = 7, Price = 11995, ProductId = 7 },
                new Product { Name = "ASUS ZenBook Pro Duo 15,6 UHD / 4K OLED Touch", CategoryId = 2, ManufacturerId = 1, Price = 21490, ProductId = 8 },
                new Product { Name = "Acer Chromebook R13 CB5-312T 13.3 FHD", CategoryId = 2, ManufacturerId = 2, Price = 2495, ProductId = 9 },
                new Product { Name = "Apple MacBook Pro laptop 16 1TB MVV med touch bar", CategoryId = 2, ManufacturerId = 3, Price = 21999, ProductId = 10 },
                new Product { Name = "Lenovo ThinkPad P53 15,6 Workstation Pro Full HD", CategoryId = 2, ManufacturerId = 4, Price = 27990, ProductId = 11 },
                new Product { Name = "Dell Vostro 3590 15,6 Full HD", CategoryId = 2, ManufacturerId = 5, Price = 5290, ProductId = 12 },
                new Product { Name = "Dell XPS 13 7390 13,3 UHD / 4K Touch", CategoryId = 2, ManufacturerId = 5, Price = 13690, ProductId = 13 },
                new Product { Name = "HP Spectre x360 15-df1012no 15,6 UHD OLED touch", CategoryId = 2, ManufacturerId = 6, Price = 17495, ProductId = 14 },
                new Product { Name = "Razer Blade Pro 17,3 UHD / 4K touch 120 Hz", CategoryId = 2, ManufacturerId = 10, Price = 33495, ProductId = 15 },
                new Product { Name = "Samsung Galaxy S20 Ultra 5G 128GB Grå", CategoryId = 3, ManufacturerId = 8, Price = 10499, ProductId = 16 },
                new Product { Name = "Samsung Galaxy A51 128GB Sort", CategoryId = 3, ManufacturerId = 8, Price = 2789, ProductId = 17 },
                new Product { Name = "iPhone 11 Pro Max 64 GB Grå", CategoryId = 3, ManufacturerId = 3, Price = 9649, ProductId = 18 },
                new Product { Name = "Apple iPhone SE 64GB Sort", CategoryId = 3, ManufacturerId = 3, Price = 3699, ProductId = 19 },
                new Product { Name = "Samsung 75 QLED Smart TV QE75Q60R", CategoryId = 4, ManufacturerId = 8, Price = 16990, ProductId = 20 },
                new Product { Name = "Samsung 75 QLED Smart TV QE75Q90R", CategoryId = 4, ManufacturerId = 8, Price = 39990, ProductId = 21 },
                new Product { Name = "LG 55 UHD OLED Smart TV OLED55C9", CategoryId = 4, ManufacturerId = 9, Price = 9990, ProductId = 22 },
                new Product { Name = "LG 48 OLED TV OLED48CX6", CategoryId = 4, ManufacturerId = 9, Price = 11999, ProductId = 23 },
                new Product { Name = "Razer BlackWidow Elite Gaming Tastatur", CategoryId = 5, ManufacturerId = 10, Price = 1399, ProductId = 24 },
                new Product { Name = "ASUS ROG Strix Scope Gaming Tastatur", CategoryId = 5, ManufacturerId = 1, Price = 1099, ProductId = 25 },
                new Product { Name = "SteelSeries Apex Pro Gaming Tastatur", CategoryId = 5, ManufacturerId = 11, Price = 1599, ProductId = 26 },
                new Product { Name = "Razer Basilisk Ultimate Trådløs Gaming Mus", CategoryId = 6, ManufacturerId = 10, Price = 1349, ProductId = 27 },
                new Product { Name = "ASUS ROG Chakram Trådløs Gaming Mus", CategoryId = 6, ManufacturerId = 1, Price = 1079, ProductId = 28 },
                new Product { Name = "Steelseries Rival 710 Gaming Mus", CategoryId = 6, ManufacturerId = 11, Price = 799, ProductId = 29 }
                );

            modelBuilder.Entity<ProductImage>().HasData(
                new ProductImage { ProductId = 23, ProductImageId = 1, Image = "https://www.elgiganten.dk/image/dv_web_D180001002410624/153758/lg-48-cx-4k-oled-tv-oled48cx.jpg?$fullsize$" },
                new ProductImage { ProductId = 23, ProductImageId = 2, Image = "https://www.elgiganten.dk/image/dv_web_D180001002410670/153758/lg-48-cx-4k-oled-tv-oled48cx.jpg?$fullsize$" },
                new ProductImage { ProductId = 23, ProductImageId = 3, Image = "https://www.elgiganten.dk/image/dv_web_D180001002410669/153758/lg-48-cx-4k-oled-tv-oled48cx.jpg?$prod_all4one$" },
                new ProductImage { ProductId = 1, ProductImageId = 4, Image = "https://www.komplett.dk/img/p/1200/1135677.jpg" },
                new ProductImage { ProductId = 2, ProductImageId = 5, Image = "https://www.komplett.dk/img/p/1200/1139034.jpg" },
                new ProductImage { ProductId = 3, ProductImageId = 6, Image = "https://www.komplett.dk/img/p/1200/1149212.jpg" },
                new ProductImage { ProductId = 4, ProductImageId = 7, Image = "https://www.komplett.dk/img/p/1200/1148757.jpg" },
                new ProductImage { ProductId = 5, ProductImageId = 8, Image = "https://www.komplett.dk/img/p/1200/1153467.jpg" },
                new ProductImage { ProductId = 6, ProductImageId = 9, Image = "https://www.komplett.dk/img/p/1200/1156443.jpg" },
                new ProductImage { ProductId = 7, ProductImageId = 10, Image = "https://www.komplett.dk/img/p/1200/1135667.jpg" },
                new ProductImage { ProductId = 8, ProductImageId = 11, Image = "https://www.komplett.dk/img/p/1200/1132405.jpg" },
                new ProductImage { ProductId = 9, ProductImageId = 12, Image = "https://www.komplett.dk/img/p/1200/898464.jpg" },
                new ProductImage { ProductId = 10, ProductImageId = 13, Image = "https://sg-next.imgix.net/medias/sys_master/root/hbd/h3a/13735092912158/MacBook-Pro-16-in-Pure-Front-Space-Gray-SCREEN-result.jpg?w=350&h=350&auto=format&fm=jpg" },
                new ProductImage { ProductId = 11, ProductImageId = 14, Image = "https://www.komplett.dk/img/p/1000/1137677.jpg" },
                new ProductImage { ProductId = 12, ProductImageId = 15, Image = "https://www.komplett.dk/img/p/1200/1150472.jpg" },
                new ProductImage { ProductId = 13, ProductImageId = 16, Image = "https://www.komplett.dk/img/p/1200/1146637.jpg" },
                new ProductImage { ProductId = 14, ProductImageId = 17, Image = "https://www.komplett.dk/img/p/1200/1132707.jpg" },
                new ProductImage { ProductId = 15, ProductImageId = 18, Image = "https://www.komplett.dk/img/p/1200/1153777.jpg" },
                new ProductImage { ProductId = 16, ProductImageId = 19, Image = "https://www.komplett.dk/img/p/1200/1151019.jpg" },
                new ProductImage { ProductId = 17, ProductImageId = 20, Image = "https://www.komplett.dk/img/p/1200/1149587.jpg" },
                new ProductImage { ProductId = 18, ProductImageId = 21, Image = "https://www.komplett.dk/img/p/1200/1138869.jpg" },
                new ProductImage { ProductId = 19, ProductImageId = 22, Image = "https://www.komplett.dk/img/p/1200/1157749.jpg" },
                new ProductImage { ProductId = 20, ProductImageId = 23, Image = "https://www.komplett.dk/img/p/1080/1124639.jpg" },
                new ProductImage { ProductId = 21, ProductImageId = 24, Image = "https://www.komplett.dk/img/p/1080/1124646.jpg" },
                new ProductImage { ProductId = 22, ProductImageId = 25, Image = "https://www.komplett.dk/img/p/1200/1130516.jpg" },
                new ProductImage { ProductId = 23, ProductImageId = 26, Image = "https://www.elgiganten.dk/image/dv_web_D180001002410624/153758/lg-48-cx-4k-oled-tv-oled48cx.jpg?$fullsize$" },
                new ProductImage { ProductId = 24, ProductImageId = 27, Image = "https://www.elgiganten.dk/image/dv_web_D18000100296972/12851/razer-blackwidow-elite-gaming-tastatur.jpg?$fullsize$" },
                new ProductImage { ProductId = 25, ProductImageId = 28, Image = "https://www.komplett.dk/img/p/1200/1144808.jpg" },
                new ProductImage { ProductId = 26, ProductImageId = 29, Image = "https://www.komplett.dk/img/p/1200/1127733.jpg" },
                new ProductImage { ProductId = 27, ProductImageId = 30, Image = "https://www.komplett.dk/img/p/1200/1146944.jpg" },
                new ProductImage { ProductId = 28, ProductImageId = 31, Image = "https://www.komplett.dk/img/p/1200/1150475.jpg" },
                new ProductImage { ProductId = 29, ProductImageId = 32, Image = "https://www.komplett.dk/img/p/1200/1041072.jpg" }
                );
        }
    }
}
