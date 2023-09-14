FROM alpine:3
WORKDIR /srv
EXPOSE 8000
RUN apk add openssl ca-certificates --no-cache
COPY src/target/release/push-rust /srv/
CMD ["./push-rust"]