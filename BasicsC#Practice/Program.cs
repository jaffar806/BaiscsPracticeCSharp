using System.Linq;
using System.Runtime.Intrinsics.Arm;



namespace BasicsC_Practice
{
    public class Program
    {
        static void Main()
        {
            BookList bookList = new BookList();
            Book book = new Book
            {
                Title = "c# in Depth",
                Author = "Mosh"
            };
            Book book1 = new Book
            {
                Title = "Clean code",
                Author ="jafar"
            };

            bookList.Add(book1);
            bookList.Add(book);

            Console.WriteLine(bookList[0].Title+"," +bookList[0].Author);
            Console.WriteLine(bookList[1].Title+"," +bookList[1].Author);
        }
     
    }
   


}













