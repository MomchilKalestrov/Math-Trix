#!/bin/bash
WINEPREFIX=~/.wine_dotnet wine dotnet build
WINEPREFIX=~/.wine_dotnet wine bin/net9.0-windows/MathTrix.exe
WINE_PREFIX=~/.wine_dotnet wineserver -k