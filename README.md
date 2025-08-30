# Library Management System

A comprehensive desktop application for managing library operations built with .NET Framework (C#) and Oracle Database.

## 📖 Overview

This Library Management System provides a complete solution for managing library resources, users, and transactions. It features separate interfaces for librarians and customers with role-based access control.

## ✨ Features

### 👨‍💼 Librarian Features
- **Book Management**: Add, update, delete, and search books
- **User Management**: Manage library users (both librarians and customers)
- **Transaction Tracking**: View borrowed books and fines
- **Advanced Query System**: Execute custom SQL queries
- **Comprehensive Search**: Search across all book attributes

### 👤 Customer Features
- **Personal Information**: View and manage account details
- **Book Browsing**: Explore available books in the library
- **Borrowing System**: Check out and return books
- **Fine Management**: View and track any outstanding fines

## 🛠️ Technology Stack

- **Frontend**: Windows Forms (.NET Framework)
- **Backend**: Oracle Database
- **Programming Language**: C#
- **Database Connectivity**: Oracle Managed Data Access

## 📋 Prerequisites

Before running this application, ensure you have:

1. **.NET Framework** (version 4.7.2 or higher)
2. **Oracle Database** (11g or higher)
3. **Oracle Managed Data Access Client**
4. **Visual Studio** (2019 or later recommended)

## 🗄️ Database Setup

1. Create an Oracle database instance
2. Execute the following SQL scripts to create necessary tables:

```sql
-- Users table
CREATE TABLE Users (
    UserID NUMBER PRIMARY KEY,
    UserType VARCHAR2(20) NOT NULL,
    FullName VARCHAR2(100) NOT NULL,
    Username VARCHAR2(50) UNIQUE NOT NULL,
    Password VARCHAR2(100) NOT NULL,
    Email VARCHAR2(100) UNIQUE NOT NULL,
    PhoneNumber VARCHAR2(20),
    Address VARCHAR2(200),
    DateCreated DATE DEFAULT SYSDATE
);

-- Books table
CREATE TABLE Books (
    BookID NUMBER PRIMARY KEY,
    Title VARCHAR2(200) NOT NULL,
    Author VARCHAR2(100) NOT NULL,
    ISBN VARCHAR2(20) UNIQUE NOT NULL,
    Genre VARCHAR2(50),
    PublicationYear NUMBER,
    Publisher VARCHAR2(100),
    CopiesAvailable NUMBER DEFAULT 0,
    TotalCopies NUMBER DEFAULT 0
);

-- BorrowedBooks table
CREATE TABLE BorrowedBooks (
    BorrowID NUMBER PRIMARY KEY,
    UserID NUMBER REFERENCES Users(UserID),
    BookID NUMBER REFERENCES Books(BookID),
    BorrowDate DATE DEFAULT SYSDATE,
    DueDate DATE,
    ReturnDate DATE
);

-- Fines table
CREATE TABLE Fines (
    FineID NUMBER PRIMARY KEY,
    UserID NUMBER REFERENCES Users(UserID),
    Amount NUMBER DEFAULT 0,
    Reason VARCHAR2(200),
    PaidDate DATE
);
```

## 🔧 Installation

1. Clone or download the project files
2. Open the solution in Visual Studio
3. Update the connection string in all forms to match your Oracle configuration:
   ```csharp
   string connectionString = "User Id=your_username;Password=your_password;Data Source=your_oracle_connection_string;";
   ```
4. Build the solution to restore NuGet packages
5. Run the application

## 🚀 Usage

1. **Launch the application**
2. **Select login type**:
   - Admin/Librarian: Full system access
   - Customer: Limited to personal and book browsing features
3. **Default credentials** (you'll need to create these in your database first):
   - Librarian: username/email and password as stored in Users table
   - Customer: username/email and password as stored in Users table

## 📁 Project Structure

```
Library-Management-System/
│
├── MainLoginForm.cs          # Main login selection screen
├── Login.cs                  # Librarian login form
├── CustomerLogin.cs          # Customer login form
├── Form1.cs                  # Main librarian dashboard
├── CustomerForm.cs           # Customer dashboard
├── PersonalInfo.cs           # Customer personal information
├── Program.cs                # Application entry point
└── App.config                # Application configuration
```

## 🔐 Security Features

- Role-based access control
- Secure password storage (Note: Passwords are stored in plain text in this version - consider enhancing security for production use)
- Parameterized SQL queries to prevent injection attacks

## 🎨 UI/UX Features

- Intuitive tabbed interface for librarians
- Responsive design with clear navigation
- Data grid views for efficient information display
- Consistent color scheme and styling

## 🔄 Database Operations

The application supports all CRUD operations:
- Create: Add new books and users
- Read: Search and view records
- Update: Modify existing records
- Delete: Remove books and users

## ⚙️ Configuration

Update the connection string in all forms to point to your Oracle database:

```csharp
string connectionString = "User Id=sys;Password=your_password;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));DBA Privilege=SYSDBA;";
```

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request

## 📝 Future Enhancements

- Implement password encryption
- Add book reservation system
- Enhance reporting capabilities
- Add email notifications for due dates
- Implement barcode scanning for books
- Add photo upload for user profiles

## 📞 Support

For questions or issues regarding this library management system, please check the code comments or refer to Oracle database documentation for connection issues.

## 📄 License

This project is created for educational purposes. Feel free to modify and use according to your needs.

---

**Note**: This application requires a properly configured Oracle database instance to function correctly. Ensure your database is running and accessible before using the application.
