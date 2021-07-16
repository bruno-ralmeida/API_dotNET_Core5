using csharp_apiRest.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_apiRest.Data
{
  public class MovieContext : DbContext
  {
    public MovieContext(DbContextOptions<MovieContext> options) : base(options)
    {

    }
    public DbSet<Movie> Movies { get; set; }
  }
}