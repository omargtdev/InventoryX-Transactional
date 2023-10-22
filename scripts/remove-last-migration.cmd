@echo off
REM Remove last migration created
dotnet ef migrations remove  -p ..\InventoryX-Transactional.Data\ -s ..\InventoryX-Transactional.API\
