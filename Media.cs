using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    public enum BookType { Book, Magzine,Movie };

    public class Media
    {
      

        public string Title { get;  set; }
        public BookType Type { get;  set; }
        public Boolean Availability { get;  set; }
        public string Borrower { get;  set; }
        public static int SerialNumber { get; private set; }
        public  int LentTime { get; private set; }

        /*public Media(string title, BookType type, bool availability, string borrower,string auther)
        {
            SerialNumber++;
            Title = title;
            Type = type;
            Availability = availability;
            Borrower = borrower
            Auther = auther;
        }*/
        public Media(string title, BookType type, bool availability, string borrower, int lentTime)
        {
            SerialNumber++;
            Title = title;
            Type = type;
            Availability = availability;
            Borrower = borrower;
            LentTime = lentTime;
        }

    }
}
