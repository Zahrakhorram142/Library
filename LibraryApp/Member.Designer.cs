namespace LibraryApp
{
    partial class frmMember
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
            lblMembershipID = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPhoneNumber = new Label();
            txtMembershipID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhoneNumber = new TextBox();
            dgvMember = new DataGridView();
            btnCancel = new Button();
            lblNationalCode = new Label();
            txtNationalCode = new TextBox();
            lblCreationDate = new Label();
            dtpMember = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(52, 296);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 45);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblMembershipID
            // 
            lblMembershipID.AutoSize = true;
            lblMembershipID.Location = new Point(29, 31);
            lblMembershipID.Name = "lblMembershipID";
            lblMembershipID.Size = new Size(111, 20);
            lblMembershipID.TabIndex = 1;
            lblMembershipID.Text = "Membership ID";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(29, 105);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(76, 20);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "FirstName";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(29, 143);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(75, 20);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "LastName";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(29, 177);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(104, 20);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "PhoneNumber";
            // 
            // txtMembershipID
            // 
            txtMembershipID.Location = new Point(166, 32);
            txtMembershipID.Name = "txtMembershipID";
            txtMembershipID.Size = new Size(125, 27);
            txtMembershipID.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(166, 105);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(166, 140);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 4;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(166, 177);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(125, 27);
            txtPhoneNumber.TabIndex = 5;
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(12, 358);
            dgvMember.Name = "dgvMember";
            dgvMember.RowHeadersWidth = 51;
            dgvMember.RowTemplate.Height = 29;
            dgvMember.Size = new Size(664, 188);
            dgvMember.TabIndex = 14;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(529, 296);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 45);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblNationalCode
            // 
            lblNationalCode.AutoSize = true;
            lblNationalCode.Location = new Point(29, 68);
            lblNationalCode.Name = "lblNationalCode";
            lblNationalCode.Size = new Size(101, 20);
            lblNationalCode.TabIndex = 16;
            lblNationalCode.Text = "NationalCode";
            // 
            // txtNationalCode
            // 
            txtNationalCode.Location = new Point(166, 68);
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new Size(125, 27);
            txtNationalCode.TabIndex = 2;
            // 
            // lblCreationDate
            // 
            lblCreationDate.AutoSize = true;
            lblCreationDate.Location = new Point(29, 211);
            lblCreationDate.Name = "lblCreationDate";
            lblCreationDate.Size = new Size(97, 20);
            lblCreationDate.TabIndex = 17;
            lblCreationDate.Text = "CreationDate";
            // 
            // dtpMember
            // 
            dtpMember.Location = new Point(166, 211);
            dtpMember.Name = "dtpMember";
            dtpMember.Size = new Size(250, 27);
            dtpMember.TabIndex = 18;
            // 
            // frmMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(705, 558);
            Controls.Add(dtpMember);
            Controls.Add(lblCreationDate);
            Controls.Add(txtNationalCode);
            Controls.Add(lblNationalCode);
            Controls.Add(btnCancel);
            Controls.Add(dgvMember);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtMembershipID);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblMembershipID);
            Controls.Add(btnSave);
            Name = "frmMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member";
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label lblMembershipID;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhoneNumber;
        private TextBox txtMembershipID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhoneNumber;
        private DataGridView dgvMember;
        private Button btnCancel;
        private Label lblNationalCode;
        private TextBox txtNationalCode;
        private Label lblCreationDate;
        private DateTimePicker dtpMember;
    }
}