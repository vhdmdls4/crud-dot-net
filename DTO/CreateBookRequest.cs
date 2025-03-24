using System.ComponentModel.DataAnnotations;

namespace crud_dot_net.DTO;

public class CreateBookRequest
{
    [Required]
    public string Uuid { get; set; }
    [Required]
    [StringLength(150)]
    public string Title { get; set; }
    [Required]
    [StringLength(150)]
    public string Author { get; set; }
    [StringLength(500)]
    public string Summary { get; set; }
    public DateTime PublishDate { get; set; }
    public int Quantity { get; set; }
}