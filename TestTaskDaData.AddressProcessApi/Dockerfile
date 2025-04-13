FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["TestTaskDaData.AddressProcessApi/TestTaskDaData.AddressProcessApi.csproj", "TestTaskDaData.AddressProcessApi/"]
RUN dotnet restore "TestTaskDaData.AddressProcessApi/TestTaskDaData.AddressProcessApi.csproj"
COPY . .
WORKDIR "/src/TestTaskDaData.AddressProcessApi"
RUN dotnet build "TestTaskDaData.AddressProcessApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "TestTaskDaData.AddressProcessApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestTaskDaData.AddressProcessApi.dll"]
