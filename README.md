# C# Calls to Lua
This is a simple project demonstrating C# calls to Lua using NLua, and simple usage of CircleCI + Docker.

## CircleCI builds:
- Status: [![CircleCI](https://circleci.com/gh/2kCarlos/csharp-calls-to-lua/tree/main.svg?style=shield)](https://circleci.com/gh/2kCarlos/csharp-calls-to-lua/tree/main)
- Configuration available at [.circleci/config.yml](.circleci/config.yml)

## Docker in This Project
- If you are unfamiliar with Docker, I highly recommend watching this [free, in-depth YouTube video course on Docker](https://www.youtube.com/watch?v=zJ6WbK9zFpI&ab_channel=KodeKloud)!
- Commands:
  - `docker build -t 2kcarlos/csharp-calls-to-lua .`
    - _Builds the Docker image based on the [Dockerfile](Dockerfile), and names the resulting image "2kcarlos/csharp-calls-to-lua"._
  - `docker-compose up`
    - _Runs a new Docker container according to the instructions in the [docker-compose.yaml](docker-compose.yaml) file._
