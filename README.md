🏢 Sistema de Mantenimiento de Trabajadores – .NET Desktop App
📌 Descripción
Mantenimiento de Trabajadores es una aplicación de escritorio robusta desarrollada en C# bajo el ecosistema .NET. El sistema permite la gestión integral (CRUD) de la información de empleados, asegurando la persistencia de datos y una organización de código profesional mediante la separación de responsabilidades.

La aplicación está diseñada para entornos empresariales donde la integridad de la información y la facilidad de mantenimiento son críticas.

🎯 Objetivo del proyecto
Desarrollar una solución de escritorio escalable que permita:

Centralizar la gestión de datos de trabajadores.

Implementar una arquitectura de N-Capas para separar la lógica de negocio del acceso a datos.

Garantizar la integridad referencial mediante la integración con SQL Server.

Proporcionar una interfaz de usuario administrativa clara y funcional.

🧱 Arquitectura
El proyecto destaca por seguir el patrón de Arquitectura en Capas (Layered Architecture), lo que facilita el testing y la escalabilidad:

[ Capa de Presentación (UI) ] ↔ [ Capa de Negocio ] ↔ [ Capa de Datos ] ↔ [ SQL Server ]
                                      ↖ [ Capa de Entidades ] ↗
Capa de Entidades: Define los objetos de dominio comunes a todas las capas.

Capa de Datos: Maneja las consultas SQL y la conexión al motor de base de datos.

Capa de Negocio: Contiene las validaciones y reglas lógicas antes de persistir la información.

Capa de Presentación: Interfaz desarrollada con Windows Forms.

🛠️ Tecnologías utilizadas
C# (Lenguaje de programación)

.NET Framework / .NET Core

SQL Server (Motor de base de datos)

ADO.NET (Para la persistencia y comandos de datos)

Windows Forms (UI)

Git / GitHub

⚙️ Funcionalidades principales
Gestión CRUD completa: Registro, edición, eliminación y listado de trabajadores.

Validación de Negocio: Control de datos obligatorios y formatos correctos desde la capa lógica.

Conexión Dinámica: Configuración de cadena de conexión mediante archivos de configuración.

Búsqueda Filtrada: Capacidad de consultar trabajadores específicos dentro del sistema.

👨‍💻 Rol y contribución
Rol: Backend & Desktop Developer
Responsabilidades principales:

Diseño y creación del esquema de base de datos en SQL Server.

Implementación de la lógica de acceso a datos mediante procedimientos almacenados o comandos SQL.

Desarrollo de la Capa de Negocio para asegurar la calidad de la información.

Maquetación y programación de la interfaz en la Capa de Presentación.

🚀 Instalación y ejecución local
Requisitos
Visual Studio (2019 o superior)

SQL Server (LocalDB o Express)

SDK de .NET correspondiente

Pasos
Bash
# 1. Clonar el repositorio
git clone https://github.com/Maserattew/MantenimientoTrabajadores.git

# 2. Abrir la solución (.sln) en Visual Studio

# 3. Configurar la base de datos
# Ejecutar el script SQL (si está incluido) o configurar el App.config 
# con tu Connection String de SQL Server.

# 4. Compilar y Ejecutar
# Presionar F5 o el botón "Iniciar" desde la Capa de Presentación.
📌 Estado del proyecto
✔️ Funcional
✔️ Código organizado en capas
✔️ Listo para integración con reportes (fase futura)
