using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Core.Entities;

namespace SocialMedia.Infrastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.ToTable("Usuario");

            builder.HasKey(e => e.UserId);

            builder.Property(e => e.UserId)
                    .HasColumnName("IdUsuario")
                    .ValueGeneratedNever();

            builder.Property(e => e.LastName)
                 .HasColumnName("Nombres")
                 .IsRequired()
                 .HasMaxLength(50)
                 .IsUnicode(false);

            builder.Property(e => e.Email)
                 .HasColumnName("Email")
                 .IsRequired()
                 .HasMaxLength(30)
                 .IsUnicode(false);

            builder.Property(e => e.DateOfBird)
                 .HasColumnName("FechaNacimiento")
                 .HasColumnType("date");

            builder.Property(e => e.FirstName)
                 .HasColumnName("Apellidos")
                 .IsRequired()
                 .HasMaxLength(50)
                 .IsUnicode(false);

            builder.Property(e => e.Telephone)
                 .HasColumnName("Telefono")
                 .HasMaxLength(10)
                 .IsUnicode(false);

            builder.Property(e => e.UserId)
                  .HasColumnName("IdUsuario");
        }
    }
}
