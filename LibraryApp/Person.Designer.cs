namespace LibraryApp
{
    partial class frmPerson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            btnCancel = new Button();
            chbIsAdmin = new CheckBox();
            lblNationalCode = new Label();
            txtNationalCode = new TextBox();
            dtpPerson = new DateTimePicker();
            lblCreationDate = new Label();
            lblPersonID = new Label();
            txtPersonID = new TextBox();
            dgvPerson = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPerson).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(43, 296);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 45);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(25, 79);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(76, 20);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "FirstName";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(26, 116);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(75, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "LastName";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(25, 154);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(104, 20);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "PhoneNumber";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(141, 147);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(125, 27);
            txtPhoneNumber.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(141, 113);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(141, 79);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(461, 297);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 44);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // chbIsAdmin
            // 
            chbIsAdmin.AutoSize = true;
            chbIsAdmin.Location = new Point(152, 239);
            chbIsAdmin.Name = "chbIsAdmin";
            chbIsAdmin.Size = new Size(85, 24);
            chbIsAdmin.TabIndex = 7;
            chbIsAdmin.Text = "IsAdmin";
            chbIsAdmin.UseVisualStyleBackColor = true;
            // 
            // lblNationalCode
            // 
            lblNationalCode.AutoSize = true;
            lblNationalCode.Location = new Point(26, 46);
            lblNationalCode.Name = "lblNationalCode";
            lblNationalCode.Size = new Size(101, 20);
            lblNationalCode.TabIndex = 12;
            lblNationalCode.Text = "NationalCode";
            // 
            // txtNationalCode
            // 
            txtNationalCode.Location = new Point(141, 43);
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new Size(125, 27);
            txtNationalCode.TabIndex = 2;
            // 
            // dtpPerson
            // 
            dtpPerson.Location = new Point(141, 180);
            dtpPerson.Name = "dtpPerson";
            dtpPerson.Size = new Size(250, 27);
            dtpPerson.TabIndex = 6;
            // 
            // lblCreationDate
            // 
            lblCreationDate.AutoSize = true;
            lblCreationDate.Location = new Point(26, 187);
            lblCreationDate.Name = "lblCreationDate";
            lblCreationDate.Size = new Size(97, 20);
            lblCreationDate.TabIndex = 14;
            lblCreationDate.Text = "CreationDate";
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Location = new Point(26, 13);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(67, 20);
            lblPersonID.TabIndex = 15;
            lblPersonID.Text = "PersonID";
            // 
            // txtPersonID
            // 
            txtPersonID.Location = new Point(141, 6);
            txtPersonID.Name = "txtPersonID";
            txtPersonID.Size = new Size(125, 27);
            txtPersonID.TabIndex = 1;
            // 
            // dgvPerson
            // 
            dgvPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerson.Location = new Point(5, 346);
            dgvPerson.Name = "dgvPerson";
            dgvPerson.RowHeadersWidth = 51;
            dgvPerson.RowTemplate.Height = 29;
            dgvPerson.Size = new Size(636, 218);
            dgvPerson.TabIndex = 16;
            // 
            // frmPerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(642, 558);
            Controls.Add(dgvPerson);
            Controls.Add(txtPersonID);
            Controls.Add(lblPersonID);
            Controls.Add(lblCreationDate);
            Controls.Add(dtpPerson);
            Controls.Add(txtNationalCode);
            Controls.Add(lblNationalCode);
            Controls.Add(chbIsAdmin);
            Controls.Add(btnCancel);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnSave);
            Name = "frmPerson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person";
            ((System.ComponentModel.ISupportInitialize)dgvPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button btnCancel;
        private CheckBox chbIsAdmin;
        private Label lblNationalCode;
        private TextBox txtNationalCode;
        private DateTimePicker dtpPerson;
        private Label lblCreationDate;
        private Label lblPersonID;
        private TextBox txtPersonID;
        private DataGridView dgvPerson;
    }
}