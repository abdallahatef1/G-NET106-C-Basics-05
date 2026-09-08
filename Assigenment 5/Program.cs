namespace Assigenment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            #region task 2
            // Console.WriteLine("copiesInStock = " + book.copiesInStock); 

            #endregion
            #region task 3
            //book.Title = "Clean Code";
            //Console.WriteLine("Title = " + book.Title);

            #endregion
            #region task 4
            //book.Genre = Genre.Science;
            //Console.WriteLine(" Genre = " + book.Genre);
            #endregion
            #region Using the Genre enum above, print the underlying int value of Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
            //Console.WriteLine("Fiction = " + (int)Genre.Fiction);
            //Console.WriteLine("NonFiction = " + (int)Genre.NonFiction);
            //Console.WriteLine("Science = " + (int)Genre.Science);

            #endregion

            #region Given int genreNumber = 1;, cast it into a Genre value and print the result.
            //int genreNumber = 1;
            // Genre genreFromNumber = (Genre)genreNumber;
            //Console.WriteLine("genreNumber 1 casts to => " + genreFromNumber);



            #endregion

            #region Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.
           // Genre genre = Genre.Fiction;
           // string genreAsString = genre.ToString();
           // Console.WriteLine("ToString() = " + genreAsString);


            #endregion



        }
    }
}
