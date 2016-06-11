@echo off

if NOT EXIST %~dp0bin\protoc.exe (
	echo "missing bin\protoc.exe"
	pause
	exit
)

REM Delete csharp directory and recreate
if exist csharp rd /s /q csharp
mkdir csharp\pb

REM Generate CSharp code
%~dp0bin/protoc.exe -I protobuf --csharp_out=csharp/pb protobuf/*.proto
