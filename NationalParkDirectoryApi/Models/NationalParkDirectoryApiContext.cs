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
              },
              new NationalPark
              {
                NationalParkId = 3,
                Name = "Arches National Park",
                AlphaCode = "ARCH",
                StateCode = "UT",
                Region = "Intermountain",
                Url = "https://www.nps.gov/arch/index.htm",
                IsOpen = false
              },
              new NationalPark
              {
                NationalParkId = 4,
                Name = "Badlands National Park",
                AlphaCode = "BADL",
                StateCode = "SD",
                Region = "Midwest",
                Url = "https://www.nps.gov/badl/index.htm",
                IsOpen = false
              },
              new NationalPark
              {
                NationalParkId = 5,
                Name = "Big Bend National Park",
                AlphaCode = "BIBE",
                StateCode = "TX",
                Region = "Intermountain",
                Url = "https://www.nps.gov/bibe/index.htm",
                IsOpen = false
              },
              new NationalPark
              {
                NationalParkId = 6,
                Name = "Biscayne National Park",
                AlphaCode = "BISC",
                StateCode = "FL",
                Region = "Southeast",
                Url = "https://www.nps.gov/bisc/index.htm",
                IsOpen = true
              },
              new NationalPark
              {
                NationalParkId = 7,
                Name = "Black Canyon of the Gunnison National Park",
                AlphaCode = "BLCA",
                StateCode = "CO",
                Region = "Intermountain",
                Url = "https://www.nps.gov/blca/index.htm",
                IsOpen = false
              },
              new NationalPark
              {
                NationalParkId = 8,
                Name = "Bryce Canyon National Park",
                AlphaCode = "BRCA",
                StateCode = "UT",
                Region = "Intermountain",
                Url = "https://www.nps.gov/brca/index.htm",
                IsOpen = true
              },
              new NationalPark
              {
                NationalParkId = 9,
                Name = "Canyonlands National Park",
                AlphaCode = "CANY",
                StateCode = "UT",
                Region = "Intermountain",
                Url = "https://www.nps.gov/cany/index.htm",
                IsOpen = false
              },
              new NationalPark
              {
                NationalParkId = 10,
                Name = "Capitol Reef National Park",
                AlphaCode = "CARE",
                StateCode = "UT",
                Region = "Intermountain",
                Url = "https://www.nps.gov/care/index.htm",
                IsOpen = true
              },
              new NationalPark
              {
                NationalParkId = 11,
                Name = "Carlsbad Caverns National Park",
                AlphaCode = "CAVE",
                StateCode = "NM",
                Region = "Intermountain",
                Url = "https://www.nps.gov/cave/index.htm",
                IsOpen = false
              },
              new NationalPark
              {
                NationalParkId = 12,
                Name = "Channel Islands National Park",
                AlphaCode = "CHIS",
                StateCode = "CA",
                Region = "Pacific-West",
                Url = "https://www.nps.gov/chis/index.htm",
                IsOpen = true
              },
              new NationalPark
              {
                NationalParkId = 13,
                Name = "Congaree National Park",
                AlphaCode = "COSW",
                StateCode = "SC",
                Region = "Southeast",
                Url = "https://www.nps.gov/cosw/index.htm",
                IsOpen = false
              },
              new NationalPark
              {
                NationalParkId = 14,
                Name = "Crater Lake National Park",
                AlphaCode = "CRLA",
                StateCode = "OR",
                Region = "Pacific-West",
                Url = "https://www.nps.gov/crla/index.htm",
                IsOpen = true
              },
              new NationalPark
              {
                NationalParkId = 15,
                Name = "Cuyahoga Valley National Park",
                AlphaCode = "CUVA",
                StateCode = "OH",
                Region = "Midwest",
                Url = "https://www.nps.gov/cuva/index.htm",
                IsOpen = false
              },
              new NationalPark
              {
                NationalParkId = 16,
                Name = "Death Valley National Park",
                AlphaCode = "DEVA",
                StateCode = "CA",
                Region = "Pacific-West",
                Url = "https://www.nps.gov/deva/index.htm",
                IsOpen = true
              },
              new NationalPark
              {
                NationalParkId = 17,
                Name = "Denali National Park",
                AlphaCode = "DENA",
                StateCode = "AK",
                Region = "Alaska",
                Url = "https://www.nps.gov/dena/index.htm",
                IsOpen = false
              },
              new NationalPark
              {
                NationalParkId = 18,
                Name = "Dry Tortugas National Park",
                AlphaCode = "DRTO",
                StateCode = "FL",
                Region = "Southeast",
                Url = "https://www.nps.gov/drto/index.htm",
                IsOpen = true
              }
          );
    }
  }
}