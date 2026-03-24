using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Biblioteca.Domain.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public required string Name { get; set; }
        [EmailAddress]
        public required string Email { get; set; }
        [PasswordPropertyText]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        public required string PasswordHash { get; set; }
        public required char Sex { get; set; }
        [Phone]
        public string? Phone { get; set; }
        public required Adress Adress { get; set; }
        public ICollection<Loan>? Loans { get; set; } 
        public ICollection<Book>? Books { get; set; } 

    }
}
