# Sana Commerce - Developer Test | Oscar Melgarejo

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
  4. Open [http://localhost:5173](http://localhost:5173) in your browser to view the application.

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

  6. For connect to database first run de script file in database folder after that please change connection string in `SanaCommerce.API/appsettings.json` SanaCommerceConnectionString.

  if you want work with Database First please go to a `SanaCommerce.Infrastructure` and change the connection string in `Data/ApplicationDbContextFactory` and in a terminal run the following command:
   ```bash
   dotnet ef migrations add InitialMigrations
   dotnet ef database update
   ```

### 3. Database

- **Description**: The `database` folder contains the SQL script needed to create and populate the database, as well as the database diagram.
- **Files**:
  - `sanacommerce-script.sql`: SQL script to create the database schema and populate initial data.
  - `diagram.jpeg`: Visual diagram of the database.
- **Usage**:
  1. Connect to your MSSQL server.
  2. Execute the `sanacommerce-script.sql` script to create tables and seed initial data.
  3. Use the diagram to understand the database structure and relationships.
### Some screenshots
![Screenshot 2024-08-05 at 2 02 41 PM](https://github.com/user-attachments/assets/2d4763ed-391f-4fc3-b4da-0177129e8016)

![Screenshot 2024-08-05 at 2 04 22 PM](https://github.com/user-attachments/assets/becb1445-d0d4-41da-98c5-5a505f4c19ad)

![Screenshot 2024-08-05 at 2 05 10 PM](https://github.com/user-attachments/assets/309efa3f-c418-40c3-a645-d395b102658c)

