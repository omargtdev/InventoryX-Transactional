@echo off
REM Apply last migration created
dotnet ef database update -s ..\InventoryX-Transactional.API\ -p ..\InventoryX-Transactional.Data
