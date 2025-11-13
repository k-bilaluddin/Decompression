# String Decompression

## Overview
This project implements a decoder that expands a compact string format into its full representation.  
Each block in the input follows the pattern `<letters><k>`, where `<letters>` is a sequence of alphabetic characters and `<k>` is an integer (0–9999).  
The decoded result repeats `<letters>` exactly `<k>` times.

**Example:**

Input: "a3b2c1"
Output: "aaabbc"


---

## Environment Details
- **Language:** C#
- **Framework:** .NET 8.0
- **IDE (optional):** Visual Studio 2022
- **Test Framework:** xUnit

---

## Build Instructions
Open a terminal in the `DeCodify` directory and run:

```bash
dotnet build
```

To run the Program:
```bash
dotnet run
```

To Run unit tests:

```bash
dotnet test
```

You should see something like:

```bash
Passed!  - Failed:     0, Passed:     6, Skipped:     0, Total:     6,
```

## Notes

- The solution does not use regular expressions.
- Handles multi-digit counts (xyz12 → "xyz" × 12).
- Handles k = 0 correctly (skipped block).

