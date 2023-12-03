namespace LibraryApp
{
    partial class frmManagement
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
            btnBorrow = new Button();
            btnShelfs = new Button();
            btnEmployees = new Button();
            btnMembers = new Button();
            btnBooks = new Button();
            btnCancel = new Button();
            btnAddresses = new Button();
            SuspendLayout();
            // 
            // btnBorrow
            // 
            btnBorrow.Location = new Point(224, 121);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(94, 53);
            btnBorrow.TabIndex = 0;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnShelfs
            // 
            btnShelfs.Location = new Point(224, 46);
            btnShelfs.Name = "btnShelfs";
            btnShelfs.Size = new Size(94, 45);
            btnShelfs.TabIndex = 1;
            btnShelfs.Text = "Shelfs";
            btnShelfs.UseVisualStyleBackColor = true;
            btnShelfs.Click += btnShelfs_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.Location = new Point(24, 46);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(94, 45);
            btnEmployees.TabIndex = 2;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnMembers
            // 
            btnMembers.Location = new Point(24, 121);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(94, 53);
            btnMembers.TabIndex = 3;
            btnMembers.Text = "Members";
            btnMembers.UseVisualStyleBackColor = true;
            btnMembers.Click += btnMembers_Click;
            // 
            // btnBooks
            // 
            btnBooks.Location = new Point(24, 205);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(94, 52);
            btnBooks.TabIndex = 4;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBook_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(117, 290);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 52);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddresses
            // 
            btnAddresses.Location = new Point(224, 205);
            btnAddresses.Name = "btnAddresses";
            btnAddresses.Size = new Size(94, 52);
            btnAddresses.TabIndex = 6;
            btnAddresses.Text = "Addresses";
            btnAddresses.UseVisualStyleBackColor = true;
            btnAddresses.Click += btnAddresses_Click;
            // 
            // frmManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(348, 354);
            Controls.Add(btnAddresses);
            Controls.Add(btnCancel);
            Controls.Add(btnBooks);
            Controls.Add(btnMembers);
            Controls.Add(btnEmployees);
            Controls.Add(btnShelfs);
            Controls.Add(btnBorrow);
            Name = "frmManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Management";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBorrow;
        private Button btnShelfs;
        private Button btnEmployees;
        private Button btnMembers;
        private Button btnBooks;
        private Button btnCancel;
        private Button btnAddresses;
    }
}