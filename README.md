# .NET 5.0
* _.NET 5_ is the next release after _.NET core_ 3.1. _.NET Framework_ will not receive any further release.
* .NET is a fusion of core and framework, or just the next release of core

## install .NET 5 under linux
* go to https://dotnet.microsoft.com/download/dotnet/5.0
* download `x64` binary
* decompress and add dotnet folder to your path
```
mkdir dotnet
tar zxf dotnet-sdk-5.0.100-rc.1.20452.10-linux-x64.tar.gz -C dotnet/

PATH="$HOME/development/dotnet:$PATH"
export DOTNET_ROOT=$HOME/development/dotnet
```
* check installation
```
dotnet --list-sdks
5.0.100-rc.1.20452.10 [/home/code/development/dotnet/sdk]
```

## create console app
```
dotnet new console --output cli
```

## run app 
```
dotnet run --project cli
dotnet run
```


## links
* target frameworks: https://docs.microsoft.com/en-us/dotnet/standard/frameworks#supported-target-frameworks
* evolution of .NET Core to .NET 5: https://docs.microsoft.com/en-us/dotnet/core/dotnet-five
> .NET 5, which is the next release of .NET Core following 3.1

# .NET core 3.1
* create project: `dotnet new web -n microservice`
    * folder `microservice` will be created

__container, cloud, ...__
* you can put your microservice in a container
* create a Dockerfile with the following base images:
    * build image: `mcr.microsoft.com/dotnet/core/sdk:3.1`
    * final image: `mcr.microsoft.com/dotnet/core/aspnet:3.1`
* we can put .NET Core apps to PaaS cloud: _Azure Web Apps_, _Azure Service Fabric_. In this case we dont need any infrastructure.
* deploy to cloud container services: _Azure ACS_, _Amazon ECS_. In this case we also dont need to care about infrastructure.
* or let it orchestrate on _kubernetes_, _openshift_, ...
