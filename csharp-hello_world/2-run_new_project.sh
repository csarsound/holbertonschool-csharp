#!/usr/bin/env bash
#Run a c# project
dotnet new console -o 2-new_project
dotnet build 2-new_project
dotnet run --project 2-new_project
