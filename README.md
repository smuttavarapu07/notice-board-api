# Notice Board API

A RESTful Web API built using ASP.NET Core to manage notices and announcements. This project demonstrates backend development, API design, database connectivity, and real-time communication concepts.

## Features

- Create and manage notices through API endpoints.
- Organize the application using controllers, models, and a database context.
- Configure database connectivity using a connection string.
- Support real-time communication using SignalR, if configured.
- Configure application logging and Cross-Origin Resource Sharing (CORS), if enabled.

## Technologies Used

- **Language:** C#
- **Framework:** ASP.NET Core Web API
- **Database:** MySQL (if configured)
- **ORM:** Entity Framework Core (if used)
- **Real-time communication:** SignalR (if enabled)
- **Tools:** Visual Studio Code, Git, GitHub

## Project Structure

```text
NoticeBoardAPI/
├── Hubs/
│   └── Noticehub.cs
├── controllers/
│   └── noticescontroller.cs
├── data/
│   └── appdbcontext.cs
├── models/
│   └── notice.cs
├── Properties/
├── Program.cs
├── NoticeBoardAPI.csproj
├── NoticeBoardAPI.http
├── .gitignore
└── README.md
```

## Getting Started

### Prerequisites

- .NET SDK compatible with the project
- MySQL, if required by the application
- Visual Studio Code or another compatible IDE

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/smuttavarapu07/notice-board-api.git
   ```

2. Navigate to the project directory:

   ```bash
   cd notice-board-api
   ```

3. Configure your local database connection and other required settings. Do not commit passwords, API keys, or other secrets.

4. Restore project dependencies:

   ```bash
   dotnet restore
   ```

5. Run the application:

   ```bash
   dotnet run
   ```

6. Use the configured API URL and endpoint routes to test the application.

## API Endpoints

The available endpoints depend on the controller implementation. Refer to the `controllers/noticescontroller.cs` file for the supported HTTP methods and routes.

## Configuration and Security

- Keep database credentials in local configuration or environment variables.
- Do not upload `appsettings.json` or other files containing secrets.
- Use `.gitignore` to exclude sensitive configuration and generated files.

## Learning Outcomes

This project provides practical experience with REST API development, backend application structure, database integration, and version control using Git and GitHub.

## Author

**Sravika Muttavarapu**

GitHub: [@smuttavarapu07](https://github.com/smuttavarapu07)
