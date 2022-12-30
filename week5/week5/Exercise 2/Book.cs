using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Exercise_2
{
    public class Book
    {
        private string title;
        private string author;
        private int pageCount;
        private int currentPage;

        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }

        public Book(string Title, string Author, int PageCount)
        {
            this.Title = Title;
            this.Author = Author;
            this.PageCount = PageCount;
            this.CurrentPage = 1;
        }

        public string GetTitle()
        {
            return this.Title;
        }

        public string GetAuthor()
        {
            return this.Author;
        }

        public int GetPageCount()
        {
            return this.PageCount;
        }

        public int GetCurrentPage()
        {
            return this.CurrentPage;
        }

        public void NextPage()
        {
            this.CurrentPage++;
        }

        public void PreviousPage()
        {
            this.CurrentPage--;
        }
    }
}
