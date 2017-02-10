using Microsoft.VisualStudio.TestTools.UnitTesting;
using AtddSampleWeb.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using AtddSampleWeb.Models;

namespace AtddSampleWeb.Controllers.Tests
{
    [TestClass()]
    public class BookControllerTests
    {
        [TestMethod()]
        public void CreateTest_should_invoke_IBookService_Add_one_time()
        {
            var bookServiceStub = Substitute.For<IBookService>();
            var bookController = new BookController(bookServiceStub);

            var book = new BookViewMoel() {ISBN = "9789869094481", Name = "玩出好創意"};
            var result = bookController.Create(book);

            bookServiceStub.Received().Add(Arg.Is<BookViewMoel>
                (x => x.ISBN == book.ISBN && x.Name == book.Name));
        }
    }
}