@echo off

start cmd /k ..\Server\bin\Debug\net5.0\Server.exe --port=7777 --teamCount=1 --playerCount=1  --gameTimeInSecond=5 --url=http://www.baidu.com --token=???

start cmd /k ..\Client\bin\Debug\net5.0-windows\Client.exe --cl --port=7777 --teamID=0 --characterID=0 --software=4 --hardware=2