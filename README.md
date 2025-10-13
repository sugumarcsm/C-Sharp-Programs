# C# ArrayList Practice Program

This repository contains a **C# console application** demonstrating the usage of **ArrayList** and its methods from the **`System.Collections`** namespace. The program provides a comprehensive hands-on experience with **Non-Generic Collections** in C#.

---

## 🔹 Features

The program demonstrates:

- **Creating an ArrayList** and adding elements using:
  - `Add()`
  - `AddRange()`
  - `Insert()`
  - `InsertRange()`
- **Removing elements** using:
  - `Remove()`
  - `RemoveAt()`
  - `RemoveRange()`
- **Searching elements**:
  - `Contains()`
  - `IndexOf()`
  - `LastIndexOf()`
- **Sorting and Reversing**:
  - `Sort()`
  - `Reverse()`
- **ArrayList properties**:
  - `Count`
  - `Capacity`
  - `TrimToSize()`
- **Other operations**:
  - `ToArray()`
  - `Clone()`
  - `Clear()`
- **Handling mixed data types** including:
  - Strings, integers, doubles, booleans, characters, `DateTime`, and `null`.

---

## 🔹 Code Overview

- The program defines a helper method `Display(ArrayList arr)` that:
  - Shows all elements with their **index** and **data type**
  - Displays **Count**, **Capacity**
  - Demonstrates `IndexOf()` and `LastIndexOf()`
- The `Main` method performs step-by-step demonstrations of all **common ArrayList methods**, including:
  - Sorting strings safely using LINQ
  - Removing duplicates
  - Cloning and clearing the ArrayList

---

## 🔹 Example Output

----- Display ArrayList -----
Count: 14
Capacity: 16

Elements (index : value (Type)):
0 : 1 (Int32)
1 : sugumar (String)
2 : World (String)
3 : sathish (String)
4 : dinesh (String)
...
IndexOf(1): 0
LastIndexOf(1): 12
IndexOf("Hello"): 13

The program also demonstrates:

- Sorting numbers
- Reversing collections
- Converting ArrayList to array
- Cloning ArrayList

---

## 🔹 Prerequisites

- **.NET 6.0 SDK** or later
- C# compatible IDE (Visual Studio, VS Code, JetBrains Rider)

---

## 🔹 How to Run

1. Clone the repository:

```bash
git clone https://github.com/yourusername/ArrayListPractice.git


Open the project in your preferred IDE.

Build and run the Programs.cs file.

Observe console outputs demonstrating ArrayList methods.

🔹 Notes

ArrayList is a non-generic collection. It can hold mixed data types, but is not type-safe.

Modern C# development usually prefers List<T> for type safety and performance.

This project is mainly for learning and practice purposes.

🔹 Author

Sugumar R

GitHub: https://github.com/yourusername

Email: your.email@example.com

🔹 License

This project is licensed under the MIT License - see the LICENSE
 file for details.


---

I can also create a **shorter “awesome README” version with tables and colored badges** suitable for GitHub that **looks professional and beginner-friendly**.  

Do you want me to make that version too?


Ch
