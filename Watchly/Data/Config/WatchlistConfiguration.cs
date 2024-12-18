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
    public class WatchlistConfiguration : IEntityTypeConfiguration<WatchList>
    {
        public void Configure(EntityTypeBuilder<WatchList> builder)
        {
            builder.HasKey(x => x.WatchListID);

            builder.Property(x => x.AddedDate)
                   .HasColumnType("datetime2") // Specify SQL Server type
                   .HasPrecision(3);

            builder.HasOne(x => x.Movie)
                   .WithMany(x => x.WatchLists)
                   .HasForeignKey(x => x.MovieID);

            builder.HasOne(x => x.User)
                  .WithMany(x => x.WatchLists)
                  .HasForeignKey(x => x.UserID);

            builder.ToTable("WatchLists");
        }
    }
}
