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
 docker build -t go-app -f docker/Dockerfile .
```

## Docker multistage

```bash
docker build -t go-app:multi -f Dockerfile.multistage .
```

## Docker run

```bash
docker run -it -e HTTP_PORT=8081 -p 8081:8081  go-app:multi
```

## Open application

Open in browser <http://localhost:8081/>
