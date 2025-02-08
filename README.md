# Clean Architecture Template

This template provides a starting point for creating .NET applications following Clean Architecture principles. It includes a pre-configured solution structure with separate projects for Domain, Application, Infrastructure, and Web API layers.

## Prerequisites

- .NET SDK (latest version recommended)
- A code editor (Visual Studio, VS Code, etc.)

## Getting Started

### 1. Install the Template

Install the template locally on your system:

```sh
dotnet new --install ./
```

### 2. Create a New Project

Generate a new solution using the template:

```sh
dotnet new clean-architecture -n MyNewProject
```

This command creates a new solution with the following structure:

```
MyNewProject
├── MyNewProject.sln
├── MyNewProject.Domain
├── MyNewProject.Application
├── MyNewProject.Infrastructure
├── MyNewProject.WebAPI
└── MyNewProject.Tests
```

### 3. Setup and Run

Follow these steps to get your project up and running:

1. Navigate to the project directory:
   ```sh
   cd MyNewProject
   ```

2. Restore dependencies:
   ```sh
   dotnet restore
   ```

3. Build the solution:
   ```sh
   dotnet build
   ```

4. Run the Web API:
   ```sh
   cd MyNewProject.WebAPI
   dotnet run
   ```

The API will start running on a specified port (typically http://localhost:5000).

## Project Structure

- **Domain**: Contains enterprise logic and entities
- **Application**: Contains business logic and interfaces
- **Infrastructure**: Implements interfaces defined in the application layer
- **WebAPI**: Handles HTTP requests and responses
- **Tests**: Contains unit tests for the solution

## Uninstalling the Template

If you need to remove the template from your system:

```sh
dotnet new --uninstall CleanArchitecture.Template
```

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

[MIT License](LICENSE)

## Support

If you encounter any issues or have questions, please file an issue in the GitHub repository.
