#!/bin/bash
set -e -o pipefail

echo
echo "Stopping containers & removing images..."
docker-compose -f docker-compose.yml down --rmi all
