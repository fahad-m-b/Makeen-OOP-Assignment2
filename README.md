# 🧾 Object-Oriented Programming Assignments (C#)

This repository contains multiple C# assignments demonstrating key Object-Oriented Programming (OOP) concepts such as **Enums**, **Indexers**, **Encapsulation**, **Inheritance**, **Interfaces**, and **Polymorphism**.  
Each assignment focuses on applying these principles in small, practical systems.

---

## 📘 Table of Contents
1. [Assignment 1: Ticket Booking System](OOP-Assignment2/Modul/Ticket_Booking.cs)  
2. [Assignment 2: Online Course Enrollment System](OOP-Assignment2/Modul/Course_Enrollment.cs)  
3. [Assignment 3: Smart Home Control Center](OOP-Assignment2/Modul/Smart_Home.cs)  
4. [Assignment 4: Library System with Book Status Tracking](OOP-Assignment2/Modul/Library_System.cs)  
5. [Assignment 5: Task Tracker Application](OOP-Assignment2/Modul/Task_Tracker.cs)

---

## 🎟️ Assignment 1: Ticket Booking System
**Concepts Used:** Enum, Indexer, Class, Encapsulation  

### Description  
A simple system to manage event tickets using OOP concepts.  
The system allows tickets to be accessed by seat number and counted by type.

**Classes & Features:**
- `Ticket` class with:
  - `EventName`, `SeatNumber`, and `TicketType` (Enum: `Regular`, `VIP`, `Backstage`)
- `TicketSystem` class:
  - Stores multiple tickets in a list
  - Indexer to access tickets by seat number (`system["A12"]`)
  - Method to count tickets by type

---

## 💻 Assignment 2: Online Course Enrollment System
**Concepts Used:** Enum, Indexer, List, OOP, Polymorphism  

### Description  
An OOP-based course catalog system that categorizes courses by difficulty level.

**Structure:**
- Enum `Level`: `Beginner`, `Intermediate`, `Advanced`
- Base class `Course`: `Name`, `Instructor`, `Level`
- Derived classes:
  - `VideoCourse` (adds `Duration`)
  - `LiveSession` (adds `Schedule`)
- `CourseCatalog` class:
  - Indexer to get courses by level (`catalog[Level.Beginner]`)

---

## 🏠 Assignment 3: Smart Home Control Center
**Concepts Used:** Interface, Indexer, Enum, Encapsulation  

### Description  
A simulated smart home system that manages multiple devices through an interface.

**Key Features:**
- Enum `DeviceType`: `Light`, `Fan`, `AC`, `Heater`
- Interface `ISmartDevice` with:
  - `TurnOn()`, `TurnOff()`, and `ShowStatus()`
- Device classes implementing the interface
- `SmartHome` class:
  - Indexer to access devices (`home[DeviceType.Light]`)
  - Demonstrates turning devices on/off and showing status

---

## 📚 Assignment 4: Library System with Book Status Tracking
**Concepts Used:** Enum, Indexer, Class, List, OOP  

### Description  
A small library management system for tracking book statuses.

**Components:**
- Enum `BookStatus`: `Available`, `CheckedOut`, `Reserved`
- `Book` class with `Title`, `Author`, `Status`
- `Library` class:
  - List of books
  - Indexer to access by title (`library["Book Title"]`)
  - Methods to:
    - `ChangeStatus(title, status)`
    - `ShowBooksByStatus(status)`

---

## ✅ Assignment 5: Task Tracker Application
**Concepts Used:** Enum, Indexer, Encapsulation, Collections  

### Description  
A task management system that organizes and tracks tasks by priority.

**Classes & Methods:**
- Enum `TaskPriority`: `Low`, `Medium`, `High`
- `Task` class with:
  - `Title`, `Description`, `Priority`, `IsCompleted`
- `TaskList` class:
  - List of tasks
  - Indexer to get tasks by priority (`list[TaskPriority.High]`)
  - Methods:
    - `AddTask(Task)`
    - `MarkComplete(string taskTitle)`
    - `ShowAll()`

---

## 🧠 Concepts Covered
- ✅ **Encapsulation**  
- ✅ **Enums**  
- ✅ **Indexers**  
- ✅ **Inheritance & Polymorphism**  
- ✅ **Interfaces**  
- ✅ **Collections**

---

## 🧑‍💻 Author
**Fahad Mohammed BaOmar**  
📍 Salalah, Oman  
📧 [fahadbao2002@gmail.com](mailto:fahadbao2002@gmail.com)  
🔗 [LinkedIn](https://www.linkedin.com/in/fahad-baomar-b1a285213) 
