using Microsoft.EntityFrameworkCore;

namespace AspNetMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products {get;  set; }
        private string connectionString = "server=127.0.0.1;port=3307;Database=AspNetMVC;user=root;password=password;";
        private MySqlServerVersion serverVersion = new MySqlServerVersion(new System.Version(8,0,21));
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(serverVersion: serverVersion, connectionString: connectionString);
        }
    }
}