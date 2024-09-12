using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsC_Practice
{
    public class BookList
    {
        public List<Book> books = new List<Book>();
       
        public void Add(Book book)
        {  
            books.Add(book);
        }
        public Book this[int index]{get{return books[index];}}

    }
}
