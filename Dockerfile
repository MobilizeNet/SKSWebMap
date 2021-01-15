FROM gitpod/workspace-full-vnc:latest


USER root	USER gitpod
RUN wget -q https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb && \	
    dpkg -i packages-microsoft-prod.deb && \	# Install .NET Core 3.1 SDK binaries on Ubuntu 20.04
    rm -rf packages-microsoft-prod.deb && \	# Source: https://dev.to/carlos487/installing-dotnet-core-in-ubuntu-20-04-6jh
    add-apt-repository universe && \	RUN mkdir -p /home/gitpod/dotnet && curl -fsSL https://download.visualstudio.microsoft.com/download/pr/f65a8eb0-4537-4e69-8ff3-1a80a80d9341/cc0ca9ff8b9634f3d9780ec5915c1c66/dotnet-sdk-3.1.201-linux-x64.tar.gz | tar xz -C /home/gitpod/dotnet
    apt-get update && \	ENV DOTNET_ROOT=/home/gitpod/dotnet
    echo resolvconf resolvconf/linkify-resolvconf boolean false | debconf-set-selections && \	ENV PATH=$PATH:/home/gitpod/dotnet
