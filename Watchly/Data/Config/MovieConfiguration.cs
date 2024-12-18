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
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            // MovieId Defined a Primary Key And Generated (Identity(seed, increment))
            builder.HasKey(x => x.MovieId);

            builder.Property(x => x.MovieName)
                   .HasColumnType("VARCHAR").HasMaxLength(70).IsRequired();

            builder.Property(x => x.Title)
                   .HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();

            builder.Property(x => x.Description)
                   .HasColumnType("text").IsRequired(false);

            builder.Property(x => x.ReleaseDate)
                   .HasColumnType("datetime2") // Specify SQL Server type
                   .HasPrecision(3);// Optional: Set precision

            builder.Property(x => x.Duration)
                   .HasColumnType("smallint") // Use `smallint` instead of `int` in SQL Server
                   .HasDefaultValue(0);  // Default value if no value is provided

            builder.Property(x => x.Language)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(20)
                   .HasDefaultValue("English");


            builder.ToTable("Movies");
        }
    }
}
