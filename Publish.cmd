@echo off

call "%INT_CMD%\cn_dev.bat"

set BUILD_PATH=.\IntNote\bin\Release\net7.0-windows
call :GET_CANONICAL_PATH "%BUILD_PATH%"
set BUILD_PATH=%RETURN_PATH%

set PUBLISH_PATH=.\Publish
call :GET_CANONICAL_PATH "%PUBLISH_PATH%"
set PUBLISH_PATH=%RETURN_PATH%

:BUILD_RELEASE
@echo on
msbuild /m /p:Configuration=Release
@echo off
if %ERRORLEVEL% neq 0 goto :FINISH

rmdir /S /Q "%PUBLISH_PATH%"
mkdir "%PUBLISH_PATH%"

robocopy /njh /njs /nc /np /w:5 /s "%BUILD_PATH%" "%PUBLISH_PATH%" *.exe *.dll *.json
if %ERRORLEVEL% leq 7 goto :SUCCESS

:FAILURE
echo Publish failed!
goto :FINISH

:SUCCESS
echo Publish succeeded!
goto :FINISH

:GET_CANONICAL_PATH
set RETURN_PATH=%~dpnx1
goto :eof

:FINISH
pause
