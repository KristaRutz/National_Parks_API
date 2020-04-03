﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NationalParkDirectoryApi.Models;

namespace NationalParkDirectoryApi.Migrations
{
    [DbContext(typeof(NationalParkDirectoryApiContext))]
    [Migration("20200403185424_InitialWithSeedData")]
    partial class InitialWithSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NationalParkDirectoryApi.Models.NationalPark", b =>
                {
                    b.Property<int>("NationalParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AlphaCode");

                    b.Property<bool>("IsOpen");

                    b.Property<string>("Name");

                    b.Property<string>("Region");

                    b.Property<string>("StateCode");

                    b.Property<string>("Url");

                    b.HasKey("NationalParkId");

                    b.ToTable("NationalParks");

                    b.HasData(
                        new
                        {
                            NationalParkId = 1,
                            AlphaCode = "ACAD",
                            IsOpen = false,
                            Name = "Acadia National Park",
                            Region = "Northeast",
                            StateCode = "ME",
                            Url = "https://www.nps.gov/acad/index.htm"
                        },
                        new
                        {
                            NationalParkId = 2,
                            AlphaCode = "NPSA",
                            IsOpen = true,
                            Name = "National Park of American Samoa",
                            Region = "Pacific-West",
                            StateCode = "AS",
                            Url = "https://www.nps.gov/npsa/index.htm"
                        },
                        new
                        {
                            NationalParkId = 3,
                            AlphaCode = "ARCH",
                            IsOpen = false,
                            Name = "Arches National Park",
                            Region = "Intermountain",
                            StateCode = "UT",
                            Url = "https://www.nps.gov/arch/index.htm"
                        },
                        new
                        {
                            NationalParkId = 4,
                            AlphaCode = "BADL",
                            IsOpen = false,
                            Name = "Badlands National Park",
                            Region = "Midwest",
                            StateCode = "SD",
                            Url = "https://www.nps.gov/badl/index.htm"
                        },
                        new
                        {
                            NationalParkId = 5,
                            AlphaCode = "BIBE",
                            IsOpen = false,
                            Name = "Big Bend National Park",
                            Region = "Intermountain",
                            StateCode = "TX",
                            Url = "https://www.nps.gov/bibe/index.htm"
                        },
                        new
                        {
                            NationalParkId = 6,
                            AlphaCode = "BISC",
                            IsOpen = true,
                            Name = "Biscayne National Park",
                            Region = "Southeast",
                            StateCode = "FL",
                            Url = "https://www.nps.gov/bisc/index.htm"
                        },
                        new
                        {
                            NationalParkId = 7,
                            AlphaCode = "BLCA",
                            IsOpen = false,
                            Name = "Black Canyon of the Gunnison National Park",
                            Region = "Intermountain",
                            StateCode = "CO",
                            Url = "https://www.nps.gov/blca/index.htm"
                        },
                        new
                        {
                            NationalParkId = 8,
                            AlphaCode = "BRCA",
                            IsOpen = true,
                            Name = "Bryce Canyon National Park",
                            Region = "Intermountain",
                            StateCode = "UT",
                            Url = "https://www.nps.gov/brca/index.htm"
                        },
                        new
                        {
                            NationalParkId = 9,
                            AlphaCode = "CANY",
                            IsOpen = false,
                            Name = "Canyonlands National Park",
                            Region = "Intermountain",
                            StateCode = "UT",
                            Url = "https://www.nps.gov/cany/index.htm"
                        },
                        new
                        {
                            NationalParkId = 10,
                            AlphaCode = "CARE",
                            IsOpen = true,
                            Name = "Capitol Reef National Park",
                            Region = "Intermountain",
                            StateCode = "UT",
                            Url = "https://www.nps.gov/care/index.htm"
                        },
                        new
                        {
                            NationalParkId = 11,
                            AlphaCode = "CAVE",
                            IsOpen = false,
                            Name = "Carlsbad Caverns National Park",
                            Region = "Intermountain",
                            StateCode = "NM",
                            Url = "https://www.nps.gov/cave/index.htm"
                        },
                        new
                        {
                            NationalParkId = 12,
                            AlphaCode = "CHIS",
                            IsOpen = true,
                            Name = "Channel Islands National Park",
                            Region = "Pacific-West",
                            StateCode = "CA",
                            Url = "https://www.nps.gov/chis/index.htm"
                        },
                        new
                        {
                            NationalParkId = 13,
                            AlphaCode = "COSW",
                            IsOpen = false,
                            Name = "Congaree National Park",
                            Region = "Southeast",
                            StateCode = "SC",
                            Url = "https://www.nps.gov/cosw/index.htm"
                        },
                        new
                        {
                            NationalParkId = 14,
                            AlphaCode = "CRLA",
                            IsOpen = true,
                            Name = "Crater Lake National Park",
                            Region = "Pacific-West",
                            StateCode = "OR",
                            Url = "https://www.nps.gov/crla/index.htm"
                        },
                        new
                        {
                            NationalParkId = 15,
                            AlphaCode = "CUVA",
                            IsOpen = false,
                            Name = "Cuyahoga Valley National Park",
                            Region = "Midwest",
                            StateCode = "OH",
                            Url = "https://www.nps.gov/cuva/index.htm"
                        },
                        new
                        {
                            NationalParkId = 16,
                            AlphaCode = "DEVA",
                            IsOpen = true,
                            Name = "Death Valley National Park",
                            Region = "Pacific-West",
                            StateCode = "CA",
                            Url = "https://www.nps.gov/deva/index.htm"
                        },
                        new
                        {
                            NationalParkId = 17,
                            AlphaCode = "DENA",
                            IsOpen = false,
                            Name = "Denali National Park",
                            Region = "Alaska",
                            StateCode = "AK",
                            Url = "https://www.nps.gov/dena/index.htm"
                        },
                        new
                        {
                            NationalParkId = 18,
                            AlphaCode = "DRTO",
                            IsOpen = true,
                            Name = "Dry Tortugas National Park",
                            Region = "Southeast",
                            StateCode = "FL",
                            Url = "https://www.nps.gov/drto/index.htm"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}