using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    public class Book
    {

        public string title;
        public string author;
        public int year;
        public Book(string title, string author, int year) 
        { 
            this.title = title;
            this.author = author;
            this.year = year;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }

        public int GetYear()
        {
            return year;
        }

        public void SetTitle(string newTitle)
        {
            this.title = newTitle;
        }

        public void SetAuthor(string newAuthor)
        {
            this.author = newAuthor;
        }

        public void SetYear(int newYear)
        {
            this.year = newYear;
        }

    }
}
