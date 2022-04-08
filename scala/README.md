# Scala

Hello World scala application

## BUILD LOCAL

```bash
cd src
sbt run

```

## Docker simple

```bash
 docker build -t scala-app -f docker/Dockerfile .
```

## Docker multistage

```bash
docker build -t scala-app -f docker/Dockerfile.multistage .
```

## Docker run

```bash
docker run -it scala-app:multi
```
