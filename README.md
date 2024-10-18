# Music Database GUI Application (CRUD Operations)

## Overview
This project involves developing a Windows Forms App (WinForms) using Visual Studio, C#, and a MySQL database to manage a music collection. The application allows users to view, add, update, and delete albums in the music database. The project is divided into three main phases: setting up the database, creating a user interface with basic CRUD functionalities, and completing all CRUD elements.

### Part 1: Setting Up the Database
In the first phase, I focused on defining the structure of the music database in MySQL. This involved:
- **Creating tables** to store album details such as title, artist, year, image URL, and description.
- **Populating the database** with initial album data.
- **Writing SQL queries** to manage data retrieval and modifications, setting the foundation for the GUI application.


### Part 2: Creating the User Interface and Initial CRUD Elements
In the second phase, I built the graphical user interface (GUI) using WinForms in Visual Studio. Key tasks included:
- **Designing the UI** with buttons, text fields, and a data grid to display albums.
- **Creating classes** to represent the albums and manage data operations.
- **Implementing basic CRUD functionalities** so users can view and add albums via the interface.
- **Establishing the connection** between the GUI and the MySQL database using SQL queries to load and display album data.

### Part 3: Completing CRUD Functionality and GUI Enhancements
In the final phase, I extended the functionality of the music database GUI application. Key tasks included:
- **Implementing full CRUD functionality** so the UI will allow users to update and delete album details directly from the data grid.
- **Track Management** to manage individual tracks, including adding, updating, and removing tracks associated with each album.
- **YouTube Video Playback** adding the ability to embed and play YouTube videos within the app for specific albums by using a WebView.

### What I Learned:
1. **String Manipulation in SQL**: Using functions like `CONCAT()`, `SUBSTRING()`, and `UPPER()` to manage and format text data.
2. **Math & Aggregate Functions in SQL**: Performing calculations using functions such as `SUM()`, `AVG()`, and `COUNT()` to generate business insights.
3. **Database Normalization**: Applying First, Second, and Third Normal Forms to optimize table structures.
4. **Building a Music App**: Connecting a MySQL database to a C# WinForms app, creating database tables, and establishing relationships with foreign keys.
5. **Foreign Keys and Joins**: Using `JOIN` statements to link data between tables, such as albums and tracks, for complex queries.
6. **CRUD in a GUI Application**: Implementing Create, Read, Update, and Delete operations in the app, allowing users to manage music albums and tracks.
7. **MySQL Workbench**: Designing and managing the database using MySQL Workbench, including troubleshooting schema changes and SQL errors.

This project showcases my ability to integrate front-end and back-end technologies, create database-driven applications, and develop user-friendly interfaces that handle data effectively.
