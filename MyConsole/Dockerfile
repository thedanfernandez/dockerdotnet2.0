FROM microsoft/dotnet:2.0-runtime

RUN apt-get update
RUN apt-get install -y youtube-dl

COPY app /app

WORKDIR /app

ENTRYPOINT ["dotnet", "MyConsole.dll"]
