FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["StrategyPattern/StrategyPattern.csproj", "StrategyPattern/"]
RUN dotnet restore "StrategyPattern/StrategyPattern.csproj"
COPY . .
WORKDIR "/src/StrategyPattern"
RUN dotnet build "StrategyPattern.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "StrategyPattern.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StrategyPattern.dll"]
