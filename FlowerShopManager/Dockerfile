# 1: Build app
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Set work directory
WORKDIR /app

# Copy project file and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy files and build app
COPY . ./
RUN dotnet publish -c Release -o out

# 2: Run app
FROM mcr.microsoft.com/dotnet/runtime:6.0

# Set work directory
WORKDIR /app

# Copy app built in build stage
COPY --from=build /app/out .

# Mention run command
ENTRYPOINT ["dotnet", "Task2.dll"]
