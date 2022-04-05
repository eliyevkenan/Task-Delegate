using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp72
{
    internal class Library
    {
        private List<Book> books;
        public Library()
        {
            books=new List<Book>();

        }
        public List<Book> FilterByPrice(int min,int max)
        {
            var filteredbooks=books.FindAll(x=>x.Price>=min&&x.Price<=max);
            if (filteredbooks.Count==0)
            {
                throw new Exception("xeta");
            }
            return filteredbooks;
        }
        public Book FilterByGenre(string genre)
        {
            if (genre==null)
            {
                throw new Exception("Xeta");
            }
            return books.Find(x=>x.Genre==genre);
        }
        public Book FindByGenre(int? No)
        {
            if (No == null)
            {
                throw new Exception("Xeta");
            }
            return books.Find(x=>x.No==No);
        } 
    }
}
