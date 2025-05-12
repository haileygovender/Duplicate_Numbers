# 🔁 Repeating Numbers Finder

A simple C# console application that detects and displays **duplicate numbers** from an integer array. This program demonstrates basic array manipulation, sorting, iteration, and list usage.

---

## 📌 Features

- Identifies **duplicate integers** in a predefined list.
- Avoids reporting the same duplicate more than once.
- Clean and color-coded console output for better readability.

---

## 🧠 How It Works

1. The array is sorted using `Array.Sort()` to bring duplicates together.
2. A `for` loop scans through the sorted array.
3. If a number is the same as the next, it checks if it's already recorded.
4. Duplicates are stored in a `List<int>` and printed to the console.

---

## 📦 Sample Input

```csharp
int[] duplicateNumberList = new int[] { 1, 4, 3, 4, 5, 7, 7, 8, 9, 10 };
