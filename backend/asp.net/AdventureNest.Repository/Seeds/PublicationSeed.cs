﻿using AdventureNest.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AdventureNest.Repository.Seeds
{
    namespace AdventureNest.Repository.Seeds
    {
        public class PublicationSeed : IEntityTypeConfiguration<Publication>
        {
            public void Configure(EntityTypeBuilder<Publication> builder)
            {
                builder.HasData(
                    new Publication
                    {
                        Id = 1,
                        Description = "Villa with Sapanca Lake view",
                        Title = "Sakarya Lux Villa House",
                        IsActive = true,
                        Price = 1000,
                        PropertyId = 1,
                        CreatedDate = DateTime.Now
                    },
                    new Publication
                    {
                        Id = 2,
                        Description = "Villa with Miami Beach view",
                        Title = "Ultra Lux Villa in Miami",
                        IsActive = true,
                        Price = 4000,
                        PropertyId = 2,
                        CreatedDate = DateTime.Now
                    },
                    new Publication
                    {
                        Id = 3,
                        Description = "A beautiful house in the center of Kadıköy",
                        Title = "Comfortable House in Kadikoy",
                        IsActive = true,
                        Price = 800,
                        PropertyId = 3,
                        CreatedDate = DateTime.Now
                    },
                    new Publication
                    {
                        Id = 4,
                        Description = "Ultra luxury all-inclusive accommodation by the ocean in the Maldives",
                        Title = "Unique Villa with deep blue ocean view",
                        IsActive = true,
                        Price = 1000,
                        PropertyId = 4,
                        CreatedDate = DateTime.Now
                    },
                    new Publication
                    {
                        Id = 5,
                        Description = "A hotel room in the unique beauty of the island of Sardinia",
                        Title = "All inclusive hotel room with sea view",
                        IsActive = true,
                        Price = 2500,
                        PropertyId = 5,
                        CreatedDate = DateTime.Now
                    },
                    new Publication
                    {
                        Id = 6,
                        Description = "One room house",
                        Title = "Affordable studio home in Paris",
                        IsActive = true,
                        Price = 200,
                        PropertyId = 6,
                        CreatedDate = DateTime.Now
                    }
                    );
            }
        }
    }
}
