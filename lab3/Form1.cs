using System.Reflection.Metadata.Ecma335;

namespace lab3
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
                return $"{Title} - Issue #{IssueNumber}";
            }
        }

        //Task 2
        public class Ebook : Book
        {
            public string Format { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} (Format: {Format})";
            }
        }

        public void ProcessBooks(Book[] books)
        {
            listBoxBooks.Items.Clear();

            foreach (Book book in books)
            {
                listBoxBooks.Items.Add(book.GetInfo());
            }
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            Book[] books = new Book[]
            {
                new Book { Title = "System Design", Author = "Jay Al Alfonso" },
                new Magazine { Title = "Best Models Boys", IssueNumber = 45 },
                new Ebook { Title = "Calculus 2", Author = "Torres Guirerra", Format = "PDF" },
                new Textbook { Title = "Calculus 1", Author = "Albert Einstein", Subject = "CEE101"},
                new AudioBook { Title = "Differential Equation", Author = "Mr. Bean", Narrator = "Rowan Atkinson", Duration = 5.5}
            };

            ProcessBooks(books);
        }

        public class Textbook : Book
        {
            public string Subject { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} (Subject: {Subject})";
            }
        }

        public class AudioBook : Book
        {
            public double Duration { get; set; }
            public string Narrator { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} (Narrated by {Narrator}, Duration: {Duration} hrs)";
            }
        }
    }
}
