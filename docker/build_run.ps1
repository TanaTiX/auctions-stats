docker rm $(docker ps -a -q) -f
docker-compose build --force-rm --build-arg
docker-compose -p auctions-stats -f docker-compose.yml -f docker-compose.override.yml up -d 