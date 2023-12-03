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
    public partial class frmManagement : Form
    {
        public frmManagement()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frmBook frmBook = new frmBook();
            frmBook.ShowDialog();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            frm.ShowDialog();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            frmMember frm = new frmMember();
            frm.ShowDialog();
        }

        private void btnShelfs_Click(object sender, EventArgs e)
        {
            frmShelf frm = new frmShelf();
            frm.ShowDialog();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            frmBorrow frm = new frmBorrow();
            frm.ShowDialog();
        }

        private void btnAddresses_Click(object sender, EventArgs e)
        {
            frmAddress frm = new frmAddress();
            frm.ShowDialog();
        }
    }
}
