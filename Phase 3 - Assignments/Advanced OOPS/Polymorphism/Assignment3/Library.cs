using System;

namespace Assignment3
{
    public abstract class Library
    {
        protected static int s_serialNumber=1000;
        public string SerialNumber{get;}
        public abstract string AuthorName{get;set;}
        public abstract string BookName { get; set; }
        public abstract string PublisherName { get; set; }
        public abstract int Year { get; set; }
        public Library(string authorName,string bookName,string publisherName,int year){
            ++s_serialNumber;
            SerialNumber = "LIB" + s_serialNumber;
            AuthorName=authorName;
            BookName=bookName;
            Year=year;
        }
        public abstract void SetBookInfo();
        public abstract void DisplayInfo();
    }
}
