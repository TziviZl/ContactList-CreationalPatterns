# 📱 Phone Contacts Manager - Creational Design Patterns

This is a C# project implementing a phone contacts manager using several **Creational Design Patterns**:  
**Factory**, **Builder**, **Prototype**, and **Singleton**.

---

## 📌 Project Summary

This project simulates a phone contact manager, supporting two types of contacts (Phone and SIM), with extended information and advanced management features using modern design patterns.

---

## 🏗️ Design Patterns Implemented

### 1. **Factory Pattern**
- Creates different types of contacts:  
  - `PhoneContact` – user-defined contacts  
  - `SimContact` – contacts stored on the SIM (fixed group and color)  
- A `ContactFactory` class handles contact creation.

### 2. **Builder Pattern**
- Adds optional properties (email, birthday, ringtone, color) to contacts.
- Two types of `Builder` classes:
  - For `PhoneContact`
  - For `SimContact`
- `Director` class decides which properties to include.

### 3. **Prototype Pattern**
- Allows cloning of contact templates for different groups (Family, Work, Friends).
- A `PrototypeRegistry` holds default prototypes for each group.

### 4. **Singleton Pattern**
- `PrintManager` class handles styled and colored console outputs.
- Singleton ensures only one instance prints contact data.
## 🧪 Features Demonstrated

- ✅ Add contacts using Factory  
- ✅ Add attributes using Builder + Director  
- ✅ Clone default templates using Prototype Registry  
- ✅ Display all contact data using a Singleton PrintManager  
- ✅ Menu for:
  - Searching contact by name or number  
  - Viewing all contacts  

---

## ▶️ How to Run

1. Clone the repository
2. Open the solution in Visual Studio
3. Build and run `Program.cs`
4. Use the console menu to interact with the contact manager

---

## 💡 Educational Purpose

This project is part of a hands-on exercise in applying **Creational Design Patterns** in C#.  
It demonstrates how real-world applications like a contact manager benefit from flexible and scalable design principles.

---
