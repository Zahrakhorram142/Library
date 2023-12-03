namespace LibraryApp
{
    partial class frmShelf
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
            lblTitle = new Label();
            lblFloor = new Label();
            lblShelfID = new Label();
            txtShelfID = new TextBox();
            txtFloor = new TextBox();
            txtTitle = new TextBox();
            dgvShelf = new DataGridView();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShelf).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(57, 129);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 46);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(31, 90);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            // 
            // lblFloor
            // 
            lblFloor.AutoSize = true;
            lblFloor.Location = new Point(31, 55);
            lblFloor.Name = "lblFloor";
            lblFloor.Size = new Size(43, 20);
            lblFloor.TabIndex = 2;
            lblFloor.Text = "Floor";
            // 
            // lblShelfID
            // 
            lblShelfID.AutoSize = true;
            lblShelfID.Location = new Point(31, 22);
            lblShelfID.Name = "lblShelfID";
            lblShelfID.Size = new Size(61, 20);
            lblShelfID.TabIndex = 3;
            lblShelfID.Text = "Shelf ID";
            // 
            // txtShelfID
            // 
            txtShelfID.Location = new Point(108, 19);
            txtShelfID.Name = "txtShelfID";
            txtShelfID.Size = new Size(125, 27);
            txtShelfID.TabIndex = 1;
            // 
            // txtFloor
            // 
            txtFloor.Location = new Point(108, 52);
            txtFloor.Name = "txtFloor";
            txtFloor.Size = new Size(125, 27);
            txtFloor.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(108, 85);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 3;
            // 
            // dgvShelf
            // 
            dgvShelf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShelf.Location = new Point(12, 181);
            dgvShelf.Name = "dgvShelf";
            dgvShelf.RowHeadersWidth = 51;
            dgvShelf.RowTemplate.Height = 29;
            dgvShelf.Size = new Size(563, 188);
            dgvShelf.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(424, 129);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 46);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmShelf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(587, 385);
            Controls.Add(btnCancel);
            Controls.Add(dgvShelf);
            Controls.Add(txtTitle);
            Controls.Add(txtFloor);
            Controls.Add(txtShelfID);
            Controls.Add(lblShelfID);
            Controls.Add(lblFloor);
            Controls.Add(lblTitle);
            Controls.Add(btnSave);
            Name = "frmShelf";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shelf";
            ((System.ComponentModel.ISupportInitialize)dgvShelf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label lblTitle;
        private Label lblFloor;
        private Label lblShelfID;
        private TextBox txtShelfID;
        private TextBox txtFloor;
        private TextBox txtTitle;
        private DataGridView dgvShelf;
        private Button btnCancel;
    }
}