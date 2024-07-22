# Use .NET 6.0 SDK base image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /app

# Copy project file and restore dependencies
COPY HotelManagementFrontend.csproj ./
RUN dotnet restore "./HotelManagementFrontend.csproj"

# Copy the rest of the application code
COPY . ./
RUN dotnet publish "./HotelManagementFrontend.csproj" -c Release -o /app/publish

# Use .NET 6.0 runtime base image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Specify the entry point of the application
ENTRYPOINT ["dotnet", "HotelManagementFrontend.dll"]
