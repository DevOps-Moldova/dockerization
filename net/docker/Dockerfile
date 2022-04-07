FROM mcr.microsoft.com/dotnet/aspnet:6.0

WORKDIR /srv

COPY out/ /srv/
ENV DOTNET_EnableDiagnostics=0


ENTRYPOINT ["dotnet", "DotNet.Docker.dll"]
