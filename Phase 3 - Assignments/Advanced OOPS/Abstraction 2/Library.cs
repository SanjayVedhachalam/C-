using System;

namespace Abstraction_2
{
    public abstract class Library
    {
        private static int s_serialNumber=1000;
        protected string serialNumber;
        public string SerialNumber
        {
            get
            {
                return serialNumber;
            }
            set{
                serialNumber=value;
            }
        }
        public abstract string AuthorName{get;set;}
        public abstract string BookName { get; set; }
        public abstract string PublisherName { get; set; } 
        public abstract int Year { get; set; }

        public Library(string authorName,string bookName,string publisherName,int year){
            ++s_serialNumber;
            SerialNumber="LIB"+s_serialNumber;
            AuthorName=authorName;
            BookName=bookName;
            PublisherName=publisherName;
            Year=year;
        }
        public abstract void SetBookInfo();
        public abstract void DisplayInfo();
    }
}
