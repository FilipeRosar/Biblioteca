using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Entities
{
    public class Adress
    {
        public Guid AdressId{ get; set; }
        public required string Street { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public required string CEP { get; set; }
        public required int Number { get; set; }

    }
}
