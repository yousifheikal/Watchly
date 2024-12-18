using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watchly.Entites;

namespace Watchly.Data.Config
{
    public class MovieCategoryConfiguration : IEntityTypeConfiguration<MovieCategory>
    {
        public void Configure(EntityTypeBuilder<MovieCategory> builder)
        {
            // Two Primary Key 
            builder.HasKey(x => new {x.MovieId, x.CategoryId});

            // Relationship
            builder.HasOne(x => x.Movie)
                   .WithMany(x => x.MovieCategories)
                   .HasForeignKey(x => x.MovieId);

            builder.HasOne(x => x.Categories)
                   .WithMany(x => x.MovieCategories)
                   .HasForeignKey(x => x.CategoryId);

            builder.ToTable("MovieCategories");
        }
    }
}
