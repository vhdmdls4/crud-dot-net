using System.ComponentModel.DataAnnotations;

namespace crud_dot_net.DTO;

public class CreateBookRequest(string Title, string Author, string Summary, DateTime PublishDate, int Quantity)
{
    [Required]
    [StringLength(150)]
    public string Title { get; set; } = Title;

    [Required]
    [StringLength(150)]
    public string Author { get; set; } = Author;

    [StringLength(500)]
    public string Summary { get; set; } = Summary;

    public DateTime PublishDate { get; set; } = PublishDate;
    public int Quantity { get; set; } = Quantity;
}