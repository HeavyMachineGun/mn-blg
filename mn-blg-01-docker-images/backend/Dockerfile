FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App

# Copy everything
COPY ./UsersService ./
# Restore as distinct layers
RUN dotnet restore UsersService.csproj
# Build and publish a release
RUN dotnet publish -c Release -o release



#ARG ConnectionStrings__DefaultConnection
#RUN echo $docker_ConnectionStrings__DefaultConnection
#ENV ConnectionStrings__DefaultConnection $ConnectionStrings__DefaultConnection


# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY --from=build-env /App/release .
COPY --from=build-env /App/scripts .
#ENTRYPOINT ["dotnet", "UsersService.dll"]
RUN chmod +x start.sh
ENTRYPOINT ["/App/start.sh"]
