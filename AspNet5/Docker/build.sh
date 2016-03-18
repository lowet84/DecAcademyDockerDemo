mkdir -p Content
unzip AspNet5.zip -d Content/
docker build -t lowet84/decacademyaspnet5 .
rm -r Content
