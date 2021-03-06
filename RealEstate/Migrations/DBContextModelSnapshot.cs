﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RealEstate.Models;

namespace RealEstate.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RealEstate.Models.PlanetObj", b =>
                {
                    b.Property<int>("PlanetObjId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color");

                    b.Property<string>("DetailImage");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<string>("Price");

                    b.Property<string>("SellType");

                    b.Property<string>("Shape");

                    b.Property<string>("Size");

                    b.HasKey("PlanetObjId");

                    b.ToTable("PlanetObjs");

                    b.HasData(
                        new { PlanetObjId = 1, Color = "Yellow", DetailImage = "sednadetails.jpg", Image = "sedna.jpg", Name = "Sedna", Price = "1.5", SellType = "Featured", Shape = "Round", Size = "Average" },
                        new { PlanetObjId = 2, Color = "Grey", DetailImage = "mercurydetails.jpg", Image = "mercury.jpg", Name = "Mercury", Price = "4.5", SellType = "New", Shape = "Sphere", Size = "Large" },
                        new { PlanetObjId = 3, Color = "Yellow", DetailImage = "venusdetails.jpg", Image = "venus.jpg", Name = "Venus", Price = "1.5", SellType = "Offer", Shape = "Potato", Size = "Small" },
                        new { PlanetObjId = 4, Color = "Red", DetailImage = "lavadetails.jpg", Image = "lava.jpg", Name = "Lava", Price = "4.5", SellType = "On Sale", Shape = "Sphere", Size = "Large" },
                        new { PlanetObjId = 5, Color = "Yellow", DetailImage = "jupiterdetails.jpg", Image = "jupiter.jpg", Name = "Jupiter", Price = "2.5", SellType = "Featured", Shape = "Round", Size = "Average" },
                        new { PlanetObjId = 6, Color = "Blue", DetailImage = "uranusdetails.jpg", Image = "uranus.jpg", Name = "Uranus", Price = "5.5", SellType = "Offer", Shape = "Potato", Size = "Large" },
                        new { PlanetObjId = 7, Color = "Yellow", DetailImage = "saturndetails.jpg", Image = "saturn.jpg", Name = "Saturn", Price = "2.5", SellType = "Featured", Shape = "Round", Size = "Large" },
                        new { PlanetObjId = 8, Color = "Blue", DetailImage = "x-3details.jpg", Image = "x-3.jpg", Name = "X-3", Price = "2.5", SellType = "Featured", Shape = "Sphere", Size = "Average" }
                    );
                });

            modelBuilder.Entity("RealEstate.Models.Realtor", b =>
                {
                    b.Property<int>("RealtorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MobileNumber");

                    b.Property<string>("Name");

                    b.Property<int?>("PlanetObjId");

                    b.HasKey("RealtorId");

                    b.HasIndex("PlanetObjId");

                    b.ToTable("Realtors");
                });

            modelBuilder.Entity("RealEstate.Models.Realtor", b =>
                {
                    b.HasOne("RealEstate.Models.PlanetObj")
                        .WithMany("Realtors")
                        .HasForeignKey("PlanetObjId");
                });
#pragma warning restore 612, 618
        }
    }
}
