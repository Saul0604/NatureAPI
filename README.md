# NatureAPI

## Descripción

**NatureAPI** es una API RESTful construida con .NET 8 que gestiona información sobre lugares naturales en México, como parques, cascadas, miradores y senderos. Permite almacenar y consultar datos relacionados con estos lugares, incluyendo coordenadas geográficas, senderos, fotos, reseñas y servicios disponibles.

## Tecnologías utilizadas

- **Backend**: .NET 8 (ASP.NET Core)
- **Base de datos**: SQL Server
- **Contenerización**: Docker
- **ORM**: Entity Framework Core
- **Migraciones**: EF Core Migrations
- **Seed de datos**: Datos iniciales precargados

## Endpoints disponibles

### `GET /api/places`

Obtiene una lista de todos los lugares naturales registrados.

**Parámetros de consulta opcionales**:

- `category`: Filtra por categoría del lugar (e.g., "parque", "cascada").
- `difficulty`: Filtra por dificultad de los senderos (e.g., "fácil", "moderada", "difícil").

### `GET /api/places/{id}`

Obtiene los detalles de un lugar específico por su ID.

### `POST /api/places`

Crea un nuevo lugar natural. El cuerpo de la solicitud debe incluir:

```json
{
  "name": "Nombre del lugar",
  "description": "Descripción del lugar",
  "category": "Categoría del lugar",
  "latitude": 19.4326,
  "longitude": -99.1332,
  "elevationMeters": 1000,
  "accessible": true,
  "entryFee": 50.0,
  "openingHours": "08:00 - 18:00",
  "trails": [
    {
      "name": "Sendero 1",
      "distanceKm": 5.0,
      "estimatedTimeMinutes": 120,
      "difficulty": "moderada",
      "path": "ruta1",
      "isLoop": true
    }
  ],
  "photos": [
    {
      "url": "https://example.com/photo1.jpg"
    }
  ],
  "amenities": [
    1,
    2
  ]
}
```

## Estructura de la base de datos

### Entidades

- **Place**
  - Id (int)
  - Name (string)
  - Description (string)
  - Category (string)
  - Latitude (double)
  - Longitude (double)
  - ElevationMeters (int)
  - Accessible (bool)
  - EntryFee (double)
  - OpeningHours (string)
  - CreatedAt (DateTime)

- **Trail**
  - Id (int)
  - PlaceId (int)
  - Name (string)
  - DistanceKm (double)
  - EstimatedTimeMinutes (int)
  - Difficulty (string)
  - Path (string)
  - IsLoop (bool)

- **Photo**
  - Id (int)
  - PlaceId (int)
  - Url (string)

- **Review**
  - Id (int)
  - PlaceId (int)
  - Author (string)
  - Rating (int)
  - Comment (string)
  - CreatedAt (DateTime)

- **Amenity**
  - Id (int)
  - Name (string)

- **PlaceAmenity** (tabla puente para relación N–N Place ↔ Amenity)
  - PlaceId (int)
  - AmenityId (int)
  - Clave primaria compuesta: (PlaceId, AmenityId)

### Relaciones

- `Place` 1 — N `Trail`
- `Place` 1 — N `Photo`
- `Place` 1 — N `Review`
- `Place` N — N `Amenity` a través de `PlaceAmenity`

## Requisitos del proyecto

Antes de ejecutar NatureAPI, asegúrate de tener instalados los siguientes componentes:

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Docker](https://www.docker.com/products/docker-desktop)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (será levantado vía Docker)
- Rider

---

## Instrucciones para ejecutar

1. **Clonar el repositorio**

```bash
git clone https://github.com/PabloAlonsoRomero/NatureAPI.git
cd NatureAPI
```

2. **Levantar el contenedor de SQL Server con Docker**
```bash
docker-compose up -d
```

3. **Restaurar dependencias de .NET**
```bash
dotnet restore
```

4. **Aplicar migraciones y crear la base de datos**
```bash
dotnet ef database update
```

5. **Ejecutar la api**
```bash
cd .\NatureAPI\
dotnet run
```

