#!/usr/bin/env bash
docker stop mvcauthvue_c || true
docker rm mvcauthvue_c || true
docker rmi -f mvcauthvue:dev || true
docker build -t mvcauthvue:dev . || true
docker run --rm --name mvcauthvue_c -d -p 8083:80 mvcauthvue:dev || true
docker rmi $(docker images -f "dangling=true" -q) || true