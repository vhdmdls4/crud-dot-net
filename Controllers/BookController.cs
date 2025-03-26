using crud_dot_net.DTO;
using crud_dot_net.Models;
using crud_dot_net.Services;
using Microsoft.AspNetCore.Mvc;

namespace crud_dot_net.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{
    private readonly IBookService _bookService;
    private readonly ILogger<BookController> _logger;

    public BookController(IBookService bookService, ILogger<BookController> logger)
    {
        _bookService = bookService;
        _logger = logger;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Book>> Get(long id)
    {
        try
        {
            var book = await _bookService.GetByIdAsync(id);
            return book == null ? NotFound() : Ok(book);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error getting book with id {Id}", id);
            return StatusCode(500, "An error occurred while processing your request.");
        }
    }

    [HttpGet("all")]
    public async Task<ActionResult<IEnumerable<Book>>> GetAll()
    {
        try
        {
            var books = await _bookService.GetAllAsync();
            return Ok(books);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error getting all books");
            return StatusCode(500, "An error occurred while processing your request.");
        }
    }

    [HttpPost("add")]
    public async Task<ActionResult<Book>> Create(CreateBookRequest request)
    {
        try
        {
            await _bookService.AddAsync(request);
            return CreatedAtAction(nameof(Get), request);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error creating book");
            return StatusCode(500, "An error occurred while processing your request.");
        }
    }
    //TODO - create UpdateBookRequest
    [HttpPut("{id}")]
    public async Task<ActionResult<Book>> Update(long id, CreateBookRequest request)
    {
        try
        {
            await _bookService.UpdateAsync(id, request);
            return Ok(request);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error updating book with id {Id}", id);
            return StatusCode(500, "An error occurred while processing your request.");
        }
    }

    public async Task<ActionResult> Delete(long id)
    {
        try
        {
            await _bookService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error deleting book with id {Id}", id);
            return StatusCode(500, "An error occurred while processing your request.");
        }
    }
}