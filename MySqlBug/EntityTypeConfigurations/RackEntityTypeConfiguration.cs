using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySqlBug.Entities;

namespace MySqlBug.EntityTypeConfigurations
{
    public class RackEntityTypeConfiguration : IEntityTypeConfiguration<Rack>
    {
        public void Configure(EntityTypeBuilder<Rack> builder)
        {
            builder.ToTable("racks");

            builder.HasIndex(e => e.RackTypeId);

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("char(36)");

            builder.Property(e => e.RackTypeId)
                .HasColumnName("rack_type_id")
                .HasColumnType("char(36)");

            builder.HasOne(e => e.Type)
                .WithMany(p => p.Racks)
                .HasForeignKey(d => d.RackTypeId);
        }
    }
}
