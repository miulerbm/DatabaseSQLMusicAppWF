# Windows Application Database Project

## Project Summary

### Project Description
This project involves building a Windows application connected to a SQL database. It is primarily focused on managing music albums and their tracks. The project utilizes a SQL database, C#, and various tools for development.

### Key Steps

1. **Build a SQL Database**: Create a SQL database for storing information about music albums and their tracks.
2. **Build a Music Player App**: Develop a Windows application for managing and displaying music albums and tracks.
3. **Connect Database to App**: Establish a connection between the SQL database and the Windows application to enable data retrieval and management.

## Database Setup

### MySQL Server
- MySQL is chosen as the database management system, with alternatives like PostgreSQL, Microsoft SQL, and Oracle considered.
- The project uses MySQL server tools and takes advantage of MySQL Workbench for more complex database operations.
- A local development environment is set up using MAMP (Macintosh Apache MySQL and PHP), with versions available for both Windows and Mac.
- The project uses MySQL Workbench for handling database schema design and management.

### Building the SQL Database
- The project's MySQL database includes tables for storing album information and tracks.
- Entity-Relationship (ER) diagrams are used to visualize the structure and relationships between entities in the database.
- The SQL database tables are designed to store album information, including title, artist, release year, image URL, and description.
- Compound queries are utilized to combine multiple SQL queries into one action for more efficient data retrieval.

## Application Development

### Visual Studio
- Visual Studio 2022 is chosen as the development environment for creating the Windows application.
- Classes are created for albums and tracks within the application.
- A Data Access Object (DAO) is established to facilitate communication between the frontend and backend of the application.
- The DataGridView control is used to display album information.
- Users can interact with the application by searching for albums and viewing track listings.

### Album and Track Management
- Albums are retrieved from the database and displayed in the application, allowing users to view album details and tracks.
- A search feature is implemented to filter and display specific albums based on user input.
- Users can click on album rows to view their associated tracks.
- Dynamic loading of album cover images is supported in the application.
- Users can add new album records to the database via input fields and an "Add" button.

### Tracks and Database Integration
- A Tracks table is created in the SQL database to store track details, such as title, video URL, and lyrics.
- Relationships between albums and tracks are established, enabling multiple tracks to be associated with a single album.
- Track data is retrieved and displayed when an album is selected.
- The application allows users to delete tracks from the database, with the associated delete functionality implemented.
- Future development includes integrating track players and adding update forms for albums and tracks.

# Media

![App Running](/images/project_image_001.jpg)
![Database and Schemas](/images/project_image_002.jpg)
![ER Diagram](/images/project_image_003.jpg)