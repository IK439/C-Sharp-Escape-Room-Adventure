# C-Sharp-Escape-Room-Adventure

## Overview

**Escape Room Adventure** is a simple C# console application designed to demonstrate key object-oriented programming concepts. The project uses a small, story-based setup involving agents, files, and servers to show how objects behave in memory and how interfaces enable polymorphism.

---

## Concepts Demonstrated

This project focuses on the following core C# and OOP concepts:

### Reference Types
- Assigning one object variable to another creates a **shared reference**
- Changes through one reference affect the same object in memory

### Object Comparison
- Two objects with identical values are **not equal by default**
- `==` compares references unless overridden

### Interfaces
- The `ISystem` interface defines shared behaviour
- Different classes can be treated uniformly through an interface

### Polymorphism
- Servers are stored and accessed using the `ISystem` type
- Each system responds correctly to `Operate()`

### Properties and Encapsulation
- Public properties expose data safely
- Internal object state is managed through class definitions

---

## Project Structure

| File | Description |
|-----|-------------|
| `Program.cs` | Entry point that demonstrates all behaviours |
| `FieldAgent.cs` | Represents an agent with shared references |
| `File.cs` | Represents a file object for comparison |
| `ISystem.cs` | Interface defining system behaviour |
| `Server.cs` | Implements `ISystem` and operates polymorphically |

---

## Example Output

```
=== Reference Type Demonstration ===
Both variables will reference the same FieldAgent object.

Agent1 Secret Code:
999
Agent2 Secret Code:
999

Both values are the same because they reference the same object.

=== Object Comparison Demonstration ===
Two separate File objects with identical values are compared.

Are file1 and file2 the same object?
False
This is false because they are different objects in memory.

=== Interface and Polymorphism Demonstration ===
Servers are treated as ISystem objects.

Operating all systems:

Server is Active
Server is Inactive

Each server responds through the ISystem interface.
```
