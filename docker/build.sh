#!/bin/bash
set -e -o pipefail

echo
echo "Removing stopped service containers (if exists) ..."
docker-compose rm -fsv

echo
echo "Building images ..."
docker-compose build --force-rm
