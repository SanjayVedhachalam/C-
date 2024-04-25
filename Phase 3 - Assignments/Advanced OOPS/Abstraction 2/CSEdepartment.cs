using System;

namespace Abstraction_2
{
    public class CSEdepartment:Library
    {
        public override string AuthorName { get; set; }
        public override string BookName { get; set; }
        public override string PublisherName { get; set ; }
        public override int Year { get; set; }

        public CSEdepartment(string authorName, string bookName, string publisherName, int year) : base(authorName, bookName, publisherName, year)
        {
        }

        public override void DisplayInfo()
        {
            System.Console.WriteLine("Display Book Details");
            System.Console.WriteLine($"Book Name: {BookName}");
            System.Console.WriteLine($"Author Name: {AuthorName}");
            System.Console.WriteLine($"Publisher Name: {PublisherName}");
            System.Console.WriteLine($"Year: {Year}");
            System.Console.WriteLine($"Book ID: {SerialNumber}");
            
        }

        public override void SetBookInfo()
        {
            System.Console.WriteLine("Setting Book info");
            System.Console.Write("Enter Author Name: ");
            AuthorName=Console.ReadLine();
            System.Console.Write("Enter Book Name: ");
            BookName=Console.ReadLine();
            System.Console.Write("Enter Publisher Name: ");
            PublisherName=Console.ReadLine();
            System.Console.Write("Enter Year: ");
            Year=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Book set successfully. Book ID is: "+SerialNumber);
            
        }
    }
}
