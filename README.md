# 📝 Blazor To-Do Application (C# .NET)

A structured learning project to build a **Blazor Server To-Do application** in C#, practicing **clean architecture, dependency injection, EF Core database setup, and xUnit testing**.  
This repository is organized to reflect **daily learning goals** so you can progress step by step.

---

## 📂 Project Structure

```Plaintext
src/                     # Source folder containing all projects
├── TodoApp/             # Main Blazor Server project
│   ├── Pages/           # Razor pages (Todo, About, Stats)
│   ├── Components/      # Reusable UI components (TodoItem, etc.)
│   ├── Data/            # EF Core DbContext and entity models
│   ├── Services/        # Business logic services (TodoService)
│   ├── Program.cs       # App startup and DI configuration
│   └── wwwroot/         # Static assets
│
└── TodoApp.Tests/       # xUnit test project
    ├── TodoItemTests.cs     # Unit tests for models
    ├── TodoServiceTests.cs  # Unit tests for services
    ├── ComponentTests.cs    # bUnit tests for Blazor components
    └── RoutingTests.cs      # Integration tests for navigation
```

---

## 📅 Daily Goals

### **Day 1: Project Setup & First Test**
- Create Blazor Server project (`TodoApp`).
- Create xUnit test project (`TodoApp.Tests`).
- Write first unit test for `TodoItem` default state.
- ✅ Goal: Understand solution structure and run `dotnet test`.

### **Day 2: Database Layer + Tests**
- Add EF Core + SQLite.
- Create `TodoContext` with `DbSet<TodoItem>`.
- Configure SQLite in `Program.cs`.
- Write tests using `UseInMemoryDatabase`.
- ✅ Goal: Persist and test basic CRUD operations.

### **Day 3: Services + Dependency Injection**
- Create `TodoService` with methods (`GetTodosAsync`, `AddTodoAsync`).
- Register service in `Program.cs`.
- Write unit tests for service methods.
- ✅ Goal: Practice DI and test business logic.

### **Day 4: Components + UI Testing**
- Create `TodoItem.razor` component.
- Add checkbox + title display.
- Install and use **bUnit** for UI testing.
- Write tests for rendering and interaction.
- ✅ Goal: Build reusable components and validate UI behavior.

### **Day 5: Routing + Integration Testing**
- Create pages (`/todo`, `/about`, `/stats`).
- Add navigation links in `NavMenu.razor`.
- Write integration tests for routing with bUnit.
- ✅ Goal: Test navigation and page-level integration.

---

## 🚀 Beyond Day 5
- Add unit tests for edge cases (empty titles, duplicates).
- Add integration tests simulating multiple users.
- Explore mocking with **Moq** for service dependencies.
- Add authentication for user-specific lists.

---

## 🧪 Testing Frameworks
- **xUnit** → Unit testing for models and services.
- **bUnit** → Component and UI testing for Blazor.
- **EF Core InMemory** → Lightweight database testing.

---

## 📖 Getting Started

### Prerequisites
- [.NET 10 SDK](https://dotnet.microsoft.com/download) (or latest stable version)
- EF Core tools:
  ```bash
  dotnet tool install --global dotnet-ef
  ```

- IDE: Visual Studio or Visual Studio Code

### Clone the Repository
```bash
git clone https://github.com/your-username/TodoApp.git
cd src\TodoApp
```

### Run the Application
```bash
dotnet run --project TodoApp
```
Open your browser at http://localhost:5000.

### Run Tests
```bash
dotnet test
```

### Apply Database Migrations
```bash
dotnet ef migrations add InitialCreate --project TodoApp
dotnet ef database update --project TodoApp
```

