# Clean Architecture Boilerplate - ASP.NET Core 5.0 (WebApi & MVC)
Clean Architecture Solution Template for ASP.NET Core 5.0. Built with Onion/Hexagonal Architecture and incorporates the most essential Packages your projects will ever need. Includes both WebApi and Web(MVC) Projects.

## Technologies Used

- ASP.NET Core 5.0 WebAPI
- ASP.NET Core 5.0 MVC
- Entity Framework Core 5.0

## Prerequisites

-   Make sure you are running on the latest .NET 5 SDK (SDK 5.0 and above only). [Get the latest one here.](https://dotnet.microsoft.com/download/dotnet/5.0)

-   Visual Studio 2019 (v16.8+) (You can check out my Installation Guide of [Visual Studio 2019 Community](https://codewithmukesh.com/blog/install-visual-studio-2019-community/) which is completely Free to use.) Make sure that ASP.NET and web development workload is installed.

-   Install the latest [.NET & EF CLI Tools](https://docs.microsoft.com/en-us/ef/core/cli/dotnet) by using this command :

    ```.NET Core CLI
    dotnet tool install --global dotnet-ef
    ```

## How To Run
- Once the Packages are done restoring, open up the appsettings.json of both the API and MVC Projects. Make sure that you add in valid Connection strings here. Currently it looks like following-
  ```.NET Core CLI
    "ConnectionStrings": {
    "ApplicationConnection": "Data Source=localhost;Initial Catalog=CQRSandMediatRinOnionArchitecture;Integrated Security=True;MultipleActiveResultSets=True",
    "IdentityConnection": "Data Source=localhost;Initial Catalog=CQRSandMediatRinOnionArchitecture;Integrated Security=True;MultipleActiveResultSets=True"
  }
  ```
- Go to menu ```Tools > NuGet Package Manager > Package Manager Console```. From the Package Manager Console window set the Startup project as the API or Web Project (which you want to run). Set the Default Project as the Infrastructure project. Run the following commands.
  ```.NET Core CLI
  update-database -context IdentityContext
  update-database -context ApplicationDbContext
  ```
- If you still face issues, please visit the link- [Getting Started - Quick Start Guide](https://codewithmukesh.com/blog/aspnet-core-hero-boilerplate-quick-start-guide/)

## Capabilities Included

### ASP.NET Core 5.0 MVC Project
- Slim Controllers using MediatR Library
- Permissions Management based on Role Claims
- Toast Notification (includes support for AJAX Calls too)
- Serilog
- ASP.NET Core Identity
- AdminLTE Bootstrap Template (Clean & SuperFast UI/UX)
- AJAX for CRUD (Blazing Fast load times)
- jQuery Datatables
- Select2
- Image Optimization
- Includes Sample CRUD Controllers / Views
- Active Route Tag Helper for UI
- RTL Support
- Complete Localization Support / Multilingual
- Clean Areas Implementation
- Dark Mode!
- Default Users / Roles Seeding at Startup
- Supports Audit Logging / Activity Logging for Entity Framework Core
- Automapper

### ASP.NET Core 5.0 WebAPI
- JWT & Refresh Tokens
- Swagger

# Reference and Reading

[Project Github Page](https://github.com/aspnetcorehero/Boilerplate)

[Get to know CQRS pattern better from here](https://codewithmukesh.com/blog/onion-architecture-in-aspnet-core/)

[Getting Started - Quick Start Guide](https://codewithmukesh.com/blog/aspnet-core-hero-boilerplate-quick-start-guide/)
