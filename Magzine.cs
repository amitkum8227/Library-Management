using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    class Magzine : Book
    {
        int IssuNumber { get; set; }
        public Magzine(string title, BookType type, bool availability, string borrower, int lentTime, int pageCount,int issueNumber) : base(title, type, availability, borrower, lentTime, pageCount)
        {
            IssuNumber = issueNumber;
        }
    }
}
