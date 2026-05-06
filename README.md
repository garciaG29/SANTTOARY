# Santtoary — Sistema de Gestión para Estudio de Tatuajes
 
## Descripción del Proyecto:

Santtoary es un sistema web completo donde el estudio de tatuajes puede administrar todo su negocio desde un solo lugar: clientes, citas, artistas, diseños, cobros, inventario y documentos legales, eliminando el uso de agendas físicas, hojas de cálculo y procesos manuales.

---

 ## Integrantes del Equipo:
 
Santiago Atencia Ortiz,
Kevin Giraldo,
Ximena Mosquera García,
Emmanuel Castañeda Cano,
Juan David Arias Ospina.

---

 ## Tecnologías Utilizadas:

-Backend: ASP.NET Core .NET 10 WebAPI,
-Frontend: Blazor WebAssembly,
-Base de datos: SQL Server LocalDB,
-ORM: Entity Framework Core 10,
-Autenticación: ASP.NET Core Identity,
-Documentación API: Swagger / OpenAPI,
-Control de versiones: Git / GitHub.

---

 ## Estructura del Proyecto:
 
Santtoary.sln
 Santtoary.API         → Backend WebAPI,
 Santtoary.Shared      → Entidades y modelos compartidos,
 Santtoary.Web         → Frontend Blazor WebAssembly.

---

 ## Entidades Principales:
 
User: Usuario del sistema con roles (Admin, Artista, Recepción),
Client: Cliente del estudio con datos de contacto y notas médicasArtistArtista tatuador con especialidad y contacto,
Appointment: Cita/Reserva que relaciona cliente y artistaInventoryItemInsumos del estudio (agujas, tinta, guantes, etc.),
Design: Diseño/Portafolio de un artista con precio

---

 ## Relaciones entre Entidades:

Un Artist puede tener muchos Appointments,
Un Client puede tener muchos Appointments,
Un Appointment pertenece a un Client y a un Artist,
Un Design pertenece a un Artist.

---

## 🌱 SeedDb — Datos Iniciales:

Al iniciar la aplicación por primera vez, el sistema carga automáticamente:
**Roles:** Admin, Artista, Recepcion

**Usuario Administrador**

| Campo | Valor |
|-------|-------|
| Email | admin@santtoary.com |
| Contraseña | Admin123! |
| Rol | Admin |

**Artistas**

| Nombre | Especialidad | Teléfono |
|--------|-------------|----------|
| Pablo Chacon | Realismo | 3029634561 |
| Laura Aristizabal | Minimalista | 3019855474 |
| Cuto Ramirez | Tribal | 3017531594 |

**Clientes**

| Nombre | Teléfono | Email |
|--------|----------|-------|
| Juan Perez | 3017853651 | JuanP@email.com |
| Maria Gomez | 3016547892 | MariaG@email.com |

---

## Instrucciones para Ejecutar el Proyecto

**Requisitos previos**
- Visual Studio 2022 o superior
- .NET 10 SDK
- SQL Server LocalDB

**Pasos**

1. Clonar el repositorio
2. Instalar la herramienta de migraciones si no la tiene con este comando en la terminal:
```
dotnet tool install --global dotnet-ef
```
3. Abrir la solución Santtoary.sln en Visual Studio
4. Verificar la cadena de conexión en appsettings.json del proyecto Santtoary.API
```json
"DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=SanttoaryDb;Trusted_Connection=True;MultipleActiveResultSets=true"
```
5. Aplicar las migraciones con este comando:
```
dotnet ef database update
```
6. Correr el proyecto con F5

---

## Funcionalidades Implementadas

- Proyecto Shared con entidades y relaciones definidas
- WebAPI con ASP.NET Core .NET 10
- ApplicationDbContext configurado con todas las entidades
- Identity para manejo de usuarios y roles
- Migraciones aplicadas con Entity Framework Core
- SeedDb con datos iniciales y usuario administrador
- Endpoints REST probados en Swagger
- Aplicación Blazor WebAssembly
- CRUD completo desde la interfaz Web
- Validaciones en formularios

---

## Video Demostrativo

https://youtu.be/PQYeCKIhOeY?si=3q5XsjoltX2sgfJh

---
