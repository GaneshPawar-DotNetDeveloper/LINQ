using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public int Score { get; set; }
}

public class RankedStudent
{
    public string Name { get; set; }
    public int Score { get; set; }
    public int Rank { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Example collection of students
        List<Student> students = new List<Student>
        {
            new Student { Name = "GaneshRao", Score = 85 },
            new Student { Name = "BobyBhai", Score = 92 },
            new Student { Name = "DhiruBhai", Score = 88 },
            new Student { Name = "SangramDaDa", Score = 85 },
            new Student { Name = "himatrao", Score = 95 },
            new Student { Name = "Datarao", Score = 89 },
            new Student { Name = "MhadaAppa", Score = 80 },
            new Student { Name = "BanduAnna", Score = 98 },
            new Student { Name = "ShamRao", Score = 89 },
            new Student { Name = "trimbakAppa", Score = 45 },
            new Student { Name = "BakulaBai", Score = 95 },
            new Student { Name = "NaMaKaka", Score = 99 },
            new Student { Name = "jack", Score = 46 },
            new Student { Name = "herry", Score = 29 },
            new Student { Name = "vinjuko", Score = 39 }
        };

        // Rank the students
        var rankedStudents = students
            .OrderByDescending(s => s.Score) // Sort by score descending
            .Select((s, index) => new RankedStudent
            {
                Name = s.Name,
                Score = s.Score,
                Rank = index + 1
            })
            .ToList();

        // Output the ranked students
        foreach (var student in rankedStudents)
        {
            Console.WriteLine($"Name: {student.Name}, Score: {student.Score}, Rank: {student.Rank}");
        }
        Console.ReadLine();
    }
}
