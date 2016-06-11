@echo off

if NOT EXIST %~dp0bin\protoc.exe (
	echo "missing bin\protoc.exe"
	pause
	exit
)

REM Delete pb directory and recreate
if exist pb rd /s /q pb
mkdir pb

REM Generate Go code
%~dp0bin\protoc.exe -I protobuf --gofast_out=pb protobuf/*.proto