using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crud_dot_net.Models;

public class Loan
{
    public Loan(long bookId, long userId, DateTime startDate, Book book, User user)
    {
        BookId = bookId;
        UserId = userId;
        StartDate = startDate;
        Book = book;
        User = user;
        Returned = false;
    }

    [Key]
    public long Id { get; set; }
    [Required] 
    public long BookId { get; set; }
    [ForeignKey("BookId")]
    [Required]
    public Book Book { get; set; }
    [Required]
    public long UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }
    [Required]
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool Returned { get; set; }
}