using System;
using System.Collections.Generic;

class Student
{
    public required string Name { get; set; }
    public int ID { get; set; }
    public List<int> Grades { get; set; } = new List<int>();
}

class Program
{
    static Dictionary<int, Student> students = new Dictionary<int, Student>();

    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\n--- Student Grade Management ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Grade");
            Console.WriteLine("3. View Records");
            Console.WriteLine("4. Calculate Average");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine() ?? string.Empty;
            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    AddGrade();
                    break;
                case "3":
                    ViewRecords();
                    break;
                case "4":
                    CalculateAverage();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }

    static void AddStudent()
    {
        Console.Write("Enter student ID: ");
        string idInput = Console.ReadLine() ?? string.Empty;
        if (!int.TryParse(idInput, out int id))
        {
            Console.WriteLine("Invalid ID.");
            return;
        }
        Console.Write("Enter student name: ");
        string name = Console.ReadLine() ?? string.Empty;

        students[id] = new Student { ID = id, Name = name };
        Console.WriteLine("Student added successfully!");
    }

    static void AddGrade()
    {
        Console.Write("Enter student ID: ");
        string idInput = Console.ReadLine() ?? string.Empty;
        if (!int.TryParse(idInput, out int id))
        {
            Console.WriteLine("Invalid ID.");
            return;
        }
        if (students.ContainsKey(id))
        {
            Console.Write("Enter grade: ");
            string gradeInput = Console.ReadLine() ?? string.Empty;
            if (int.TryParse(gradeInput, out int grade))
            {
                students[id].Grades.Add(grade);
                Console.WriteLine("Grade added successfully!");
            }
            else
            {
                Console.WriteLine("Invalid grade.");
            }
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    static void ViewRecords()
    {
        foreach (var student in students.Values)
        {
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Grades: {string.Join(", ", student.Grades)}");
        }
    }

    static void CalculateAverage()
    {
        Console.Write("Enter student ID: ");
        string idInput = Console.ReadLine() ?? string.Empty;
        if (!int.TryParse(idInput, out int id))
        {
            Console.WriteLine("Invalid ID.");
            return;
        }
        if (students.ContainsKey(id) && students[id].Grades.Count > 0)
        {
            double avg = 0;
            foreach (int grade in students[id].Grades)
            {
                avg += grade;
            }
            avg /= students[id].Grades.Count;
            Console.WriteLine($"Average grade for {students[id].Name}: {avg:F2}");
        }
        else
        {
            Console.WriteLine("No grades found for this student.");
        }
    }
}
