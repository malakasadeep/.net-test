# SQL Server Connection Guide

## Current Configuration
The application is now configured to connect to SQL Server instead of LocalDB.

## Connection String Options

### 1. Windows Authentication (Current Setup)
```json
"Server=localhost;Database=EmployeeDirectoryDb;Integrated Security=true;TrustServerCertificate=true;MultipleActiveResultSets=true"
```

### 2. SQL Server Authentication
```json
"Server=localhost;Database=EmployeeDirectoryDb;User ID=your_username;Password=your_password;TrustServerCertificate=true;MultipleActiveResultSets=true"
```

### 3. Remote SQL Server
```json
"Server=your_server_ip_or_name;Database=EmployeeDirectoryDb;User ID=your_username;Password=your_password;TrustServerCertificate=true;MultipleActiveResultSets=true"
```

### 4. Azure SQL Database
```json
"Server=tcp:yourserver.database.windows.net,1433;Initial Catalog=EmployeeDirectoryDb;Persist Security Info=False;User ID=your_username;Password=your_password;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
```

### 5. SQL Server Express
```json
"Server=localhost\\SQLEXPRESS;Database=EmployeeDirectoryDb;Integrated Security=true;TrustServerCertificate=true;MultipleActiveResultSets=true"
```

## How to Update Connection String

1. **For Development**: Update `appsettings.Development.json`
2. **For Production**: Update `appsettings.json` or use environment variables

## Environment Variables (Recommended for Production)
Set the connection string as an environment variable:
```bash
setx ConnectionStrings__DefaultConnection "Server=your_server;Database=EmployeeDirectoryDb;User ID=username;Password=password;TrustServerCertificate=true"
```

## Database Status
- ✅ Database: `EmployeeDirectoryDb` created on SQL Server
- ✅ Tables: All Identity and Employee tables created
- ✅ Seed Data: Removed (clean database)
- ✅ Migrations: Applied successfully

## Next Steps
1. Update the connection string with your specific SQL Server details
2. Run `dotnet ef database update` if you change the connection string to a different server
3. Start the application with `dotnet run`

## Troubleshooting
- **Connection Issues**: Check if SQL Server is running and accessible
- **Authentication Issues**: Verify username/password or Windows Authentication setup
- **Network Issues**: Check firewall settings and SQL Server network configuration
