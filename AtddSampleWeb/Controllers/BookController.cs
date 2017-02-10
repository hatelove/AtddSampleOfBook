﻿using AtddSampleWeb.Models;
using System.Collections.Generic;
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
            return new List<BookViewMoel>
            {
                new BookViewMoel() {Name = "玩出好創意", ISBN = "9789869094481"},
                new BookViewMoel() {Name = "玩出好創意", ISBN = "9789869094481"},
            };
        }
    }
}