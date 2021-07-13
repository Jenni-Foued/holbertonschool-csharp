#!/usr/bin/env bash
# Bash script that initializes, builds and run a new C# project
mkdir 2-new_project
cd 2-new_project
dotnet new console
dotnet build
dotnet run
