using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crud_dot_net.Models;
public class Book
{

    [Key]
    public long Id { get; set; }
    public Guid Uuid { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Summary { get; set; }
    public DateTime PublishDate { get; set; }
    public int Quantity { get; set; }
}