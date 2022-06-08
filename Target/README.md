### WebMap - SKS  
This repository contains a Winforms demo for sales purpose. 

If you want more technical documentation about our webmap product:

* [General Product Information](http://https://www.mobilize.net/products/app-migrations/webmap/ "General Product Information")
* [Documentation for WebMap](http://https://docs.mobilize.net/webmap/ "Documentation for WebMap")

## Repository Contents

This folder contains the back-end and front-end related to the Salmon King Seafood or SKS demo, a functional demo related to Winforms created by Mobilize.net

## How to build

### Building locally

If you want to build this project on your development machine, just check that you match this requirements:

* [Node.js LTS](https://nodejs.org/en/download/)
* [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/)
* [.NET Core](https://dotnet.microsoft.com/download)
* [SQLite3 ODBC Driver](http://www.ch-werner.de/sqliteodbc/) (download sqliteodbc.exe and sqliteodbc_w64.exe)

> NOTE: Your installation of Visual Studio, must include the *ASP.NET and Web Development Feature *
>
> To install this feature open your VS installer and Go to Workloads tab and then turn on ASP.Net and web development as in the following picture: 
![AspWebDevelopment](https://gblobscdn.gitbook.com/assets%2F-MEOm98BbzqckTUoLpXN%2F-MObjz9M3Gd4Q3oDTVfk%2F-MOfsymyfLvuUJarfQAA%2Fimage.png?alt=media&token=67fbfe2d-b5f9-4c78-b24b-51d5800053af)

To build your application just open the `SKS\SKS.sln` file with VS Studio and select **Rebuild**. This will install any missing dependencies and trigger the build process.

> NOTE: the angular frontend is already built. If you want to build it yourself see the step on Building the Frontend code.


## Building the FrontEnd code

To build the frontend code make sure you already have [Node.js LTS](https://nodejs.org/en/download/) installed.

Open a terminal at `SKS\sks-angular` and run:
```
npm config set "@mobilize:registry" "https://packages.mobilize.net/npm/mobilizenet-npm/"
npm install
npm run build
```