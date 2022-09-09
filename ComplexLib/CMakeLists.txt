cmake_minimum_required(VERSION 3.0)
set(CMAKE_DOTNET_TARGET_FRAMEWORK_VERSION v4.6.1)
project(ComplexLib LANGUAGES CSharp)
add_library(ComplexLib SHARED ComplexLib.cs)