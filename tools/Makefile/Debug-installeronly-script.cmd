@echo off
setx NEST C:\Projects\ndoctor\src\View\Probel.NDoctor.View.Core\bin\Debug
echo %NEST%
nant -buildfile:nDoctor.build.xml -D:build-mode=debug -D:release-dir=C:\Projects\ndoctor -D:code-dir=C:\Projects\ndoctor -D:tool-dir=C:\Projects\ndoctor\tools -D:only-installer=true Clean-Up
pause
