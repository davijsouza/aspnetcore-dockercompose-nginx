FROM microsoft/dotnet:2.1-aspnetcore-runtime
LABEL Author="rsantosdev"

WORKDIR /app
COPY bin/Debug/netcoreapp2.1/ .
ENTRYPOINT ["dotnet", "AspnetCore.Orders.dll"]
