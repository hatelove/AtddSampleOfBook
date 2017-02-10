using AtddSampleWeb.Models.DataModels;

namespace AtddSampleWeb.Models
{
    public class BookService : IBookService
    {
        public void Add(BookViewMoel model)
        {
            using (var dbcontext = new BookEntities())
            {
                var book = new Book { ISBN = model.ISBN, Name = model.Name };
                dbcontext.Books.Add(book);

                dbcontext.SaveChanges();
            }
        }
    }
}