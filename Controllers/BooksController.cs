using Microsoft.AspNetCore.Mvc;
using Application.Queries;


namespace Controllers
{
    [Route("/xxx")]
    public class BooksController : ApiController
    {
        // 每次写api需要日志，注入日志
        private readonly ILogger<BooksController> _logger; // 只读，只有构造函数可以修改；ILogger默认控制台实现
       // private readonly IBookService _bookService; // 注入的是IBookService；BookService是实现

       // 构造函数，注入Logger
        public BooksController(ILogger<BooksController> logger)
        {
            _logger = logger;
        }

        public async Task<IEnumerable<string>> Index()
        {
            var list = await Mediator.Send(new GetAllBooksQuery());
            return list;
        }


        //  public BooksController(ILogger<BooksController> logger, IBookService bookService)
        // { // 构造函数
        //     _logger = logger;
        //     _bookService = bookService;
        // }

        // public IEnumerable<string> Index()
        // {
        //     _logger.LogInformation("Index 日志");

        //     // return new[] { "books", "books1", "books2", "books3", "books4", "books5" };
        //     return _bookService.GetAll();
        // }

        // [HttpGet]
        // public IEnumerable<string>
        // Index([FromServices] IBookService _bookService) // 使用时才注入(只有controller才可以)
        // {
        //     _logger.LogInformation("Logging from BooksController");
        //     return _bookService.GetAll();
        // }
    }
}
