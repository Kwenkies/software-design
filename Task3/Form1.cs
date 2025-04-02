namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Book
        {
            public string Title { get; set; }

            public string Author { get; set; }


            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }


        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author} - issue {IssueNumber}";
            }
        }

        public class Ebook : Book
        {
            public string Format { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author} - Format: {Format}";
            }
        }

        public class TextBook : Book
        {
            public string Subject { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author} - Subject: {Subject}";
            }

        }

        public class AudioBook : Book
        {
            public string Narrator { get; set; }

            public string Duration { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author} - Narrator: {Narrator} Duration: {Duration}";
            }


            public void ProcessBooks(Book[] books)
            {
                ProcessBooksRecursive(books, 0);
            }

            private void ProcessBooksRecursive(Book[] books, int index)
            {
                if (index >= books.Length)
                {
                    return;
                }

                ProcessBooksRecursive(books, index + 1);
            }

        }

        private void btnShowinfo_Click(object sender, EventArgs e)
        {
            Book myBook = new Book
            {
                Title = "Tech Weekly",
                Author = "John Doe",

            };

            Book myEbook = new Ebook
            {
                Title = "Once upon a time",
                Author = "Mimasur",
                Format = "PDF"
            };

            Book myMagazine = new Magazine
            {
                Title = "Daily shooting",
                Author = "bulbasur",
                IssueNumber = 09
            };

            Book myTextBook = new TextBook
            {
                Title = "Tech Weekly's Puzzles",
                Author = "Rover",
                Subject = "Math"
            };

            Book myAudioBook = new AudioBook
            {
                Title = "The songs of Mahimiya Forests",
                Author = "Sofia",
                Narrator = "Golden Narra",
                Duration = "2 hours"
            };

            Book[] books = { myBook, myEbook, myMagazine, myTextBook, myAudioBook };
            listBoxBooks.Items.Clear();
            foreach (Book book in books)
            {
                listBoxBooks.Items.Add(book.GetInfo());

            }
        }
    }
}
