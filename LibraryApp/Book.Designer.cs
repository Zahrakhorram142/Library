namespace LibraryApp
{
    partial class frmBook
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
            lblBookID = new Label();
            lblName = new Label();
            lblSubject = new Label();
            lblWriter = new Label();
            lblPublishers = new Label();
            lblYearOfPublication = new Label();
            lblEdition = new Label();
            txtedition = new TextBox();
            txtYearOfPublication = new TextBox();
            txtPublishers = new TextBox();
            txtWriter = new TextBox();
            txtSubject = new TextBox();
            txtName = new TextBox();
            txtBookID = new TextBox();
            dgvBook = new DataGridView();
            btnCancel = new Button();
            lblCreationDate = new Label();
            dtpCreationDate = new DateTimePicker();
            chbIsActive = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(63, 367);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 45);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.Location = new Point(29, 25);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(62, 20);
            lblBookID.TabIndex = 1;
            lblBookID.Text = "Book ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(29, 56);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(29, 91);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(58, 20);
            lblSubject.TabIndex = 3;
            lblSubject.Text = "Subject";
            // 
            // lblWriter
            // 
            lblWriter.AutoSize = true;
            lblWriter.Location = new Point(29, 123);
            lblWriter.Name = "lblWriter";
            lblWriter.Size = new Size(50, 20);
            lblWriter.TabIndex = 4;
            lblWriter.Text = "Writer";
            // 
            // lblPublishers
            // 
            lblPublishers.AutoSize = true;
            lblPublishers.Location = new Point(29, 157);
            lblPublishers.Name = "lblPublishers";
            lblPublishers.Size = new Size(75, 20);
            lblPublishers.TabIndex = 5;
            lblPublishers.Text = "Publishers";
            // 
            // lblYearOfPublication
            // 
            lblYearOfPublication.AutoSize = true;
            lblYearOfPublication.Location = new Point(29, 193);
            lblYearOfPublication.Name = "lblYearOfPublication";
            lblYearOfPublication.Size = new Size(135, 20);
            lblYearOfPublication.TabIndex = 6;
            lblYearOfPublication.Text = "Year Of Publication";
            // 
            // lblEdition
            // 
            lblEdition.AutoSize = true;
            lblEdition.Location = new Point(29, 226);
            lblEdition.Name = "lblEdition";
            lblEdition.Size = new Size(56, 20);
            lblEdition.TabIndex = 7;
            lblEdition.Text = "Edition";
            // 
            // txtedition
            // 
            txtedition.Location = new Point(170, 223);
            txtedition.Name = "txtedition";
            txtedition.Size = new Size(125, 27);
            txtedition.TabIndex = 7;
            // 
            // txtYearOfPublication
            // 
            txtYearOfPublication.Location = new Point(170, 190);
            txtYearOfPublication.Name = "txtYearOfPublication";
            txtYearOfPublication.Size = new Size(125, 27);
            txtYearOfPublication.TabIndex = 6;
            // 
            // txtPublishers
            // 
            txtPublishers.Location = new Point(170, 157);
            txtPublishers.Name = "txtPublishers";
            txtPublishers.Size = new Size(125, 27);
            txtPublishers.TabIndex = 5;
            // 
            // txtWriter
            // 
            txtWriter.Location = new Point(170, 124);
            txtWriter.Name = "txtWriter";
            txtWriter.Size = new Size(125, 27);
            txtWriter.TabIndex = 4;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(170, 91);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(125, 27);
            txtSubject.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(170, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 2;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(170, 25);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(125, 27);
            txtBookID.TabIndex = 1;
            // 
            // dgvBook
            // 
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Location = new Point(12, 418);
            dgvBook.Name = "dgvBook";
            dgvBook.RowHeadersWidth = 51;
            dgvBook.RowTemplate.Height = 29;
            dgvBook.Size = new Size(657, 188);
            dgvBook.TabIndex = 15;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(544, 367);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 45);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblCreationDate
            // 
            lblCreationDate.AutoSize = true;
            lblCreationDate.Location = new Point(29, 256);
            lblCreationDate.Name = "lblCreationDate";
            lblCreationDate.Size = new Size(97, 20);
            lblCreationDate.TabIndex = 16;
            lblCreationDate.Text = "CreationDate";
            // 
            // dtpCreationDate
            // 
            dtpCreationDate.Location = new Point(170, 256);
            dtpCreationDate.Name = "dtpCreationDate";
            dtpCreationDate.Size = new Size(250, 27);
            dtpCreationDate.TabIndex = 17;
            // 
            // chbIsActive
            // 
            chbIsActive.AutoSize = true;
            chbIsActive.Location = new Point(287, 331);
            chbIsActive.Name = "chbIsActive";
            chbIsActive.Size = new Size(82, 24);
            chbIsActive.TabIndex = 18;
            chbIsActive.Text = "IsActive";
            chbIsActive.UseVisualStyleBackColor = true;
            // 
            // frmBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(690, 607);
            Controls.Add(chbIsActive);
            Controls.Add(dtpCreationDate);
            Controls.Add(lblCreationDate);
            Controls.Add(btnCancel);
            Controls.Add(dgvBook);
            Controls.Add(txtBookID);
            Controls.Add(txtName);
            Controls.Add(txtSubject);
            Controls.Add(txtWriter);
            Controls.Add(txtPublishers);
            Controls.Add(txtYearOfPublication);
            Controls.Add(txtedition);
            Controls.Add(lblEdition);
            Controls.Add(lblYearOfPublication);
            Controls.Add(lblPublishers);
            Controls.Add(lblWriter);
            Controls.Add(lblSubject);
            Controls.Add(lblName);
            Controls.Add(lblBookID);
            Controls.Add(btnSave);
            Name = "frmBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book";
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label lblBookID;
        private Label lblName;
        private Label lblSubject;
        private Label lblWriter;
        private Label lblPublishers;
        private Label lblYearOfPublication;
        private Label lblEdition;
        private TextBox txtedition;
        private TextBox txtYearOfPublication;
        private TextBox txtPublishers;
        private TextBox txtWriter;
        private TextBox txtSubject;
        private TextBox txtName;
        private TextBox txtBookID;
        private DataGridView dgvBook;
        private Button btnCancel;
        private Label lblCreationDate;
        private DateTimePicker dtpCreationDate;
        private CheckBox chbIsActive;
    }
}