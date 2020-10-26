# Overview

This repository is a test project which accepts as input dimensions
and coordinates of two cubic objects (considering a 3D space). The application must determine
whether the two objects collide and calculate the intersected volume.

# How to run

## Test

You can now run your tests using the Visual Studio Test Explorer, or by running `dotnet test` from the command line.

```sh
# Restore the NuGet packages
dotnet restore

# Run the unit tests in a different directory
dotnet test cubes.test/cubes.test.csproj
```