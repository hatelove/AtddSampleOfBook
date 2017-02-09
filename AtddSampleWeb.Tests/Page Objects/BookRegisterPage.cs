using AtddSampleWeb.Models;
using FluentAutomation;

namespace AtddSampleWeb.Tests
{
    public class BookRegisterPage : PageObject<BookRegisterPage>
    {
        public BookRegisterPage(FluentTest test) : base(test)
        {
        }

        public void Create(BookModel book)
        {
            throw new System.NotImplementedException();
        }

        public void ShouldDisplay(string addedSuccessFulMessage)
        {
            throw new System.NotImplementedException();
        }
    }
}