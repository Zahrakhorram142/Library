using BaseBakend.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class frmMember : Form
    {
        List<MemberClass> members;
        public frmMember()
        {
            InitializeComponent();
            members = new List<MemberClass>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string phoneNumber;
            MemberClass member = new();
            try
            {
                member.MembershipID = int.Parse(PersonClass.IsValidNumber(txtMembershipID.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                member.NationalCode = PersonClass.IsValidCode(txtNationalCode.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                member.FirstName = PersonClass.IsValidInput(txtFirstName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                member.LastName = PersonClass.IsValidInput(txtLastName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                phoneNumber = PersonClass.IsValidPhoneNumber(txtPhoneNumber.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            member.PhoneNumber = PersonClass.ReplacePhone(phoneNumber);
            member.CreationDate = dtpMember.Value;

            members.Add(member);
            dgvMember.DataSource = null;
            dgvMember.DataSource = members;
            dgvMember.Refresh();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
