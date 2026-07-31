using System.Drawing;

namespace Assignment4
{
    enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }

    class CBook
    {
        private string password = "secret";
        internal int copiesInStock = 5;
        public string Title { get; set; }
        public Genre Genre { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CBook book = new CBook();

            #region Question1
            // Add a private string password = "secret"; field to a Book class.
            // Try to print it from Main (outside the class).
            // What happens, and why?

            //Console.WriteLine(book.password);

            // gives error can't access 'password' because it is private
            // private members can only be accessed inside the same class
            #endregion

        }
    }
}