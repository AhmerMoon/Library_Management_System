using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Library
{
    public partial class Form1 : Form
    {
        private int LibrarianID; // To store the logged-in librarian's ID
        private string FullNameOfLibrarian;
        private string connectionString = "User Id=sys;Password=ahmer28704;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));DBA Privilege=SYSDBA;";
        public Form1(int userID, string fullName)
        {
            InitializeComponent();
            LibrarianID = userID;
            FullNameOfLibrarian = fullName;
        }

        private void LoadUsers()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Users"; // Adjust table name as per your database
                    OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable; // Bind data to the DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadBooks()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Books"; // Adjust table name as per your database
                    OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable; // Bind data to the DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Method to add a new book record
        public void Add_Book()
        {
            try
            {
                // Get values from textboxes
                string title = Title.Text;
                string author = Author.Text;
                string isbn = ISBN.Text;
                string genre = Genre.Text;
                int publicationYear = int.Parse(PublicationYear.Text);
                string publisher = Publisher.Text;
                int totalCopies = int.Parse(TotalCopies.Text);
                int copiesAvailable = int.Parse(CopiesAvailable.Text);

                // SQL query to insert book
                string query = @"
            INSERT INTO Books (Title, Author, ISBN, Genre, PublicationYear, Publisher, CopiesAvailable, TotalCopies)
            VALUES (:Title, :Author, :ISBN, :Genre, :PublicationYear, :Publisher, :CopiesAvailable, :TotalCopies)";

                // Create a connection and command
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        // Add parameters
                        cmd.Parameters.Add(new OracleParameter("Title", title));
                        cmd.Parameters.Add(new OracleParameter("Author", author));
                        cmd.Parameters.Add(new OracleParameter("ISBN", isbn));
                        cmd.Parameters.Add(new OracleParameter("Genre", genre));
                        cmd.Parameters.Add(new OracleParameter("PublicationYear", publicationYear));
                        cmd.Parameters.Add(new OracleParameter("Publisher", publisher));
                        cmd.Parameters.Add(new OracleParameter("CopiesAvailable", copiesAvailable));
                        cmd.Parameters.Add(new OracleParameter("TotalCopies", totalCopies));

                        // Open connection and execute the command
                        conn.Open();
                        int rowsInserted = cmd.ExecuteNonQuery();

                        // Show success message
                        if (rowsInserted > 0)
                        {
                            MessageBox.Show("Book added successfully!");
                            Title.Clear();
                            Author.Clear();
                            ISBN.Clear();
                            Genre.Clear();
                            PublicationYear.Clear();
                            Publisher.Clear();
                            TotalCopies.Clear();
                            CopiesAvailable.Clear();
                            LoadBooks();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the book.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle errors
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void DisplayBooks_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void RunQuery_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    string query = Query.Text;
                    OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable; // Bind data to the DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            Add_Book();
        }

        private void SearchaBook_Click(object sender, EventArgs e)
        {
            // Check if the search text is empty
            if (string.IsNullOrWhiteSpace(SearchBook.Text))
            {
                MessageBox.Show("Please enter a value to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();

                    string query;
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;

                    // Check if the input is numeric
                    if (int.TryParse(SearchBook.Text, out int numericValue))
                    {
                        // Search across numeric columns
                        query = @"
                SELECT * FROM Books
                WHERE BookID = :NumericValue
                   OR PublicationYear = :NumericValue
                   OR CopiesAvailable = :NumericValue
                   OR TotalCopies = :NumericValue";
                        cmd.Parameters.Add(new OracleParameter("NumericValue", numericValue));
                    }
                    else
                    {
                        // Search across string columns
                        query = @"
                SELECT * FROM Books
                WHERE LOWER(Title) LIKE :SearchValue
                   OR LOWER(Author) LIKE :SearchValue
                   OR LOWER(Genre) LIKE :SearchValue
                   OR LOWER(Publisher) LIKE :SearchValue
                   OR LOWER(ISBN) LIKE :SearchValue";
                        cmd.Parameters.Add(new OracleParameter("SearchValue", "%" + SearchBook.Text.ToLower() + "%"));
                    }

                    cmd.CommandText = query;

                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dataTable; // Display results in the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No records found matching the search criteria.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteaBook_Click(object sender, EventArgs e)
        {
            // Check if the delete input is empty
            if (string.IsNullOrWhiteSpace(deletebook.Text))
            {
                MessageBox.Show("Please enter a value to delete a book.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();

                    string query;
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;

                    // Check if the input is numeric
                    if (int.TryParse(deletebook.Text, out int numericValue))
                    {
                        // Delete based on numeric columns
                        query = @"
                DELETE FROM Books
                WHERE BookID = :NumericValue";
                        cmd.Parameters.Add(new OracleParameter("NumericValue", numericValue));
                    }
                    else
                    {
                        // Delete based on string columns with case-insensitive comparison
                        query = @"
                DELETE FROM Books
                WHERE LOWER(Title) = LOWER(:SearchValue)
                   OR LOWER(ISBN) = LOWER(:SearchValue)";
                        cmd.Parameters.Add(new OracleParameter("SearchValue", deletebook.Text));
                    }

                    cmd.CommandText = query;

                    // Confirm deletion with the user
                    DialogResult confirmation = MessageBox.Show(
                        "Are you sure you want to delete the book(s) matching the entered value?",
                        "Delete Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmation == DialogResult.Yes)
                    {
                        int rowsAffected = cmd.ExecuteNonQuery(); // Execute the delete query

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"{rowsAffected} record(s) deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBooks();
                            deletebook.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No matching records found to delete.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewUsers_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Users"; // Adjust table name as per your database
                    OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView2.DataSource = dataTable; // Bind data to the DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ViewBorrowedBooks_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM BorrowedBooks"; // Adjust table name as per your database
                    OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable; // Bind data to the DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ViewFines_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Fines"; // Adjust table name as per your database
                    OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView2.DataSource = dataTable; // Bind data to the DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateaBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from textboxes
                int bookid = int.Parse(UpdateBook.Text); // This will be used to identify the book to update
                string title = Title.Text;
                string author = Author.Text;
                string isbn = ISBN.Text;
                string genre = Genre.Text;
                int publicationYear = int.Parse(PublicationYear.Text);
                string publisher = Publisher.Text;
                int totalCopies = int.Parse(TotalCopies.Text);
                int copiesAvailable = int.Parse(CopiesAvailable.Text);

                // SQL query to update book
                string query = @"
        UPDATE Books
        SET 
            Title = :Title,
            Author = :Author,
            ISBN = :ISBN,
            Genre = :Genre,
            PublicationYear = :PublicationYear,
            Publisher = :Publisher,
            CopiesAvailable = :CopiesAvailable,
            TotalCopies = :TotalCopies
        WHERE 
            BookID = :BookID";

                // Create a connection and command
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        // Add parameters
                        cmd.Parameters.Add(new OracleParameter("Title", title));
                        cmd.Parameters.Add(new OracleParameter("Author", author));
                        cmd.Parameters.Add(new OracleParameter("ISBN", isbn));
                        cmd.Parameters.Add(new OracleParameter("Genre", genre));
                        cmd.Parameters.Add(new OracleParameter("PublicationYear", publicationYear));
                        cmd.Parameters.Add(new OracleParameter("Publisher", publisher));
                        cmd.Parameters.Add(new OracleParameter("CopiesAvailable", copiesAvailable));
                        cmd.Parameters.Add(new OracleParameter("TotalCopies", totalCopies));
                        cmd.Parameters.Add(new OracleParameter("BookID", bookid)); // Add the BookID as a condition

                        // Open connection and execute the command
                        conn.Open();
                        int rowsUpdated = cmd.ExecuteNonQuery();

                        // Show success message
                        if (rowsUpdated > 0)
                        {
                            MessageBox.Show("Book updated successfully!");
                            UpdateBook.Clear();
                            Title.Clear();
                            Author.Clear();
                            ISBN.Clear();
                            Genre.Clear();
                            PublicationYear.Clear();
                            Publisher.Clear();
                            TotalCopies.Clear();
                            CopiesAvailable.Clear();
                            LoadBooks(); // Refresh the book list
                        }
                        else
                        {
                            MessageBox.Show("No matching book found to update.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle errors
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from textboxes
                string fullName = FullName.Text;
                string userType = UserType.Text; // Ensure this is either 'Librarian' or 'Customer'
                string username = Username.Text;
                string password = Password.Text; // Consider hashing the password before storing
                string email = Email.Text;
                string phoneNumber = PhoneNumber.Text;
                string address = Address.Text;

                // SQL query to insert user
                string query = @"
    INSERT INTO Users (FullName, UserType, Username, Password, Email, PhoneNumber, Address)
    VALUES (:FullName, :UserType, :Username, :Password, :Email, :PhoneNumber, :Address)";

                // Create a connection and command
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        // Add parameters
                        cmd.Parameters.Add(new OracleParameter("FullName", fullName));
                        cmd.Parameters.Add(new OracleParameter("UserType", userType));
                        cmd.Parameters.Add(new OracleParameter("Username", username));
                        cmd.Parameters.Add(new OracleParameter("Password", password)); // Consider hashing
                        cmd.Parameters.Add(new OracleParameter("Email", email));
                        cmd.Parameters.Add(new OracleParameter("PhoneNumber", phoneNumber));
                        cmd.Parameters.Add(new OracleParameter("Address", address));

                        // Open connection and execute the command
                        conn.Open();
                        int rowsInserted = cmd.ExecuteNonQuery();

                        // Show success message
                        if (rowsInserted > 0)
                        {
                            MessageBox.Show("User added successfully!");
                            FullName.Clear();
                            Username.Clear();
                            Password.Clear();
                            Email.Clear();
                            PhoneNumber.Clear();
                            Address.Clear();
                            LoadUsers(); // Assuming you have a method to load users
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the user.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle errors
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void SearchUser_Click(object sender, EventArgs e)
        {
            // Check if the search text is empty
            if (string.IsNullOrWhiteSpace(SearchUserID.Text))
            {
                MessageBox.Show("Please enter a value to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();

                    string query;
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;

                    // Check if the input is numeric
                    if (int.TryParse(SearchUserID.Text, out int numericValue))
                    {
                        // Search across numeric columns
                        query = @"
            SELECT * FROM Users
            WHERE UserID = :NumericValue";
                        cmd.Parameters.Add(new OracleParameter("NumericValue", numericValue));
                    }
                    else
                    {
                        // Search across string columns
                        query = @"
            SELECT * FROM Users
            WHERE LOWER(FullName) LIKE :SearchValue
               OR LOWER(UserType) LIKE :SearchValue
               OR LOWER(Username) LIKE :SearchValue
               OR LOWER(Email) LIKE :SearchValue
               OR LOWER(PhoneNumber) LIKE :SearchValue
               OR LOWER(Address) LIKE :SearchValue";
                        cmd.Parameters.Add(new OracleParameter("SearchValue", "%" + SearchUserID.Text.ToLower() + "%"));
                    }

                    cmd.CommandText = query;

                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dataTable; // Display results in the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No records found matching the search criteria.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            // Check if the delete input is empty
            if (string.IsNullOrWhiteSpace(DeleteUserID.Text))
            {
                MessageBox.Show("Please enter a value to delete a user.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();

                    string query;
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;

                    // Check if the input is numeric
                    if (int.TryParse(DeleteUserID.Text, out int numericValue))
                    {
                        // Delete based on numeric column (UserID)
                        query = @"
            DELETE FROM Users
            WHERE UserID = :NumericValue";
                        cmd.Parameters.Add(new OracleParameter("NumericValue", numericValue));
                    }
                    else
                    {
                        // Delete based on string columns with case-insensitive comparison
                        query = @"
            DELETE FROM Users
            WHERE LOWER(FullName) = LOWER(:SearchValue)
               OR LOWER(Username) = LOWER(:SearchValue)
               OR LOWER(Email) = LOWER(:SearchValue)";
                        cmd.Parameters.Add(new OracleParameter("SearchValue", DeleteUserID.Text));
                    }

                    cmd.CommandText = query;

                    // Confirm deletion with the user
                    DialogResult confirmation = MessageBox.Show(
                        "Are you sure you want to delete the user(s) matching the entered value?",
                        "Delete Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmation == DialogResult.Yes)
                    {
                        int rowsAffected = cmd.ExecuteNonQuery(); // Execute the delete query

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"{rowsAffected} record(s) deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUsers(); // Refresh the Users list
                            DeleteUserID.Clear(); // Clear the input field
                        }
                        else
                        {
                            MessageBox.Show("No matching records found to delete.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from textboxes
                int userId = int.Parse(UpdateUserID.Text); // This will be used to identify the user to update
                string fullName = FullName.Text;
                string userType = UserType.Text; // Ensure 'Librarian' or 'Customer'
                string username = Username.Text;
                string password = Password.Text; // Consider encrypting before saving
                string email = Email.Text;
                string phoneNumber = PhoneNumber.Text;
                string address = Address.Text;

                // SQL query to update user
                string query = @"
    UPDATE Users
    SET 
        FullName = :FullName,
        UserType = :UserType,
        Username = :Username,
        Password = :Password,
        Email = :Email,
        PhoneNumber = :PhoneNumber,
        Address = :Address
    WHERE 
        UserID = :UserID";

                // Create a connection and command
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        // Add parameters
                        cmd.Parameters.Add(new OracleParameter("FullName", fullName));
                        cmd.Parameters.Add(new OracleParameter("UserType", userType));
                        cmd.Parameters.Add(new OracleParameter("Username", username));
                        cmd.Parameters.Add(new OracleParameter("Password", password)); // Ensure security for passwords
                        cmd.Parameters.Add(new OracleParameter("Email", email));
                        cmd.Parameters.Add(new OracleParameter("PhoneNumber", phoneNumber));
                        cmd.Parameters.Add(new OracleParameter("Address", address));
                        cmd.Parameters.Add(new OracleParameter("UserID", userId)); // Add the UserID as a condition

                        // Open connection and execute the command
                        conn.Open();
                        int rowsUpdated = cmd.ExecuteNonQuery();

                        // Show success message
                        if (rowsUpdated > 0)
                        {
                            MessageBox.Show("User updated successfully!");
                            UpdateUserID.Clear();
                            FullName.Clear();
                            Username.Clear();
                            Password.Clear();
                            Email.Clear();
                            PhoneNumber.Clear();
                            Address.Clear();
                            LoadUsers(); // Refresh the user list
                        }
                        else
                        {
                            MessageBox.Show("No matching user found to update.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle errors
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblGreeting.Text = $"Hello {FullNameOfLibrarian}!"; // Set the label text
            lblGreeting2.Text = $"Hello {FullNameOfLibrarian}!"; // Set the label text

        }
    }
}
