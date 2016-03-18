#!/bin/bash
mkdir -p Program
unzip Debug.zip -d Program/
docker build -t lowet84/decacademyowin .
rm -r Program
