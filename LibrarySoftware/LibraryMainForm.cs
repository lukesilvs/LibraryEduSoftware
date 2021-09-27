using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySoftware
{
    /// <summary>
    /// Main Form for the Application It Contains Options for the User to Select
    /// </summary>
    public partial class LibraryMainForm : Form
    {
        public LibraryMainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button Click to Show ReplacingBooksForm
        /// </summary>
        
        private void BtnReplacingBooks_Click(object sender, EventArgs e)
        {
            ReplacingBooksForm replacingBooks = new ReplacingBooksForm();
            replacingBooks.ShowDialog();
        }
    }
}
