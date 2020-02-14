FROM gitpod/workspace-dotnet

USER root

RUN apt-get update && apt-get -y -o APT::Install-Suggests="true" install dotnet-sdk-2.2 && \
    rm -rf /var/lib/apt/lists/*;
