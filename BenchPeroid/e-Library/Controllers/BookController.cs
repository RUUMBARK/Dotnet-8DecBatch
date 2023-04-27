using e_Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace e_Library.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    
    private readonly ILogger<BookController> _logger;

    public BookController(ILogger<BookController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetBook")]
    public IEnumerable<Book> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Book
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
