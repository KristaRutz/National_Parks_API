using Microsoft.EntityFrameworkCore;

namespace NationalParkDirectoryApi.Models
{
  public class NationalParkDirectoryApiContext : DbContext
  {
    public NationalParkDirectoryApiContext(DbContextOptions<NationalParkDirectoryApiContext> options) : base(options)
    {

    }

    public DbSet<NationalPark> NationalParks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<NationalPark>()
          .HasData(
              new NationalPark
              {
                NationalParkId = 1,
                Name = "Acadia National Park",
                AlphaCode = "ACAD",
                StateCode = "ME",
                Region = "Northeast",
                Url = "https://www.nps.gov/acad/index.htm",
                IsOpen = false
              },
              new NationalPark
              {
                NationalParkId = 2,
                Name = "National Park of American Samoa",
                AlphaCode = "NPSA",
                StateCode = "AS",
                Region = "Pacific-West",
                Url = "https://www.nps.gov/npsa/index.htm",
                IsOpen = true
              }
          );
    }
  }
}