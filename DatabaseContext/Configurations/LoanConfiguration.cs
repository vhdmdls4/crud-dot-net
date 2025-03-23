using crud_dot_net.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace crud_dot_net.DatabaseContext.Configurations;

public class LoanConfiguration : IEntityTypeConfiguration<Loan>
{
    public void Configure(EntityTypeBuilder<Loan> builder)
    {
        builder.ToTable("Loans")
            .HasKey(x => x.Id);
        builder.Property(x => x.BookId)
            .IsRequired();
        builder.Property(x => x.UserId)
            .IsRequired();
        builder.Property(x => x.StartDate)
            .IsRequired();
        builder.Property(x => x.EndDate)
            .IsRequired();
        builder.Property(x => x.Returned)
            .IsRequired();
    }
}