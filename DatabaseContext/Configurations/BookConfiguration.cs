using crud_dot_net.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace crud_dot_net.DatabaseContext.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("Books")
            .HasKey(x => x.Id);
        builder.Property(x => x.Author)
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(x => x.Title)
            .HasMaxLength(150)
            .IsRequired();
        builder.Property(x => x.Quantity)
            .IsRequired();
        builder.Property(x => x.Uuid)
            .IsRequired();
        builder.Property(x => x.Summary)
            .HasMaxLength(500)
            .IsRequired();
        builder.Property(x => x.PublishDate)
            .IsRequired();
    }
}