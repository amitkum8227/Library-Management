using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    static class Library
    {

        public static List<Media> ListLibrary = new List<Media>() {

        new Book("War and Peace",BookType.Book,false,"",0,150),
        new Book("Song of Solomon",BookType.Book,false,"",0,250),
        new Book("Song of Solomon",BookType.Book,false,"",0,100),
        new Book("Ulysses",BookType.Book,false,"",0,85),
        new Book("The Lord of the Rings",BookType.Book,false,"",0,85),


       new Magzine("The Satanic Verses",BookType.Magzine,false,"",0,0,55),
       new Magzine("Don Quixote",BookType.Magzine,false,"",0,0,105),
       new Magzine("The Golden Compass",BookType.Magzine,false,"",0,0,5),
       new Magzine("Catch-22",BookType.Magzine,false,"",0,0,99),
       new Magzine("1984",BookType.Magzine,false,"",0,0,33),

       new Movie("The Kite Runner",BookType.Movie,false,"",0,150),
       new Movie("Little Women",BookType.Movie,false,"",0,180),
       new Movie("The Cloud Atlas",BookType.Movie,false,"",0,100),
       new Movie("The Fountainhead",BookType.Movie,false,"",0,900),
       new Movie("Lolita",BookType.Movie,false,"",0,1500)
        
        };
    }
}
