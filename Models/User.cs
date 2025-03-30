using System.ComponentModel.DataAnnotations;

namespace crud_dot_net.Models;

public class User : EntityBase
{
    public User(long id, string name, string password, string email, string phone, string document, ICollection<Loan> loans)
    {
        Id = id;
        Name = name;
        Password = password;
        Email = email;
        Phone = phone;
        Document = document;
        Loans = loans;
    }

    [Key]
    public long Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Document { get; set; }
    public ICollection<Loan> Loans { get; set; }
}