using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class BookInfo:RackInfo
    {
        private static int s_bookID=100;
        public string BookID{get;}
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }
        public BookInfo(string departmentName,string degree,int rackNumber,int columnNumber,string bookName,string authorName,double price){
            ++s_bookID;
            BookID="BID"+s_bookID;
            DepartmentName=departmentName;
            Degree=degree;
            RackNumber=rackNumber;
            ColumnNumber=columnNumber;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }
        public void Display(){
            System.Console.WriteLine("Book Details");
            System.Console.WriteLine("____________________________");
            System.Console.WriteLine($"Department Name: {DepartmentName}");
            System.Console.WriteLine($"Degree         : {Degree}");
            System.Console.WriteLine($"Rack Number    : {RackNumber}");
            System.Console.WriteLine($"Column Number  : {ColumnNumber}");
            System.Console.WriteLine($"Book ID        : {BookID}");
            System.Console.WriteLine($"Book Name      : {BookName}");
            System.Console.WriteLine($"Author Name    : {AuthorName}");
            System.Console.WriteLine($"Price          : {Price}");
            System.Console.WriteLine("------------------------------");
        }
    }
}