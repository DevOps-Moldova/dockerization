FROM openjdk:8-jre-alpine3.9 
WORKDIR /srv

COPY target/scala-2.13/helloworld_2.13-1.0.jar app.jar
COPY scala-library.jar ./scala-library.jar

CMD ["java",  "-cp", "app.jar:scala-library.jar", "Hello"]