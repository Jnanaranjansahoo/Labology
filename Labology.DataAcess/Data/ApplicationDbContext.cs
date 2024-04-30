using Labology.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labology.DataAcess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Officer> Officers { get; set; }
        public DbSet<Client> Clients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Officer>().HasData(
                new Officer { Id = 1, Name = "Male", Cost = 1 },
                new Officer { Id = 2, Name = "FeMale", Cost = 2 }
                );

            modelBuilder.Entity<Client>().HasData(
                new Client
                {
                    Id = 1,
                    CName = "Fortune of Time",
                    Mobile = 123456789,
                    Dist = "SWD9999001",
                    Pos = "Pankapal",
                    Pin = 90,
                    LandMark = "Near bara gachha",
                    Total = 1399,
                    OfficerId = 1,
                    ImageUrl = ""
                },
                new Client
                {
                    Id = 2,
                    CName = "Fortune of Time",
                    Mobile = 123456789,
                    Dist = "SWD9999001",
                    Pos = "Pankapal",
                    Pin = 90,
                    LandMark = "Near bara gachha",
                    Total = 1399,
                    OfficerId = 2,
                    ImageUrl = ""
                },
                new Client
                {
                    Id = 3,
                    CName = "Fortune of Time",
                    Mobile = 123456789,
                    Dist = "SWD9999001",
                    Pos = "Pankapal",
                    Pin = 90,
                    LandMark = "Near bara gachha",
                    Total = 1399,
                    OfficerId = 1,
                    ImageUrl = ""

                },
                new Client
                {
                    Id = 4,
                    CName = "Fortune of Time",
                    Mobile = 123456789,
                    Dist = "SWD9999001",
                    Pos = "Pankapal",
                    Pin = 90,
                    LandMark = "Near bara gachha",
                    Total = 1399,
                    OfficerId = 2,
                    ImageUrl = ""
                },
                new Client
                {
                    Id = 5,
                    CName = "Fortune of Time",
                    Mobile = 123456789,
                    Dist = "SWD9999001",
                    Pos = "Pankapal",
                    Pin = 90,
                    LandMark = "Near bara gachha",
                    Total = 1399,
                    OfficerId = 1,
                    ImageUrl = ""
                },
                new Client
                {
                    Id = 6,
                    CName = "Fortune of Time",
                    Mobile = 123456789,
                    Dist = "SWD9999001",
                    Pos = "Pankapal",
                    Pin = 90,
                    LandMark = "Near bara gachha",
                    Total = 1399,
                    OfficerId = 2,
                    ImageUrl = ""
                }
                );
        }
    }
}
