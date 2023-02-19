# Filemanager
A file manager SPA using a dotnet MVC framework.
![image](https://user-images.githubusercontent.com/44981193/221663565-c8c6c555-9e54-4681-9c72-8e34befbfed9.png)

Filemanager can show files and directories for a server side base directory, and all its sub-dirrctories. The web app works as an SPA - all directory addresses are set as params within the url, so there is only one page with Javascript http requests fetching and posting data between the client browser and server.

## Versions
Dotnet: dotnet sdk 6.0.113 <br>
CSharp: Microsoft (R) Visual C# Compiler version 3.9.0-6.21124.20 (db94f4cc)

## Downloading and setting up a Development Environment

The project code can be downloaded from this repository with a direct download (click the download zip button from the green code button), or alternatively, using a git clone command: `git clone git@github.com:gperilli/filemanager.git`.

### Git
For more information on the version controll system Git, see this: https://git-scm.com/. (Git needs to be installed on your computer in order to use any commands mentioned here.)

### Dotnet / .NET
See this for more information on dotnet: https://dotnet.microsoft.com/en-us/. Installation guides are here: https://learn.microsoft.com/en-us/dotnet/core/install

### Running the app on a local server
Navigate through the command line to the root of the filemanager app and then use either of these commands to launch a local server:
```command
dotnet watch run
```

```command
dotnet run
```

Using the `dotnet watch run` command something like this should appear in the terminal:
```
filemanager -> /home/gareth/projects/filemanager/bin/Debug/net6.0/filemanager.dll
watch : Started
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: https://localhost:7039
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5272
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: /home/gareth/projects/filemanager/
Opening in existing browser session.

```
The app should be usable from a browser at `https://localhost:7039`.
Exit the app on the command line by pressing `ctrl` + `c` on your keyboard.

***

### Current Issues

ssl is not set up or dealt with on the local development server. Your browser wiil probably consider the development site as a potential security risk.

~~https~~://localhost:7039/

browser console log:
```
This site does not have a valid SSL certificate! Without SSL, your site's and visitors' data is vulnerable to theft and tampering. Get a valid SSL certificate before  releasing your website to the public.
```
