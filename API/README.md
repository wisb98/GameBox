# GameBox

## Database Setup

### Initial Setup
1. Start SQL Server container (replace password with your secure choice):
```powershell
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=yourStrong(!)Password" \
          -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest
```

2. Verify container is running:
```powershell
docker ps -a
```

### User Secrets Setup

1. Initialize user secrets:
```powershell
dotnet user-secrets init
```

2. Add connection string to secrets:
```powershell
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=localhost,1433;Database=GameBoxDB;User Id=sa;Password=YourPassword;TrustServerCertificate=True;"
```

3. View all secrets:
```powershell
dotnet user-secrets list
```

### Database Migrations

Common commands for managing migrations:

| Command | Description |
|---------|-------------|
| `dotnet ef migrations add <MigrationName>` | Create new migration |
| `dotnet ef database update` | Apply migrations to database |
| `dotnet ef migrations remove` | Remove last migration |
| `dotnet ef database drop` | Drop entire database |
| `dotnet ef database update 0` | Revert all migrations |