# Second stage: minimal runtime environment
FROM openjdk:11-jre-slim

# copy jar from the first stage
COPY src/target/employee_app-0.0.1-SNAPSHOT.jar /srv/app.jar

EXPOSE 8080

CMD ["java", "-jar", "/srv/app.jar"]



