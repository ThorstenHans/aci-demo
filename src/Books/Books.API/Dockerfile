FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY Books.API/Books.API.csproj Books.API/
RUN dotnet restore Books.API/Books.API.csproj
COPY . .
WORKDIR /src/Books.API
RUN dotnet build Books.API.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Books.API.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Books.API.dll"]
