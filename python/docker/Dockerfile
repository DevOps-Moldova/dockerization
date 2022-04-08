FROM python:3.7-alpine

RUN apk add --update --no-cache libpq libjpeg-turbo

WORKDIR /srv

ENV PYTHONUNBUFFERED 1
ENV PYTHONDONTWRITEBYTECODE 1
ENV PYTHONPATH /srv:$PYTHONPATH
EXPOSE 8000

COPY src/ /srv/
COPY docker/docker_entrypoint.sh /srv/
RUN pip install --no-cache-dir -r requirements.txt

ENTRYPOINT [ "/srv/docker_entrypoint.sh" ]