using System;
using System.Threading.Tasks;
using Books.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Books.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly IBooksRepository _repository;

        public BooksController(IBooksRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            return Ok(_repository.GetBooks());
        }


        [HttpGet("{id}")]
        public IActionResult GetBookById(Guid id)
        {
            var book = _repository.GetBookById(id);
            if(book == null){
                return NotFound();
            }
            return Ok(book);
        } 
    }
}
