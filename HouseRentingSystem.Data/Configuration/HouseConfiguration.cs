using System;
using System.Collections.Generic;
using HouseRentingSystem.Data.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRentingSystem.Data.Configuration
{
    public class HouseConfiguration : IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {

            builder.HasData(SeedHouses());
        }

        private IEnumerable<House> SeedHouses()
        {
            return new House[]
            {
                new House
                {
                    Id = 1,
                    Title = "Beach House",
                    Address = "Miami, Florida",
                    ImageUrl = @"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQvcje9el9YUxSqN4VSt3llpb6su9ghN-_ZbA&s",
                    PricePerMonth = 2000,
                    CategoryId = 1,
                    AgentId = 1,

                    Agent = default!
                },
                new House
                {
                    Id = 2,
                    Title = "Mountain House",
                    Address = "Rila Mountain, Bulgaria",
                    ImageUrl = @"https://bghike.com/en/images/huts_pic/rila_lakes_main.jpg",
                    PricePerMonth = 800,
                    CategoryId = 3,
                    AgentId = 2,
                    Agent = default!
                },
                new House
                {
                    Id = 3,
                    Title = "Urban House",
                    Address = "Luylin, Sofia",
                    ImageUrl = @"https://cdnp.ues.bg/projects/watermark_thumbs_768/257/180582.jpg",
                    PricePerMonth = 1200,
                    CategoryId = 1,
                    AgentId = 3,
                    Agent = default!
                }
            };
        }
    }
}