#!/usr/bin/env bash
# Bash script that initializes and builds a new C# project
dotnet new console -o 1-new_project
cd 1-new_project
dotnet build
