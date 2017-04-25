@ECHO OFF
TITLE Compilation Tool for FantasyHeaven Networking Packages
RMDIR /S /Q target
MKDIR target
MKDIR target\csharp
MKDIR target\java

CALL process src
