using BaseBakend.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class frmBook : Form
    {
        List<BookClass> books;
        public frmBook()
        {
            InitializeComponent();
            books = new List<BookClass>();
        }

        public void btnSave_Click(object sender, EventArgs e)
        {

            BookClass book = new();
            try
            {
                book.BookID = int.Parse(PersonClass.IsValidNumber(txtBookID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                book.Name = PersonClass.IsValidInput(txtName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                book.Writer = PersonClass.IsValidInput(txtName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                book.Subject = PersonClass.IsValidInput(txtName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                book.Publishers = PersonClass.IsValidInput(txtName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                book.YearOfPublication = int.Parse(PersonClass.IsValidNumber(txtYearOfPublication.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                book.Edition = PersonClass.IsValidInput(txtName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            book.CreationDate = dtpCreationDate.Value;
            book.IsActive = chbIsActive.Checked;
            books.Add(book);
            dgvBook.DataSource = null;
            dgvBook.DataSource = books;
            dgvBook.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}
