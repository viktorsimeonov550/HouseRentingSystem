using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseRentingSystem.Data.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRentingSystem.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public CategoryConfiguration() { }
        public CategoryConfiguration(string name) { }

        public void Configure(EntityTypeBuilder<Category> builder)
        {

        }

        private IEnumerable<Category> SeedCategories()
        {
            return new Category[]
            {
               new Category
               {
                     Id = 1,
                     Name = "Urban",
               },
                new Category
                {
                        Id = 2,
                        Name = "Suburban"
                },
                new Category
                {
                        Id = 3,
                        Name = "Rural"
                }
            };
        }


    }
}