using B2BWEB.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace B2BWEB.DataAccess.Data
{
    
    public class ApplicationDbContext : IdentityDbContext<IdentityUser> 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSet tanımları sınıfın içinde olmalıdır
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Çikolata", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Kraker", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Kek", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Lifli Ürünler", DisplayOrder = 4},
                new Category { Id = 5, Name = "Soğuk Ürünler", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Bisküviler", DisplayOrder = 6}
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Karam",
                    Description = "Taptaze, çıtır çıtır gofret yapraklarının arasında benzersiz fındıklı kreması ve nefis Ülker çikolata kaplaması ile herkesin sevdiği Ülker Çikolatalı Gofret! ",
                    No = "SWD9999001",
                    Price = 30,
                    CategoryId = 1,
                    ImageUrl = ""

                },
                new Product
                {
                    Id = 2,
                    Title = "Balık",
                    Description = "Balık Kraker hem şekli hem de lezzetiyle yerken sizi neşelendirmeye devam ediyor!  ",
                    No = "SWD9999002",
                    Price = 24,
                    CategoryId = 2,
                    ImageUrl = ""

                },
                new Product
                {
                    Id = 3,
                    Title = "Kek",
              
                    Description = "Yılların sevilen lezzeti,yenilenen yumuşacık kekiyle güncellendi!",
                    No = "SWD9999003",
                    Price = 15,
                    CategoryId = 3,
                    ImageUrl=""

                },
                new Product
                {
                    Id = 4,
                    Title = "Lifalif",
                    
                    Description = "Yulafın doğallığını, lezzetini ve besleyiciliğini size pratik bir şekilde sunan sağlam bir kahvaltı ve ara öğün alternatifidir.",
                    No = "SWD9999004",
                    Price = 29,
                    CategoryId = 4,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title =  "Sütburger",
                    
                    Description = "ETİ’den buzdolabındaki süt dolu lezzet! ",
                    No = "SWD9999005",
                    Price = 15,
                    CategoryId = 5,
                    ImageUrl = ""

                },
                new Product
                {
                    Id = 6,
                    Title = "Burçak",
                    
                    Description = "Hem çay keyfinizin eşlikçisi hem de harika pasta ve tatlılarınızın aranılan malzemesi!",
                    No = "SWD9999006",
                    Price = 20,
                    CategoryId = 6,
                    ImageUrl = ""

                }

               );

        }
    }
    }
