# AuthorMySQL  
A minimal Blazor Server + MySQL CRUD demo built with .NET 8 and Docker.

## ✅ Overview

This project demonstrates a simple **CRUD (Create, Read, Update, Delete)** application using:

- **.NET 8** with **C#**
- **Blazor Server** UI
- **MySQL** database (running in Docker)
- **Entity Framework Core** for database access
- **QuickGrid** for responsive data display
- **Docker Compose** for container orchestration
- **xUnit** for unit testing
- **GitHub Actions** for CI (Continuous Integration)

---

## 🚀 Quick Start

### 1. Prerequisites

Make sure the following are installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/)
- (Optional) [Rider](https://www.jetbrains.com/rider/) or Visual Studio

---

### 2. Start the app via Docker Compose

```bash
docker compose up --build
```

The app will run on `http://localhost:5001` by default.

MySQL is exposed on port `3306` and stores its data in a Docker volume.

---

### 3. Seed the database (if needed)

You can import the initial test data from `seed-data.sql` using:

```bash
docker exec -i <container_id_or_name> \
  mysql -u root -p --default-character-set=utf8mb4 dotnet_practice_db < seed-data.sql
```

---

### 4. CRUD Features

| Feature | URL                  | Description                      |
|---------|----------------------|----------------------------------|
| List    | `/authors`           | View all authors (paginated)     |
| Create  | `/authors/create`    | Add a new author                 |
| Edit    | `/authors/edit/:id`  | Edit author details              |
| Delete  | `/authors/delete/:id`| Delete author with confirmation  |

Data is displayed using `QuickGrid` with pagination and sorting support.

---

## 🧪 Testing

### Unit Tests

Run unit tests with:

```bash
dotnet test
```

Tests are located in `AuthorMySQL.Tests` and include:

- Model validation
- DbContext-based logic tests using in-memory database

---

## 🔄 Continuous Integration (CI)

This project uses **GitHub Actions** for CI.  
Every push to `main` triggers:

- Build and restore dependencies
- Run unit tests

CI config is located in `.github/workflows/ci.yml`.

---

## 🐳 Tech Stack

- .NET 8 / C#
- Blazor Server
- EF Core + Pomelo.MySQL
- QuickGrid
- Docker / Docker Compose
- GitHub Actions
- xUnit

---

## 🙋‍♂️ About

This project was created to learn and demonstrate a clean end-to-end CRUD pipeline with modern .NET tooling.

You can clone it and reuse it for your own demos, tutorials, or interview projects.
