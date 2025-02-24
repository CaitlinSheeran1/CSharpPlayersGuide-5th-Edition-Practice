// Caitlin Sheeran
// 2/24/2025

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EBook ebook1 = new EBook("Harry Potter and the Half-Blood Price", "J.K. Rowling", 2005, 160);
            PrintedBook printedBook1 = new PrintedBook("Game of Thrones", "George R.R. Martin", 1996, 694);

            Console.WriteLine(ebook1);
            Console.WriteLine(printedBook1);

           
        }
    }
    public abstract class Book
    {
        private string title = "n/a";
        private string author = "n/a";
        private int yearPublished = -1;

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }
        public int YearPublished
        {
            get { return this.yearPublished; }
            set { this.yearPublished = value; }
        }



        public Book(string aTitle, string aAuthor, int aYearPublished)
        {
            this.Title = aTitle;
            this.Author = aAuthor;
            this.YearPublished = aYearPublished;
        }



        public override string ToString()
        {
            string msg = "";
            msg += $"{this.Title} written by {this.Author} published in {this.YearPublished}";
            return msg;
        }
    }


    public class EBook : Book
    {
        private double fileSizeMB = -1.0;

        public double FileSizeMB
        {
            get { return this.fileSizeMB; }
            set { this.fileSizeMB = value; }
        }

        public EBook(string aTitle, string aAuthor, int aYearPublished, double aFileSizeMN) : base(aTitle, aAuthor, aYearPublished)
        {
            this.fileSizeMB = aFileSizeMN;
        }


        public override string ToString()
        {
            string msg = "";
            msg += $"{this.Title} written by {this.Author} published in {this.YearPublished}\n File Size: {this.FileSizeMB}mb\n";
            return msg;
        }
    }
    public class PrintedBook : Book
    {
        private int pageCount = -1;

        public int PageCount
        {
            get { return this.pageCount; }
            set { this.pageCount = value;  }
        }

        public PrintedBook(string aTitle, string aAuthor, int aYearPublished, int aPageCount) : base(aTitle, aAuthor, aYearPublished)
        {
            this.pageCount = aPageCount;
        }


        public override string ToString()
        {
            string msg = "";
            msg += $"{this.Title} written by {this.Author} published in {this.YearPublished}\n Page Count: {this.PageCount}\n";
            return msg;
        }
    }




}
