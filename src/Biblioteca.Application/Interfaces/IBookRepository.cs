using Biblioteca.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Application.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBookAsync();
        Task<Book> GetBookById(Guid Id);
        Task AddBookAsync(Book book);
        Task UpdateBookAsync(Book book);
        Task DeleteBookAsyns(Book book);

    }
}
