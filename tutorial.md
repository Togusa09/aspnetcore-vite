# Tutorial

1. Create directories
    ```bash
    # Create directories
    mkdir AspDotNetCoreVite/src/clients
    mkdir AspDotNetCoreVite/src/WebApp
    ```
1. Create default dotnet project
    ```bash
    cd AspDotNetCoreVite/src/WebApp
    dotnet new mvc
    ```
1. Create Solution
    ```bash
    dotnet new sln
    dotnet sln add src/WebApp/WebApp.csproj
    ```
