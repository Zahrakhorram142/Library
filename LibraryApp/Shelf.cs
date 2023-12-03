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
    public partial class frmShelf : Form
    {
        List<ShelfClass> shelfs;
        public frmShelf()
        {
            InitializeComponent();
            shelfs = new List<ShelfClass>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ShelfClass shelf = new();
            try
            {
                shelf.ShelfID = int.Parse(PersonClass.IsValidNumber(txtShelfID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                shelf.Floor = PersonClass.IsValidInput(txtFloor.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                shelf.Title = PersonClass.IsValidInput(txtTitle.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            shelfs.Add(shelf);
            dgvShelf.DataSource = null;
            dgvShelf.DataSource = shelfs;
            dgvShelf.Refresh();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
