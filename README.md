Santtoary — Sistema de Gestión para Estudio de Tatuajes
 
Descripción del Proyecto:

Santtoary es un sistema web completo donde el estudio de tatuajes puede administrar todo su negocio desde un solo lugar: clientes, citas, artistas, diseños, cobros, inventario y documentos legales, eliminando el uso de agendas físicas, hojas de cálculo y procesos manuales.

 Integrantes del Equipo:
 
Santiago Atencia Ortiz
Kevin Giraldo
Ximena Mosquera García
Emmanuel Castañeda Cano
Juan David Arias Ospina

 Tecnologías Utilizadas:

Backend: ASP.NET Core .NET 10 WebAPI
Frontend: Blazor WebAssembly
Base de datos: SQL Server LocalDB
ORM: Entity Framework Core 10
Autenticación: ASP.NET Core Identity
Documentación API: Swagger / OpenAPI
Control de versiones: Git / GitHub

 Estructura del Proyecto:
 
Santtoary.sln
├── Santtoary.API         → Backend WebAPI
├── Santtoary.Shared      → Entidades y modelos compartidos
└── Santtoary.Web         → Frontend Blazor WebAssembly

 Entidades Principales:
 
User: Usuario del sistema con roles (Admin, Artista, Recepción)
Client: Cliente del estudio con datos de contacto y notas médicasArtistArtista tatuador con especialidad y contacto
Appointment: Cita/Reserva que relaciona cliente y artistaInventoryItemInsumos del estudio (agujas, tinta, guantes, etc.)
Design: Diseño/Portafolio de un artista con precio

 Relaciones entre Entidades:

Un Artist puede tener muchos Appointments
Un Client puede tener muchos Appointments
Un Appointment pertenece a un Client y a un Artist
Un Design pertenece a un Artist


🌱 SeedDb — Datos Iniciales:

Al iniciar la aplicación por primera vez, el sistema carga automáticamente:
Roles

Admin
Artista
Recepcion
