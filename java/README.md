# JAVA

## Docker simple

```bash
docker build -t java-app -f docker/Dockerfile .
```

## Docker multistage

```bash
docker build -t java-app -f docker/Dockerfile.multistage .
```

## Docker run

```bash
docker run -it -e HTTP_PORT=8081 -e DB_HOST=192.168.0.1 -e DB_DBNAME=mydatabase -e DB_USERNAME=root -e DB_PASSWORD=pass123 -p 8081:8081  java-app:multi
```

## Open application

Open in browser <http://localhost:8081/>
