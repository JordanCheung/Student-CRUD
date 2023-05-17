FROM nginx:alpine
WORKDIR /app
COPY StudentClient/dist/wwwroot /app
COPY StudentClient/nginx.conf /etc/nginx/nginx.conf
EXPOSE 80/tcp
EXPOSE 443/tcp