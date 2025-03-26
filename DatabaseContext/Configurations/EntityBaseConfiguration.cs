using crud_dot_net.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace crud_dot_net.DatabaseContext.Configurations;

public class EntityBaseConfiguration<T> : IEntityTypeConfiguration<T> where T : EntityBase
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.Property(x => x.Uuid)
            .IsRequired();

        builder.Property(x => x.Created)
            .IsRequired()
            .HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.Property(x => x.LastModified)
            .IsRequired()
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
    }
}