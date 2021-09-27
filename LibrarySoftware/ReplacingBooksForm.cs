using LibraryHelper;
using LibraryModel.LibraryBook;
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
    /// This Form shows Randomly Generated Call Numbers in DataGrid
    /// It also allow the User to Sort the Call Numbers in Ascending Order
    /// </summary>
    public partial class ReplacingBooksForm : Form
    {
        private LibraryBookList BookList = new LibraryBookList();
        private static Random random = new Random();
        public ReplacingBooksForm()
        {
            InitializeComponent();
            GenerateNumbers();
        }

        /// <summary>
        /// This Method Generates the Call Numbers
        /// First Generate Decimal Numbers and then a 3 Digit Random String
        /// Combines Decimal Number and String to Create a Call Number
        /// </summary>
        private void GenerateNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                LibraryBookModel model = new LibraryBookModel
                {
                    CallNumber = CommonHelper.NextDecimal(random).ToString("000.##") + " " + CommonHelper.RandomString(3, random)
                };
                this.BookList.LibraryBooks.Add(model);
            }

            LoadCallNumbers();
        }

        /// <summary>
        /// Reorder as Ascending button Lets the user to Sort the Call Numbers
        /// </summary>
        
        private void BtnReorderAscending_Click(object sender, EventArgs e)
        {
            this.timer.Start();
            this.progressBar.Visible = true;
            this.lblProgressBarPercent.Visible = true;
        }

        /// <summary>
        /// LoadCallNumbers() binds the Call number List to the DataGrid
        /// </summary>
        private void LoadCallNumbers()
        {

            if (BookList.LibraryBooks != null)
            {
                this.callNumberList.DataSource = BookList.LibraryBooks;
            }
        }

        /// <summary>
        /// Shows Row Number in the DataGrid Serial No. Coloumn
        /// </summary>
        
        private void CallNumberList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.callNumberList.Rows[e.RowIndex].Cells["serialNo"].Value = (e.RowIndex + 1).ToString();
        }

        /// <summary>
        /// Timer shows the Progress Bar Incrementation
        /// Once the Progress Bar is Completed the Sorted List is Loaded to DataGrid
        /// </summary>
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.progressBar.Increment(1);
            this.lblProgressBarPercent.Text = this.progressBar.Value.ToString() + "%";

            if(Convert.ToUInt32(this.progressBar.Value) == 100)
            {
                if (BookList.LibraryBooks != null)
                {
                    BookList.LibraryBooks = BookList.LibraryBooks.OrderBy(x => x.CallNumber).ToList();
                    LoadCallNumbers();
                }

                this.timer.Stop();
                this.progressBar.Visible = false;
                this.lblProgressBarPercent.Visible = false;
            }
        }

        private void callNumberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReplacingBooksForm_Load(object sender, EventArgs e)
        {

        }
    }
}
