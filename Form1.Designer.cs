namespace Library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            DisplayBooks = new Button();
            Query = new TextBox();
            RunQuery = new Button();
            Author = new TextBox();
            Genre = new TextBox();
            PublicationYear = new TextBox();
            Publisher = new TextBox();
            CopiesAvailable = new TextBox();
            TotalCopies = new TextBox();
            ISBN = new TextBox();
            Title = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            AddBook = new Button();
            label9 = new Label();
            label10 = new Label();
            deletebook = new TextBox();
            SearchBook = new TextBox();
            label11 = new Label();
            SearchaBook = new Button();
            DeleteaBook = new Button();
            ViewUsers = new Button();
            ViewBorrowedBooks = new Button();
            ViewFines = new Button();
            label12 = new Label();
            UpdateBook = new TextBox();
            UpdateaBook = new Button();
            label13 = new Label();
            lblGreeting = new Label();
            lblGreeting2 = new Label();
            FullName = new TextBox();
            PhoneNumber = new TextBox();
            Email = new TextBox();
            Password = new TextBox();
            Username = new TextBox();
            Address = new TextBox();
            UserType = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            AddUser = new Button();
            SearchUserID = new TextBox();
            DeleteUserID = new TextBox();
            UpdateUserID = new TextBox();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            SearchUser = new Button();
            DeleteUser = new Button();
            UpdateUser = new Button();
            TabPage = new TabControl();
            BooksTab = new TabPage();
            UsersTab = new TabPage();
            label26 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            TabPage.SuspendLayout();
            BooksTab.SuspendLayout();
            UsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(307, 188);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(977, 331);
            dataGridView1.TabIndex = 0;
            // 
            // DisplayBooks
            // 
            DisplayBooks.Location = new Point(594, 152);
            DisplayBooks.Name = "DisplayBooks";
            DisplayBooks.Size = new Size(168, 29);
            DisplayBooks.TabIndex = 1;
            DisplayBooks.Text = "View Books";
            DisplayBooks.UseVisualStyleBackColor = true;
            DisplayBooks.Click += DisplayBooks_Click;
            // 
            // Query
            // 
            Query.Location = new Point(124, 55);
            Query.Name = "Query";
            Query.PlaceholderText = "Enter your Query here";
            Query.Size = new Size(218, 27);
            Query.TabIndex = 2;
            // 
            // RunQuery
            // 
            RunQuery.Location = new Point(348, 55);
            RunQuery.Name = "RunQuery";
            RunQuery.Size = new Size(94, 29);
            RunQuery.TabIndex = 3;
            RunQuery.Text = "Run Query";
            RunQuery.UseVisualStyleBackColor = true;
            RunQuery.Click += RunQuery_Click;
            // 
            // Author
            // 
            Author.Location = new Point(109, 252);
            Author.Name = "Author";
            Author.PlaceholderText = "Enter Book Author";
            Author.Size = new Size(192, 27);
            Author.TabIndex = 4;
            // 
            // Genre
            // 
            Genre.Location = new Point(109, 318);
            Genre.Name = "Genre";
            Genre.PlaceholderText = "Enter Book Genre";
            Genre.Size = new Size(192, 27);
            Genre.TabIndex = 5;
            // 
            // PublicationYear
            // 
            PublicationYear.Location = new Point(109, 351);
            PublicationYear.Name = "PublicationYear";
            PublicationYear.PlaceholderText = "Enter Book Publication Year";
            PublicationYear.Size = new Size(192, 27);
            PublicationYear.TabIndex = 6;
            // 
            // Publisher
            // 
            Publisher.Location = new Point(109, 384);
            Publisher.Name = "Publisher";
            Publisher.PlaceholderText = "Enter Book Publisher";
            Publisher.Size = new Size(192, 27);
            Publisher.TabIndex = 7;
            // 
            // CopiesAvailable
            // 
            CopiesAvailable.Location = new Point(109, 417);
            CopiesAvailable.Name = "CopiesAvailable";
            CopiesAvailable.PlaceholderText = "Enter Book copies available";
            CopiesAvailable.Size = new Size(192, 27);
            CopiesAvailable.TabIndex = 8;
            // 
            // TotalCopies
            // 
            TotalCopies.Location = new Point(109, 450);
            TotalCopies.Name = "TotalCopies";
            TotalCopies.PlaceholderText = "Enter Book total copies";
            TotalCopies.Size = new Size(192, 27);
            TotalCopies.TabIndex = 9;
            // 
            // ISBN
            // 
            ISBN.Location = new Point(109, 285);
            ISBN.Name = "ISBN";
            ISBN.PlaceholderText = "Enter Book ISBN";
            ISBN.Size = new Size(192, 27);
            ISBN.TabIndex = 10;
            // 
            // Title
            // 
            Title.Location = new Point(109, 219);
            Title.Name = "Title";
            Title.PlaceholderText = "Enter Book Title";
            Title.Size = new Size(192, 27);
            Title.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 222);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 12;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 255);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 13;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 288);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 14;
            label3.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 321);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 15;
            label4.Text = "Genre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 354);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 16;
            label5.Text = "Year";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 387);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 17;
            label6.Text = "Publisher";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 420);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 18;
            label7.Text = "Copies";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 453);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 19;
            label8.Text = "Total Copies";
            // 
            // AddBook
            // 
            AddBook.Location = new Point(109, 483);
            AddBook.Name = "AddBook";
            AddBook.Size = new Size(131, 29);
            AddBook.TabIndex = 20;
            AddBook.Text = "Add Book";
            AddBook.UseVisualStyleBackColor = true;
            AddBook.Click += AddBook_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(19, 184);
            label9.Name = "label9";
            label9.Size = new Size(250, 32);
            label9.TabIndex = 21;
            label9.Text = "Add or Update a Book";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 91);
            label10.Name = "label10";
            label10.Size = new Size(91, 20);
            label10.TabIndex = 22;
            label10.Text = "Delete Book";
            // 
            // deletebook
            // 
            deletebook.Location = new Point(124, 88);
            deletebook.Name = "deletebook";
            deletebook.PlaceholderText = "Enter BookID or Title to Delete";
            deletebook.Size = new Size(218, 27);
            deletebook.TabIndex = 23;
            // 
            // SearchBook
            // 
            SearchBook.Location = new Point(124, 121);
            SearchBook.Name = "SearchBook";
            SearchBook.PlaceholderText = "Enter any Book Attribute";
            SearchBook.Size = new Size(218, 27);
            SearchBook.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 124);
            label11.Name = "label11";
            label11.Size = new Size(91, 20);
            label11.TabIndex = 25;
            label11.Text = "Search Book";
            // 
            // SearchaBook
            // 
            SearchaBook.Location = new Point(348, 120);
            SearchaBook.Name = "SearchaBook";
            SearchaBook.Size = new Size(94, 29);
            SearchaBook.TabIndex = 26;
            SearchaBook.Text = "Search";
            SearchaBook.UseVisualStyleBackColor = true;
            SearchaBook.Click += SearchaBook_Click;
            // 
            // DeleteaBook
            // 
            DeleteaBook.Location = new Point(348, 87);
            DeleteaBook.Name = "DeleteaBook";
            DeleteaBook.Size = new Size(94, 29);
            DeleteaBook.TabIndex = 27;
            DeleteaBook.Text = "Delete";
            DeleteaBook.UseVisualStyleBackColor = true;
            DeleteaBook.Click += DeleteaBook_Click;
            // 
            // ViewUsers
            // 
            ViewUsers.Location = new Point(593, 127);
            ViewUsers.Name = "ViewUsers";
            ViewUsers.Size = new Size(168, 29);
            ViewUsers.TabIndex = 28;
            ViewUsers.Text = "View Users";
            ViewUsers.UseVisualStyleBackColor = true;
            ViewUsers.Click += ViewUsers_Click;
            // 
            // ViewBorrowedBooks
            // 
            ViewBorrowedBooks.Location = new Point(768, 152);
            ViewBorrowedBooks.Name = "ViewBorrowedBooks";
            ViewBorrowedBooks.Size = new Size(168, 29);
            ViewBorrowedBooks.TabIndex = 29;
            ViewBorrowedBooks.Text = "View Borrowed Books";
            ViewBorrowedBooks.UseVisualStyleBackColor = true;
            ViewBorrowedBooks.Click += ViewBorrowedBooks_Click;
            // 
            // ViewFines
            // 
            ViewFines.Location = new Point(767, 127);
            ViewFines.Name = "ViewFines";
            ViewFines.Size = new Size(168, 29);
            ViewFines.TabIndex = 30;
            ViewFines.Text = "View Fines";
            ViewFines.UseVisualStyleBackColor = true;
            ViewFines.Click += ViewFines_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 156);
            label12.Name = "label12";
            label12.Size = new Size(96, 20);
            label12.TabIndex = 31;
            label12.Text = "Update Book";
            // 
            // UpdateBook
            // 
            UpdateBook.Location = new Point(124, 154);
            UpdateBook.Name = "UpdateBook";
            UpdateBook.PlaceholderText = "Enter BookID to Update";
            UpdateBook.Size = new Size(218, 27);
            UpdateBook.TabIndex = 32;
            // 
            // UpdateaBook
            // 
            UpdateaBook.Location = new Point(348, 153);
            UpdateaBook.Name = "UpdateaBook";
            UpdateaBook.Size = new Size(94, 29);
            UpdateaBook.TabIndex = 33;
            UpdateaBook.Text = "Update";
            UpdateaBook.UseVisualStyleBackColor = true;
            UpdateaBook.Click += UpdateaBook_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(67, 58);
            label13.Name = "label13";
            label13.Size = new Size(48, 20);
            label13.TabIndex = 34;
            label13.Text = "Query";
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.Font = new Font("Segoe UI", 20F);
            lblGreeting.Location = new Point(14, 3);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(236, 46);
            lblGreeting.TabIndex = 35;
            lblGreeting.Text = "Hello Librarian";
            // 
            // lblGreeting2
            // 
            lblGreeting2.AutoSize = true;
            lblGreeting2.Font = new Font("Segoe UI", 20F);
            lblGreeting2.Location = new Point(6, 6);
            lblGreeting2.Name = "lblGreeting2";
            lblGreeting2.Size = new Size(236, 46);
            lblGreeting2.TabIndex = 36;
            lblGreeting2.Text = "Hello Librarian";
            // 
            // FullName
            // 
            FullName.Location = new Point(98, 211);
            FullName.Name = "FullName";
            FullName.PlaceholderText = "Enter Full Name";
            FullName.Size = new Size(125, 27);
            FullName.TabIndex = 37;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Location = new Point(98, 277);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.PlaceholderText = "Enter Phone No";
            PhoneNumber.Size = new Size(125, 27);
            PhoneNumber.TabIndex = 38;
            // 
            // Email
            // 
            Email.Location = new Point(98, 244);
            Email.Name = "Email";
            Email.PlaceholderText = "Enter Email";
            Email.Size = new Size(125, 27);
            Email.TabIndex = 39;
            // 
            // Password
            // 
            Password.Location = new Point(98, 343);
            Password.Name = "Password";
            Password.PlaceholderText = "Enter Password";
            Password.Size = new Size(125, 27);
            Password.TabIndex = 40;
            // 
            // Username
            // 
            Username.Location = new Point(98, 310);
            Username.Name = "Username";
            Username.PlaceholderText = "Enter Username";
            Username.Size = new Size(125, 27);
            Username.TabIndex = 41;
            // 
            // Address
            // 
            Address.Location = new Point(98, 376);
            Address.Name = "Address";
            Address.PlaceholderText = "Enter Address";
            Address.Size = new Size(125, 27);
            Address.TabIndex = 42;
            // 
            // UserType
            // 
            UserType.FormattingEnabled = true;
            UserType.Items.AddRange(new object[] { "Librarian", "Customer" });
            UserType.Location = new Point(98, 409);
            UserType.Name = "UserType";
            UserType.Size = new Size(151, 28);
            UserType.TabIndex = 43;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(16, 214);
            label16.Name = "label16";
            label16.Size = new Size(76, 20);
            label16.TabIndex = 44;
            label16.Text = "Full Name";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(17, 313);
            label17.Name = "label17";
            label17.Size = new Size(75, 20);
            label17.TabIndex = 45;
            label17.Text = "Username";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(46, 247);
            label18.Name = "label18";
            label18.Size = new Size(46, 20);
            label18.TabIndex = 46;
            label18.Text = "Email";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(22, 346);
            label19.Name = "label19";
            label19.Size = new Size(70, 20);
            label19.TabIndex = 47;
            label19.Text = "Password";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(18, 280);
            label20.Name = "label20";
            label20.Size = new Size(74, 20);
            label20.TabIndex = 48;
            label20.Text = "Phone No";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(30, 379);
            label21.Name = "label21";
            label21.Size = new Size(62, 20);
            label21.TabIndex = 49;
            label21.Text = "Address";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(19, 412);
            label22.Name = "label22";
            label22.Size = new Size(73, 20);
            label22.TabIndex = 50;
            label22.Text = "User Type";
            // 
            // AddUser
            // 
            AddUser.Location = new Point(98, 446);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(151, 29);
            AddUser.TabIndex = 51;
            AddUser.Text = "Add User";
            AddUser.UseVisualStyleBackColor = true;
            AddUser.Click += AddUser_Click;
            // 
            // SearchUserID
            // 
            SearchUserID.Location = new Point(109, 63);
            SearchUserID.Name = "SearchUserID";
            SearchUserID.PlaceholderText = "Enter User ID";
            SearchUserID.Size = new Size(159, 27);
            SearchUserID.TabIndex = 52;
            // 
            // DeleteUserID
            // 
            DeleteUserID.Location = new Point(109, 96);
            DeleteUserID.Name = "DeleteUserID";
            DeleteUserID.PlaceholderText = "Enter User ID";
            DeleteUserID.Size = new Size(159, 27);
            DeleteUserID.TabIndex = 53;
            // 
            // UpdateUserID
            // 
            UpdateUserID.Location = new Point(109, 129);
            UpdateUserID.Name = "UpdateUserID";
            UpdateUserID.PlaceholderText = "Enter User ID";
            UpdateUserID.Size = new Size(159, 27);
            UpdateUserID.TabIndex = 54;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(17, 66);
            label23.Name = "label23";
            label23.Size = new Size(86, 20);
            label23.TabIndex = 55;
            label23.Text = "Search User";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(17, 99);
            label24.Name = "label24";
            label24.Size = new Size(86, 20);
            label24.TabIndex = 56;
            label24.Text = "Delete User";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(12, 132);
            label25.Name = "label25";
            label25.Size = new Size(91, 20);
            label25.TabIndex = 57;
            label25.Text = "Update User";
            // 
            // SearchUser
            // 
            SearchUser.Location = new Point(274, 61);
            SearchUser.Name = "SearchUser";
            SearchUser.Size = new Size(94, 29);
            SearchUser.TabIndex = 58;
            SearchUser.Text = "Search";
            SearchUser.UseVisualStyleBackColor = true;
            SearchUser.Click += SearchUser_Click;
            // 
            // DeleteUser
            // 
            DeleteUser.Location = new Point(274, 95);
            DeleteUser.Name = "DeleteUser";
            DeleteUser.Size = new Size(94, 29);
            DeleteUser.TabIndex = 59;
            DeleteUser.Text = "Delete";
            DeleteUser.UseVisualStyleBackColor = true;
            DeleteUser.Click += DeleteUser_Click;
            // 
            // UpdateUser
            // 
            UpdateUser.Location = new Point(274, 128);
            UpdateUser.Name = "UpdateUser";
            UpdateUser.Size = new Size(94, 29);
            UpdateUser.TabIndex = 60;
            UpdateUser.Text = "Update";
            UpdateUser.UseVisualStyleBackColor = true;
            UpdateUser.Click += UpdateUser_Click;
            // 
            // TabPage
            // 
            TabPage.Controls.Add(BooksTab);
            TabPage.Controls.Add(UsersTab);
            TabPage.Location = new Point(2, 0);
            TabPage.Name = "TabPage";
            TabPage.SelectedIndex = 0;
            TabPage.Size = new Size(1295, 558);
            TabPage.TabIndex = 61;
            // 
            // BooksTab
            // 
            BooksTab.Controls.Add(lblGreeting);
            BooksTab.Controls.Add(Query);
            BooksTab.Controls.Add(RunQuery);
            BooksTab.Controls.Add(Author);
            BooksTab.Controls.Add(Genre);
            BooksTab.Controls.Add(PublicationYear);
            BooksTab.Controls.Add(Publisher);
            BooksTab.Controls.Add(CopiesAvailable);
            BooksTab.Controls.Add(TotalCopies);
            BooksTab.Controls.Add(ISBN);
            BooksTab.Controls.Add(Title);
            BooksTab.Controls.Add(label1);
            BooksTab.Controls.Add(label2);
            BooksTab.Controls.Add(label3);
            BooksTab.Controls.Add(label4);
            BooksTab.Controls.Add(label5);
            BooksTab.Controls.Add(label6);
            BooksTab.Controls.Add(label7);
            BooksTab.Controls.Add(label8);
            BooksTab.Controls.Add(AddBook);
            BooksTab.Controls.Add(label9);
            BooksTab.Controls.Add(label10);
            BooksTab.Controls.Add(deletebook);
            BooksTab.Controls.Add(SearchBook);
            BooksTab.Controls.Add(label11);
            BooksTab.Controls.Add(SearchaBook);
            BooksTab.Controls.Add(DeleteaBook);
            BooksTab.Controls.Add(ViewBorrowedBooks);
            BooksTab.Controls.Add(label13);
            BooksTab.Controls.Add(label12);
            BooksTab.Controls.Add(DisplayBooks);
            BooksTab.Controls.Add(UpdateaBook);
            BooksTab.Controls.Add(dataGridView1);
            BooksTab.Controls.Add(UpdateBook);
            BooksTab.Location = new Point(4, 29);
            BooksTab.Name = "BooksTab";
            BooksTab.Padding = new Padding(3);
            BooksTab.Size = new Size(1287, 525);
            BooksTab.TabIndex = 0;
            BooksTab.Text = "Books";
            BooksTab.UseVisualStyleBackColor = true;
            // 
            // UsersTab
            // 
            UsersTab.Controls.Add(label26);
            UsersTab.Controls.Add(dataGridView2);
            UsersTab.Controls.Add(lblGreeting2);
            UsersTab.Controls.Add(label20);
            UsersTab.Controls.Add(UpdateUser);
            UsersTab.Controls.Add(label18);
            UsersTab.Controls.Add(ViewUsers);
            UsersTab.Controls.Add(label16);
            UsersTab.Controls.Add(DeleteUser);
            UsersTab.Controls.Add(ViewFines);
            UsersTab.Controls.Add(SearchUser);
            UsersTab.Controls.Add(FullName);
            UsersTab.Controls.Add(label25);
            UsersTab.Controls.Add(PhoneNumber);
            UsersTab.Controls.Add(label24);
            UsersTab.Controls.Add(Email);
            UsersTab.Controls.Add(label23);
            UsersTab.Controls.Add(Password);
            UsersTab.Controls.Add(UpdateUserID);
            UsersTab.Controls.Add(Username);
            UsersTab.Controls.Add(DeleteUserID);
            UsersTab.Controls.Add(Address);
            UsersTab.Controls.Add(SearchUserID);
            UsersTab.Controls.Add(UserType);
            UsersTab.Controls.Add(AddUser);
            UsersTab.Controls.Add(label17);
            UsersTab.Controls.Add(label22);
            UsersTab.Controls.Add(label19);
            UsersTab.Controls.Add(label21);
            UsersTab.Location = new Point(4, 29);
            UsersTab.Name = "UsersTab";
            UsersTab.Padding = new Padding(3);
            UsersTab.Size = new Size(1287, 525);
            UsersTab.TabIndex = 1;
            UsersTab.Text = "Users";
            UsersTab.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 14F);
            label26.Location = new Point(12, 163);
            label26.Name = "label26";
            label26.Size = new Size(224, 32);
            label26.TabIndex = 62;
            label26.Text = "Add or Update User";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(308, 163);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(973, 352);
            dataGridView2.TabIndex = 61;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 556);
            Controls.Add(TabPage);
            Name = "Form1";
            Text = "Library ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            TabPage.ResumeLayout(false);
            BooksTab.ResumeLayout(false);
            BooksTab.PerformLayout();
            UsersTab.ResumeLayout(false);
            UsersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button DisplayBooks;
        private TextBox Query;
        private Button RunQuery;
        private TextBox Author;
        private TextBox Genre;
        private TextBox PublicationYear;
        private TextBox Publisher;
        private TextBox CopiesAvailable;
        private TextBox TotalCopies;
        private TextBox ISBN;
        private TextBox Title;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button AddBook;
        private Label label9;
        private Label label10;
        private TextBox deletebook;
        private TextBox SearchBook;
        private Label label11;
        private Button SearchaBook;
        private Button DeleteaBook;
        private Button ViewUsers;
        private Button ViewBorrowedBooks;
        private Button ViewFines;
        private Label label12;
        private TextBox UpdateBook;
        private Button UpdateaBook;
        private Label label13;
        private Label lblGreeting;
        private Label lblGreeting2;
        private TextBox FullName;
        private TextBox PhoneNumber;
        private TextBox Email;
        private TextBox Password;
        private TextBox Username;
        private TextBox Address;
        private ComboBox UserType;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Button AddUser;
        private TextBox SearchUserID;
        private TextBox DeleteUserID;
        private TextBox UpdateUserID;
        private Label label23;
        private Label label24;
        private Label label25;
        private Button SearchUser;
        private Button DeleteUser;
        private Button UpdateUser;
        private TabControl TabPage;
        private TabPage BooksTab;
        private TabPage UsersTab;
        private Label label26;
        private DataGridView dataGridView2;
    }
}
