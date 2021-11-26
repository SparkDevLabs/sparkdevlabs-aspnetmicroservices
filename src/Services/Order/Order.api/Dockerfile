#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Services/Order/Order.api/Order.api.csproj", "Services/Order/Order.api/"]
COPY ["Services/Order/Order.Infrastructure/Order.Infrastructure.csproj", "services/Order/Order.Infrastructure/"]
COPY ["Services/Order/Order.Application/Order.Application.csproj", "services/Order/Order.Application/"]
COPY ["Services/Order/Order.Domain/Order.Domain.csproj", "services/Order/Order.Domain/"]
RUN dotnet restore "Services/Order/Order.api/Order.api.csproj"
COPY . .
WORKDIR "/src/Services/Order/Order.api"
RUN dotnet build "Order.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Order.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Order.api.dll"]
