using System.IO;
using DoAn1.Models.Tables;
using Microsoft.EntityFrameworkCore;

namespace DoAn1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Delivery> Deliveries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string dbPath = Path.Combine(
                AppContext.BaseDirectory,
                @"..\..\..\Database\lavitadb.mdf");

            dbPath = Path.GetFullPath(dbPath);
           // string connectionString = @"Server=1.1.1.1;Database=lavitadb;User Id=thailo;Password=123456;TrustServerCertificate=True;";
            string connectionString = @"Server=172.31.143.125;Database=lavitadb;User Id=thailo;Password=123456;TrustServerCertificate=True;Pooling=False;";
            //string connectionString=$@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True;TrustServerCertificate=True;"
            optionsBuilder.UseSqlServer(connectionString);
        //    optionsBuilder.UseSqlServer(
        //        @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\lavitadb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Composite Primary Key
            modelBuilder.Entity<OrderDetail>()
                .HasKey(x => new { x.OrderId, x.ProductId });

            // Account.Acc là duy nhất
            modelBuilder.Entity<Account>()
                .HasIndex(x => x.Acc)
                .IsUnique();

            // 1 Order - 1 Invoice
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Invoice)
                .WithOne(i => i.Order)
                .HasForeignKey<Invoice>(i => i.OrderId);
        }
    }
}