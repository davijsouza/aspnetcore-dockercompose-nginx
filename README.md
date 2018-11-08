# aspnetcore-dockercompose-nginx
A repo to work with multiple aspnet core apis and hosting them on azure app services using nginx as reverse proxy

docker build -t rsantosdev/aspnetcore-nginx-orders .
docker build -t rsantosdev/aspnetcore-nginx-payments .

docker run -d -p 8002:80 rsantosdev/aspnetcore-nginx-orders
docker run -d -p 8003:80 rsantosdev/aspnetcore-nginx-payments