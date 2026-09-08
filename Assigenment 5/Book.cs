using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Assigenment_5
{
    public class Book {
        #region Add a private string password = "secret"; field to a Book class. Try to print it from Main(outside the class). What happens, and why?
        private string password = "secret"; // NOT accessible from Main 


        #endregion

        #region  Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why?

        internal int copiesInStock = 5; // Accessible from Main because internal allows access within the same assembly

        #endregion

        #region Add a public string Title; field to Book. Set it and print it from Main.
        public string Title;



        #endregion

        #region Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book, assign it Genre.Science, and print it.
        public Genre Genre { get; set; }

        #endregion





    }

}
