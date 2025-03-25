using AutoMapper;
using crud_dot_net.DTO;
using crud_dot_net.Models;
using crud_dot_net.Repository;

namespace crud_dot_net.Services.Impl;

public class BookService : IBookService
{
    private readonly IBookRepository _repository;
    private readonly IMapper _mapper;

    public BookService(IBookRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public async Task<Book?> GetByIdAsync(long id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<List<Book?>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task AddAsync(CreateBookRequest request)
    {
        var book = _mapper.Map<Book>(request);
        await _repository.AddAsync(book);
    }

    public async Task UpdateAsync(long id, CreateBookRequest request)
    {
        var book = await _repository.GetByIdAsync(id);
        if (book != null)
        {
            _mapper.Map(request, book);
            await _repository.UpdateAsync(book);
        }
    }

    public async Task DeleteAsync(long id)
    {
        await _repository.DeleteAsync(id);
    }
}