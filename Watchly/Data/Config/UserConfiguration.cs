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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // MovieId Defined a Primary Key And Generated (Identity(seed, increment))
            builder.HasKey(x => x.UserId);

            builder.Property(x => x.UserName)
                   .HasColumnType("VARCHAR").HasMaxLength(70).IsRequired();

            builder.Property(x => x.Email)
                   .HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();

            builder.Property(x => x.Password)
                   .HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();

            builder.Property(x => x.DateJoined)
                   .HasColumnType("datetime2") // Specify SQL Server type
                   .HasPrecision(3);// Optional: Set precision

            builder.ToTable("Users");
        }
    }
}
