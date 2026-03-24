using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Entities
{
    public class Book
    {
        public Guid BookId { get; set; }
        public required string Name { get; set; }
        public required string Author { get; set; }
        public required int Quantity { get; set; }
        public ICollection<Loan> Loans { get; set; }
        public void DecreaseQuantity() {
            if (Quantity < 0)
            {
                throw new ArgumentException ("Livro Indisponivel");
            }
            Quantity --;
        }
        public void IncreaseQuantity() {
            Quantity ++;
        }
    }
}
