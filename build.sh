#!/bin/bash
WINEPREFIX=~/.wine-dotnet wine dotnet build
WINEPREFIX=~/.wine-dotnet wine bin/net9.0-windows/MathTrix.exe
WINE_PREFIX=~/.wine-dotnet wineserver -k