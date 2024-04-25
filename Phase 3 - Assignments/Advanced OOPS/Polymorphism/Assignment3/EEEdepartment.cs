using System;

namespace Assignment3
{
    public class EEEdepartment : Library
    {
        

        public override string AuthorName { get ; set; }
        public override string BookName { get ; set; }
        public override string PublisherName { get ; set; }
        public override int Year { get ; set; }
        public EEEdepartment(string authorName, string bookName, string publisherName, int year) : base(authorName, bookName, publisherName, year)
        {
        }
        
        public override void SetBookInfo()
        {
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine("Setting EEE department Book info");
            System.Console.WriteLine();
            System.Console.Write("Enter Book Name: ");
            BookName=Console.ReadLine();
            System.Console.Write("Enter Author Name: ");
            AuthorName=Console.ReadLine();
            System.Console.Write("Enter Publisher Name: ");
            PublisherName=Console.ReadLine();
            System.Console.Write("Enter Year: ");
            Year=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Book Set successfully. Serial Number: "+SerialNumber);
            System.Console.WriteLine("------------------------------------");
            
        }
        public override void DisplayInfo()
        {
            
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine("Displaying EEE Depatment Book Details");
            System.Console.WriteLine("Serial Number: "+SerialNumber);
            System.Console.WriteLine("Book Name: "+BookName);
            System.Console.WriteLine("Author Name: "+AuthorName);
            System.Console.WriteLine("Publisher Name: "+PublisherName);
            System.Console.WriteLine("Year: "+Year);
            System.Console.WriteLine("------------------------------------");
        }

        
    }
}
