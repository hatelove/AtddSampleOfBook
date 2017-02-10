using AtddSampleWeb.Models;
using System.Web.Mvc;

namespace AtddSampleWeb.Controllers
{
    public class BookController : Controller
    {
        private IBookService _bookService;

        public BookController()
        {            
        }

        public BookController(IBookService bookService)
        {
            this._bookService = bookService;
        }

        // GET: Book
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(BookViewMoel model)
        {
            this._bookService.Add(model);


            ViewBag.Message = "新增成功";
            return View(model);
        }
    }
}