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
    public partial class frmEmployee : Form
    {
        List<EmployeeClass> employees;
        public frmEmployee()
        {
            InitializeComponent();
            employees = new List<EmployeeClass>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeClass employee = new();
            string phoneNumber;
            try
            {
                employee.EmployeeID = int.Parse(PersonClass.IsValidNumber(txtEmployeeID.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                employee.NationalCode = PersonClass.IsValidCode(txtNationalCode.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                employee.FirstName = PersonClass.IsValidInput(txtFirstName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                employee.LastName = PersonClass.IsValidInput(txtLastName.Text);
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
            try
            {
                employee.JobTitle = PersonClass.IsValidInput(txtJobTItle.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            employee.PhoneNumber = PersonClass.ReplacePhone(phoneNumber);
            employee.EmployeementDate = dtpEmployeementDate.Value;
            employee.CreationDate = dtpCreationDate.Value;
            employees.Add(employee);
            dgvEmployee.DataSource = null;
            dgvEmployee.DataSource = employees;
            dgvEmployee.Refresh();

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
