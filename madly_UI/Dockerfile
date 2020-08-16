FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 5000


FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["madly_UI/madly_UI.csproj", "madly_UI/"]
RUN dotnet restore "madly_UI/madly_UI.csproj"
COPY . .
WORKDIR "/src/madly_UI"
RUN dotnet build "madly_UI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "madly_UI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "madly_UI.dll"]
