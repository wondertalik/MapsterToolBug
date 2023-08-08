FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/HttpApi/HttpApi.csproj", "src/HttpApi/"]
RUN dotnet restore "src/HttpApi/HttpApi.csproj"
COPY . .
WORKDIR "/src/src/HttpApi"
RUN dotnet build "HttpApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HttpApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HttpApi.dll"]
