using auth_jwt_token_asp_net_core_web_api_with_sameer.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace auth_jwt_token_asp_net_core_web_api_with_sameer.Data
{
    public class WalksDbContext : DbContext
    {
        public WalksDbContext(DbContextOptions<WalksDbContext> options) : base(options)
        {
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Difficulties
            // Easy, Medium, Hard

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("70cc45a7-fd24-4df7-aa30-0585cbabaaef"),
                    Name = "Easy"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("54d6af36-1448-4721-ac33-e1d241230e55"),
                    Name = "Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("8c8d3b4d-80b2-4030-bae3-c5bc26f6aa13"),
                    Name = "Hard"
                }
            };

            // Seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);


            // Seed data for Regions
            var regions = new List<Region>()
            {
                new Region
                {
                    Id = Guid.Parse("bff68585-2cd9-4a88-8e08-56e79c7ccf2d"),
                    Name = "Auckland",
                    Code = "AUC",
                    RegionImageUrl = ""
                },
                new Region
                {
                    Id = Guid.Parse("da0404b6-8afb-437f-ade3-9c028bbf624a"),
                    Name = "Northland",
                    Code = "NOR",
                    RegionImageUrl = ""
                },
                new Region
                {
                    Id = Guid.Parse("792319ea-0c5e-4556-a4ee-4f75134f41af"),
                    Name = "Bay Of Plenty",
                    Code = "BOP",
                    RegionImageUrl = ""
                },
                new Region
                {
                    Id = Guid.Parse("f70bbae4-f1c9-4506-9edc-a24bf8d3e629"),
                    Name = "Wellinton",
                    Code = "WELL",
                    RegionImageUrl = ""
                }
            };

            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}