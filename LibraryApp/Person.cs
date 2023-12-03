using BaseBakend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;
using BaseBakend.Repository;

namespace LibraryApp
{
    public partial class frmPerson : Form
    {
        public frmPerson()
        {
            InitializeComponent();
            PersonRepository personRepository = new PersonRepository();
            List<PersonClass> people = personRepository.GetPeople();
            dgvPerson.DataSource = null;
            dgvPerson.DataSource = people;
            dgvPerson.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string phoneNumber;
            PersonClass person = new();
            try
            {
                person.PersonID = int.Parse(PersonClass.IsValidNumber(txtPersonID.Text));
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                person.NationalCode = PersonClass.IsValidCode(txtNationalCode.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                person.FirstName = PersonClass.IsValidInput(txtFirstName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                person.LastName = PersonClass.IsValidInput(txtLastName.Text);
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
            person.PhoneNumber = PersonClass.ReplacePhone(phoneNumber);
            person.IsAdmin = chbIsAdmin.Checked;
            person.CreationDate = dtpPerson.Value;
            if (person.IsAdmin)
            {
                person.IsAdmin = true;
                frmAdmin frm = new frmAdmin();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("You are not the manager");
            };

            PersonRepository personRepository = new PersonRepository();
            personRepository.Insert(person);
            List<PersonClass> people = personRepository.GetPeople();
            // MessageBox.Show($"NationalCode:{person.NationalCode},FirstName:{person.FirstName},LastName:{person.LastName},PhoneNumber:{person.PhoneNumber}");
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
