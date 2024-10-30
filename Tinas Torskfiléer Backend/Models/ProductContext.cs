using Microsoft.EntityFrameworkCore;

namespace Tinas_Torskfiléer_Backend.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> TinasProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-D3B4HAG\\SQLEXPRESS;Initial Catalog=projects;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

    }
}
