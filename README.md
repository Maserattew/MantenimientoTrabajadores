#  Mantenimiento de Trabajadores – .NET Desktop App

##  Descripción

**Mantenimiento de Trabajadores** es una aplicación de escritorio robusta desarrollada en **C#** bajo el ecosistema **.NET Framework**. El sistema permite la gestión integral (CRUD) de la información de empleados, asegurando la persistencia de datos y una organización de código profesional mediante la separación de responsabilidades.

La aplicación está diseñada para entornos empresariales donde la integridad de la información y la facilidad de mantenimiento son críticas.

---

##  Objetivo del proyecto

Desarrollar una solución de escritorio escalable que permita:

* Centralizar la gestión de datos de trabajadores.
* Implementar una **arquitectura de N-Capas** para separar la lógica de negocio del acceso a datos.
* Garantizar la integridad referencial mediante la integración con **SQL Server**.
* Proporcionar una interfaz de usuario administrativa clara y funcional mediante Windows Forms.

---

##  Arquitectura

El proyecto destaca por seguir el patrón de **Arquitectura en Capas (Layered Architecture)**, lo que facilita el mantenimiento y la escalabilidad del sistema:
[ Capa de Presentación (UI) ] ↔ [ Capa de Negocio ] ↔ [ Capa de Datos ] ↔ [ SQL Server ]
↖ [ Capa de Entidades ] ↗

* **Capa de Entidades:** Define los modelos de datos y objetos de dominio.
* **Capa de Datos:** Gestiona la conexión y las consultas hacia SQL Server (ADO.NET).
* **Capa de Negocio:** Contiene las validaciones y reglas lógicas del sistema.
* **Capa de Presentación:** Interfaz de usuario (WinForms) que interactúa con el usuario final.

---

##  Tecnologías utilizadas

* **C#** (Lenguaje de programación)
* **.NET Framework**
* **SQL Server** (Motor de base de datos)
* **ADO.NET** (Manejo de persistencia de datos)
* **Windows Forms** (Desktop UI)
* **Git / GitHub**

---

##  Funcionalidades principales

* **Gestión CRUD:** Registro, edición, eliminación y listado de trabajadores.
* **Validación de Datos:** Reglas de negocio aplicadas antes de la persistencia en la base de datos.
* **Arquitectura Desacoplada:** Código organizado para facilitar la migración o actualización de componentes.
* **Consultas Eficientes:** Listado dinámico de información almacenada en el servidor de datos.

---

##  Rol y contribución

**Rol:** Backend & Desktop Developer
**Responsabilidades principales:**

* Diseño del **esquema de base de datos** y tablas en SQL Server.
* Desarrollo de la **Capa de Datos** para la comunicación con el motor de base de datos.
* Implementación de la **Lógica de Negocio** (validaciones y procesos internos).
* Creación de la interfaz de usuario en la **Capa de Presentación**.

---

##  Instalación y ejecución local

### Requisitos

* Visual Studio (2019 o superior)
* SQL Server (Express o LocalDB)
* .NET Framework SDK

### Pasos

1.  **Clonar el repositorio:**
    ```bash
    git clone [https://github.com/Maserattew/MantenimientoTrabajadores.git](https://github.com/Maserattew/MantenimientoTrabajadores.git)
    ```
2.  **Abrir la solución:** Carga el archivo `.sln` en Visual Studio.
3.  **Configurar Base de Datos:** Asegúrate de que el Connection String en el archivo de configuración apunte a tu instancia local de SQL Server.
4.  **Ejecutar:** Compila el proyecto y ejecuta la **Capa de Presentación**.

---

##  Estado del proyecto

✔️ Funcional
✔️ Arquitectura de N-Capas implementada
✔️ Código limpio y documentado

---

##  Notas finales

Este proyecto demuestra mi capacidad para estructurar soluciones siguiendo estándares de la industria como la **separación de capas**. Es un ejemplo sólido de mi dominio del ecosistema **.NET** para resolver necesidades de gestión organizacional.
