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

            #region Question2
            //Add an internal int copiesInStock = 5; field to Book.
            //Print it from Main. Does it compile? Why?

            //Console.WriteLine(book.copiesInStock);

            // Output 5
            //it compiles because internal are accessible from anywhere inside the same project
            #endregion

            #region Question3
            // Add a public string Title field to Book.
            // Set it and print it from Main.

            //book.Title = "Harry Potter";
            //Console.WriteLine(book.Title);

            // Output: Harry Potter
            // public members can be accessed from anywhere
            #endregion

            #region Question4
            // Declare an enum Genre.
            // Add a Genre property to Book.
            // Assign Genre.Science and print it.

            //book.Genre = Genre.Science;
            //Console.WriteLine(book.Genre);

            // Output Science
            #endregion

            #region Question5
            // Print the underlying int value of each Genre.

            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);

            // Output
            // 0
            // 1
            // 2
            #endregion

        }
    }
}