FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["conver mph to km/conver mph to km.csproj", "conver mph to km/"]
RUN dotnet restore "conver mph to km/conver mph to km.csproj"
COPY . .
WORKDIR "/src/conver mph to km"
RUN dotnet build "conver mph to km.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "conver mph to km.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "conver mph to km.dll"]
