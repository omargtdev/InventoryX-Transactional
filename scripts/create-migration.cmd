@echo off
REM Receive the name of new migration as argument
dotnet ef migrations add %1 -p ..\InventoryX-Transactional.Data\ -s ..\InventoryX-Transactional.API\
