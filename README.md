# Employee API

此專案為 Employee 管理系統，採用 ASP.NET Core 8 與 Clean Architecture 架構。

## 專案結構

- src/employee.Api/             // Web API 專案
- src/employee.Application/     // Application Layer
- src/employee.Domain/          // Domain Layer
- src/employee.Infrastructure/  // Infrastructure Layer
- tests/employee.UnitTests/     // 單元測試專案

## 快速開始

```bash
# 還原 NuGet 套件
dotnet restore
# 建立資料庫、遷移等…
dotnet ef database update
# 執行 API 專案
dotnet run --project src/employee.Api
```