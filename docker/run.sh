#!/bin/bash
set -e -o pipefail

./build.sh

echo
echo "Starting containers for project '${PROJECT_NAME}' ..."
docker-compose -f docker-compose.yml up -d
