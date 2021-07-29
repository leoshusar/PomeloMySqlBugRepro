using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySqlBug.Entities;

namespace MySqlBug.EntityTypeConfigurations
{
    public class RackTypeEntityTypeConfiguration : IEntityTypeConfiguration<RackType>
    {
        public void Configure(EntityTypeBuilder<RackType> builder)
        {
            builder.ToTable("rack_types");

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("char(36)");

            builder.Property(e => e.Size)
                .HasColumnName("size")
                .HasColumnType("int(11)");
        }
    }
}
