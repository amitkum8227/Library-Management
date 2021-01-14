using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    class Movie : Media
    {
        int RunTime { get; set; }
        public Movie(string title, BookType type, bool availability, string borrower, int lentTime,int runTime) : base(title, type, availability, borrower, lentTime)
        {
            RunTime = runTime;
        }
    }
}
