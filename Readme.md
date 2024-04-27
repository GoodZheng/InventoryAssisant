# InventoryAssisant
## Overview | 项目概述
The main value of this project:
1. This is a .net8.0 winform based program;
2. This project uses **EF Core framework**, and uses IOC container of .Net to realize DI(dependency injection);
3. To be continued...
---
本项目的主要价值：
1. 这是一个基于.net 8.0 winform的程序;
2. 此项目使用了**EF Core框架**，使用.net原生的IOC容器实现DI(依赖注入);
3. 未完待续……

## Installation | 下载安装项目

## Requirements
- Visual Studio 2022

- .NET 8.0

- MySQL or others.

## Architecture | 系统架构


## Database configuration | 数据库路径配置

Modify the appsettings.json file and fill in your connection string in the MySQLConnectionString.

---

修改appsettings.json文件，并在MySQLConnectionString中填写您的连接字符串。
```json
{
  "AllowedHosts": "*",

  "DbContext": {
    "MySQLConnectionString": "Server=196.0.0.1;Database=testDb;Uid=name; Pwd=123456
    "
  }
}
```
