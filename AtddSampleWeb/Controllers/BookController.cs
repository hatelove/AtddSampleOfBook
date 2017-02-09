using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AtddSampleWeb.Models;

namespace AtddSampleWeb.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(BookViewMoel model)
        {
            ViewBag.Message = "新增成功";
            return View(model);
        }
    }
}