using Microsoft.EntityFrameworkCore;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Author
        {
            public int AuthorID { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }
        }

        public void AddAuthorWithBook(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };
                context.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();
            }
        }

        public List<string> GetBookWithAuthors()
        {
            using (var context = new BookstoreContext())
            {
                var booksWithAuthors = context.Books
                    .Include(b => b.Author)
                    .Select(b => $"{b.BookID} \t {b.Title} by {b.Author.Name}")
                    .ToList();
                return booksWithAuthors;
            }
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            var books = GetBookWithAuthors();
            listBoxBooks.DataSource = books;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string authorName = txtboxAuthorName.Text.Trim();
            string bookTitle = txtboxBookTitle.Text.Trim();
            AddAuthorWithBook(authorName, bookTitle);
        }

        public void DeleteBookWithBookID(int id)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Find(id);
                var author = context.Authors.Find(id);
                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                    MessageBox.Show("Book deleted successfully.");
                }
                else
                {
                    MessageBox.Show($"Book with ID {id} not found.");
                }
            }
        }
        public void SearchBooksByAuthorName(string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var books = context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Author.Name.Contains(authorName))
                    .Select(b => $"{b.BookID} \t {b.Title} by {b.Author.Name}")
                    .ToList();

                if (books.Count > 0)
                {
                    listBoxBooks.DataSource = books;
                }
                else
                {
                    MessageBox.Show($"No books found for author name: {authorName}");
                    listBoxBooks.DataSource = null;
                }
            }
        }
        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string authorName = txtboxAuthorName.Text.Trim();
            SearchBooksByAuthorName(authorName);
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt32(txtboxBookID.Text.Trim());
            DeleteBookWithBookID(bookID);
        }
    }
}
