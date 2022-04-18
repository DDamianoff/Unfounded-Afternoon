using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Ingeniería.Backend.Modelos;

public class SqLiteDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(connectionString: "Filename=db.sqlite", sqliteOptionsAction: options => options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName));
        
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brand>().ToTable(nameof(Marcas));
        modelBuilder.Entity<Brand>(entity => entity.HasKey(e => e.Id));
        
        modelBuilder.Entity<Category>().ToTable(nameof(Categorías));
        modelBuilder.Entity<Category>(entity => entity.HasKey(e => e.Id));
        
        modelBuilder.Entity<Currency>().ToTable(nameof(Monedas));
        modelBuilder.Entity<Currency>(entity => entity.HasKey(e => e.Id));
        
        modelBuilder.Entity<Customer>().ToTable(nameof(Clientes));
        modelBuilder.Entity<Customer>(entity => entity.HasKey(e => e.Id));
        
        modelBuilder.Entity<Order>().ToTable(nameof(Pedidos));
        modelBuilder.Entity<Order>(entity => entity.HasKey(e => e.Id));
        
        modelBuilder.Entity<Receipt>().ToTable(nameof(Comprobantes));
        modelBuilder.Entity<Receipt>(entity => entity.HasKey(e => e.ReceiptId));
        
        modelBuilder.Entity<User>().ToTable(nameof(Usuarios));
        modelBuilder.Entity<User>(entity => entity.HasKey(e => e.Id));

        modelBuilder.Entity<Product>().ToTable(nameof(Productos));
        modelBuilder.Entity<Product>(entity => entity.HasKey(e => e.Id));

        base.OnModelCreating(modelBuilder);
    }
    
    public DbSet<Brand?> Marcas
    {
        get;
        set;
    }
    public DbSet<Category?> Categorías
    {
        get;
        set;
    }
    public DbSet<Currency> Monedas
    {
        get;
        set;
    }
    public DbSet<Customer> Clientes
    {
        get;
        set;
    }
    public DbSet<Order> Pedidos
    {
        get;
        set;
    }
    public DbSet<Receipt> Comprobantes
    {
        get;
        set;
    }
    public DbSet<User> Usuarios
    {
        get;
        set;
    }

    public DbSet<Product> Productos
    {
        get;
        set;
    }
}