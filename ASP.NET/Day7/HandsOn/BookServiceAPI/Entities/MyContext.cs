using Microsoft.EntityFrameworkCore;
namespace BookServiceAPI.Entities
{
    public class MyContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=INTERNS31\SQL2022;Initial Catalog=TrainingDB;User ID=sa;Password=Password123.;Trust Server Certificate=True");
        }
    }
}
