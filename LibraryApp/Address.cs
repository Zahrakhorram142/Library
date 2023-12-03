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
    public partial class frmAddress : Form
    {
        List<Address> addresses;
        public frmAddress()
        {
            InitializeComponent();
            addresses = new List<Address>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Address address = new Address();
            try
            {
                address.ID = int.Parse(PersonClass.IsValidNumber(txtAddressID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                address.Title = PersonClass.IsValidInput(txtTitle.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                address.City = PersonClass.IsValidInput(txtCity.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            address.Street = txtTitle.Text;
            address.FullAddress = txtFullAddress.Text;
            try
            {
                address.PostalCode = PersonClass.IsValidCode(txtPostalCode.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            address.CreationDate = dtpCreationDate.Value;
            address.IsActive = ckbIsActive.Checked;
            addresses.Add(address);
            dgvAddress.DataSource = null;
            dgvAddress.DataSource = addresses;
            dgvAddress.Refresh();

        }
    }
}

