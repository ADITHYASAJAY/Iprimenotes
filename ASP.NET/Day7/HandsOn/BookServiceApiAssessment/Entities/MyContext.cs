using Microsoft.EntityFrameworkCore;

namespace BookServiceApiAssessment.Entities
{
    public class MyContext:DbContext
    {
        private readonly IConfiguration configuration;
        public MyContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyConnection"));
        }
    }
}
