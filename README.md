# .NET • ASP.NET • Windows Forms • API

Solución de **tienda / gestión de stock** con tres capas:
- **API REST (.NET)** que expone datos y lógica de negocio.
- **Web ASP.NET** como interfaz web.
- **App de escritorio (Windows Forms)** para control de stock.

## 📦 Estructura
Entrega/
├─ Api_Tienda_TP/ # API REST (ASP.NET Core Web API)
├─ WebTienda1/ # Aplicación Web (ASP.NET)
├─ ControlStockWindowsForms/ # App de escritorio (WinForms)
├─ ProyectoCompartido/ # Modelos/DTOs/utilidades compartidas (si aplica)
└─ README.md
## 🧠 Arquitectura (resumen)

- **Capas**: Presentación (Web/WinForms) → API REST → Datos.
- **Comunicación**: Web y WinForms consumen la API vía HTTP/JSON.
- **Modelos compartidos**: DTOs/contratos en `ProyectoCompartido`.
- **Base de datos**: SQL Server (LocalDB/Docker). ORM típico: Entity Framework (ajusta si usas otro).

---

## ✅ Requisitos

- **.NET SDK 6/7/8**.
- **Visual Studio 2022** o **VS Code**.
- **SQL Server** y **connection string**.

## 🏗️ Tecnologías

.NET (API, Web, WinForms)

ASP.NET / ASP.NET Core

Entity Framework / ADO.NET

SQL Server

## 👤 Autor

LorenGrz — Proyecto de entrega con API + Web + WinForms.
