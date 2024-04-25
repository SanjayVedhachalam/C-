using System;
using Assignment_2;
namespace Assignment2;
class Program{
    public static void Main(string[] args)
    {
        BookInfo book1=new BookInfo("Information Technology","B. Tech",3,4,"C# Made Easy","Mysskin",2000);
        BookInfo book2=new BookInfo("Computer Science","B. E",9,5,"Basics to Intermediate in java","James Goshling",1200);
        BookInfo book3=new BookInfo("Electrical and Electronics","B. E",6,1,"C Programming","Butler",1500);
        book1.Display();
        book2.Display();
        book3.Display();

    }
}