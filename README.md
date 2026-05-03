# Student Grade Management System

## Why I’m Doing This
I’m learning C# as part of Microsoft’s Full Stack Developer course on Coursera. This project is one of my first real coding activities where I get to plan, design, and build something from scratch.  

I’m documenting it here because this isn’t just about finishing an assignment — it’s about showing my progress as I actively learn a new language and start thinking like a developer.

---

## What This Project Is
A simple console app that helps manage student grades. It covers the basics:
- Add students with names and IDs
- Add grades for each student
- View all student records
- Calculate average grades

It’s basically a practice project to get comfortable with:
- Control structures (`switch`, `if-else`)
- Loops (`while`, `foreach`)
- Methods (breaking tasks into reusable functions)
- Data structures (`Dictionary` and `List`)

---

## Requirements and Objectives
### Functional Requirements
- Add new students with names and IDs
- Assign grades for different subjects
- Calculate average grade for each student
- Display student records with their grades

### Non-Functional Requirements
- Console-based application
- Simple and easy to use
- Efficient handling of multiple students and grades

### Objectives
- Build a working console app in C#
- Demonstrate use of control structures, loops, and methods
- Provide clear output for users to view student records and averages
- Document the design process as part of my learning journey

---

## Design Outline (Flowchart)
Program logic flow:

Start → Show Menu → User Choice
├── Add Student → Store in Dictionary
├── Add Grade → Append to Student’s Grades
├── View Records → Loop through Dictionary
├── Calculate Average → Loop through Grades
└── Exit → End


Code components:
- Variables & Data Structures: `Dictionary<int, Student>` to store student info, `List<int>` for grades
- Methods: `AddStudent()`, `AddGrade()`, `ViewRecords()`, `CalculateAverage()`
- Control Structures: `switch` for menu choices, `if-else` for validation
- Loops: `while` for the main program loop, `foreach` to display records

---

## Running the Project
1. Install the [.NET SDK](https://dotnet.microsoft.com/download).
2. Create a new console project:


dotnet new console -n StudentGrade
cd StudentGrade


3. Replace the contents of `Program.cs` with my code.
4. Run it:

## Reflections
This project is me getting hands-on with C# for the first time. I’m learning how to:
- Break down a problem into smaller coding tasks
- Write methods that make code cleaner
- Use loops and conditions to control program flow
- Think about how data should be stored and accessed


This README is part of my active learning journey with Microsoft and Coursera. It shows where I am right now and where I’m heading.