using api_rest.Domain.Models;
using api_rest.Domain.Helpers;
using Microsoft.EntityFrameworkCore;

namespace api_rest.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().ToTable("Categories");
            builder.Entity<Category>().HasKey(p => p.Id);
            builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Category>().HasMany(p => p.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);

            builder.Entity<Category>().HasData
            (
                new Category { Id = 1, Name = "RPG" }
                new Category { Id = 2, Name = "Terror" }
                new Category { Id = 3, Name = "Guerra" }
            );

            builder.Entity<Product>().ToTable("Products");
            builder.Entity<Product>().HasKey(p => p.Id);
            builder.Entity<Product>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Entity<Product>().Property(p => p.QuantityInPackage).IsRequired();
            builder.Entity<Product>().Property(p => p.UnitOfPlatform).IsRequired();

            builder.Entity<Product>().HasData
            (
                new Product
                {
                    Id = 1,
                    Name = "Ruined King: A League of Legends Story",
                    QuantityInPackage = 4,
                    UnitOfPlatform = EUnitOfPlatform.Riot,
                    CategoryId = 1
                },
               
                new Product
                {
                    Id = 2,
                    Name = "Wartales",
                    QuantityInPackage = 5,
                    UnitOfPlatform = EUnitOfPlatform.Steam,
                    CategoryId = 1,
                },
                
                new Product
                {
                  Id = 3,
                  Name = "Friday the 13th: The Game",
                  QuantityInPackage = 4,
                  UnitOfPlatform = EUnitOfPlatform.Steam,
                  CategoryId = 2,
                },

                new Product
                {
                  Id = 4,
                  Name = "Fortnite Battle Royale",
                  QuantityInPackage = 4,
                  UnitOfPlatform = EUnitOfPlatform.EpicGames,
                  CategoryId = 3,
                }
            );

            builder.Entity<User>().ToTable("Users");
            builder.Entity<User>().HasKey(p => p.Id);
            builder.Entity<User>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<User>().Property(p => p.Login).IsRequired().HasMaxLength(50);
            builder.Entity<User>().Property(p => p.Password).IsRequired().HasMaxLength(10);
            
            builder.Entity<User>().HasData
            (
                new User
                {
                    Id = 1,
                    Login = "Isabelle",
                    Password = "12345678",
                }
            );
        }
    }
}
