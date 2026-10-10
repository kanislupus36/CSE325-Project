# Expense Tracker

## Overview

Expense Tracker is a web application that helps users record, organize, and review their personal expenses. Users can manage their spending in one place, review monthly totals, and identify how their money is being spent across different categories.

The application focuses on providing a straightforward and secure way to keep track of everyday expenses.

## Features

- **User Accounts:** Register, log in, and access your personal expense records.
- **Expense Management:** Add, view, edit, and delete expenses.
- **Expense Categories:** Organize spending into categories such as food, transportation, bills, entertainment, shopping, school, and other.
- **Search and Filtering:** Find expenses by description, category, and date range.
- **Monthly Summary:** View the current month's total spending and number of expenses.
- **Category Breakdown:** Review spending totals for individual categories.
- **Input Validation:** Prevent invalid expense information from being submitted.
- **Responsive Interface:** Use the application on desktop and smaller screens.

## Technologies Used

- C#
- .NET and ASP.NET Core
- Blazor
- Entity Framework Core
- ASP.NET Core Identity
- SQLite 
- HTML and CSS
- Bootstrap

## Getting Started

### Prerequisites

Install the .NET SDK required by the project. You can find installation instructions at:

https://dotnet.microsoft.com/download

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/kanislupus36/CSE325-Project
   ```

2. Open the project directory:

   ```bash
   cd ExpenseTracker
   ```

3. Restore the project dependencies:

   ```bash
   dotnet restore
   ```

4. Apply the database migrations:

   ```bash
   dotnet ef database update
   ```

5. Start the application:

   ```bash
   dotnet run
   ```

6. Open the local URL displayed in the terminal.

> Note: Database setup may vary depending on the configured database provider and environment. If the Entity Framework command is unavailable, install the .NET Entity Framework CLI tool or use the database setup instructions for your project.

## How to Use

1. Create an account or log in.
2. Open the Expenses page.
3. Enter a description, amount, category, and date. Add notes if needed.
4. Save the expense to add it to your history.
5. Use the edit and delete actions to manage existing records.
6. Search or filter expenses to find specific transactions.
7. Review monthly totals and category breakdowns to understand your spending.

Each account's expense records are associated with its signed-in user.

## Project Structure

- `Components/` — Blazor pages, layouts, and reusable interface components.
- `Data/` — Database context and application data configuration.
- `Models/` — Data models and validation rules.
- `wwwroot/` — Static assets and application styles.
- `Program.cs` — Application configuration and service registration.
- `appsettings.json` — Application configuration settings.

## Security and Validation

The application uses ASP.NET Core Identity for user authentication and associates expense records with individual user accounts. Expense operations are restricted to the signed-in user's records. Input validation helps prevent incomplete or invalid expense data.

## Future Improvements

Potential improvements include exporting expense reports, displaying spending trends over time, and adding additional reporting options.

## License

No license has been specified for this project.
