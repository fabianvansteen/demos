# Cheatsheet

## Getting started

[Docker for Windows](https://docs.docker.com/docker-for-windows/)

[Visual Studio 2017 RC](https://www.visualstudio.com/vs/visual-studio-2017-rc/)

## Visual Studio 2017 RC1

1. Creating an ASP.NET Core Web Application with the name `DockerDemo`
2. Enable `support docker` in the project creation

## Push container to docker hub
1. Login to docker
```
docker Login
```  
2. Push the docker container to hub
```
docker push fabianvansteen/dockerdemo
```
## Hosting container in Azure
1. Add azure host to `docker-machine` 
```
docker-machine create -d azure `
  --azure-ssh-user ops `
  --azure-subscription-id <subscription-id> `
  --azure-open-port 80 `
  docker-demo
```
2. Switch to env docker-demo in azure
```
docker-machine env docker-demo
& "C:\Program Files\Docker\Docker\Resources\bin\docker-machine.exe" env docker-demo | Invoke-Expression
```
3. Pull the image from docker hub
```
docker pull fabianvansteen/dockerdemo
```
4. Run the docker container
```
docker run -d -p 80:80 --restart=always fabianvansteen/dockerdemo dockerdemo
```
5. Remove the azure resource groups
```
docker-machine rm docker-demo -y
```