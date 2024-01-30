using Microsoft.EntityFrameworkCore;
namespace HandsOnAPIWithEFCodeFirst.Entities
{
    public class MyContext:DbContext
    {
        //define entity set
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define the connectionstring
            optionsBuilder.UseSqlServer(@"Data Source=INTERNS31\SQL2022;Initial Catalog=TrainingDB;User ID=sa;Password=Password123.;Trust Server Certificate=True");
            // base.OnConfiguring(optionsBuilder);

        }
    }
}
