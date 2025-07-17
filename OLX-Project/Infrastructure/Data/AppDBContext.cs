using Microsoft.EntityFrameworkCore;
using OLX_Project.Core.Entities;

namespace OLX_Project.Infrastructure.Data;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Ad>  Ads { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<SubCategory> SubCategories { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<SubRegion> SubRegions { get; set; }    
    public DbSet<Image> Images { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<Message> Messages { get; set; }
}