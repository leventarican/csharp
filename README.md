# C# .NET Core
* get donet from https://dotnet.microsoft.com/download
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
