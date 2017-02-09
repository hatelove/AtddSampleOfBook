using System;
using System.Linq;
using AtddSampleWeb.Controllers;
using AtddSampleWeb.Models;
using AtddSampleWebTests.DataModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AtddSampleWebTests
{
    [Binding]
    [Scope(Feature = "BookController")]
    public class BookControllerSteps
    {
        private BookController _bookController;

        [BeforeScenario()]
        public void BeforeScenario()
        {
            this._bookController = new BookController();
        }

        [Given(@"a book for registering")]
        public void GivenABookForRegistering(Table table)
        {
            var book = table.CreateInstance<BookViewMoel>();
            ScenarioContext.Current.Set<BookViewMoel>(book);
        }

        [When(@"Create")]
        public void WhenCreate()
        {
            var book = ScenarioContext.Current.Get<BookViewMoel>();
            this._bookController.Create(book);
        }

        [Then(@"Book table should exist a record")]
        public void ThenBookTableShouldExistARecord(Table table)
        {
            using (var dbcontext = new NorthwindEntities())
            {
                var firstBook = dbcontext.Books.FirstOrDefault();
                Assert.IsNotNull(firstBook);

                table.CompareToInstance(firstBook);
            }
        }
    }
}
