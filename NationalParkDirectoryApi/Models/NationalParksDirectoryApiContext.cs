using Microsoft.EntityFrameworkCore;

namespace NationalParkDirectoryApi.Models
{
  public class NationalParkDirectoryApiContext : DbContext
  {
    public NationalParkDirectoryApiContext(DbContextOptions<NationalParkDirectoryApiContext> options) : base(options)
    {

    }

    public DbSet<NationalPark> NationalParks { get; set; }
  }
}