# 🚀 C# Learning Journey - Chapter 5 & Advanced Exercises

Welcome to my C# practice repository! This project documents my progress through Chapter 5, transitioning from basic procedural logic to robust **Object-Oriented Programming (OOP)** principles, data structures, and advanced memory management in C#.

---

## 🛠️ Key Concepts & Technical Highlights Covered

Throughout these exercises, I implemented and mastered several core C# features:

### 1. Methods & Parameter Modifiers (Bài 6 - Bài 9)

- **Return Values (`return`)**: Moving away from standard `void` methods to return computed data types (`int`, `bool`, `string`).
- **Pass by Reference (`ref`)**: Allowing methods to modify original local variables directly by passing their memory address.
- **Output Parameters (`out`)**: Enabling methods to return multiple results simultaneously (e.g., finding both Min and Max values).
- **Inline `out` Declaration**: Using modern C# syntax (`out double minValue`) directly inside method calls for cleaner code.

### 2. String Manipulation & Algorithms (Bài 10 - Bài 12)

- **Two-Pointer Algorithm**: Efficiently checking for Palindromes with $O(N)$ time complexity.
- **String Immutability**: Converting strings to mutable character arrays (`ToCharArray()`, `Array.Reverse()`) to manipulate text.
- **Advanced Text Parsing**: Utilizing `String.Split()` paired with `StringSplitOptions.RemoveEmptyEntries` to clean up consecutive whitespaces and accurately count words.

### 3. Object-Oriented Programming & Data Validation (Bài 13 - Bài 16)

- **Encapsulation & Blueprints**: Structuring code into dedicated classes (`Student`, `Employee`, `StudentGrade`) acting as logical blueprints.
- **Financial Precision (`decimal`)**: Utilizing the `decimal` data type for currency calculations to prevent floating-point rounding errors.
- **Ternary Conditional Operator (`?:`)**: Writing clean, inline data validation logic (e.g., clamping negative absent days or invalid scores).
- **Dynamic Collections (`List<T>`)**: Leveraging flexible generic lists that automatically resize in RAM when handling unknown quantities of data.
- **Formatting Specifiers (`:N0`)**: Enhancing User Experience (UX) by formatting numbers with thousand separators.

### 4. Matrices & Multi-Dimensional Arrays (Bài 17)

- **2D Arrays (`int[,]`)**: Managing rows and columns using `GetLength(0)` and `GetLength(1)`.
- **Pseudo-Random Generation (`Random`)**: Automating data population within specific numerical bounds using `rand.Next()`.
- **Grid Formatting**: Aligning matrix outputs cleanly using fixed-width string interpolation (`{value,4}`).

---

## 📂 Project Structure

```text
ExCSharp/
│
├── Program.cs          # Main entry point & interactive switch-case menu system
├── Ex6.cs              # Return values (Max of 3 numbers)
├── Ex7.cs              # Boolean methods & Prime number validation
├── Ex8.cs              # Pass by reference (Swap values using 'ref')
├── Ex9.cs              # Output parameters (Find Min/Max using 'out')
├── Ex10.cs             # Palindrome string validation (Two-pointer technique)
├── Ex11.cs             # String reversal operations
├── Ex12.cs             # Text analysis: Lower/Upper conversion & word counting
├── Ex13.cs             # Student object modeling & encapsulation
├── Ex14.cs             # Employee payroll calculation with decimal & data validation
├── Ex15.cs             # Dynamic list collections & Prime extraction from arrays
├── Ex16.cs             # String array sorting (Alphabetical A-Z sorting)
└── Ex17.cs             # 2D Matrix generation, printing, and even/odd separation
```
