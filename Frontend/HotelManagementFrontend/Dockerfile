# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copy the csproj and restore any dependencies (via NuGet)
COPY HotelManagementFrontend.csproj ./
RUN dotnet restore

# Copy the rest of the code and build the app
COPY . ./
RUN dotnet publish -c Release -o /app/publish

# Use an Nginx image to serve the static files
FROM nginx:alpine
COPY --from=build /app/publish/wwwroot /usr/share/nginx/html
