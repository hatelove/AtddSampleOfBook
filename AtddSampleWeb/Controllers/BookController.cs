using AtddSampleWeb.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AtddSampleWeb.Models.DataModels;

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

        [HttpGet]
        public ActionResult Query()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Query(BookQueryViewModel model)
        {
            model.Books = this.GetBooks(model);
            return View(model);
        }



        private IEnumerable<BookViewMoel> GetBooks(BookQueryViewModel model)
        {
            using (var dbcontext = new BookEntities())
            {
                var books = dbcontext.Books
                    .Where(x => x.Name == model.Name)
                    .Select(x => new BookViewMoel() { Name = x.Name, ISBN = x.ISBN }).ToList();

                return books;
            }
        }
    }
}