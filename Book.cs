using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    public class Book : Media
    {

        public  int PageCount { get; private set; }

        public Book(string title, BookType type, bool availability, string borrower, int lentTime,int pageCount) : base(title, type, availability, borrower, lentTime)
        {
            PageCount = pageCount;
        }
    }
}
