# 📅 Task Planner Pro

Una Single Page Application (SPA) full-stack para la gestión avanzada de tareas y tiempo, desarrollada con Blazor WebAssembly y la arquitectura .NET.

## 🚀 Características Principales

* **Vistas Dinámicas de Calendario:** Implementación de vistas de Día, Semana y Mes desde cero utilizando CSS Grid puro para un rendimiento óptimo.
* **Sistema de Tareas Recurrentes:** Lógica avanzada para la repetición de tareas (días específicos de la semana) con manejo de excepciones (eliminación de ocurrencias individuales sin romper la serie).
* **Algoritmo de Solapamiento:** Cálculo matemático en tiempo real para renderizar visualmente tareas que coinciden en la misma franja horaria.
* **Gestión del Estado (State Management):** Comunicación fluida entre componentes independientes (menú lateral interactivo y calendario principal) utilizando un servicio de estado inyectado (`AppState`).
* **Filtros en Tiempo Real:** Interfaz de usuario reactiva que permite filtrar el calendario por etiquetas/categorías instantáneamente.

## 🛠️ Stack Tecnológico

* **Frontend:** Blazor WebAssembly (C#), HTML5, CSS Grid, Bootstrap.
* **Backend:** ASP.NET Core API.
* **Base de Datos:** Entity Framework Core.

## 📸 Demostración

**Vista principal (Cuadrícula Semanal):**
![Vista de la Semana](Imagenes/vista-semana.png)

**Vista Mensual (Calendario completo):**
![Vista del Mes](Imagenes/vista-mes.png)

**Gestión avanzada y creación de tareas recurrentes:**
![Modal Nueva Tarea](Imagenes/vista-nueva-tarea.png)
