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

## Learning aims

This project demonstrates a complete small-scale C# software solution that meets identified client requirements.

### Development environment

- C# is used as the primary language with an object-oriented programming approach.
- Development is carried out in GitHub Codespaces with integrated code development tools.
- The environment supports code and syntax highlighting.
- Code completion, compiler/interpreter support, and debugging are used to improve code quality.
- Git-based repository integration is used for version control and commits.

### Methodologies and standards

- The project follows professional software engineering stages: investigating, designing, developing, testing, and reviewing.
- Object-oriented principles are applied through classes, objects, and instances.
- Core OOP concepts are used where appropriate: inheritance, encapsulation, abstraction, and polymorphism.

### Defensive coding and quality

- Good coding practices are applied to keep the solution functional and efficient.
- Defensive coding includes input validation and sanitisation.
- Robustness is supported with data hiding, obfuscation, fallback states, and error messaging.
- Naming conventions, logical code organisation, and informative commenting support maintainability.

### Testing and evaluation

- Development and testing follow an iterative approach to improve robustness.
- Functional and non-functional requirements are evaluated with appropriate testing methods.
- Feedback is collected through user acceptance testing and bug reporting.
- Code and unit test cases are reworked and documented to resolve identified defects.
