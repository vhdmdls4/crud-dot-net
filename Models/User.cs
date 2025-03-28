﻿using System.ComponentModel.DataAnnotations;

namespace crud_dot_net.Models;

public class User : EntityBase
{
    [Key]
    public long Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Document { get; set; }
    public ICollection<Loan> Loans { get; set; }
}