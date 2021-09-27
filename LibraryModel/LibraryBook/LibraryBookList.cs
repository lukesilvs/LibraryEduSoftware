using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel.LibraryBook
{
    /// <summary>
    /// This class creates a List for Library Book Model
    /// </summary>
    public class LibraryBookList
    {
        /// <summary>
        /// LibraryBooks is a List name for containing Call Numbers for Books
        /// </summary>
        public List<LibraryBookModel> LibraryBooks { get; set; }

        /// <summary>
        /// This is Contructor Method which creates new List for Library Book Model
        /// </summary>
        public LibraryBookList()
        {
            this.LibraryBooks = new List<LibraryBookModel>();
        }
    }
}
