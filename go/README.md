# GO

## RUN

```bash
go run src/main.go
```

## BUILD LOCAL

```bash
CGO_ENABLED=0 GOOS=linux  go build -a -installsuffix cgo -o dist/app ./src/main.go
```

## Docker simple

```bash
 docker build -t golang -f docker/Dockerfile .
```

## Docker multistage

```bash
docker build -t golang:multi -f Dockerfile.multistage .
```

## Docker run

```bash
docker run -it -e HTTP_PORT=8081 -p 8081:8081  golang:multi
```

## Open application

Open in browser <http://localhost:8081/>
