#!/bin/sh

if [ "$HTTP_PORT" == "" ]; then
  HTTP_PORT="database.example.com"
fi

python manage.py migrate
python manage.py runserver 0.0.0.0:$HTTP_PORT
