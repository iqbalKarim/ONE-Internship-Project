using Microsoft.EntityFrameworkCore;
using API.Entities;
using Microsoft.Data.SqlClient;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions options) : base (options){
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-GMOA06LL\SQLEXPRESS;Initial Catalog=ONE_ProjectDatabase;Integrated Security=True;");
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}