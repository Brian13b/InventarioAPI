# 🛍️ Product API - Sistema de Gestión de Productos 

![.NET Version](https://img.shields.io/badge/.NET-6.0-512BD4?logo=dotnet)
![C#](https://img.shields.io/badge/C%23-Language-239120?logo=c-sharp)
[![License](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)

API RESTful para gestión de productos con operaciones CRUD completa, desarrollada en ASP.NET Core.

---

## 🌟 Características Principales

- ✅ **CRUD Completo** para productos
- 🔍 Búsqueda de productos por ID
- 📦 Modelo de datos flexible
- 🔐 Validación integrada de datos
- 📄 Documentación de API incluida

---

## 🛠️ Stack Tecnológico

| Tecnología             | Uso en el Proyecto                     |
|------------------------|----------------------------------------|
| **ASP.NET Core 6**     | Framework principal para la API        |
| **C# 10**              | Lenguaje de programación               |
| **Entity Framework**   | ORM para acceso a datos                |
| **PostgreSQL**         | Base de datos relacional               |
| **Swagger**            | Documentación interactiva de la API    |

---

## 🚀 Instalación y Configuración

### Requisitos Previos
- [.NET 6 SDK](https://dotnet.microsoft.com/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) o [VS Code](https://code.visualstudio.com/)
- [PostgreSQL](https://www.postgresql.org/download/) (opcional)

### Pasos para Configuración

```bash
# 1. Clonar el repositorio
git clone https://github.com/tuusuario/product-api.git

# 2. Navegar al directorio del proyecto
cd product-api

# 3. Restaurar paquetes NuGet
dotnet restore

# 4. Configurar la base de datos (editar appsettings.json)
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=ProductDB;User Id=sa;Password=TuContraseña;"
  }
}

# 5. Ejecutar migraciones (si usas EF Core)
dotnet ef database update

# 6. Iniciar la aplicación
dotnet run
```
---

# 📡 Endpoints de la API

## 🔹 Obtener todos los productos
```http
GET /api/productos
```

**Respuesta Exitosa (200 OK):**
```json
[
  {
    "id": 1,
    "nombre": "Laptop Gamer XYZ",
    "cantidad": 1,
    "descripcion": "Laptop de alta gama para videojuegos...",
    "precio": 1500.00
  }
]
```

## 🔹 Obtener producto específico
```http
GET /api/productos/{id}
```
**Parámetros:**
- `id`: ID del producto (requerido)

## 🔹 Crear nuevo producto
```http
POST /api/productos
```

**Cuerpo de la Solicitud:**
```json
{
  "nombre": "Nuevo Producto",
  "cantidad": 10,
  "descripcion": "Descripción del producto",
  "precio": 99.99
}
```

## 🔹 Actualizar producto
```http
PUT /api/productos/{id}
```

**Validaciones:**
- Todos los campos son requeridos.
- El precio debe ser mayor que 0.

## 🔹 Eliminar producto
```http
DELETE /api/productos/{id}
```

---

# 📚 Documentación Adicional
Accede a la documentación interactiva con Swagger UI en:

```text
http://localhost:5000/swagger
```

---

# 🤝 Contribuciones
¡Las contribuciones son bienvenidas! Por favor, lee las guías de contribución antes de enviar un PR.

---

# 📄 Licencia
Este proyecto está bajo la licencia MIT.

