using BaseBakend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class frmBorrow : Form
    {
        List<BorrowClass> borrows;
        public frmBorrow()
        {
            InitializeComponent();
            borrows = new List<BorrowClass>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BorrowClass borrow = new();
            try
            {
                borrow.BorrowID = int.Parse(PersonClass.IsValidNumber(txtBorrowID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                borrow.BorrowedBookName = PersonClass.IsValidInput(txtborrowedBookName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            borrow.BorrowingDate = dtpBorrowingDate.Value;
            borrow.ReturnDate = dtpReturnDate.Value;
            borrow.CreationDate=dtpCreationDateTime.Value;
            borrows.Add(borrow);
            dgvBorrow.DataSource = null;
            dgvBorrow.DataSource = borrows;
            dgvBorrow.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
