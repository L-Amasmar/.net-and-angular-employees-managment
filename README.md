# Employee Management System  

## Objective  
This project aims to develop a robust Employee Management System using a .NET 8 API and Angular 16 for efficient data handling with CRUD operations.  

## Project Details  

### Backend (.NET 8 API)  
- **Project Setup**: Created a .NET 8 Web API project.  
- **Database**: Utilized Entity Framework Core with a SQLite database.  
- **Employee Object**:  
  - **Properties**: Id (GUID), FirstName, LastName, Email, PhoneNumber, Position, Department.  
- **API Endpoints**:  
  - Implemented Restful endpoints to manage employees.  

### Frontend (Angular 16 Application)  
- **Project Setup**: Developed the frontend using Angular 16 and Angular CLI.  
- **User Interface**: Utilized Tailwind CSS for enhanced styling and responsiveness.  
- **Employee Management**:  
  - Implemented service communication with the API.  
  - Created components for listing, viewing, adding, and editing employees.  
- **CRUD Operations**:  
  - Implemented forms and views for Create, Read, Update, and Delete operations.  
- **Routing**:  
  - Set up Angular routing for seamless navigation.  

## Getting Started  
To run the project locally, follow these steps:  
1. Clone this repository.  
2. Navigate to the backend and frontend directories and run `npm install` to install dependencies.  
3. Start the backend server by running `dotnet run` in the backend directory.  
4. Start the Angular application by running `ng serve` in the frontend directory.  
5. Access the application in your browser at `http://localhost:4200`.  
