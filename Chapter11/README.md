# Chapter 11 - Entity Framework Core

- SQLite Tools
- SQLiteStudio
- EF Core

## Setup

### Setup SQLite
- Install `sqlite-tools-win32-x86` from `https://www.sqlite.org`
- Move sqlite3 executables to `c:\sqlite`
- Set environment variables, select `Path` and edit/add c:\sqlite
- Copy `Northwind.sql` from book-repository to project
- Execute sql script: `sqlite3 Northwind.db -init Northwind.sql`
- Install **SQLiteStudio** and connect to the `Northwind.db` database in the project.

### Setup EF Core
- Install EF Core
  - `dotnet tool list --global`
  - Uninstall old ef version: `dotnet tool uninstall --global dotnet-ef`
  - Install new version: `dotnet tool install --global dotnet-ef`

### Connect to database