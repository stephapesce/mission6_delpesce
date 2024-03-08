using Microsoft.EntityFrameworkCore;

namespace mission6_delpesce.Models
{
    public class MovieCollectionContext : DbContext
    {
        public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options) : base(options) // constructor
        {  
        }
    
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Category> Categories { get; set; }

    }
}
