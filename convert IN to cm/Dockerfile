FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["convert IN to cm/convert IN to cm.csproj", "convert IN to cm/"]
RUN dotnet restore "convert IN to cm/convert IN to cm.csproj"
COPY . .
WORKDIR "/src/convert IN to cm"
RUN dotnet build "convert IN to cm.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "convert IN to cm.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "convert IN to cm.dll"]
