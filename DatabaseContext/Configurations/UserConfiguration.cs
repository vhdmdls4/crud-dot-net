using crud_dot_net.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace crud_dot_net.DatabaseContext.Configurations;

using Microsoft.EntityFrameworkCore;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users")
            .HasKey(x => x.Id);
        builder.Property(x => x.Name)
            .HasMaxLength(100)
            .IsRequired();
        builder.Property(x => x.Password)
            .HasMaxLength(100)
            .IsRequired();
        builder.Property(x => x.Email)
            .HasMaxLength(100)
            .IsRequired();
        builder.Property(x => x.Phone)
            .HasMaxLength(15)
            .IsRequired();
        builder.Property(x => x.Document)
            .HasMaxLength(20)
            .IsRequired();
        builder.HasMany(x => x.Loans)
            .WithOne()
            .HasForeignKey(x => x.UserId);
    }
}