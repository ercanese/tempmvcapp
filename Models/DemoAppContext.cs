using Microsoft.EntityFrameworkCore;

namespace dockersqlapp.Models
{
    public class DemoAppContext:DbContext
    {
        protected readonly IConfiguration Configuration;

        public DemoAppContext(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Request> requests { get; set; }
    }
}
