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
<img width="2559" height="1392" alt="vista-semana" src="https://github.com/user-attachments/assets/8d9028e5-89c1-4531-9424-da6e06add439" />


**Vista Mensual (Calendario completo):**
<img width="2559" height="1386" alt="vista-mes" src="https://github.com/user-attachments/assets/0bf439a1-440e-4ce3-bb15-c1e9d0bdc987" />


**Gestión avanzada y creación de tareas recurrentes:**
<img width="2557" height="1389" alt="vista-nueva-tarea" src="https://github.com/user-attachments/assets/17e8d4fa-36f8-49f4-bc94-e86d31afabbb" />

