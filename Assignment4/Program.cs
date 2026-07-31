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

            #region Question6
            // Given int genreNumber = 1;
            // Cast it into a Genre value and print it.

            //int genreNumber = 1;

            //Genre genre = (Genre)genreNumber;

            //Console.WriteLine(genre);

            // Output NonFiction
            #endregion

            #region Question7
            // Given Genre genre = Genre.Fiction;
            // Convert it into a string using ToString().

            //Genre genre2 = Genre.Fiction;

            //string genreString = genre2.ToString();

            //Console.WriteLine(genreString);

            // Output fiction
            #endregion

            #region Question8
            // Given string genreText = "Science";
            // Convert it into a Genre value using Enum.Parse().

            //string genreText = "Science";
            //Genre parsedGenre = (Genre)Enum.Parse(typeof(Genre), genreText);
            //Console.WriteLine(parsedGenre);

            // Output:
            // Science
            #endregion

            #region Question9
            // Given string genreText = "Mystery";
            // Use Enum.TryParse() and print "Unknown genre" if it fails.

            //string invalidGenre = "Mystery";

            //if (Enum.TryParse(invalidGenre, out Genre result))
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{Console.WriteLine("Unknown genre");}

            // Output unknown genre
            #endregion

        }
    }
}