FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-bionic
WORKDIR /app
COPY StudentApi/dist /app
EXPOSE 80/tcp
EXPOSE 443/tcp
ENTRYPOINT ["dotnet", "StudentApi.dll"]