using BaseBakend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phoneNumber;
            Admin admin = new Admin();
            try
            {
                admin.AdminID = int.Parse(PersonClass.IsValidNumber(txtAdminID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (admin.AdminID == 142)
            {
                frmManagement frm = new frmManagement();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid ID please try again:");
            }
        }
    }
}
