namespace LibraryApp
{
    partial class frmAdmin
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
            lblAdminID = new Label();
            txtAdminID = new TextBox();
            btnCancel = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblAdminID
            // 
            lblAdminID.AutoSize = true;
            lblAdminID.Location = new Point(33, 18);
            lblAdminID.Name = "lblAdminID";
            lblAdminID.Size = new Size(68, 20);
            lblAdminID.TabIndex = 0;
            lblAdminID.Text = "AdminID";
            // 
            // txtAdminID
            // 
            txtAdminID.Location = new Point(118, 18);
            txtAdminID.Name = "txtAdminID";
            txtAdminID.Size = new Size(125, 27);
            txtAdminID.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(164, 108);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 45);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(33, 108);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 2;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(282, 184);
            Controls.Add(button1);
            Controls.Add(btnCancel);
            Controls.Add(txtAdminID);
            Controls.Add(lblAdminID);
            Name = "frmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdminID;
        private TextBox txtAdminID;
        private Button btnCancel;
        private Button button1;
    }
}