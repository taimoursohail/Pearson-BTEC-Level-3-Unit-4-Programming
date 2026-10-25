# Pearson-BTEC-Level-3-Unit-4-Programming

Pearson BTEC Level 3 IT: Unit 4 - Programming.

## Solution overview

This repository now contains a minimal C# solution that demonstrates:

- Object-oriented design with abstraction (`ProgrammingTask`), encapsulation (validated immutable properties), and polymorphism (`CalculateComplexityScore` overrides).
- Defensive coding through input validation and sanitisation (null/empty checks, range checks, control-character removal, trimmed input).
- Automated unit tests that validate both expected behaviour and defensive edge cases.

## Project structure

- `src/Unit4Programming.Core` – core solution classes.
- `tests/Unit4Programming.Core.Tests` – xUnit tests.
- `Unit4Programming.slnx` – solution file.

## Build and test

```bash
dotnet test /home/runner/work/Pearson-BTEC-Level-3-Unit-4-Programming/Pearson-BTEC-Level-3-Unit-4-Programming/Unit4Programming.slnx
```
