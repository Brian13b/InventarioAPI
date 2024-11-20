# Proyecto de API de Productos

Este es un proyecto que implementa una API RESTful para gestionar productos. La API permite realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre los productos.

### Funcionalidades

- **Obtener todos los productos** (`GET /api/productos`)
- **Obtener un producto específico** (`GET /api/productos/{id}`)
- **Crear un nuevo producto** (`POST /api/productos`)
- **Actualizar un producto existente** (`PUT /api/productos/{id}`)
- **Eliminar un producto** (`DELETE /api/productos/{id}`)

## Tecnologías Utilizadas

- **ASP.NET Core**: Framework utilizado para construir la API RESTful.
- **C#**: Lenguaje de programación principal del proyecto.
- **Entity Framework Core** (opcional, dependiendo de tu configuración de base de datos): ORM utilizado para la gestión de datos.
- **PostgreSQL** o cualquier otra base de datos que elijas para almacenar los productos.

## Instalación

Sigue estos pasos para configurar y ejecutar el proyecto localmente.

### Requisitos

1. **.NET SDK**: Asegúrate de tener el SDK de .NET instalado en tu máquina. Puedes descargarlo desde [aquí](https://dotnet.microsoft.com/download).
2. **Editor de Código**: Se recomienda usar [Visual Studio](https://visualstudio.microsoft.com/es/) o [Visual Studio Code](https://code.visualstudio.com/).

### Pasos

1. **Clonar el repositorio**
   ```bash
   git clone https://github.com/tuusuario/tu-repositorio.git

2. **Abrir el proyecto en tu editor de código Si estás usando Visual Studio Code, puedes abrir la carpeta del proyecto con:**
   ```bash
   code .

3. **Restaurar los paquetes NuGet Ejecuta el siguiente comando para restaurar las dependencias del proyecto:**
   ```bash
   dotnet restore
   
4. **Ejecutar la aplicación Puedes ejecutar la API con el siguiente comando:**
   ```bash
   dotnet run

## Endpoints

### 1. Obtener todos los productos
- **Método**: `GET`
- **Ruta**: `/api/productos`
- **Descripción**: Obtiene una lista de todos los productos.
- **Respuesta exitosa**:
  ```json
  [
    {
      "id": 1,
      "nombre": "Laptop Gamer XYZ",
      "cantidad": 1,
      "descripcion": "Laptop de alta gama para videojuegos con pantalla de 15.6\" y procesador i7.",
      "precio": 1500.00
    },
    {
      "id": 2,
      "nombre": "Smartphone Alpha X12",
      "cantidad": 4,
      "descripcion": "Smartphone de última generación con cámara de 108MP...",
      "precio": 899.99
    }
  ]

### 2. Obtener un producto específico
- **Método**: `GET`
- **Ruta**: `/api/productos/{id}`
- **Descripción**: Obtiene los detalles de un producto específico por su ID.
- **Respuesta exitosa**:
  ```json
  {
    "id": 1,
    "nombre": "Laptop Gamer XYZ",
    "cantidad": 1,
    "descripcion": "Laptop de alta gama para videojuegos con pantalla de 15.6\" y procesador i7.",
    "precio": 1500.00
  }

### 3. Crear un nuevo producto
- **Método**: `POST`
- **Ruta**: `/api/productos`
- **Descripción**: Crea un nuevo producto.
- **Cuerpo de la solicitud**:
  ```json
  {
    "id": 1,
    "nombre": "Laptop Gamer XYZ",
    "cantidad": 1,
    "descripcion": "Laptop de alta gama para videojuegos con pantalla de 15.6\" y procesador i7.",
    "precio": 1500.00
  }

### 4. Actualizar un producto existente
- **Método**: `PUT`
- **Ruta**: `/api/productos/{id}`
- **Descripción**: Actualiza un producto existente.
- **Cuerpo de la solicitud**:
  ```json
  {
    "id": 1,
    "nombre": "Laptop Gamer XYZ",
    "cantidad": 1,
    "descripcion": "Laptop de alta gama para videojuegos con pantalla de 15.6\" y procesador i7.",
    "precio": 1500.00
  }

### 5. Eliminar un producto
- **Método**: `DELETE`
- **Ruta**: `/api/productos/{id}`
- **Descripción**: Elimina un producto por su ID.


