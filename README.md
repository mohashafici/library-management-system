
# Library Management System

## Overview

The Library Management System is a software application developed in C# with a SQL Server backend. It is designed to manage the various operations of a library, including user authentication, book management, member management, and book borrowing/returning processes. The system also includes search functionality and reporting features.

## Motivation

In today's digital age, the power of coding is more evident than ever. As someone who understands the transformative potential of technology, I embarked on this project to harness the power of programming to create a robust and efficient solution for managing library operations. This project not only showcases my coding skills but also my commitment to solving real-world problems through technology.

## Features

- **User Authentication**: Secure login for administrators and users.
- **Book Management**: Add, edit, delete, and view books.
- **Member Management**: Add, edit, delete, and view library members.
- **Borrowing and Returning**: Manage book borrowing and returning processes.
- **Search Functionality**: Search for books and members based on various criteria.
- **Reporting**: Generate reports on overdue books, most borrowed books, etc.

## Installation

### Prerequisites

- Visual Studio
- SQL Server
- SQL Server Management Studio (SSMS)

### Steps

1. **Clone the repository**:
   ```sh
   git clone https://github.com/mohashafici/library-management-system
   cd LibraryManagementSystem
   ```

2. **Set up the database**:
   - Open `SQLScripts/CreateDatabase.sql` in SSMS and execute the script to create the database and tables.
   - Open `SQLScripts/InsertSampleData.sql` in SSMS and execute the script to insert sample data.

3. **Configure the connection string**:
   - Open the project in Visual Studio.
   - In `App.config`, update the connection string with your SQL Server details.

4. **Build and run the application**:
   - Build the project in Visual Studio.
   - Run the application.

## Usage

- **Login**: Use the username `admin` and password `admin123` to log in as an admin.
- **Manage Books**: Navigate to the book management section to add, edit, delete, or view books.
- **Manage Members**: Navigate to the member management section to add, edit, delete, or view members.
- **Borrow/Return Books**: Use the borrowing section to manage book loans and returns.
- **Generate Reports**: Access the reporting section to generate various library reports.

## Project Structure

```
LibraryManagementSystem/
├── LibraryManagementSystem/
│   ├── Properties/
│   ├── bin/
│   ├── obj/
│   ├── MainForm.cs
│   ├── MainForm.Designer.cs
│   ├── Program.cs
│   ├── App.config
├── SQLScripts/
│   ├── CreateDatabase.sql
│   ├── InsertSampleData.sql
├── .gitignore
```

## Contributing

Contributions are welcome! If you have any suggestions or improvements, feel free to create an issue or submit a pull request.

## License

This project is licensed under the MIT License.

## Acknowledgements

- Thanks to the developers of Visual Studio and SQL Server for their powerful tools.
- Inspiration from various online coding communities and forums.

## Contact

For any questions or feedback, please reach out to me at mohashafici@gmail.com.


