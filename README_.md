# wasm-in-JS

https://khalidabuhakmeh.com/consuming-dotnet-webassembly-from-javascript-in-the-browser


wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb

sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-7.0

sudo dotnet workload install wasm-tools
sudo dotnet workload install wasm-experimental