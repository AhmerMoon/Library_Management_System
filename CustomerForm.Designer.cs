namespace Library
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            ViewBorrowedBooks = new Button();
            DisplayBooks = new Button();
            dataGridView1 = new DataGridView();
            lblGreeting = new Label();
            BorrowBook = new Button();
            ReturnBook = new Button();
            ViewFines = new Button();
            pictureBox1 = new PictureBox();
            ViewPersonalInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ViewBorrowedBooks
            // 
            ViewBorrowedBooks.Location = new Point(531, 195);
            ViewBorrowedBooks.Name = "ViewBorrowedBooks";
            ViewBorrowedBooks.Size = new Size(168, 29);
            ViewBorrowedBooks.TabIndex = 64;
            ViewBorrowedBooks.Text = "View Borrowed Books";
            ViewBorrowedBooks.UseVisualStyleBackColor = true;
            // 
            // DisplayBooks
            // 
            DisplayBooks.Location = new Point(357, 195);
            DisplayBooks.Name = "DisplayBooks";
            DisplayBooks.Size = new Size(168, 29);
            DisplayBooks.TabIndex = 63;
            DisplayBooks.Text = "View Books";
            DisplayBooks.UseVisualStyleBackColor = true;
            DisplayBooks.Click += DisplayBooks_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(357, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(632, 331);
            dataGridView1.TabIndex = 62;
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.Font = new Font("Segoe UI", 16F);
            lblGreeting.Location = new Point(9, 187);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(201, 37);
            lblGreeting.TabIndex = 65;
            lblGreeting.Text = "Hello Customer";
            // 
            // BorrowBook
            // 
            BorrowBook.Location = new Point(357, 160);
            BorrowBook.Name = "BorrowBook";
            BorrowBook.Size = new Size(168, 29);
            BorrowBook.TabIndex = 67;
            BorrowBook.Text = "Borrow Book";
            BorrowBook.UseVisualStyleBackColor = true;
            // 
            // ReturnBook
            // 
            ReturnBook.Location = new Point(531, 160);
            ReturnBook.Name = "ReturnBook";
            ReturnBook.Size = new Size(168, 29);
            ReturnBook.TabIndex = 68;
            ReturnBook.Text = "Return Book";
            ReturnBook.UseVisualStyleBackColor = true;
            // 
            // ViewFines
            // 
            ViewFines.Location = new Point(705, 195);
            ViewFines.Name = "ViewFines";
            ViewFines.Size = new Size(168, 29);
            ViewFines.TabIndex = 69;
            ViewFines.Text = "View Fines";
            ViewFines.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            // 
            // ViewPersonalInfo
            // 
            ViewPersonalInfo.Location = new Point(195, 2);
            ViewPersonalInfo.Name = "ViewPersonalInfo";
            ViewPersonalInfo.Size = new Size(155, 29);
            ViewPersonalInfo.TabIndex = 72;
            ViewPersonalInfo.Text = "View Personal Info";
            ViewPersonalInfo.UseVisualStyleBackColor = true;
            ViewPersonalInfo.Click += ViewPersonalInfo_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 561);
            Controls.Add(ViewPersonalInfo);
            Controls.Add(pictureBox1);
            Controls.Add(ViewFines);
            Controls.Add(ReturnBook);
            Controls.Add(BorrowBook);
            Controls.Add(lblGreeting);
            Controls.Add(ViewBorrowedBooks);
            Controls.Add(DisplayBooks);
            Controls.Add(dataGridView1);
            Name = "CustomerForm";
            Text = "CustomerForm";
            Load += CustomerForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ViewBorrowedBooks;
        private Button DisplayBooks;
        private DataGridView dataGridView1;
        private Label lblGreeting;
        private Button BorrowBook;
        private Button ReturnBook;
        private Button ViewFines;
        private PictureBox pictureBox1;
        private Button ViewPersonalInfo;
    }
}