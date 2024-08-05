# Project

This repository is organized into three main folders: `frontend`, `backend`, and `database`. Below is a description of the technologies used and how to run each part of the project.

## Project Structure

### 1. Frontend

- **Technologies Used**: React 18, Redux, Redux Toolkit, Axios
- **Description**: The `frontend` folder contains the code for the project's user interface.
- **Running the Project**:
  1. Navigate to the `frontend` folder.
  2. Install dependencies:
     ```bash
     npm install
     ```
  3. Start the development server:
     ```bash
     npm start
     ```
  4. Open [http://localhost:3000](http://localhost:3000) in your browser to view the application.

### 2. Backend

- **Technologies Used**: .NET 7, Clean Architecture, Entity Framework, MediatR, CQRS, AutoMapper
- **Description**: The `backend` folder contains the server-side logic, including database access and business rules implementation.
- **Running the Project**:
  1. Navigate to the `backend` folder.
  2. Restore dependencies:
     ```bash
     dotnet restore
     ```
  3. Build the project:
     ```bash
     dotnet build
     ```
  4. Run the application:
     ```bash
     dotnet run
     ```
  5. The API will be available at [http://localhost:5000](http://localhost:5000) (may vary based on configuration).

### 3. Database

- **Description**: The `database` folder contains the SQL script needed to create and populate the database, as well as the database diagram.
- **Files**:
  - `schema.sql`: SQL script to create the database schema and populate initial data.
  - `diagram.png`: Visual diagram of the database.
- **Usage**:
  1. Connect to your PostgreSQL server (or the SQL server you are using).
  2. Execute the `schema.sql` script to create tables and seed initial data.
  3. Use the diagram to understand the database structure and relationships.

## Contributing

If you wish to contribute to this project, please follow these steps:
1. Fork the repository.
2. Create a branch for your change:
   ```bash
   git checkout -b feature/new-feature
