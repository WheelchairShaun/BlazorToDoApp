# 📚 Blazor To‑Do App Daily Quizzes

Use these short quizzes at the end of each day to check your understanding before moving forward.

---

## Day 1 – Project Setup & First Test

1. Why do we separate the main Blazor project and the test project into different folders?  
   - A) To keep UI and business logic together  
   - B) To isolate tests from production code  
   - C) To make deployment easier  
   - D) To avoid using EF Core  

2. What command runs all tests in your solution?  
   - A) `dotnet run`  
   - B) `dotnet build`  
   - C) `dotnet test`  
   - D) `dotnet ef migrations add`  

---

## Day 2 – Database Layer + Tests

1. What does `DbSet<TodoItem>` represent in EF Core?  
   - A) A single TodoItem object  
   - B) A collection/table of TodoItem entities  
   - C) A migration script  
   - D) A Razor component  

2. Why use `UseInMemoryDatabase` in tests?  
   - A) To avoid writing SQL manually  
   - B) To test persistence without a real database  
   - C) To seed production data  
   - D) To enable dependency injection  

---

## Day 3 – Services + Dependency Injection

1. What is the main purpose of dependency injection in Blazor?  
   - A) To reduce the number of Razor components  
   - B) To allow services to be swapped or mocked easily  
   - C) To avoid writing unit tests  
   - D) To configure routing  

2. If you register `TodoService` in `Program.cs`, how do you inject it into a component?  
   - A) `@inject TodoService Service`  
   - B) `new TodoService()`  
   - C) `TodoService.GetInstance()`  
   - D) `@service TodoService`  

---

## Day 4 – Components + UI Testing

1. What is the benefit of creating a `TodoItem.razor` component instead of writing markup directly in a page?  
   - A) It makes EF Core queries faster  
   - B) It allows reuse and easier testing  
   - C) It avoids dependency injection  
   - D) It replaces Program.cs  

2. Which library is commonly used for Blazor component testing?  
   - A) Moq  
   - B) xUnit  
   - C) bUnit  
   - D) NUnit  

---

## Day 5 – Routing + Integration Testing

1. What file typically defines navigation links in a Blazor Server app?  
   - A) `Program.cs`  
   - B) `NavMenu.razor`  
   - C) `Startup.cs`  
   - D) `TodoService.cs`  

2. Why write integration tests for routing?  
   - A) To verify EF Core migrations  
   - B) To ensure navigation between pages works as expected  
   - C) To test dependency injection  
   - D) To validate database seeding  

---

## ✅ How to Use
- Answer each quiz at the end of the day.  
- If you miss a question, revisit your code or docs until you can explain the answer.  
- Treat wrong answers as a signal to dig deeper — that’s where the real learning happens.