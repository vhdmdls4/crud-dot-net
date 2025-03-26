using crud_dot_net.DTO;
using crud_dot_net.Models;

namespace crud_dot_net.Services;

public interface IBookService
{
    Task<Book?> GetByIdAsync(long id);
    Task<IEnumerable<Book>> GetAllAsync();
    Task<Book> AddAsync(CreateBookRequest request);
    Task<Book> UpdateAsync(long id, CreateBookRequest request);
    Task DeleteAsync(long id);
}