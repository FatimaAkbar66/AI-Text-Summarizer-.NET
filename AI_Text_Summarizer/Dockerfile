# 1. Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# 2. Copy the project files and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# 3. Copy the rest of the files and build the project
COPY . ./
RUN dotnet build -c Release -o out

# 4. Command to run the application
CMD ["dotnet", "run"]