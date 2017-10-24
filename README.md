# dockerdotnet2.0

Code samples for an updated Docker Talk

## MyConsole

This project requires *apt-get* to install *youtube-dl* and therefore cannot run on Windows Server 2016.

* git clone project locally
* Ensure you have the correct version of .NET SDK installed (.NET Core 2.0) and Docker.
* Ensure you are in the "MyConsole" directory
* Run: "dotnet restore" to restore NuGet packages
* Run: "dotnet publish -o $(pwd)/app" to publish a Framework-Dependent version to the "/app" directory
* Run: "docker build -t myconsole:dev ." to build the image. The first build will take some time as apt-get and youtube-dl have a number of dependencies/packages. Future builds will be fast.
* Run: "docker run myconsole:dev"
* Run with environment variable & shared drive to read files out: "docker run -v $(pwd)/app:/app -e url=https://www.youtube.com/watch?v=Y7SWYEW_K_I myconsole:dev"
* View Logs: Use "docker ps -a" to get the container id for myconsole:dev (ex: 1a7867a6615f), then "docker logs 1a7867a6615f"
