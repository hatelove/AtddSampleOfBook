using AtddSampleWeb.Models;
using FluentAutomation;

namespace AtddSampleWeb.Tests
{
    public class BookRegisterPage : PageObject<BookRegisterPage>
    {
        public BookRegisterPage(FluentTest test) : base(test)
        {
            this.Url = $"{PageContext.Domain}/book/create";
        }

        public void Create(BookModel book)
        {
            I.Enter(book.ISBN).In("#isbn")
                .Enter(book.Name).In("#name")
                .Click("input[type=\"submit\"]");
        }

        public void ShouldDisplay(string message)
        {
            I.Assert.Text(message).In("#message");
        }
    }
}