# .NET

Hello World scala application

## BUILD LOCAL

```bash
cd src
sbt run

```

## Docker simple

```bash
 docker build -t scala -f docker/Dockerfile .
```

## Docker multistage

```bash
docker build -t scala:multi -f docker/Dockerfile.multistage .
```

## Docker run

```bash
docker run -it scala:multi
```
