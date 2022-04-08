# .NET

Application writen in .net5 or later can be dockerized

## BUILD LOCAL

```bash
cd src
dotnet restore
dotnet publish -c Release -o out
```

## Docker simple

```bash
 docker build -t net-app -f docker/Dockerfile .
```

## Docker multistage

```bash
docker build -t net-app:multi -f docker/Dockerfile.multistage .
```

## Docker run

```bash
docker run -it -e COUNT_LENGHT=6   net-app:multi
```
