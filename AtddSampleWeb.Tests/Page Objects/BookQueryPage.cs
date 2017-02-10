using System.Collections.Generic;
using FluentAutomation;

namespace AtddSampleWebTests
{
    public class BookQueryPage : PageObject<BookQueryPage>
    {
        public BookQueryPage(FluentTest test) : base(test)
        {

        }

        public void Query(BookQueryCondition condition)
        {
            throw new System.NotImplementedException();
        }

        public void ShouldDisplay(IEnumerable<BookQueryResult> books)
        {
            throw new System.NotImplementedException();
        }
    }
}