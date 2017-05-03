### .NET Core client
```
dotnet new sln
dotnet new classlib
dotnet new console
dotnet mstest -n UnitTestProject1
dotnet --help

dotnet new templates install github

Zit nu in MSBuild
Geen package folder meer :)
```

# App

```
.vscode folder
    launch.json
    tasks.json

handige 
ctrl shift + p
visual studio icons :D
```

### .csproj 
```
<ItemGroup>
    <PackageReference Include="Microsoft.AspNetCore.Server.Kestrel" Version="1.1.1"/>
</ItemGroup>
```

```
using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Server;

namespace MyCoolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();

                host.Run();
        }
    }
}
```

```
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace MyCoolApp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app){
            app.Run(context => {
                return context.Response.WriteAsync("Hello world");
            });
        }
    }
}
```

# Docker

### Example dockerfile
```
FROM microsoft/aspnetcore

ADD ./output /app

WORKDIR /app

ENTRYPOINT ["dotnet", "MyCoolApp.dll"]
```

### Commands
```
docker build -t fancypants
```

```
docker run --it --rm -p 5000:80 fancypants
```