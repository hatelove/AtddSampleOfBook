using AtddSampleWeb.Models;
using AtddSampleWeb.Models.DataModels;
using System.Web.Mvc;

namespace AtddSampleWeb.Controllers
{
    public class BookController : Controller
    {
        private IBookService bookServiceStub;

        public BookController()
        {
            
        }

        public BookController(IBookService bookServiceStub)
        {
            this.bookServiceStub = bookServiceStub;
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
            using (var dbcontext = new BookEntities())
            {
                var book = new Book { ISBN = model.ISBN, Name = model.Name };
                dbcontext.Books.Add(book);

                dbcontext.SaveChanges();
            }

            ViewBag.Message = "新增成功";
            return View(model);
        }
    }
}