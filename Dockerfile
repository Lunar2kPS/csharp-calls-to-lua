FROM mcr.microsoft.com/dotnet/sdk:5.0

COPY ./CSharpCallsToLua /src
RUN dotnet build /src/CSharpCallsToLua.sln

ENTRYPOINT [ "dotnet", "/src/bin/Debug/net5.0/CSharpCallsToLua.dll" ]
