namespace LibraryApp
{
    partial class frmBorrow
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
            lblBorrowID = new Label();
            lblBorrowedBookName = new Label();
            lblBorrowingDate = new Label();
            lblReturnDate = new Label();
            txtborrowedBookName = new TextBox();
            txtBorrowID = new TextBox();
            dgvBorrow = new DataGridView();
            btnCancel = new Button();
            dtpReturnDate = new DateTimePicker();
            dtpBorrowingDate = new DateTimePicker();
            lblCreationDateTIme = new Label();
            dtpCreationDateTime = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvBorrow).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(60, 229);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 41);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblBorrowID
            // 
            lblBorrowID.AutoSize = true;
            lblBorrowID.Location = new Point(27, 9);
            lblBorrowID.Name = "lblBorrowID";
            lblBorrowID.Size = new Size(72, 20);
            lblBorrowID.TabIndex = 1;
            lblBorrowID.Text = "BorrowID";
            // 
            // lblBorrowedBookName
            // 
            lblBorrowedBookName.AutoSize = true;
            lblBorrowedBookName.Location = new Point(27, 42);
            lblBorrowedBookName.Name = "lblBorrowedBookName";
            lblBorrowedBookName.Size = new Size(148, 20);
            lblBorrowedBookName.TabIndex = 2;
            lblBorrowedBookName.Text = "BorrowedBookName";
            // 
            // lblBorrowingDate
            // 
            lblBorrowingDate.AutoSize = true;
            lblBorrowingDate.Location = new Point(27, 78);
            lblBorrowingDate.Name = "lblBorrowingDate";
            lblBorrowingDate.Size = new Size(110, 20);
            lblBorrowingDate.TabIndex = 3;
            lblBorrowingDate.Text = "BorrowingDate";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Location = new Point(27, 111);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(84, 20);
            lblReturnDate.TabIndex = 4;
            lblReturnDate.Text = "ReturnDate";
            // 
            // txtborrowedBookName
            // 
            txtborrowedBookName.Location = new Point(185, 42);
            txtborrowedBookName.Name = "txtborrowedBookName";
            txtborrowedBookName.Size = new Size(125, 27);
            txtborrowedBookName.TabIndex = 2;
            // 
            // txtBorrowID
            // 
            txtBorrowID.Location = new Point(185, 9);
            txtBorrowID.Name = "txtBorrowID";
            txtBorrowID.Size = new Size(125, 27);
            txtBorrowID.TabIndex = 1;
            // 
            // dgvBorrow
            // 
            dgvBorrow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrow.Location = new Point(12, 276);
            dgvBorrow.Name = "dgvBorrow";
            dgvBorrow.RowHeadersWidth = 51;
            dgvBorrow.RowTemplate.Height = 29;
            dgvBorrow.Size = new Size(627, 188);
            dgvBorrow.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(509, 229);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(89, 41);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(185, 111);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(250, 27);
            dtpReturnDate.TabIndex = 4;
            // 
            // dtpBorrowingDate
            // 
            dtpBorrowingDate.Location = new Point(185, 78);
            dtpBorrowingDate.Name = "dtpBorrowingDate";
            dtpBorrowingDate.Size = new Size(250, 27);
            dtpBorrowingDate.TabIndex = 3;
            // 
            // lblCreationDateTIme
            // 
            lblCreationDateTIme.AutoSize = true;
            lblCreationDateTIme.Location = new Point(27, 149);
            lblCreationDateTIme.Name = "lblCreationDateTIme";
            lblCreationDateTIme.Size = new Size(130, 20);
            lblCreationDateTIme.TabIndex = 10;
            lblCreationDateTIme.Text = "CreationDateTIme";
            // 
            // dtpCreationDateTime
            // 
            dtpCreationDateTime.Location = new Point(185, 144);
            dtpCreationDateTime.Name = "dtpCreationDateTime";
            dtpCreationDateTime.Size = new Size(250, 27);
            dtpCreationDateTime.TabIndex = 11;
            // 
            // frmBorrow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(651, 466);
            Controls.Add(dtpCreationDateTime);
            Controls.Add(lblCreationDateTIme);
            Controls.Add(dtpBorrowingDate);
            Controls.Add(dtpReturnDate);
            Controls.Add(btnCancel);
            Controls.Add(dgvBorrow);
            Controls.Add(txtBorrowID);
            Controls.Add(txtborrowedBookName);
            Controls.Add(lblReturnDate);
            Controls.Add(lblBorrowingDate);
            Controls.Add(lblBorrowedBookName);
            Controls.Add(lblBorrowID);
            Controls.Add(btnSave);
            Name = "frmBorrow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Borrow";
            ((System.ComponentModel.ISupportInitialize)dgvBorrow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label lblBorrowID;
        private Label lblBorrowedBookName;
        private Label lblBorrowingDate;
        private Label lblReturnDate;
        private TextBox txtborrowedBookName;
        private TextBox txtBorrowID;
        private DataGridView dgvBorrow;
        private Button btnCancel;
        private DateTimePicker dtpReturnDate;
        private DateTimePicker dtpBorrowingDate;
        private Label lblCreationDateTIme;
        private DateTimePicker dtpCreationDateTime;
    }
}