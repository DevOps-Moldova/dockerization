# RUST

## RUN

```bash
cd src
cargo run 
```

## BUILD LOCAL

```bash
cargo build --release
```

## Docker simple

```bash
 docker build -t push-rust -f docker/Dockerfile .
```

## Docker multistage

```bash
docker build -t push-rust:multi -f Dockerfile.multistage .
```

## Docker run

```bash
docker run -it -e HTTP_PORT=8000 -p 8000:8000  push-rust:multi
```

## Open application

run in commandline

``` bash
curl -X POST 'http://localhost:8000/register' -H 'Content-Type: application/json' -d '{ "user_id": 1 }' 
curl -X POST 'http://localhost:8000/publish' \
    -H 'Content-Type: application/json' \
    -d '{"user_id": 1, "topic": "cats", "message": "are awesome"}'
```

in postman connect to url value from first request
