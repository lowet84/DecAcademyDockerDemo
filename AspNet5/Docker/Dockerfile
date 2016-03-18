FROM microsoft/aspnet

COPY Content /project
WORKDIR /project
RUN ["dnu", "restore"]

EXPOSE 5000

ENTRYPOINT ["dnx", "web", "--server.urls","http://0.0.0.0:5000"]
