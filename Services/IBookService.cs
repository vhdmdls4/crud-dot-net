using crud_dot_net.DTO;
using crud_dot_net.Models;

namespace crud_dot_net.Services;

public interface IBookService
{
    Task<Book?> GetByIdAsync(long id);
    Task<List<Book?>> GetAllAsync();
    Task AddAsync(CreateBookRequest request);
    Task UpdateAsync(long id, CreateBookRequest request);
    Task DeleteAsync(long id);
}