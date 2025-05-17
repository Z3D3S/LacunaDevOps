FROM mcr.microsoft.com/dotnet/sdk:8.0@sha256:35792ea4ad1db051981f62b313f1be3b46b1f45cadbaa3c288cd0d3056eefb83 AS build-env

# Copy everything
COPY . ./

# Restore as distinct layers
RUN dotnet restore ./*/LacunaDevOps.Site.csproj

# Build and publish a release
RUN dotnet publish -c Release -o /Site/out ./*/LacunaDevOps.Site.csproj

# Build runtime image -- multi stage --
FROM mcr.microsoft.com/dotnet/aspnet:8.0@sha256:6c4df091e4e531bb93bdbfe7e7f0998e7ced344f54426b7e874116a3dc3233ff

COPY --from=build-env ./Site/out .

ENTRYPOINT ["dotnet","./LacunaDevOps.Site.dll"]
