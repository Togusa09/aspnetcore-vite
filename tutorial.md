# Tutorial

## Setup
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
1. Create SPA
    ```bash
    npm create vite@latest react-spa -- --template react-ts
    cd react-spa
    npm install
    npm run dev # Runs the dev server
    ```

## Features

1. Intro to vite - basic setup and config (mention paths and different config files)
1. Old proxying via webpack
1. Host vite react content on page
1. Debugging vite react app
1. Default to spa index.html