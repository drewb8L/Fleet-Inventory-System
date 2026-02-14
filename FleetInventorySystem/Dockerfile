FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Fleet Inventory System/FleetInventorySystem.csproj", "FleetInventorySystem/"]
RUN dotnet restore "FleetInventorySystem/FleetInventorySystem.csproj"
COPY . .
WORKDIR "/src/Fleet Inventory System"
RUN dotnet build "FleetInventorySystem.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release

RUN dotnet publish "FleetInventorySystem.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "FleetInventorySystem.dll"]
