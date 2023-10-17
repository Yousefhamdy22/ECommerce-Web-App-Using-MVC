using ECommerce_MVC.Areas.AdminPanel.Models;
using ECommerce_MVC.Areas.SellerPanel.Models;
using ECommerce_MVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;


namespace ECommerce_MVC.Areas.Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {


            builder.Entity<Customer>()
            .HasKey(c => c.CustmerId);
            builder.Entity<SellerProductes>()
                .HasIndex("SellerId", "ProductId")
                .IsUnique();

            builder.Entity<Product>()
                .HasIndex(p => p.Serialnum)
                .IsUnique();


            builder.Entity<Orderitem>()
                .HasOne(p => p.SellerProductes)
                .WithMany(s => s.OrderItems)
                .HasForeignKey(p => p.SellerProductId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<CartItem>()
                .HasOne(p => p.SellerProduct)
                .WithMany(s => s.CartItems)
                .HasForeignKey(p => p.SellerProductId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Report>()
                .HasOne(p => p.Review)
                .WithMany(s => s.Reports)
                .HasForeignKey(p => p.ReviewId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Report>()
                .Property(r => r.CreateDatet)
                .HasDefaultValueSql("getdate()");

            builder.Entity<Review>()
                .Property(r => r.CreatedDate)
                .HasDefaultValueSql("getdate()");

            builder.Entity<Order>()
                .HasOne(o => o.Address)
                .WithMany()
                .HasForeignKey(o => o.AddressId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Review>()
                 .HasOne(r => r.Seller)
                 .WithMany()
                 .HasForeignKey(r => r.SellerId)
                 .OnDelete(DeleteBehavior.Restrict);




            base.OnModelCreating(builder);

            
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }
        public virtual DbSet<SellerProductes> SellerProducts { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Orderitem> OrderItems { get; set; }



        public virtual DbSet<Admin> Admins { get; set; }



        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }







    }



   
}