# Simple Todo App

A simple, clean Todo List application built with .NET MAUI.

## Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- Visual Studio Code or Visual Studio 2022 (recommended)  
- Windows 10/11 for running the Windows version

## Running the Application

### Option 1: Using Visual Studio (Recommended)

1. Open Visual Studio 2022
2. Open the solution by selecting `SimpleTodoApp.csproj`
3. Select "Windows Machine" as the target platform
4. Click the Run button (green play button) or press F5

### Option 2: Using Command Line

1. Open a terminal/command prompt
2. Navigate to the project directory
3. Run the following command:
   ```
   dotnet run --framework net9.0-windows10.0.19041.0
   ```

### Option 3: Using Visual Studio Code

1. Open Visual Studio Code
2. Install the C# Dev Kit extension
3. Open the project folder
4. Press F5 to run the application

## Features

- Add new tasks by typing in the text field and pressing Enter or clicking the Add button
- Mark tasks as completed by checking the checkbox
- Completed tasks are shown with a strikethrough effect
- Simple and clean user interface

## Project Structure

- `MainPage.xaml` - The main user interface
- `MainPage.xaml.cs` - The code-behind for the main page
- `TodoItem.cs` - The model class for todo items

## Troubleshooting

If you encounter any issues:

1. Make sure you have the .NET 9.0 SDK installed
2. Try cleaning and rebuilding the solution
3. Make sure you're targeting the Windows platform
4. Check that all required dependencies are installed
