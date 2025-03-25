using crud_dot_net.Models;

namespace crud_dot_net.Repository;

public interface IBookRepository
{
    Task<Book?> GetByIdAsync(long id);
    Task<List<Book?>> GetAllAsync();
    Task AddAsync(Book book);
    Task UpdateAsync(Book book);
    Task DeleteAsync(long id);
}