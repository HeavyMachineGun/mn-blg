FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App

# Copy everything
COPY ./UsersService ./
# Restore as distinct layers
RUN dotnet restore UsersService.csproj
# Build and publish a release
RUN dotnet publish -c Release -o release

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY --from=build-env /App/release .
ENTRYPOINT ["dotnet", "UsersService.dll"]