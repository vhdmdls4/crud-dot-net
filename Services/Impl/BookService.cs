using AutoMapper;
using crud_dot_net.DTO;
using crud_dot_net.Models;
using crud_dot_net.Repository;

namespace crud_dot_net.Services.Impl;

public class BookService : IBookService
{
    private readonly IBookRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<BookService> _logger;

    public BookService(IBookRepository repository, IMapper mapper, ILogger<BookService> logger)
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }
    
    public async Task<Book?> GetByIdAsync(long id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<Book>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Book> AddAsync(CreateBookRequest request)
    {
        var book = _mapper.Map<Book>(request);
        await _repository.AddAsync(book);
        return book;
    }

    public async Task<Book> UpdateAsync(long id, CreateBookRequest request)
    {
        var book = await _repository.GetByIdAsync(id);
        if (book == null)
        {
            throw new KeyNotFoundException($"Book with id {id} not found");
        }
        _mapper.Map(request, book);
        await _repository.UpdateAsync(book);
        return book;
    }

    public async Task DeleteAsync(long id)
    {
        await _repository.DeleteAsync(id);
    }
}