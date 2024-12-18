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
    public class CastConfiguration : IEntityTypeConfiguration<Cast>
    {
        public void Configure(EntityTypeBuilder<Cast> builder)
        {
            builder.HasKey(x => x.CastId);

            builder.Property(x => x.CharacterName)
                   .HasColumnType("VARCHAR").HasMaxLength(100).IsRequired();

            builder.Property(x => x.ActorName)
                   .HasColumnType("VARCHAR").HasMaxLength(100).IsRequired();

            builder.Property(x => x.RoleType)
                   .HasConversion<string>(); // Converts the enum to a string in the database;

            builder.Property(x => x.Note)
                   .HasColumnType("text").IsRequired(false);

            builder.HasOne(x => x.Movies)
                   .WithMany(x => x.Casts)
                   .HasForeignKey(x => x.MovieId);

            builder.ToTable("Casts");
        }
    }
}
