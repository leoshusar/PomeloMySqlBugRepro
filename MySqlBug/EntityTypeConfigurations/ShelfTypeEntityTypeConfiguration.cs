using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySqlBug.Entities;

namespace MySqlBug.EntityTypeConfigurations
{
    public class ShelfTypeEntityTypeConfiguration : IEntityTypeConfiguration<ShelfType>
    {
        public void Configure(EntityTypeBuilder<ShelfType> builder)
        {
            builder.ToTable("shelf_types");

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("char(36)");

            builder.Property(e => e.Thickness)
                .HasColumnName("thickness")
                .HasColumnType("int(11)");
        }
    }
}
