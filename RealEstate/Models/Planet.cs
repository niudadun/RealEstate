using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RealEstate.Models
{
    public class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlanetObj>().HasData(new PlanetObj { PlanetObjId = 1, Name = "Sedna", Color = "Yellow", Price = "1.5", Image="sedna.jpg", DetailImage= "sednadetails.jpg" },
                                                     new PlanetObj { PlanetObjId = 2, Name = "Mercury", Color = "Blue", Price = "4.5", Image = "mercury.jpg", DetailImage = "mercurydetails.jpg" },
                                                     new PlanetObj { PlanetObjId = 3, Name = "Venus", Color = "Yellow", Price = "1.5", Image = "venus.jpg", DetailImage = "venusdetails.jpg" },
                                                     new PlanetObj { PlanetObjId = 4, Name = "Lava", Color = "Red", Price = "4.5", Image = "lava.jpg", DetailImage = "lavadetails.jpg" },
                                                     new PlanetObj { PlanetObjId = 5, Name = "Jupiter", Color = "Yellow", Price = "2.5", Image = "jupiter.jpg", DetailImage = "jupiterdetails.jpg" },
                                                     new PlanetObj { PlanetObjId = 6, Name = "Uranus", Color = "Blue", Price = "5.5", Image = "uranus.jpg", DetailImage = "uranusdetails.jpg" },
                                                     new PlanetObj { PlanetObjId = 7, Name = "Saturn", Color = "Yellow", Price = "2.5", Image = "saturn.jpg", DetailImage = "saturndetails.jpg" },
                                                     new PlanetObj { PlanetObjId = 8, Name = "X-3", Color = "Yellow", Price = "2.5", Image = "x-3.jpg", DetailImage = "x-3details.jpg" }
                                                     );
        }
        public DbSet<Realtor> Realtors { get; set; }
        public DbSet<PlanetObj> PlanetObjs { get; set; }

    }
    public class PlanetObj
    {
        public int PlanetObjId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Shape { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public string DetailImage { get; set; }
        public ICollection<Realtor> Realtors { get; set; }
    }
   

    public class Realtor
    {
        public int RealtorId { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
    }
}
