FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY TibberSmartPlug/TibberSmartPlug.csproj TibberSmartPlug/
RUN dotnet restore TibberSmartPlug/TibberSmartPlug.csproj

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out ./TibberSmartPlug/TibberSmartPlug.csproj

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "TibberSmartPlug.dll"]
