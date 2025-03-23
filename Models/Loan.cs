using System.ComponentModel.DataAnnotations;

namespace crud_dot_net.Models;

public class Loan
{
    [Key]
    public long Id { get; set; }
    public int BookId { get; set; }
    public int UserId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool Returned { get; set; }
}