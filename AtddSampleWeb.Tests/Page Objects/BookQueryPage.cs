using System;
using System.Collections.Generic;
using System.Linq;
using FluentAutomation;

namespace AtddSampleWebTests
{
    public class BookQueryPage : PageObject<BookQueryPage>
    {
        public BookQueryPage(FluentTest test) : base(test)
        {
            this.Url = $"{PageContext.Domain}/books/query";
        }

        public void Query(BookQueryCondition condition)
        {
            I.Enter(condition.Name).In("#name")
                .Click("input[type=\"submit\"]");
        }

        public void ShouldDisplay(IEnumerable<BookQueryResult> books)
        {
            for (int i = 0; i < books.Count(); i++)
            {
                var book = books.ElementAt(i);
                I.Assert.Text(book.Name).In($"td .name:nth-child({i + 1})");
            }
        }
    }
}