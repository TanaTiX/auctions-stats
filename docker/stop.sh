#!/bin/bash
set -e -o pipefail

echo
echo "Stopping containers ..."
docker-compose -f docker-compose.yml stop
