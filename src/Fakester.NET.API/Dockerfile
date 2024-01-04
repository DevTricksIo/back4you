#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Fakester.NET.API/Fakester.NET.API.csproj", "src/Fakester.NET.API/"]
COPY ["src/Fakester.NET.Application/Fakester.NET.Application.csproj", "src/Fakester.NET.Application/"]
RUN dotnet restore "./src/Fakester.NET.API/Fakester.NET.API.csproj"
COPY . .
WORKDIR "/src/src/Fakester.NET.API"
RUN dotnet build "./Fakester.NET.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Fakester.NET.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Fakester.NET.API.dll"]