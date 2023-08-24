using TestGraphQL.Model;

namespace TestGraphQL.Data
{
    public class BookRepository : IBookRepository
    {
        private List<Book> _books = new List<Book>
            {
                //new Book { Author = new Author { Name = "Jon Skeet" }, Title = "C# in Depth" },
                //new Book { Author = new Author { Name = "Simon Robinson" }, Title = "Professional C# 7 and .NET Core 2.0" },
                //new Book { Author = new Author { Name = "Andrew Troelsen" }, Title = "Pro C# 7" },
                //new Book { Title = "Harry Potter and the Philosopher's Stone", Author = new Author { Name = "J. K. Rowling" } },
                //new Book { Title = "Harry Potter and the Chamber of Secrets", Author = new Author { Name = "J. K. Rowling" } },
                //new Book { Title = "Harry Potter and the Prisoner of Azkaban", Author = new Author { Name = "J. K. Rowling" } },
                //new Book { Title = "Harry Potter and the Goblet of Fire", Author = new Author { Name = "J. K. Rowling" } },
                //new Book { Title = "Harry Potter and the Order of the Phoenix", Author = new Author { Name = "J. K. Rowling" } },
                //new Book { Title = "Harry Potter and the Half-Blood Prince", Author = new Author { Name = "J. K. Rowling" } },
                //new Book { Title = "Harry Potter and the Deathly Hallows", Author = new Author { Name = "J. K. Rowling" } },
                //new Book { Title = "The Hobbit", Author = new Author { Name = "J. R. R. Tolkien" } },
                //new Book { Title = "The Fellowship of the Ring", Author = new Author { Name = "J. R. R. Tolkien" } },
            };

        public void AddBook(Book book)
        {
            if (!_books.Any(t => t.Title == book.Title))
                _books.Add(book);
        }

        public List<Book> GetBooks()
        {
            return _books;
        }

        Book? IBookRepository.GetBookByTitle(string title)
        {
            return _books.Find(b => string.Equals(b.Title, title, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}