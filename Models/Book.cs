using System.ComponentModel.DataAnnotations;

namespace crud_dot_net.Models;

public class Book
{
    public Book(long id, Guid uuid, string title, string author, string summary, DateTime publishDate, int quantity)
    {
        Id = id;
        Uuid = uuid;
        Title = title;
        Author = author;
        Summary = summary;
        PublishDate = publishDate;
        Quantity = quantity;
    }

    [Key]
    public long Id { get; set; }
    public Guid Uuid { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Summary { get; set; }
    public DateTime PublishDate { get; set; }
    public int Quantity { get; set; }
}