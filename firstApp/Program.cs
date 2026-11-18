using System.Dynamic;
using System.Net.NetworkInformation;
using System.Net.WebSockets;

namespace firstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            // Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
            // variable of type object.Print it.
            Book book = new Book();
            book.Title = "c# Basics";
            book.Pages = 50;
            object obj = book;
            Console.WriteLine(obj);
            #endregion

            #region Q02
            //Using the Book class above, print the result of calling ToString(), Equals() (compare book with
            //itself), GetHashCode(), and GetType() on book
            Console.WriteLine(obj.ToString());
            Console.WriteLine(obj.Equals(obj));//in this case compare with value 
            Console.WriteLine(obj.GetHashCode());
            Console.WriteLine(obj.GetType());
            #endregion
        }
    }
}
