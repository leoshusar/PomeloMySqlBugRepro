using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySqlBug.Entities;

namespace MySqlBug.EntityTypeConfigurations
{
    public class ShelfEntityTypeConfiguration : IEntityTypeConfiguration<Shelf>
    {
        public void Configure(EntityTypeBuilder<Shelf> builder)
        {
            builder.ToTable("shelves");

            builder.HasIndex(e => e.ShelfTypeId);

            builder.HasIndex(e => e.RackId);

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("char(36)");

            builder.Property(e => e.RackId)
                .HasColumnName("rack_id")
                .HasColumnType("char(36)");

            builder.Property(e => e.ShelfTypeId)
                .HasColumnName("shelf_type_id")
                .HasColumnType("char(36)");

            builder.Property(e => e.VerticalPosition)
                .HasColumnName("vertical_position")
                .HasColumnType("int(11)");

            builder.HasOne(e => e.Type)
                .WithMany(p => p.Shelves)
                .HasForeignKey(d => d.ShelfTypeId);

            builder.HasOne(d => d.Rack)
                .WithMany(p => p.Shelves)
                .HasForeignKey(d => d.RackId);
        }
    }
}
