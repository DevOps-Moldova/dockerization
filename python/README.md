# Python

Web application writen in Python django

## BUILD LOCAL

```bash
cd src
pip istall -r requirements.txt
```

## Docker simple

```bash
 docker build -t python-app -f docker/Dockerfile .
```

## Docker multistage

```bash
docker build -t python-app:multi -f docker/Dockerfile.multistage .
```

## Docker run

```bash
docker run -it -e HTTP_PORT=8080  -p 8080:8080 python-app:multi
```
