# mn-blg
Using docker to build your app. 


# Setup your backend service.

start database service to seed the db.


docker-compose up --build -d pg-database   

install netcore ef tools and run migrations

dotnet tool install --global dotnet-ef

run first migration

dotnet ef migrations add InitMigration  

update appsettings.json connection string to

 "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=8001;Database=users;Username=databaseuser;Password=databasepassword"
  }

update database with migration

dotnet ef database update 

once migration has completed restore back connection string

"ConnectionStrings": {
    "DefaultConnection": "Host=pg-database;Port=5432;Database=users;Username=databaseuser;Password=databasepassword"
  }


docker-compose up --build -d backend



