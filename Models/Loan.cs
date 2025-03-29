using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crud_dot_net.Models;

public class Loan
{
    public Loan(long id, long bookId, long userId, DateTime startDate, DateTime endDate)
    {
        Id = id;
        BookId = bookId;
        UserId = userId;
        StartDate = startDate;
        EndDate = endDate;
        Returned = false;
    }

    [Key]
    public long Id { get; set; }
    
    public long BookId { get; set; }
    [ForeignKey("BookId")]
    public Book Book { get; set; }
    
    public long UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }
    
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool Returned { get; set; }
}