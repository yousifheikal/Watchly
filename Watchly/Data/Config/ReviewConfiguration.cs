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
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(x => x.ReviewId);

            builder.Property(x => x.Content)
                   .HasColumnType("text").IsRequired();

            builder.Property(x => x.Rating).HasPrecision(2, 1);

            builder.Property(x => x.ReviewDate)
                   .HasColumnType("datetime2") // Specify SQL Server type
                   .HasPrecision(3);

            builder.HasOne(x => x.Movie)
                   .WithMany(x => x.Reviews)
                   .HasForeignKey(x => x.MovieId);

            builder.HasOne(x => x.User)
                   .WithMany(x => x.Reviews)
                   .HasForeignKey(x => x.UserId);

            builder.ToTable("Reviews");

        }
    }
}
