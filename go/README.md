# GO

## RUN 

```bash
go run src/main.go
```

## BUILD

```bash
CGO_ENABLED=0 GOOS=linux  go build -a -installsuffix cgo -o dist/app ./src/main.go
```

## Docker simple

```bash
 docker build -t golang:simple .
```

## Docker multistage

```bash
docker build -t golang:multi -f Dockerfile.multistage .
```

## Docker run

```bash
docker run -it -p 10000:10000  golang:multi
```

## Open application

Open in browser <http://localhost:10000/>
