# wasm-in-JS

https://khalidabuhakmeh.com/consuming-dotnet-webassembly-from-javascript-in-the-browser


wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb

sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-7.0

sudo dotnet workload install wasm-tools
sudo dotnet workload install wasm-experimental


image.png




gitpod /workspace/wasm-in-JS01 (main) $ sudo chmod +x ./dotnet-install.sh
gitpod /workspace/wasm-in-JS01 (main) $ ./dotnet-install.sh --channel 7.0.2xx
dotnet-install: Note that the intended use of this script is for Continuous Integration (CI) scenarios, where:
dotnet-install: - The SDK needs to be installed without user interaction and without admin rights.
dotnet-install: - The SDK installation doesn't need to persist across multiple CI runs.
dotnet-install: To set up a development environment or to run apps, use installers rather than this script. Visit https://dotnet.microsoft.com/download to get the installer.

dotnet-install: .NET Core SDK with version '7.0.202' is already installed.
gitpod /workspace/wasm-in-JS01 (main) $ export DOTNET_ROOT=$HOME/.dotnet
gitpod /workspace/wasm-in-JS01 (main) $ export PATH=$PATH:$HOME/.dotnet:$HOME/.dotnet/tools
gitpod /workspace/wasm-in-JS01 (main) $ dotnet run
/home/gitpod/dotnet/sdk/7.0.100/Sdks/Microsoft.NET.Sdk/targets/Microsoft.NET.Sdk.ImportWorkloads.targets(38,5): error NETSDK1147: To build this project, the following workloads must be installed: wasm-tools [/workspace/wasm-in-JS01/wasm-in-JS.csproj]
/home/gitpod/dotnet/sdk/7.0.100/Sdks/Microsoft.NET.Sdk/targets/Microsoft.NET.Sdk.ImportWorkloads.targets(38,5): error NETSDK1147: To install these workloads, run the following command: dotnet workload restore [/workspace/wasm-in-JS01/wasm-in-JS.csproj]

The build failed. Fix the build errors and run again.
gitpod /workspace/wasm-in-JS01 (main) $ dotnet serve
Could not execute because the specified command or file was not found.
Possible reasons for this include:
  * You misspelled a built-in dotnet command.
  * You intended to execute a .NET program, but dotnet-serve does not exist.
  * You intended to run a global tool, but a dotnet-prefixed executable with this name could not be found on the PATH.
gitpod /workspace/wasm-in-JS01 (main) $ 