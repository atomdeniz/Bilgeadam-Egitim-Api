#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["BilgeadamEgitim.WebAPI/BilgeadamEgitim.WebAPI.csproj", "BilgeadamEgitim.WebAPI/"]
COPY ["BilgeadamEgitim.DataAccess/BilgeadamEgitim.DataAccess.csproj", "BilgeadamEgitim.DataAccess/"]
COPY ["BilgeadamEgitim.Core/BilgeadamEgitim.Core.csproj", "BilgeadamEgitim.Core/"]
COPY ["BilgeadamEgitim.Services/BilgeadamEgitim.Services.csproj", "BilgeadamEgitim.Services/"]
RUN dotnet restore "BilgeadamEgitim.WebAPI/BilgeadamEgitim.WebAPI.csproj"
COPY . .
WORKDIR "/src/BilgeadamEgitim.WebAPI"
RUN dotnet build "BilgeadamEgitim.WebAPI.csproj" -c Release -o /app/build
RUN dotnet ef database update

FROM build AS publish
RUN dotnet publish "BilgeadamEgitim.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BilgeadamEgitim.WebAPI.dll"]