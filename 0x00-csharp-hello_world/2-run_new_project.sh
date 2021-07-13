#!/usr/bin/env bash
# Bash script that initializes, builds and run a new C# project
dotnet new console -o 2-new_project
cd 2-new_project
dotnet build
dotnet run
