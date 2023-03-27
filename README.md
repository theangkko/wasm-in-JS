# wasm-in-JS

https://khalidabuhakmeh.com/consuming-dotnet-webassembly-from-javascript-in-the-browser


wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb

sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-7.0

sudo dotnet workload install wasm-tools
sudo dotnet workload install wasm-experimental



## .NET WebAssembly Browser app

## Build

You can build the app from Visual Studio or from the command-line:

```
dotnet build -c Debug/Release
```

After building the app, the result is in the `bin/$(Configuration)/net7.0/browser-wasm/AppBundle` directory.

## Run

You can build the app from Visual Studio or the command-line:

```
dotnet run -c Debug/Release
```

Or you can start any static file server from the AppBundle directory:

```
dotnet tool install dotnet-serve
dotnet serve -d:bin/$(Configuration)/net7.0/browser-wasm/AppBundle
```